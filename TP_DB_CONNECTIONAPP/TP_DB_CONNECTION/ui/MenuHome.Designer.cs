namespace TP_DB_CONNECTION
{
    partial class MenuHome
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
            this.btn_passager.Location = new System.Drawing.Point(177, 217);
            this.btn_passager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_passager.Name = "btn_passager";
            this.btn_passager.Size = new System.Drawing.Size(128, 75);
            this.btn_passager.TabIndex = 0;
            this.btn_passager.Text = "Passager";
            this.btn_passager.UseVisualStyleBackColor = true;
            this.btn_passager.Click += new System.EventHandler(this.btn_passager_Click);
            // 
            // btn_Reservation
            // 
            this.btn_Reservation.Location = new System.Drawing.Point(429, 217);
            this.btn_Reservation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Reservation.Name = "btn_Reservation";
            this.btn_Reservation.Size = new System.Drawing.Size(120, 75);
            this.btn_Reservation.TabIndex = 1;
            this.btn_Reservation.Text = "Reservation";
            this.btn_Reservation.UseVisualStyleBackColor = true;
            this.btn_Reservation.Click += new System.EventHandler(this.btn_Reservation_Click);
            // 
            // btn_Analyse
            // 
            this.btn_Analyse.Location = new System.Drawing.Point(691, 217);
            this.btn_Analyse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Analyse.Name = "btn_Analyse";
            this.btn_Analyse.Size = new System.Drawing.Size(113, 75);
            this.btn_Analyse.TabIndex = 2;
            this.btn_Analyse.Text = "Analyse";
            this.btn_Analyse.UseVisualStyleBackColor = true;
            // 
            // MenuHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_Analyse);
            this.Controls.Add(this.btn_Reservation);
            this.Controls.Add(this.btn_passager);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MenuHome";
            this.Text = "MenuHome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_passager;
        private System.Windows.Forms.Button btn_Reservation;
        private System.Windows.Forms.Button btn_Analyse;
    }
}

