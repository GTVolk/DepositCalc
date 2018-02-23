namespace DepositCalc
{
    partial class MainForm
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
            this.depositCurrent = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.salaryPercent = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.depositPercent = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.salaryLevel = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.monthsCount = new System.Windows.Forms.NumericUpDown();
            this.calcButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.depositResult = new System.Windows.Forms.NumericUpDown();
            this.percentResult = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.depositCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.percentResult)).BeginInit();
            this.SuspendLayout();
            // 
            // depositCurrent
            // 
            this.depositCurrent.DecimalPlaces = 2;
            this.depositCurrent.Location = new System.Drawing.Point(176, 33);
            this.depositCurrent.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.depositCurrent.Name = "depositCurrent";
            this.depositCurrent.Size = new System.Drawing.Size(120, 20);
            this.depositCurrent.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Текущее состояние счета:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Процент для депозита:";
            // 
            // salaryPercent
            // 
            this.salaryPercent.DecimalPlaces = 2;
            this.salaryPercent.Location = new System.Drawing.Point(176, 59);
            this.salaryPercent.Name = "salaryPercent";
            this.salaryPercent.Size = new System.Drawing.Size(120, 20);
            this.salaryPercent.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Процент по вкладу за год:";
            // 
            // depositPercent
            // 
            this.depositPercent.DecimalPlaces = 2;
            this.depositPercent.Location = new System.Drawing.Point(176, 85);
            this.depositPercent.Name = "depositPercent";
            this.depositPercent.Size = new System.Drawing.Size(120, 20);
            this.depositPercent.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Общее кол-во руб в месяц:";
            // 
            // salaryLevel
            // 
            this.salaryLevel.DecimalPlaces = 2;
            this.salaryLevel.Location = new System.Drawing.Point(176, 7);
            this.salaryLevel.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.salaryLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.salaryLevel.Name = "salaryLevel";
            this.salaryLevel.Size = new System.Drawing.Size(120, 20);
            this.salaryLevel.TabIndex = 6;
            this.salaryLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Количество месяцев:";
            // 
            // monthsCount
            // 
            this.monthsCount.Location = new System.Drawing.Point(176, 111);
            this.monthsCount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.monthsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.monthsCount.Name = "monthsCount";
            this.monthsCount.Size = new System.Drawing.Size(120, 20);
            this.monthsCount.TabIndex = 8;
            this.monthsCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(15, 137);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(281, 48);
            this.calcButton.TabIndex = 10;
            this.calcButton.Text = "Рассчитать";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Итоговое состояние счета:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Процент в месяц на остаток:";
            // 
            // depositResult
            // 
            this.depositResult.DecimalPlaces = 2;
            this.depositResult.Location = new System.Drawing.Point(176, 191);
            this.depositResult.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.depositResult.Name = "depositResult";
            this.depositResult.ReadOnly = true;
            this.depositResult.Size = new System.Drawing.Size(120, 20);
            this.depositResult.TabIndex = 13;
            // 
            // percentResult
            // 
            this.percentResult.DecimalPlaces = 2;
            this.percentResult.Location = new System.Drawing.Point(176, 217);
            this.percentResult.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.percentResult.Name = "percentResult";
            this.percentResult.ReadOnly = true;
            this.percentResult.Size = new System.Drawing.Size(120, 20);
            this.percentResult.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 247);
            this.Controls.Add(this.percentResult);
            this.Controls.Add(this.depositResult);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.monthsCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.salaryLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.depositPercent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salaryPercent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.depositCurrent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Deposit Calc";
            ((System.ComponentModel.ISupportInitialize)(this.depositCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.percentResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown depositCurrent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown salaryPercent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown depositPercent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown salaryLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown monthsCount;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown depositResult;
        private System.Windows.Forms.NumericUpDown percentResult;
    }
}

