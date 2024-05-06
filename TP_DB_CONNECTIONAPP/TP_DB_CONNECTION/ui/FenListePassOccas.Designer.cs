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
            this.txt_search_occas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_occPass)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_occPass
            // 
            this.dgv_occPass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_occPass.Location = new System.Drawing.Point(203, 162);
            this.dgv_occPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_occPass.Name = "dgv_occPass";
            this.dgv_occPass.RowHeadersWidth = 51;
            this.dgv_occPass.Size = new System.Drawing.Size(715, 272);
            this.dgv_occPass.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rechercher un passager par son nom";
            // 
            // btn_affOccPass
            // 
            this.btn_affOccPass.Location = new System.Drawing.Point(203, 470);
            this.btn_affOccPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_affOccPass.Name = "btn_affOccPass";
            this.btn_affOccPass.Size = new System.Drawing.Size(207, 46);
            this.btn_affOccPass.TabIndex = 3;
            this.btn_affOccPass.Text = "Afficher les passagers";
            this.btn_affOccPass.UseVisualStyleBackColor = true;
            this.btn_affOccPass.Click += new System.EventHandler(this.btn_affOccPass_Click);
            // 
            // btn_retourAnalyse
            // 
            this.btn_retourAnalyse.Location = new System.Drawing.Point(817, 487);
            this.btn_retourAnalyse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_retourAnalyse.Name = "btn_retourAnalyse";
            this.btn_retourAnalyse.Size = new System.Drawing.Size(100, 28);
            this.btn_retourAnalyse.TabIndex = 4;
            this.btn_retourAnalyse.Text = "Retour";
            this.btn_retourAnalyse.UseVisualStyleBackColor = true;
            this.btn_retourAnalyse.Click += new System.EventHandler(this.btn_retourAnalyse_Click);
            // 
            // txt_search_occas
            // 
            this.txt_search_occas.Location = new System.Drawing.Point(499, 119);
            this.txt_search_occas.Name = "txt_search_occas";
            this.txt_search_occas.Size = new System.Drawing.Size(211, 22);
            this.txt_search_occas.TabIndex = 6;
            this.txt_search_occas.TextChanged += new System.EventHandler(this.txt_box_TextChanged);
            // 
            // FenListePassOccas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txt_search_occas);
            this.Controls.Add(this.btn_retourAnalyse);
            this.Controls.Add(this.btn_affOccPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_occPass);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox txt_search_occas;
    }
}