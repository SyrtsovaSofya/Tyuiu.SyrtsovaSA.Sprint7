namespace Tyuiu.SyrtsovaSA.Sprint7.Project.V11
{
    partial class FormGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide));
            this.textBox_SSA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_SSA
            // 
            this.textBox_SSA.BackColor = System.Drawing.Color.FloralWhite;
            this.textBox_SSA.HideSelection = false;
            this.textBox_SSA.Location = new System.Drawing.Point(0, 0);
            this.textBox_SSA.Multiline = true;
            this.textBox_SSA.Name = "textBox_SSA";
            this.textBox_SSA.ReadOnly = true;
            this.textBox_SSA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_SSA.Size = new System.Drawing.Size(804, 447);
            this.textBox_SSA.TabIndex = 0;
            this.textBox_SSA.TabStop = false;
            this.textBox_SSA.Text = resources.GetString("textBox_SSA.Text");
            // 
            // FormGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_SSA);
            this.Name = "FormGuide";
            this.Text = "Руководство пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_SSA;
    }
}