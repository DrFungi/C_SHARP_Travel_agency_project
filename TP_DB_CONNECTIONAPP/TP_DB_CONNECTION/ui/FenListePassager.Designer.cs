namespace TP_DB_CONNECTION.ui
{
    partial class FenListePassager
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
            this.dgv_lpg = new System.Windows.Forms.DataGridView();
            this.btn_aff_passagers = new System.Windows.Forms.Button();
            this.txt_search_passager = new System.Windows.Forms.TextBox();
            this.btn_retourAnalyse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lpg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rechercher un passager par son nom";
            // 
            // dgv_lpg
            // 
            this.dgv_lpg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lpg.Location = new System.Drawing.Point(25, 107);
            this.dgv_lpg.Name = "dgv_lpg";
            this.dgv_lpg.RowHeadersWidth = 51;
            this.dgv_lpg.RowTemplate.Height = 24;
            this.dgv_lpg.Size = new System.Drawing.Size(746, 255);
            this.dgv_lpg.TabIndex = 2;
            this.dgv_lpg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_lpg_CellContentClick);
            // 
            // btn_aff_passagers
            // 
            this.btn_aff_passagers.Location = new System.Drawing.Point(64, 383);
            this.btn_aff_passagers.Name = "btn_aff_passagers";
            this.btn_aff_passagers.Size = new System.Drawing.Size(246, 39);
            this.btn_aff_passagers.TabIndex = 3;
            this.btn_aff_passagers.Text = "Afficher tous les passagers";
            this.btn_aff_passagers.UseVisualStyleBackColor = true;
            this.btn_aff_passagers.Click += new System.EventHandler(this.btn_aff_passagers_Click);
            // 
            // txt_search_passager
            // 
            this.txt_search_passager.Location = new System.Drawing.Point(313, 65);
            this.txt_search_passager.Name = "txt_search_passager";
            this.txt_search_passager.Size = new System.Drawing.Size(180, 22);
            this.txt_search_passager.TabIndex = 4;
            this.txt_search_passager.TextChanged += new System.EventHandler(this.txt_search_passager_TextChanged);
            // 
            // btn_retourAnalyse
            // 
            this.btn_retourAnalyse.Location = new System.Drawing.Point(576, 388);
            this.btn_retourAnalyse.Margin = new System.Windows.Forms.Padding(4);
            this.btn_retourAnalyse.Name = "btn_retourAnalyse";
            this.btn_retourAnalyse.Size = new System.Drawing.Size(100, 28);
            this.btn_retourAnalyse.TabIndex = 5;
            this.btn_retourAnalyse.Text = "Retour";
            this.btn_retourAnalyse.UseVisualStyleBackColor = true;
            this.btn_retourAnalyse.Click += new System.EventHandler(this.btn_retourAnalyse_Click);
            // 
            // FenListePassager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_retourAnalyse);
            this.Controls.Add(this.txt_search_passager);
            this.Controls.Add(this.btn_aff_passagers);
            this.Controls.Add(this.dgv_lpg);
            this.Controls.Add(this.label1);
            this.Name = "FenListePassager";
            this.Text = "FenListePassager";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lpg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_lpg;
        private System.Windows.Forms.Button btn_aff_passagers;
        private System.Windows.Forms.TextBox txt_search_passager;
        private System.Windows.Forms.Button btn_retourAnalyse;
    }
}