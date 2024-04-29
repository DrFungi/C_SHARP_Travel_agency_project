namespace TP_DB_CONNECTION.ui
{
    partial class MenuAnalyse
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
            this.btn_lpg = new System.Windows.Forms.Button();
            this.btn_ocas = new System.Windows.Forms.Button();
            this.btn_md = new System.Windows.Forms.Button();
            this.btn_retour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_lpg
            // 
            this.btn_lpg.Location = new System.Drawing.Point(47, 182);
            this.btn_lpg.Name = "btn_lpg";
            this.btn_lpg.Size = new System.Drawing.Size(160, 59);
            this.btn_lpg.TabIndex = 0;
            this.btn_lpg.Text = "Liste des passagers";
            this.btn_lpg.UseVisualStyleBackColor = true;
            this.btn_lpg.Click += new System.EventHandler(this.btn_lpg_Click);
            // 
            // btn_ocas
            // 
            this.btn_ocas.Location = new System.Drawing.Point(267, 180);
            this.btn_ocas.Name = "btn_ocas";
            this.btn_ocas.Size = new System.Drawing.Size(239, 61);
            this.btn_ocas.TabIndex = 1;
            this.btn_ocas.Text = "Liste des passagers occasionnels";
            this.btn_ocas.UseVisualStyleBackColor = true;
            // 
            // btn_md
            // 
            this.btn_md.Location = new System.Drawing.Point(586, 180);
            this.btn_md.Name = "btn_md";
            this.btn_md.Size = new System.Drawing.Size(152, 60);
            this.btn_md.TabIndex = 2;
            this.btn_md.Text = "Master Detail";
            this.btn_md.UseVisualStyleBackColor = true;
            // 
            // btn_retour
            // 
            this.btn_retour.Location = new System.Drawing.Point(586, 318);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(152, 51);
            this.btn_retour.TabIndex = 3;
            this.btn_retour.Text = "Retour";
            this.btn_retour.UseVisualStyleBackColor = true;
            this.btn_retour.Click += new System.EventHandler(this.btn_retour_Click);
            // 
            // MenuAnalyse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_retour);
            this.Controls.Add(this.btn_md);
            this.Controls.Add(this.btn_ocas);
            this.Controls.Add(this.btn_lpg);
            this.Name = "MenuAnalyse";
            this.Text = "MenuAnalyse";
            this.Load += new System.EventHandler(this.MenuAnalyse_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_lpg;
        private System.Windows.Forms.Button btn_ocas;
        private System.Windows.Forms.Button btn_md;
        private System.Windows.Forms.Button btn_retour;
    }
}