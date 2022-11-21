using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Szamla {
    public partial class Form1 : Form {

        private readonly MySqlConnection connection;
        private readonly MySqlCommand command;

        public Form1() {
            InitializeComponent();

            try {
                (connection = new MySqlConnection("server=localhost;user=root;database=szamlak;convert zero datetime=True")).Open();
                command = connection.CreateCommand();
            } catch (Exception e) {
                MessageBox.Show(e.Message, "Adatbázis kapcsolódás sikertelen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
                return;
            }

            currentAmount.Maximum = decimal.MaxValue;
            DateTime now = DateTime.Now;
            nyitasDate.MaxDate = now;
            nyitasDate.MinDate = now.AddYears(-22);

            RefreshData();
        }

        private void ResetProperties() {
            accountID.Value = 0;
            ownerName.Text = "";
            currentAmount.Value = 0;
            nyitasDate.Value = DateTime.Now.AddDays(-1);
        }

        private void RefreshData() {
            szamlak.Items.Clear();

            command.CommandText = "select * from szamlak;";

            using (MySqlDataReader reader = command.ExecuteReader()) {
                while (reader.Read()) {
                    szamlak.Items.Add(new Szamla(reader.GetInt32("id"), reader.GetString("tulajdonosNeve"), reader.GetDecimal("egyenleg"),
                        reader.IsDBNull(3) ? DateTime.Now : reader.GetDateTime("nyitasdatum")));
                }
            }
        }

        private async System.Threading.Tasks.Task<bool> ExecuteSql(MySqlCommand cmd) {
            try {
                if ((await command.ExecuteNonQueryAsync()) != 1) {
                    return false;
                }
            } catch (System.Data.Common.DbException ex) {
                MessageBox.Show("Hiba lépett fel az adatbázis parancs végrehajtásakor: " + ex.Message, "Adatbázis hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            connection.Close();
        }

        private async void newAccountButton_Click(object sender, EventArgs e) {
            string name = ownerName.Text;
            
            if (name.Trim().Length == 0) {
                errorProvider.SetError(ownerName, "Számla tulajdonos név megadása kötelező.");
                return;
            }

            command.CommandText = "insert into `szamlak` (`tulajdonosNeve`, `egyenleg`, `nyitasdatum`) values (@tulajdonosNeve, @egyenleg, @nyitasdatum);";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@tulajdonosNeve", name);
            command.Parameters.AddWithValue("@egyenleg", currentAmount.Value);
            command.Parameters.AddWithValue("@nyitasdatum", nyitasDate.Value);

            if (!(await ExecuteSql(command))) {
                return;
            }

            ResetProperties();
            RefreshData();

            MessageBox.Show("Számla elkészült", "Új számlája nyílt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void updateButton_Click(object sender, EventArgs e) {
            if (!(szamlak.SelectedItem is Szamla szamla)) {
                MessageBox.Show("Válasszon ki egy meglévő számlát a módosításhoz", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string name = ownerName.Text;

            if (name.Trim().Length == 0) {
                errorProvider.SetError(ownerName, "Számla tulajdonos név megadása kötelező.");
                return;
            }

            command.CommandText = "update `szamlak` set `tulajdonosNeve` = @tulajdonosNeve, `egyenleg` = @egyenleg, `nyitasdatum` = @nyitasdatum where `id` = @id;";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", szamla.Id);
            command.Parameters.AddWithValue("@tulajdonosNeve", name);
            command.Parameters.AddWithValue("@egyenleg", currentAmount.Value);
            command.Parameters.AddWithValue("@nyitasdatum", nyitasDate.Value);

            if (!(await ExecuteSql(command))) {
                return;
            }

            ResetProperties();
            RefreshData();

            MessageBox.Show("Számla adatok frissítve", "Számlája frissítve", MessageBoxButtons.OK, MessageBoxIcon.Information);
            accountDeleteButton.Enabled = updateButton.Enabled = false;
        }

        private void szamlak_SelectedIndexChanged(object sender, EventArgs e) {
            updateButton.Enabled = accountDeleteButton.Enabled = szamlak.SelectedItems.Count != 0;

            if (szamlak.SelectedItem is Szamla szamla) {
                accountID.Value = szamla.Id;
                ownerName.Text = szamla.TulajNev;
                currentAmount.Value = szamla.Egyenleg;
                nyitasDate.Value = szamla.NyitasDatum;
            }
        }

        private async void accountDeleteButton_Click(object sender, EventArgs e) {
            if (!(szamlak.SelectedItem is Szamla szamla)) {
                MessageBox.Show("Válasszon ki egy meglévő számlát az eltávolításhoz", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            command.CommandText = $"delete from `szamlak` where `id` = @id;";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", szamla.Id);

            if (!(await ExecuteSql(command))) {
                return;
            }

            RefreshData();
            MessageBox.Show("Kiválasztott számla eltávolítva", "Számla eltávolítva", MessageBoxButtons.OK, MessageBoxIcon.Information);

            updateButton.Enabled = accountDeleteButton.Enabled = false;
            ResetProperties();
        }

        private void ownerName_TextChanged(object sender, EventArgs e) {
            newAccountButton.Enabled = ownerName.Text.Trim().Length != 0;
        }
    }
}
