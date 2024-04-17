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
            this.txt_date_res = new System.Windows.Forms.TextBox();
            this.btn_inserer = new System.Windows.Forms.Button();
            this.btn_retour = new System.Windows.Forms.Button();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code passager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Statut reservation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date reservation";
            // 
            // cmb_statut_res
            // 
            this.cmb_statut_res.FormattingEnabled = true;
            this.cmb_statut_res.Items.AddRange(new object[] {
            "OK",
            "Standby"});
            this.cmb_statut_res.Location = new System.Drawing.Point(236, 129);
            this.cmb_statut_res.Name = "cmb_statut_res";
            this.cmb_statut_res.Size = new System.Drawing.Size(187, 24);
            this.cmb_statut_res.TabIndex = 4;
            // 
            // txt_date_res
            // 
            this.txt_date_res.Location = new System.Drawing.Point(236, 187);
            this.txt_date_res.Name = "txt_date_res";
            this.txt_date_res.Size = new System.Drawing.Size(187, 22);
            this.txt_date_res.TabIndex = 5;
            this.txt_date_res.Text = "aaaa-mm-dd";
            // 
            // btn_inserer
            // 
            this.btn_inserer.Location = new System.Drawing.Point(124, 330);
            this.btn_inserer.Name = "btn_inserer";
            this.btn_inserer.Size = new System.Drawing.Size(149, 49);
            this.btn_inserer.TabIndex = 6;
            this.btn_inserer.Text = "Inserer";
            this.btn_inserer.UseVisualStyleBackColor = true;
            this.btn_inserer.Click += new System.EventHandler(this.btn_inserer_Click);
            // 
            // btn_retour
            // 
            this.btn_retour.Location = new System.Drawing.Point(378, 330);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(149, 49);
            this.btn_retour.TabIndex = 7;
            this.btn_retour.Text = "Retour";
            this.btn_retour.UseVisualStyleBackColor = true;
            this.btn_retour.Click += new System.EventHandler(this.btn_retour_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(236, 81);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(187, 22);
            this.txt_pass.TabIndex = 9;
            // 
            // InsertReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.btn_retour);
            this.Controls.Add(this.btn_inserer);
            this.Controls.Add(this.txt_date_res);
            this.Controls.Add(this.cmb_statut_res);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.TextBox txt_date_res;
        private System.Windows.Forms.Button btn_inserer;
        private System.Windows.Forms.Button btn_retour;
        private System.Windows.Forms.TextBox txt_pass;
    }
}