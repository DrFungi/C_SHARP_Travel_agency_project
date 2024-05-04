namespace TP_DB_CONNECTION.ui
{
    partial class MasterDetail
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
            this.cmb_freq_fly = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lsb_freq = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmb_freq_fly
            // 
            this.cmb_freq_fly.FormattingEnabled = true;
            this.cmb_freq_fly.Location = new System.Drawing.Point(263, 49);
            this.cmb_freq_fly.Name = "cmb_freq_fly";
            this.cmb_freq_fly.Size = new System.Drawing.Size(159, 21);
            this.cmb_freq_fly.TabIndex = 0;
            this.cmb_freq_fly.SelectedIndexChanged += new System.EventHandler(this.cmb_freq_fly_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Frequent Flyer Passager";
            // 
            // lsb_freq
            // 
            this.lsb_freq.FormattingEnabled = true;
            this.lsb_freq.Location = new System.Drawing.Point(87, 135);
            this.lsb_freq.Name = "lsb_freq";
            this.lsb_freq.Size = new System.Drawing.Size(335, 238);
            this.lsb_freq.TabIndex = 2;
            // 
            // MasterDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsb_freq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_freq_fly);
            this.Name = "MasterDetail";
            this.Text = "Master_detail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_freq_fly;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsb_freq;
    }
}