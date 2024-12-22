namespace Tyuiu.SyrtsovaSA.Sprint7.Project.V11
{
    partial class FormAbout
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
            this.pictureBox_SSA = new System.Windows.Forms.PictureBox();
            this.labelAbout_SSA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SSA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_SSA
            // 
            this.pictureBox_SSA.Image = global::Tyuiu.SyrtsovaSA.Sprint7.Project.V11.Properties.Resources._1;
            this.pictureBox_SSA.Location = new System.Drawing.Point(13, 13);
            this.pictureBox_SSA.Name = "pictureBox_SSA";
            this.pictureBox_SSA.Size = new System.Drawing.Size(255, 346);
            this.pictureBox_SSA.TabIndex = 0;
            this.pictureBox_SSA.TabStop = false;
            // 
            // labelAbout_SSA
            // 
            this.labelAbout_SSA.AutoSize = true;
            this.labelAbout_SSA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAbout_SSA.Location = new System.Drawing.Point(274, 13);
            this.labelAbout_SSA.Name = "labelAbout_SSA";
            this.labelAbout_SSA.Size = new System.Drawing.Size(196, 140);
            this.labelAbout_SSA.TabIndex = 1;
            this.labelAbout_SSA.Text = "Разработчик: Сырцова С.А.\r\nгруппа ИИПб-24-1.\r\n\r\nПрограмма является \r\nучебным прое" +
    "ктом\r\nв рамках изучения C#.\r\n\r\n";
            this.labelAbout_SSA.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(487, 373);
            this.Controls.Add(this.labelAbout_SSA);
            this.Controls.Add(this.pictureBox_SSA);
            this.Name = "FormAbout";
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SSA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_SSA;
        private System.Windows.Forms.Label labelAbout_SSA;
    }
}