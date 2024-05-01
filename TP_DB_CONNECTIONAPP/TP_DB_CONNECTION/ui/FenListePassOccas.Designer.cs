namespace TP_DB_CONNECTION.ui
{
    partial class FenListePassOccas
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
            this.dgv_occPass = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_affOccPass = new System.Windows.Forms.Button();
            this.btn_retourAnalyse = new System.Windows.Forms.Button();
            this.cmb_statut = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_occPass)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_occPass
            // 
            this.dgv_occPass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_occPass.Location = new System.Drawing.Point(152, 132);
            this.dgv_occPass.Name = "dgv_occPass";
            this.dgv_occPass.Size = new System.Drawing.Size(536, 221);
            this.dgv_occPass.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rechercher un passager";
            // 
            // btn_affOccPass
            // 
            this.btn_affOccPass.Location = new System.Drawing.Point(152, 382);
            this.btn_affOccPass.Name = "btn_affOccPass";
            this.btn_affOccPass.Size = new System.Drawing.Size(155, 37);
            this.btn_affOccPass.TabIndex = 3;
            this.btn_affOccPass.Text = "Afficher les passagers";
            this.btn_affOccPass.UseVisualStyleBackColor = true;
            this.btn_affOccPass.Click += new System.EventHandler(this.btn_affOccPass_Click);
            // 
            // btn_retourAnalyse
            // 
            this.btn_retourAnalyse.Location = new System.Drawing.Point(613, 396);
            this.btn_retourAnalyse.Name = "btn_retourAnalyse";
            this.btn_retourAnalyse.Size = new System.Drawing.Size(75, 23);
            this.btn_retourAnalyse.TabIndex = 4;
            this.btn_retourAnalyse.Text = "Retour";
            this.btn_retourAnalyse.UseVisualStyleBackColor = true;
            this.btn_retourAnalyse.Click += new System.EventHandler(this.btn_retourAnalyse_Click);
            // 
            // cmb_statut
            // 
            this.cmb_statut.FormattingEnabled = true;
            this.cmb_statut.Location = new System.Drawing.Point(280, 60);
            this.cmb_statut.Name = "cmb_statut";
            this.cmb_statut.Size = new System.Drawing.Size(155, 21);
            this.cmb_statut.TabIndex = 5;
            this.cmb_statut.SelectedIndexChanged += new System.EventHandler(this.cmb_statut_SelectedIndexChanged);
            // 
            // FenListePassOccas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmb_statut);
            this.Controls.Add(this.btn_retourAnalyse);
            this.Controls.Add(this.btn_affOccPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_occPass);
            this.Name = "FenListePassOccas";
            this.Text = "FenListePassOccas";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_occPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_occPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_affOccPass;
        private System.Windows.Forms.Button btn_retourAnalyse;
        private System.Windows.Forms.ComboBox cmb_statut;
    }
}