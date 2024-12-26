namespace Tyuiu.SyrtsovaSA.Sprint7.Project.V11
{
    partial class FormEmployeeStats
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelEmployeesCount_SSA = new System.Windows.Forms.Label();
            this.textBoxEmployeesCount_SSA = new System.Windows.Forms.TextBox();
            this.textBoxMoneyAVG_SSA = new System.Windows.Forms.TextBox();
            this.labelMoneyAVG_SSA = new System.Windows.Forms.Label();
            this.textBoxMaxMoney_SSA = new System.Windows.Forms.TextBox();
            this.labelMaxMoney_SSA = new System.Windows.Forms.Label();
            this.textBoxMinMoney_SSA = new System.Windows.Forms.TextBox();
            this.labelMinMoney_SSA = new System.Windows.Forms.Label();
            this.chartEmployees_SSA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEmployees_SSA)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.textBoxMinMoney_SSA);
            this.panel1.Controls.Add(this.labelMinMoney_SSA);
            this.panel1.Controls.Add(this.textBoxMaxMoney_SSA);
            this.panel1.Controls.Add(this.labelMaxMoney_SSA);
            this.panel1.Controls.Add(this.textBoxMoneyAVG_SSA);
            this.panel1.Controls.Add(this.labelMoneyAVG_SSA);
            this.panel1.Controls.Add(this.textBoxEmployeesCount_SSA);
            this.panel1.Controls.Add(this.labelEmployeesCount_SSA);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 449);
            this.panel1.TabIndex = 0;
            // 
            // labelEmployeesCount_SSA
            // 
            this.labelEmployeesCount_SSA.AutoSize = true;
            this.labelEmployeesCount_SSA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmployeesCount_SSA.Location = new System.Drawing.Point(11, 13);
            this.labelEmployeesCount_SSA.Name = "labelEmployeesCount_SSA";
            this.labelEmployeesCount_SSA.Size = new System.Drawing.Size(185, 20);
            this.labelEmployeesCount_SSA.TabIndex = 0;
            this.labelEmployeesCount_SSA.Text = "Количество сотрудников:";
            // 
            // textBoxEmployeesCount_SSA
            // 
            this.textBoxEmployeesCount_SSA.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEmployeesCount_SSA.Location = new System.Drawing.Point(11, 33);
            this.textBoxEmployeesCount_SSA.Name = "textBoxEmployeesCount_SSA";
            this.textBoxEmployeesCount_SSA.ReadOnly = true;
            this.textBoxEmployeesCount_SSA.Size = new System.Drawing.Size(176, 25);
            this.textBoxEmployeesCount_SSA.TabIndex = 1;
            // 
            // textBoxMoneyAVG_SSA
            // 
            this.textBoxMoneyAVG_SSA.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMoneyAVG_SSA.Location = new System.Drawing.Point(11, 95);
            this.textBoxMoneyAVG_SSA.Name = "textBoxMoneyAVG_SSA";
            this.textBoxMoneyAVG_SSA.ReadOnly = true;
            this.textBoxMoneyAVG_SSA.Size = new System.Drawing.Size(176, 25);
            this.textBoxMoneyAVG_SSA.TabIndex = 3;
            // 
            // labelMoneyAVG_SSA
            // 
            this.labelMoneyAVG_SSA.AutoSize = true;
            this.labelMoneyAVG_SSA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMoneyAVG_SSA.Location = new System.Drawing.Point(11, 75);
            this.labelMoneyAVG_SSA.Name = "labelMoneyAVG_SSA";
            this.labelMoneyAVG_SSA.Size = new System.Drawing.Size(117, 20);
            this.labelMoneyAVG_SSA.TabIndex = 2;
            this.labelMoneyAVG_SSA.Text = "Средний оклад:";
            // 
            // textBoxMaxMoney_SSA
            // 
            this.textBoxMaxMoney_SSA.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMaxMoney_SSA.Location = new System.Drawing.Point(11, 159);
            this.textBoxMaxMoney_SSA.Name = "textBoxMaxMoney_SSA";
            this.textBoxMaxMoney_SSA.ReadOnly = true;
            this.textBoxMaxMoney_SSA.Size = new System.Drawing.Size(176, 25);
            this.textBoxMaxMoney_SSA.TabIndex = 5;
            // 
            // labelMaxMoney_SSA
            // 
            this.labelMaxMoney_SSA.AutoSize = true;
            this.labelMaxMoney_SSA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxMoney_SSA.Location = new System.Drawing.Point(11, 139);
            this.labelMaxMoney_SSA.Name = "labelMaxMoney_SSA";
            this.labelMaxMoney_SSA.Size = new System.Drawing.Size(164, 20);
            this.labelMaxMoney_SSA.TabIndex = 4;
            this.labelMaxMoney_SSA.Text = "Максимальный оклад:";
            // 
            // textBoxMinMoney_SSA
            // 
            this.textBoxMinMoney_SSA.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMinMoney_SSA.Location = new System.Drawing.Point(11, 230);
            this.textBoxMinMoney_SSA.Name = "textBoxMinMoney_SSA";
            this.textBoxMinMoney_SSA.ReadOnly = true;
            this.textBoxMinMoney_SSA.Size = new System.Drawing.Size(176, 25);
            this.textBoxMinMoney_SSA.TabIndex = 7;
            // 
            // labelMinMoney_SSA
            // 
            this.labelMinMoney_SSA.AutoSize = true;
            this.labelMinMoney_SSA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMinMoney_SSA.Location = new System.Drawing.Point(11, 210);
            this.labelMinMoney_SSA.Name = "labelMinMoney_SSA";
            this.labelMinMoney_SSA.Size = new System.Drawing.Size(160, 20);
            this.labelMinMoney_SSA.TabIndex = 6;
            this.labelMinMoney_SSA.Text = "Минимальный оклад:";
            // 
            // chartEmployees_SSA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartEmployees_SSA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartEmployees_SSA.Legends.Add(legend1);
            this.chartEmployees_SSA.Location = new System.Drawing.Point(274, 12);
            this.chartEmployees_SSA.Name = "chartEmployees_SSA";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartEmployees_SSA.Series.Add(series1);
            this.chartEmployees_SSA.Size = new System.Drawing.Size(514, 426);
            this.chartEmployees_SSA.TabIndex = 1;
            this.chartEmployees_SSA.Text = "chart";
            // 
            // FormEmployeeStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartEmployees_SSA);
            this.Controls.Add(this.panel1);
            this.Name = "FormEmployeeStats";
            this.Text = "Статистика по сотрудникам";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEmployees_SSA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxEmployeesCount_SSA;
        private System.Windows.Forms.Label labelEmployeesCount_SSA;
        private System.Windows.Forms.TextBox textBoxMoneyAVG_SSA;
        private System.Windows.Forms.Label labelMoneyAVG_SSA;
        private System.Windows.Forms.TextBox textBoxMaxMoney_SSA;
        private System.Windows.Forms.Label labelMaxMoney_SSA;
        private System.Windows.Forms.TextBox textBoxMinMoney_SSA;
        private System.Windows.Forms.Label labelMinMoney_SSA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEmployees_SSA;
    }
}