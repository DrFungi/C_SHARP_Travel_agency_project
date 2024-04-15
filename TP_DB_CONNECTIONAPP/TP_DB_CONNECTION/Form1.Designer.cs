namespace TP_DB_CONNECTION
{
    partial class MainMenu
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
            this.btn_passager = new System.Windows.Forms.Button();
            this.btn_Reservation = new System.Windows.Forms.Button();
            this.btn_Analyse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_passager
            // 
            this.btn_passager.Location = new System.Drawing.Point(133, 176);
            this.btn_passager.Name = "btn_passager";
            this.btn_passager.Size = new System.Drawing.Size(96, 61);
            this.btn_passager.TabIndex = 0;
            this.btn_passager.Text = "Passager";
            this.btn_passager.UseVisualStyleBackColor = true;
            this.btn_passager.Click += new System.EventHandler(this.btn_passager_Click);
            // 
            // btn_Reservation
            // 
            this.btn_Reservation.Location = new System.Drawing.Point(322, 176);
            this.btn_Reservation.Name = "btn_Reservation";
            this.btn_Reservation.Size = new System.Drawing.Size(90, 61);
            this.btn_Reservation.TabIndex = 1;
            this.btn_Reservation.Text = "Reservation";
            this.btn_Reservation.UseVisualStyleBackColor = true;
            // 
            // btn_Analyse
            // 
            this.btn_Analyse.Location = new System.Drawing.Point(518, 176);
            this.btn_Analyse.Name = "btn_Analyse";
            this.btn_Analyse.Size = new System.Drawing.Size(85, 61);
            this.btn_Analyse.TabIndex = 2;
            this.btn_Analyse.Text = "Analyse";
            this.btn_Analyse.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Analyse);
            this.Controls.Add(this.btn_Reservation);
            this.Controls.Add(this.btn_passager);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_passager;
        private System.Windows.Forms.Button btn_Reservation;
        private System.Windows.Forms.Button btn_Analyse;
    }
}

