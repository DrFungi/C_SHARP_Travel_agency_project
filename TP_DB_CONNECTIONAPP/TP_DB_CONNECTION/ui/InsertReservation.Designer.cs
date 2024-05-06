namespace TP_DB_CONNECTION.ui
{
    partial class InsertReservation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_statut_res = new System.Windows.Forms.ComboBox();
            this.btn_inserer = new System.Windows.Forms.Button();
            this.btn_retour = new System.Windows.Forms.Button();
            this.cmb_passager = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.date_time_pecker = new System.Windows.Forms.DateTimePicker();
            this.lbl_codePass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code passager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Statut reservation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date reservation";
            // 
            // cmb_statut_res
            // 
            this.cmb_statut_res.FormattingEnabled = true;
            this.cmb_statut_res.Items.AddRange(new object[] {
            "OK         ",
            "Standby"});
            this.cmb_statut_res.Location = new System.Drawing.Point(177, 105);
            this.cmb_statut_res.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_statut_res.Name = "cmb_statut_res";
            this.cmb_statut_res.Size = new System.Drawing.Size(141, 21);
            this.cmb_statut_res.TabIndex = 1;
            // 
            // btn_inserer
            // 
            this.btn_inserer.Location = new System.Drawing.Point(93, 268);
            this.btn_inserer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_inserer.Name = "btn_inserer";
            this.btn_inserer.Size = new System.Drawing.Size(112, 40);
            this.btn_inserer.TabIndex = 4;
            this.btn_inserer.Text = "Inserer";
            this.btn_inserer.UseVisualStyleBackColor = true;
            this.btn_inserer.Click += new System.EventHandler(this.btn_inserer_Click);
            // 
            // btn_retour
            // 
            this.btn_retour.Location = new System.Drawing.Point(284, 268);
            this.btn_retour.Margin = new System.Windows.Forms.Padding(2);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(112, 40);
            this.btn_retour.TabIndex = 5;
            this.btn_retour.Text = "Retour";
            this.btn_retour.UseVisualStyleBackColor = true;
            this.btn_retour.Click += new System.EventHandler(this.btn_retour_Click);
            // 
            // cmb_passager
            // 
            this.cmb_passager.FormattingEnabled = true;
            this.cmb_passager.Location = new System.Drawing.Point(175, 195);
            this.cmb_passager.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_passager.Name = "cmb_passager";
            this.cmb_passager.Size = new System.Drawing.Size(141, 21);
            this.cmb_passager.TabIndex = 0;
            this.cmb_passager.SelectedIndexChanged += new System.EventHandler(this.cmb_passager_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Passager";
            // 
            // date_time_pecker
            // 
            this.date_time_pecker.CustomFormat = "yyyy-MM-dd";
            this.date_time_pecker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_time_pecker.Location = new System.Drawing.Point(175, 155);
            this.date_time_pecker.Name = "date_time_pecker";
            this.date_time_pecker.Size = new System.Drawing.Size(143, 20);
            this.date_time_pecker.TabIndex = 2;
            this.date_time_pecker.Value = new System.DateTime(2024, 4, 25, 12, 13, 58, 0);
            // 
            // lbl_codePass
            // 
            this.lbl_codePass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_codePass.Location = new System.Drawing.Point(174, 50);
            this.lbl_codePass.Name = "lbl_codePass";
            this.lbl_codePass.Size = new System.Drawing.Size(144, 23);
            this.lbl_codePass.TabIndex = 11;
            this.lbl_codePass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InsertReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lbl_codePass);
            this.Controls.Add(this.date_time_pecker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_passager);
            this.Controls.Add(this.btn_retour);
            this.Controls.Add(this.btn_inserer);
            this.Controls.Add(this.cmb_statut_res);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InsertReservation";
            this.Text = "InsertReservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_statut_res;
        private System.Windows.Forms.Button btn_inserer;
        private System.Windows.Forms.Button btn_retour;
        private System.Windows.Forms.ComboBox cmb_passager;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date_time_pecker;
        private System.Windows.Forms.Label lbl_codePass;
    }
}