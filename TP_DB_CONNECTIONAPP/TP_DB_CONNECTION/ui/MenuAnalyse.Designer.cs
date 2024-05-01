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
            this.btn_lpg.Location = new System.Drawing.Point(35, 148);
            this.btn_lpg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_lpg.Name = "btn_lpg";
            this.btn_lpg.Size = new System.Drawing.Size(120, 48);
            this.btn_lpg.TabIndex = 0;
            this.btn_lpg.Text = "Liste des passagers";
            this.btn_lpg.UseVisualStyleBackColor = true;
            this.btn_lpg.Click += new System.EventHandler(this.btn_lpg_Click);
            // 
            // btn_ocas
            // 
            this.btn_ocas.Location = new System.Drawing.Point(200, 146);
            this.btn_ocas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ocas.Name = "btn_ocas";
            this.btn_ocas.Size = new System.Drawing.Size(179, 50);
            this.btn_ocas.TabIndex = 1;
            this.btn_ocas.Text = "Liste des passagers occasionnels";
            this.btn_ocas.UseVisualStyleBackColor = true;
            this.btn_ocas.Click += new System.EventHandler(this.btn_ocas_Click);
            // 
            // btn_md
            // 
            this.btn_md.Location = new System.Drawing.Point(440, 146);
            this.btn_md.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_md.Name = "btn_md";
            this.btn_md.Size = new System.Drawing.Size(114, 49);
            this.btn_md.TabIndex = 2;
            this.btn_md.Text = "Master Detail";
            this.btn_md.UseVisualStyleBackColor = true;
            // 
            // btn_retour
            // 
            this.btn_retour.Location = new System.Drawing.Point(440, 258);
            this.btn_retour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(114, 41);
            this.btn_retour.TabIndex = 3;
            this.btn_retour.Text = "Retour";
            this.btn_retour.UseVisualStyleBackColor = true;
            this.btn_retour.Click += new System.EventHandler(this.btn_retour_Click);
            // 
            // MenuAnalyse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btn_retour);
            this.Controls.Add(this.btn_md);
            this.Controls.Add(this.btn_ocas);
            this.Controls.Add(this.btn_lpg);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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