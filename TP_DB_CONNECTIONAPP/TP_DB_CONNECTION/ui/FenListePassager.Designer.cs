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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lpg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des passagers";
            // 
            // dgv_lpg
            // 
            this.dgv_lpg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lpg.Location = new System.Drawing.Point(163, 61);
            this.dgv_lpg.Name = "dgv_lpg";
            this.dgv_lpg.RowHeadersWidth = 51;
            this.dgv_lpg.RowTemplate.Height = 24;
            this.dgv_lpg.Size = new System.Drawing.Size(542, 255);
            this.dgv_lpg.TabIndex = 2;
            this.dgv_lpg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_lpg_CellContentClick);
            // 
            // FenListePassager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}