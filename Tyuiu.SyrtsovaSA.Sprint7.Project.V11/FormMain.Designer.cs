using System.Windows.Forms;

namespace Tyuiu.SyrtsovaSA.Sprint7.Project.V11
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.panelMenu_SSA = new System.Windows.Forms.Panel();
            this.buttonAbout_SSA = new System.Windows.Forms.Button();
            this.buttonGuide_SSA = new System.Windows.Forms.Button();
            this.buttonUnits_SSA = new System.Windows.Forms.Button();
            this.buttonEmployees_SSA = new System.Windows.Forms.Button();
            this.panelEmployees_SSA = new System.Windows.Forms.Panel();
            this.labelMoney_SSA = new System.Windows.Forms.Label();
            this.textBoxMoney_SSA = new System.Windows.Forms.TextBox();
            this.checkBoxDegree_SSA = new System.Windows.Forms.CheckBox();
            this.buttonEmployeeStats_SSA = new System.Windows.Forms.Button();
            this.comboBoxSort_SSA = new System.Windows.Forms.ComboBox();
            this.buttonSearchEmployees_SSA = new System.Windows.Forms.Button();
            this.buttonDeleteEmployee_SSA = new System.Windows.Forms.Button();
            this.buttonAddEmployee_SSA = new System.Windows.Forms.Button();
            this.textBoxStartWork_SSA = new System.Windows.Forms.TextBox();
            this.textBoxExperience_SSA = new System.Windows.Forms.TextBox();
            this.textBoxDegree_SSA = new System.Windows.Forms.TextBox();
            this.textBoxBirth_SSA = new System.Windows.Forms.TextBox();
            this.textBoxRole_SSA = new System.Windows.Forms.TextBox();
            this.textBoxPhone_SSA = new System.Windows.Forms.TextBox();
            this.textBoxAdress_SSA = new System.Windows.Forms.TextBox();
            this.textBoxFIO_SSA = new System.Windows.Forms.TextBox();
            this.labelDegree_SSA = new System.Windows.Forms.Label();
            this.labelExperience_SSA = new System.Windows.Forms.Label();
            this.labelStartWork_SSA = new System.Windows.Forms.Label();
            this.labelRole_SSA = new System.Windows.Forms.Label();
            this.labelBirth_SSA = new System.Windows.Forms.Label();
            this.labelPhone_SSA = new System.Windows.Forms.Label();
            this.labelAdress_SSA = new System.Windows.Forms.Label();
            this.labelFIO_SSA = new System.Windows.Forms.Label();
            this.textBoxSearchEmployees_SSA = new System.Windows.Forms.TextBox();
            this.dataGridViewEmployees_SSA = new System.Windows.Forms.DataGridView();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Degree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Experience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Оклад = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelEmployees_SSA = new System.Windows.Forms.Label();
            this.toolTip_SSA = new System.Windows.Forms.ToolTip(this.components);
            this.panelMenu_SSA.SuspendLayout();
            this.panelEmployees_SSA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees_SSA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu_SSA
            // 
            this.panelMenu_SSA.BackColor = System.Drawing.Color.SeaShell;
            this.panelMenu_SSA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu_SSA.Controls.Add(this.buttonAbout_SSA);
            this.panelMenu_SSA.Controls.Add(this.buttonGuide_SSA);
            this.panelMenu_SSA.Controls.Add(this.buttonUnits_SSA);
            this.panelMenu_SSA.Controls.Add(this.buttonEmployees_SSA);
            this.panelMenu_SSA.Location = new System.Drawing.Point(0, -1);
            this.panelMenu_SSA.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panelMenu_SSA.Name = "panelMenu_SSA";
            this.panelMenu_SSA.Size = new System.Drawing.Size(225, 552);
            this.panelMenu_SSA.TabIndex = 0;
            // 
            // buttonAbout_SSA
            // 
            this.buttonAbout_SSA.BackColor = System.Drawing.Color.SeaShell;
            this.buttonAbout_SSA.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAbout_SSA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout_SSA.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAbout_SSA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAbout_SSA.Location = new System.Drawing.Point(-1, 167);
            this.buttonAbout_SSA.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.buttonAbout_SSA.Name = "buttonAbout_SSA";
            this.buttonAbout_SSA.Size = new System.Drawing.Size(226, 59);
            this.buttonAbout_SSA.TabIndex = 3;
            this.buttonAbout_SSA.Text = "О программе";
            this.buttonAbout_SSA.UseVisualStyleBackColor = false;
            this.buttonAbout_SSA.Click += new System.EventHandler(this.buttonAbout_SSA_Click);
            // 
            // buttonGuide_SSA
            // 
            this.buttonGuide_SSA.BackColor = System.Drawing.Color.SeaShell;
            this.buttonGuide_SSA.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonGuide_SSA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuide_SSA.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGuide_SSA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGuide_SSA.Location = new System.Drawing.Point(-1, 112);
            this.buttonGuide_SSA.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.buttonGuide_SSA.Name = "buttonGuide_SSA";
            this.buttonGuide_SSA.Size = new System.Drawing.Size(226, 59);
            this.buttonGuide_SSA.TabIndex = 2;
            this.buttonGuide_SSA.Text = "Руководство пользователя";
            this.buttonGuide_SSA.UseVisualStyleBackColor = false;
            this.buttonGuide_SSA.Click += new System.EventHandler(this.buttonGuide_SSA_Click);
            // 
            // buttonUnits_SSA
            // 
            this.buttonUnits_SSA.BackColor = System.Drawing.Color.SeaShell;
            this.buttonUnits_SSA.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonUnits_SSA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUnits_SSA.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUnits_SSA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonUnits_SSA.Location = new System.Drawing.Point(-1, 56);
            this.buttonUnits_SSA.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.buttonUnits_SSA.Name = "buttonUnits_SSA";
            this.buttonUnits_SSA.Size = new System.Drawing.Size(225, 59);
            this.buttonUnits_SSA.TabIndex = 1;
            this.buttonUnits_SSA.Text = "Подразделения";
            this.buttonUnits_SSA.UseVisualStyleBackColor = false;
            this.buttonUnits_SSA.Click += new System.EventHandler(this.buttonUnits_SSA_Click);
            // 
            // buttonEmployees_SSA
            // 
            this.buttonEmployees_SSA.BackColor = System.Drawing.Color.SeaShell;
            this.buttonEmployees_SSA.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonEmployees_SSA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployees_SSA.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEmployees_SSA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEmployees_SSA.Location = new System.Drawing.Point(-1, 0);
            this.buttonEmployees_SSA.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.buttonEmployees_SSA.Name = "buttonEmployees_SSA";
            this.buttonEmployees_SSA.Size = new System.Drawing.Size(226, 59);
            this.buttonEmployees_SSA.TabIndex = 0;
            this.buttonEmployees_SSA.Text = "Сотрудники";
            this.buttonEmployees_SSA.UseVisualStyleBackColor = false;
            this.buttonEmployees_SSA.Click += new System.EventHandler(this.buttonEmployees_SSA_Click);
            // 
            // panelEmployees_SSA
            // 
            this.panelEmployees_SSA.BackColor = System.Drawing.Color.FloralWhite;
            this.panelEmployees_SSA.Controls.Add(this.labelMoney_SSA);
            this.panelEmployees_SSA.Controls.Add(this.textBoxMoney_SSA);
            this.panelEmployees_SSA.Controls.Add(this.checkBoxDegree_SSA);
            this.panelEmployees_SSA.Controls.Add(this.buttonEmployeeStats_SSA);
            this.panelEmployees_SSA.Controls.Add(this.comboBoxSort_SSA);
            this.panelEmployees_SSA.Controls.Add(this.buttonSearchEmployees_SSA);
            this.panelEmployees_SSA.Controls.Add(this.buttonDeleteEmployee_SSA);
            this.panelEmployees_SSA.Controls.Add(this.buttonAddEmployee_SSA);
            this.panelEmployees_SSA.Controls.Add(this.textBoxStartWork_SSA);
            this.panelEmployees_SSA.Controls.Add(this.textBoxExperience_SSA);
            this.panelEmployees_SSA.Controls.Add(this.textBoxDegree_SSA);
            this.panelEmployees_SSA.Controls.Add(this.textBoxBirth_SSA);
            this.panelEmployees_SSA.Controls.Add(this.textBoxRole_SSA);
            this.panelEmployees_SSA.Controls.Add(this.textBoxPhone_SSA);
            this.panelEmployees_SSA.Controls.Add(this.textBoxAdress_SSA);
            this.panelEmployees_SSA.Controls.Add(this.textBoxFIO_SSA);
            this.panelEmployees_SSA.Controls.Add(this.labelDegree_SSA);
            this.panelEmployees_SSA.Controls.Add(this.labelExperience_SSA);
            this.panelEmployees_SSA.Controls.Add(this.labelStartWork_SSA);
            this.panelEmployees_SSA.Controls.Add(this.labelRole_SSA);
            this.panelEmployees_SSA.Controls.Add(this.labelBirth_SSA);
            this.panelEmployees_SSA.Controls.Add(this.labelPhone_SSA);
            this.panelEmployees_SSA.Controls.Add(this.labelAdress_SSA);
            this.panelEmployees_SSA.Controls.Add(this.labelFIO_SSA);
            this.panelEmployees_SSA.Controls.Add(this.textBoxSearchEmployees_SSA);
            this.panelEmployees_SSA.Controls.Add(this.dataGridViewEmployees_SSA);
            this.panelEmployees_SSA.Controls.Add(this.labelEmployees_SSA);
            this.panelEmployees_SSA.Location = new System.Drawing.Point(228, 0);
            this.panelEmployees_SSA.Name = "panelEmployees_SSA";
            this.panelEmployees_SSA.Size = new System.Drawing.Size(1168, 551);
            this.panelEmployees_SSA.TabIndex = 2;
            // 
            // labelMoney_SSA
            // 
            this.labelMoney_SSA.AutoSize = true;
            this.labelMoney_SSA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMoney_SSA.Location = new System.Drawing.Point(676, 436);
            this.labelMoney_SSA.Name = "labelMoney_SSA";
            this.labelMoney_SSA.Size = new System.Drawing.Size(54, 20);
            this.labelMoney_SSA.TabIndex = 31;
            this.labelMoney_SSA.Text = "Оклад:";
            // 
            // textBoxMoney_SSA
            // 
            this.textBoxMoney_SSA.Location = new System.Drawing.Point(680, 460);
            this.textBoxMoney_SSA.Name = "textBoxMoney_SSA";
            this.textBoxMoney_SSA.Size = new System.Drawing.Size(123, 22);
            this.textBoxMoney_SSA.TabIndex = 30;
            // 
            // checkBoxDegree_SSA
            // 
            this.checkBoxDegree_SSA.AutoSize = true;
            this.checkBoxDegree_SSA.Location = new System.Drawing.Point(492, 60);
            this.checkBoxDegree_SSA.Name = "checkBoxDegree_SSA";
            this.checkBoxDegree_SSA.Size = new System.Drawing.Size(108, 20);
            this.checkBoxDegree_SSA.TabIndex = 29;
            this.checkBoxDegree_SSA.Text = "Только с ВО";
            this.checkBoxDegree_SSA.UseVisualStyleBackColor = true;
            this.checkBoxDegree_SSA.CheckedChanged += new System.EventHandler(this.checkBoxDegree_SSA_CheckedChanged);
            // 
            // buttonEmployeeStats_SSA
            // 
            this.buttonEmployeeStats_SSA.BackColor = System.Drawing.Color.Cornsilk;
            this.buttonEmployeeStats_SSA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEmployeeStats_SSA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployeeStats_SSA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEmployeeStats_SSA.Location = new System.Drawing.Point(970, 48);
            this.buttonEmployeeStats_SSA.Name = "buttonEmployeeStats_SSA";
            this.buttonEmployeeStats_SSA.Size = new System.Drawing.Size(178, 41);
            this.buttonEmployeeStats_SSA.TabIndex = 28;
            this.buttonEmployeeStats_SSA.Text = "Статистика";
            this.buttonEmployeeStats_SSA.UseVisualStyleBackColor = false;
            this.buttonEmployeeStats_SSA.Click += new System.EventHandler(this.buttonEmployeeStats_SSA_Click);
            // 
            // comboBoxSort_SSA
            // 
            this.comboBoxSort_SSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSort_SSA.FormattingEnabled = true;
            this.comboBoxSort_SSA.Location = new System.Drawing.Point(281, 56);
            this.comboBoxSort_SSA.Name = "comboBoxSort_SSA";
            this.comboBoxSort_SSA.Size = new System.Drawing.Size(168, 26);
            this.comboBoxSort_SSA.TabIndex = 27;
            this.comboBoxSort_SSA.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonSearchEmployees_SSA
            // 
            this.buttonSearchEmployees_SSA.BackColor = System.Drawing.Color.FloralWhite;
            this.buttonSearchEmployees_SSA.FlatAppearance.BorderSize = 0;
            this.buttonSearchEmployees_SSA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchEmployees_SSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchEmployees_SSA.Location = new System.Drawing.Point(212, 54);
            this.buttonSearchEmployees_SSA.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.buttonSearchEmployees_SSA.Name = "buttonSearchEmployees_SSA";
            this.buttonSearchEmployees_SSA.Size = new System.Drawing.Size(27, 30);
            this.buttonSearchEmployees_SSA.TabIndex = 26;
            this.buttonSearchEmployees_SSA.Text = "🔎";
            this.toolTip_SSA.SetToolTip(this.buttonSearchEmployees_SSA, "Введите данные для поиска.");
            this.buttonSearchEmployees_SSA.UseVisualStyleBackColor = false;
            this.buttonSearchEmployees_SSA.Click += new System.EventHandler(this.buttonSearchEmployees_SSA_Click);
            this.buttonSearchEmployees_SSA.MouseEnter += new System.EventHandler(this.buttonSearchEmployees_SSA_MouseEnter);
            // 
            // buttonDeleteEmployee_SSA
            // 
            this.buttonDeleteEmployee_SSA.BackColor = System.Drawing.Color.Cornsilk;
            this.buttonDeleteEmployee_SSA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteEmployee_SSA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteEmployee_SSA.Location = new System.Drawing.Point(970, 490);
            this.buttonDeleteEmployee_SSA.Name = "buttonDeleteEmployee_SSA";
            this.buttonDeleteEmployee_SSA.Size = new System.Drawing.Size(178, 45);
            this.buttonDeleteEmployee_SSA.TabIndex = 25;
            this.buttonDeleteEmployee_SSA.Text = "Удалить";
            this.buttonDeleteEmployee_SSA.UseVisualStyleBackColor = false;
            this.buttonDeleteEmployee_SSA.Click += new System.EventHandler(this.buttonDeleteEmployee_SSA_Click);
            // 
            // buttonAddEmployee_SSA
            // 
            this.buttonAddEmployee_SSA.BackColor = System.Drawing.Color.Cornsilk;
            this.buttonAddEmployee_SSA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAddEmployee_SSA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddEmployee_SSA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddEmployee_SSA.Location = new System.Drawing.Point(970, 443);
            this.buttonAddEmployee_SSA.Name = "buttonAddEmployee_SSA";
            this.buttonAddEmployee_SSA.Size = new System.Drawing.Size(178, 41);
            this.buttonAddEmployee_SSA.TabIndex = 24;
            this.buttonAddEmployee_SSA.Text = "Добавить";
            this.buttonAddEmployee_SSA.UseVisualStyleBackColor = false;
            this.buttonAddEmployee_SSA.Click += new System.EventHandler(this.buttonAddEmployee_SSA_Click);
            // 
            // textBoxStartWork_SSA
            // 
            this.textBoxStartWork_SSA.Location = new System.Drawing.Point(534, 513);
            this.textBoxStartWork_SSA.Name = "textBoxStartWork_SSA";
            this.textBoxStartWork_SSA.Size = new System.Drawing.Size(123, 22);
            this.textBoxStartWork_SSA.TabIndex = 23;
            // 
            // textBoxExperience_SSA
            // 
            this.textBoxExperience_SSA.Location = new System.Drawing.Point(534, 460);
            this.textBoxExperience_SSA.Name = "textBoxExperience_SSA";
            this.textBoxExperience_SSA.Size = new System.Drawing.Size(123, 22);
            this.textBoxExperience_SSA.TabIndex = 22;
            // 
            // textBoxDegree_SSA
            // 
            this.textBoxDegree_SSA.Location = new System.Drawing.Point(381, 513);
            this.textBoxDegree_SSA.Name = "textBoxDegree_SSA";
            this.textBoxDegree_SSA.Size = new System.Drawing.Size(123, 22);
            this.textBoxDegree_SSA.TabIndex = 21;
            // 
            // textBoxBirth_SSA
            // 
            this.textBoxBirth_SSA.Location = new System.Drawing.Point(381, 460);
            this.textBoxBirth_SSA.Name = "textBoxBirth_SSA";
            this.textBoxBirth_SSA.Size = new System.Drawing.Size(123, 22);
            this.textBoxBirth_SSA.TabIndex = 20;
            // 
            // textBoxRole_SSA
            // 
            this.textBoxRole_SSA.Location = new System.Drawing.Point(200, 513);
            this.textBoxRole_SSA.Name = "textBoxRole_SSA";
            this.textBoxRole_SSA.Size = new System.Drawing.Size(150, 22);
            this.textBoxRole_SSA.TabIndex = 19;
            // 
            // textBoxPhone_SSA
            // 
            this.textBoxPhone_SSA.Location = new System.Drawing.Point(200, 460);
            this.textBoxPhone_SSA.Name = "textBoxPhone_SSA";
            this.textBoxPhone_SSA.Size = new System.Drawing.Size(150, 22);
            this.textBoxPhone_SSA.TabIndex = 18;
            // 
            // textBoxAdress_SSA
            // 
            this.textBoxAdress_SSA.Location = new System.Drawing.Point(20, 513);
            this.textBoxAdress_SSA.Name = "textBoxAdress_SSA";
            this.textBoxAdress_SSA.Size = new System.Drawing.Size(150, 22);
            this.textBoxAdress_SSA.TabIndex = 17;
            // 
            // textBoxFIO_SSA
            // 
            this.textBoxFIO_SSA.Location = new System.Drawing.Point(20, 460);
            this.textBoxFIO_SSA.Name = "textBoxFIO_SSA";
            this.textBoxFIO_SSA.Size = new System.Drawing.Size(150, 22);
            this.textBoxFIO_SSA.TabIndex = 16;
            // 
            // labelDegree_SSA
            // 
            this.labelDegree_SSA.AutoSize = true;
            this.labelDegree_SSA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDegree_SSA.Location = new System.Drawing.Point(377, 490);
            this.labelDegree_SSA.Name = "labelDegree_SSA";
            this.labelDegree_SSA.Size = new System.Drawing.Size(107, 20);
            this.labelDegree_SSA.TabIndex = 15;
            this.labelDegree_SSA.Text = "Образование:";
            // 
            // labelExperience_SSA
            // 
            this.labelExperience_SSA.AutoSize = true;
            this.labelExperience_SSA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExperience_SSA.Location = new System.Drawing.Point(530, 437);
            this.labelExperience_SSA.Name = "labelExperience_SSA";
            this.labelExperience_SSA.Size = new System.Drawing.Size(46, 20);
            this.labelExperience_SSA.TabIndex = 14;
            this.labelExperience_SSA.Text = "Стаж:";
            // 
            // labelStartWork_SSA
            // 
            this.labelStartWork_SSA.AutoSize = true;
            this.labelStartWork_SSA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStartWork_SSA.Location = new System.Drawing.Point(530, 490);
            this.labelStartWork_SSA.Name = "labelStartWork_SSA";
            this.labelStartWork_SSA.Size = new System.Drawing.Size(129, 20);
            this.labelStartWork_SSA.TabIndex = 13;
            this.labelStartWork_SSA.Text = "Дата зачисления:";
            // 
            // labelRole_SSA
            // 
            this.labelRole_SSA.AutoSize = true;
            this.labelRole_SSA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRole_SSA.Location = new System.Drawing.Point(196, 490);
            this.labelRole_SSA.Name = "labelRole_SSA";
            this.labelRole_SSA.Size = new System.Drawing.Size(89, 20);
            this.labelRole_SSA.TabIndex = 12;
            this.labelRole_SSA.Text = "Должность:";
            // 
            // labelBirth_SSA
            // 
            this.labelBirth_SSA.AutoSize = true;
            this.labelBirth_SSA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBirth_SSA.Location = new System.Drawing.Point(377, 437);
            this.labelBirth_SSA.Name = "labelBirth_SSA";
            this.labelBirth_SSA.Size = new System.Drawing.Size(119, 20);
            this.labelBirth_SSA.TabIndex = 11;
            this.labelBirth_SSA.Text = "Дата рождения:";
            // 
            // labelPhone_SSA
            // 
            this.labelPhone_SSA.AutoSize = true;
            this.labelPhone_SSA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone_SSA.Location = new System.Drawing.Point(196, 437);
            this.labelPhone_SSA.Name = "labelPhone_SSA";
            this.labelPhone_SSA.Size = new System.Drawing.Size(72, 20);
            this.labelPhone_SSA.TabIndex = 10;
            this.labelPhone_SSA.Text = "Телефон:";
            // 
            // labelAdress_SSA
            // 
            this.labelAdress_SSA.AutoSize = true;
            this.labelAdress_SSA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdress_SSA.Location = new System.Drawing.Point(17, 490);
            this.labelAdress_SSA.Name = "labelAdress_SSA";
            this.labelAdress_SSA.Size = new System.Drawing.Size(54, 20);
            this.labelAdress_SSA.TabIndex = 9;
            this.labelAdress_SSA.Text = "Адрес:";
            // 
            // labelFIO_SSA
            // 
            this.labelFIO_SSA.AutoSize = true;
            this.labelFIO_SSA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFIO_SSA.Location = new System.Drawing.Point(17, 436);
            this.labelFIO_SSA.Name = "labelFIO_SSA";
            this.labelFIO_SSA.Size = new System.Drawing.Size(45, 20);
            this.labelFIO_SSA.TabIndex = 8;
            this.labelFIO_SSA.Text = "ФИО:";
            // 
            // textBoxSearchEmployees_SSA
            // 
            this.textBoxSearchEmployees_SSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearchEmployees_SSA.Location = new System.Drawing.Point(21, 56);
            this.textBoxSearchEmployees_SSA.Name = "textBoxSearchEmployees_SSA";
            this.textBoxSearchEmployees_SSA.Size = new System.Drawing.Size(188, 28);
            this.textBoxSearchEmployees_SSA.TabIndex = 7;
            // 
            // dataGridViewEmployees_SSA
            // 
            this.dataGridViewEmployees_SSA.AllowUserToAddRows = false;
            this.dataGridViewEmployees_SSA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees_SSA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FIO,
            this.Address,
            this.Phone,
            this.Role,
            this.Birth,
            this.Degree,
            this.Experience,
            this.StartWork,
            this.Оклад});
            this.dataGridViewEmployees_SSA.Location = new System.Drawing.Point(20, 92);
            this.dataGridViewEmployees_SSA.MultiSelect = false;
            this.dataGridViewEmployees_SSA.Name = "dataGridViewEmployees_SSA";
            this.dataGridViewEmployees_SSA.RowHeadersVisible = false;
            this.dataGridViewEmployees_SSA.RowHeadersWidth = 50;
            this.dataGridViewEmployees_SSA.RowTemplate.Height = 24;
            this.dataGridViewEmployees_SSA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmployees_SSA.Size = new System.Drawing.Size(1128, 341);
            this.dataGridViewEmployees_SSA.TabIndex = 5;
            this.dataGridViewEmployees_SSA.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployees_SSA_CellEndEdit);
            // 
            // FIO
            // 
            this.FIO.HeaderText = "ФИО";
            this.FIO.MinimumWidth = 6;
            this.FIO.Name = "FIO";
            this.FIO.Width = 125;
            // 
            // Address
            // 
            this.Address.HeaderText = "Адрес";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.Width = 125;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Телефон";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.Width = 125;
            // 
            // Role
            // 
            this.Role.HeaderText = "Должность";
            this.Role.MinimumWidth = 6;
            this.Role.Name = "Role";
            this.Role.Width = 125;
            // 
            // Birth
            // 
            this.Birth.HeaderText = "Дата рождения";
            this.Birth.MinimumWidth = 6;
            this.Birth.Name = "Birth";
            this.Birth.Width = 125;
            // 
            // Degree
            // 
            this.Degree.HeaderText = "Образование";
            this.Degree.MinimumWidth = 6;
            this.Degree.Name = "Degree";
            this.Degree.Width = 125;
            // 
            // Experience
            // 
            this.Experience.HeaderText = "Стаж";
            this.Experience.MinimumWidth = 6;
            this.Experience.Name = "Experience";
            this.Experience.Width = 125;
            // 
            // StartWork
            // 
            this.StartWork.HeaderText = "Дата зачисления";
            this.StartWork.MinimumWidth = 6;
            this.StartWork.Name = "StartWork";
            this.StartWork.Width = 125;
            // 
            // Оклад
            // 
            this.Оклад.HeaderText = "Money";
            this.Оклад.MinimumWidth = 6;
            this.Оклад.Name = "Оклад";
            this.Оклад.Width = 125;
            // 
            // labelEmployees_SSA
            // 
            this.labelEmployees_SSA.AutoSize = true;
            this.labelEmployees_SSA.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmployees_SSA.Location = new System.Drawing.Point(404, 9);
            this.labelEmployees_SSA.Name = "labelEmployees_SSA";
            this.labelEmployees_SSA.Size = new System.Drawing.Size(196, 31);
            this.labelEmployees_SSA.TabIndex = 4;
            this.labelEmployees_SSA.Text = "Учет сотрудников";
            // 
            // toolTip_SSA
            // 
            this.toolTip_SSA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_SSA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1396, 554);
            this.Controls.Add(this.panelEmployees_SSA);
            this.Controls.Add(this.panelMenu_SSA);
            this.Name = "FormMain";
            this.Text = "Отдел кадров";
            this.panelMenu_SSA.ResumeLayout(false);
            this.panelEmployees_SSA.ResumeLayout(false);
            this.panelEmployees_SSA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees_SSA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu_SSA;
        private System.Windows.Forms.Button buttonEmployees_SSA;
        private System.Windows.Forms.Button buttonAbout_SSA;
        private System.Windows.Forms.Button buttonGuide_SSA;
        private System.Windows.Forms.Button buttonUnits_SSA;
        private System.Windows.Forms.Panel panelEmployees_SSA;
        private System.Windows.Forms.Label labelEmployees_SSA;
        private System.Windows.Forms.DataGridView dataGridViewEmployees_SSA;
        private System.Windows.Forms.TextBox textBoxSearchEmployees_SSA;
        private System.Windows.Forms.Label labelAdress_SSA;
        private System.Windows.Forms.Label labelFIO_SSA;
        private System.Windows.Forms.Label labelPhone_SSA;
        private System.Windows.Forms.Label labelDegree_SSA;
        private System.Windows.Forms.Label labelExperience_SSA;
        private System.Windows.Forms.Label labelStartWork_SSA;
        private System.Windows.Forms.Label labelRole_SSA;
        private System.Windows.Forms.Label labelBirth_SSA;
        private System.Windows.Forms.TextBox textBoxFIO_SSA;
        private System.Windows.Forms.TextBox textBoxStartWork_SSA;
        private System.Windows.Forms.TextBox textBoxExperience_SSA;
        private System.Windows.Forms.TextBox textBoxDegree_SSA;
        private System.Windows.Forms.TextBox textBoxBirth_SSA;
        private System.Windows.Forms.TextBox textBoxRole_SSA;
        private System.Windows.Forms.TextBox textBoxPhone_SSA;
        private System.Windows.Forms.TextBox textBoxAdress_SSA;
        private System.Windows.Forms.Button buttonSearchEmployees_SSA;
        private System.Windows.Forms.Button buttonDeleteEmployee_SSA;
        private System.Windows.Forms.Button buttonAddEmployee_SSA;
        private System.Windows.Forms.ComboBox comboBoxSort_SSA;
        private System.Windows.Forms.Button buttonEmployeeStats_SSA;
        private System.Windows.Forms.ToolTip toolTip_SSA;
        private DataGridViewTextBoxColumn FIO;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Role;
        private DataGridViewTextBoxColumn Birth;
        private DataGridViewTextBoxColumn Degree;
        private DataGridViewTextBoxColumn Experience;
        private DataGridViewTextBoxColumn StartWork;
        private CheckBox checkBoxDegree_SSA;
        private DataGridViewTextBoxColumn Оклад;
        private Label labelMoney_SSA;
        private TextBox textBoxMoney_SSA;
    }
}

