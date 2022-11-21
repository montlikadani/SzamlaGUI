namespace Szamla {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.szamlak = new System.Windows.Forms.ListBox();
            this.newAccountButton = new System.Windows.Forms.Button();
            this.accountDeleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ownerName = new System.Windows.Forms.TextBox();
            this.currentAmount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nyitasDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.accountID = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.currentAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountID)).BeginInit();
            this.SuspendLayout();
            // 
            // szamlak
            // 
            this.szamlak.Dock = System.Windows.Forms.DockStyle.Left;
            this.szamlak.FormattingEnabled = true;
            this.szamlak.ItemHeight = 18;
            this.szamlak.Location = new System.Drawing.Point(0, 0);
            this.szamlak.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.szamlak.Name = "szamlak";
            this.szamlak.Size = new System.Drawing.Size(178, 623);
            this.szamlak.TabIndex = 0;
            this.szamlak.SelectedIndexChanged += new System.EventHandler(this.szamlak_SelectedIndexChanged);
            // 
            // newAccountButton
            // 
            this.newAccountButton.Enabled = false;
            this.newAccountButton.Location = new System.Drawing.Point(308, 406);
            this.newAccountButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newAccountButton.Name = "newAccountButton";
            this.newAccountButton.Size = new System.Drawing.Size(321, 51);
            this.newAccountButton.TabIndex = 1;
            this.newAccountButton.Text = "Új számla hozzáadása";
            this.newAccountButton.UseVisualStyleBackColor = true;
            this.newAccountButton.Click += new System.EventHandler(this.newAccountButton_Click);
            // 
            // accountDeleteButton
            // 
            this.accountDeleteButton.BackColor = System.Drawing.Color.Red;
            this.accountDeleteButton.Enabled = false;
            this.accountDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.accountDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.accountDeleteButton.ForeColor = System.Drawing.Color.White;
            this.accountDeleteButton.Location = new System.Drawing.Point(308, 478);
            this.accountDeleteButton.Name = "accountDeleteButton";
            this.accountDeleteButton.Size = new System.Drawing.Size(321, 53);
            this.accountDeleteButton.TabIndex = 2;
            this.accountDeleteButton.Text = "Jelenlegi számla törlése";
            this.accountDeleteButton.UseVisualStyleBackColor = false;
            this.accountDeleteButton.Click += new System.EventHandler(this.accountDeleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Enabled = false;
            this.updateButton.Location = new System.Drawing.Point(308, 336);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(321, 51);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Számla adatok frissítése";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Számla azonosító";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tulajdonos neve";
            // 
            // ownerName
            // 
            this.ownerName.Location = new System.Drawing.Point(308, 138);
            this.ownerName.MaxLength = 200;
            this.ownerName.Name = "ownerName";
            this.ownerName.Size = new System.Drawing.Size(321, 24);
            this.ownerName.TabIndex = 7;
            this.ownerName.WordWrap = false;
            this.ownerName.TextChanged += new System.EventHandler(this.ownerName_TextChanged);
            // 
            // currentAmount
            // 
            this.currentAmount.DecimalPlaces = 2;
            this.currentAmount.Location = new System.Drawing.Point(308, 212);
            this.currentAmount.Name = "currentAmount";
            this.currentAmount.Size = new System.Drawing.Size(321, 24);
            this.currentAmount.TabIndex = 8;
            this.currentAmount.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Jelenlegi egyenleg";
            // 
            // nyitasDate
            // 
            this.nyitasDate.Location = new System.Drawing.Point(308, 281);
            this.nyitasDate.Name = "nyitasDate";
            this.nyitasDate.Size = new System.Drawing.Size(321, 24);
            this.nyitasDate.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nyitási dátum";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // accountID
            // 
            this.accountID.Location = new System.Drawing.Point(308, 63);
            this.accountID.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.accountID.Name = "accountID";
            this.accountID.ReadOnly = true;
            this.accountID.Size = new System.Drawing.Size(321, 24);
            this.accountID.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 623);
            this.Controls.Add(this.accountID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nyitasDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.currentAmount);
            this.Controls.Add(this.ownerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.accountDeleteButton);
            this.Controls.Add(this.newAccountButton);
            this.Controls.Add(this.szamlak);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Számlák";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.currentAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox szamlak;
        private System.Windows.Forms.Button newAccountButton;
        private System.Windows.Forms.Button accountDeleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ownerName;
        private System.Windows.Forms.NumericUpDown currentAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker nyitasDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.NumericUpDown accountID;
    }
}

