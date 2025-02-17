using System;

namespace InteractiveCalculateApp
{
    partial class CalcForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.GraduateLevel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startYear = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.erorr_Year = new System.Windows.Forms.Label();
            this.Enter_Instruction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(670, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GraduateLevel
            // 
            this.GraduateLevel.BackColor = System.Drawing.SystemColors.Window;
            this.GraduateLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GraduateLevel.FormattingEnabled = true;
            this.GraduateLevel.Items.AddRange(new object[] {
            "Бакалавриат",
            "Магистратура",
            "Специалитет"});
            this.GraduateLevel.Location = new System.Drawing.Point(138, 114);
            this.GraduateLevel.Name = "GraduateLevel";
            this.GraduateLevel.Size = new System.Drawing.Size(500, 28);
            this.GraduateLevel.TabIndex = 2;
            this.GraduateLevel.Text = "Выберите уровень образования, который Вы получите";
            this.GraduateLevel.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(723, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Узнайте в каком году Вы получите высшее образование";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // startYear
            // 
            this.startYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startYear.Location = new System.Drawing.Point(484, 199);
            this.startYear.Name = "startYear";
            this.startYear.Size = new System.Drawing.Size(105, 24);
            this.startYear.TabIndex = 4;
            this.startYear.Text = "введите год";
            this.startYear.Click += new System.EventHandler(this.startYear_Click);
            this.startYear.TextChanged += new System.EventHandler(this.startYear_TextChanged);
            // 
            // Calculate
            // 
            this.Calculate.BackColor = System.Drawing.SystemColors.Window;
            this.Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calculate.Location = new System.Drawing.Point(331, 417);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(150, 40);
            this.Calculate.TabIndex = 5;
            this.Calculate.Text = "Рассчитать";
            this.Calculate.UseVisualStyleBackColor = false;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.BackColor = System.Drawing.SystemColors.Info;
            this.result.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(74, 307);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(644, 25);
            this.result.TabIndex = 6;
            this.result.Text = " ";
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // erorr_Year
            // 
            this.erorr_Year.AutoSize = true;
            this.erorr_Year.ForeColor = System.Drawing.Color.Red;
            this.erorr_Year.Location = new System.Drawing.Point(484, 234);
            this.erorr_Year.Name = "erorr_Year";
            this.erorr_Year.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.erorr_Year.Size = new System.Drawing.Size(10, 16);
            this.erorr_Year.TabIndex = 7;
            this.erorr_Year.Text = " ";
            // 
            // Enter_Instruction
            // 
            this.Enter_Instruction.AutoSize = true;
            this.Enter_Instruction.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enter_Instruction.Location = new System.Drawing.Point(133, 199);
            this.Enter_Instruction.Name = "Enter_Instruction";
            this.Enter_Instruction.Size = new System.Drawing.Size(321, 26);
            this.Enter_Instruction.TabIndex = 8;
            this.Enter_Instruction.Text = "Введите год поступления в ВУЗ";
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.Enter_Instruction);
            this.Controls.Add(this.erorr_Year);
            this.Controls.Add(this.result);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.startYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GraduateLevel);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CalcForm";
            this.Text = "Год выпуска из ВУЗа";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox GraduateLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox startYear;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label erorr_Year;
        private System.Windows.Forms.Label Enter_Instruction;
    }
}

