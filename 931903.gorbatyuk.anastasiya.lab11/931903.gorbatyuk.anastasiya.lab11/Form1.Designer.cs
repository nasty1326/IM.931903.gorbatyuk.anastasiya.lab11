
namespace _931903.gorbatyuk.anastasiya.lab11
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numMean = new System.Windows.Forms.NumericUpDown();
            this.numVar = new System.Windows.Forms.NumericUpDown();
            this.numNumber = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbTF = new System.Windows.Forms.Label();
            this.lbHiVal = new System.Windows.Forms.Label();
            this.lbZnac = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbHi = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lbErVar = new System.Windows.Forms.Label();
            this.lbErMean = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbStatVar = new System.Windows.Forms.Label();
            this.lbStatMean = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Лабораторная 11";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Мат.Ожидание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дисперсия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Число испытаний";
            // 
            // numMean
            // 
            this.numMean.DecimalPlaces = 2;
            this.numMean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numMean.Location = new System.Drawing.Point(193, 59);
            this.numMean.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numMean.Name = "numMean";
            this.numMean.Size = new System.Drawing.Size(120, 30);
            this.numMean.TabIndex = 4;
            // 
            // numVar
            // 
            this.numVar.DecimalPlaces = 2;
            this.numVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numVar.Location = new System.Drawing.Point(193, 108);
            this.numVar.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numVar.Name = "numVar";
            this.numVar.Size = new System.Drawing.Size(120, 30);
            this.numVar.TabIndex = 5;
            // 
            // numNumber
            // 
            this.numNumber.DecimalPlaces = 2;
            this.numNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numNumber.Location = new System.Drawing.Point(193, 157);
            this.numNumber.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numNumber.Name = "numNumber";
            this.numNumber.Size = new System.Drawing.Size(120, 30);
            this.numNumber.TabIndex = 6;
            this.numNumber.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(68, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 60);
            this.button1.TabIndex = 7;
            this.button1.Text = "Старт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(410, 25);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(708, 418);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // lbTF
            // 
            this.lbTF.AutoSize = true;
            this.lbTF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTF.ForeColor = System.Drawing.Color.Red;
            this.lbTF.Location = new System.Drawing.Point(1074, 466);
            this.lbTF.Name = "lbTF";
            this.lbTF.Size = new System.Drawing.Size(45, 25);
            this.lbTF.TabIndex = 55;
            this.lbTF.Text = "true";
            // 
            // lbHiVal
            // 
            this.lbHiVal.AutoSize = true;
            this.lbHiVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHiVal.Location = new System.Drawing.Point(966, 466);
            this.lbHiVal.Name = "lbHiVal";
            this.lbHiVal.Size = new System.Drawing.Size(23, 25);
            this.lbHiVal.TabIndex = 54;
            this.lbHiVal.Text = "0";
            // 
            // lbZnac
            // 
            this.lbZnac.AutoSize = true;
            this.lbZnac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbZnac.Location = new System.Drawing.Point(923, 466);
            this.lbZnac.Name = "lbZnac";
            this.lbZnac.Size = new System.Drawing.Size(23, 25);
            this.lbZnac.TabIndex = 53;
            this.lbZnac.Text = "?";
            this.lbZnac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(1033, 466);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 25);
            this.label15.TabIndex = 52;
            this.label15.Text = "it\'s";
            // 
            // lbHi
            // 
            this.lbHi.AutoSize = true;
            this.lbHi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHi.Location = new System.Drawing.Point(859, 466);
            this.lbHi.Name = "lbHi";
            this.lbHi.Size = new System.Drawing.Size(23, 25);
            this.lbHi.TabIndex = 51;
            this.lbHi.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(724, 466);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(119, 25);
            this.label19.TabIndex = 50;
            this.label19.Text = "Хи-квадрат";
            // 
            // lbErVar
            // 
            this.lbErVar.AutoSize = true;
            this.lbErVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbErVar.Location = new System.Drawing.Point(604, 678);
            this.lbErVar.Name = "lbErVar";
            this.lbErVar.Size = new System.Drawing.Size(23, 25);
            this.lbErVar.TabIndex = 49;
            this.lbErVar.Text = "0";
            // 
            // lbErMean
            // 
            this.lbErMean.AutoSize = true;
            this.lbErMean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbErMean.Location = new System.Drawing.Point(604, 639);
            this.lbErMean.Name = "lbErMean";
            this.lbErMean.Size = new System.Drawing.Size(23, 25);
            this.lbErMean.TabIndex = 48;
            this.lbErMean.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(405, 678);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(115, 25);
            this.label17.TabIndex = 47;
            this.label17.Text = "Дисперсия";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(405, 639);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(158, 25);
            this.label18.TabIndex = 46;
            this.label18.Text = "Мат. Ожидание";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(405, 596);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(291, 25);
            this.label14.TabIndex = 45;
            this.label14.Text = "Относительные погрешности";
            // 
            // lbStatVar
            // 
            this.lbStatVar.AutoSize = true;
            this.lbStatVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStatVar.Location = new System.Drawing.Point(595, 550);
            this.lbStatVar.Name = "lbStatVar";
            this.lbStatVar.Size = new System.Drawing.Size(23, 25);
            this.lbStatVar.TabIndex = 44;
            this.lbStatVar.Text = "0";
            // 
            // lbStatMean
            // 
            this.lbStatMean.AutoSize = true;
            this.lbStatMean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStatMean.Location = new System.Drawing.Point(595, 511);
            this.lbStatMean.Name = "lbStatMean";
            this.lbStatMean.Size = new System.Drawing.Size(23, 25);
            this.lbStatMean.TabIndex = 42;
            this.lbStatMean.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(405, 550);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 25);
            this.label7.TabIndex = 40;
            this.label7.Text = "Дисперсия";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(405, 511);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 25);
            this.label6.TabIndex = 39;
            this.label6.Text = "Мат. Ожидание";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(405, 466);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(281, 25);
            this.label9.TabIndex = 36;
            this.label9.Text = "Статистические показатели";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 743);
            this.Controls.Add(this.lbTF);
            this.Controls.Add(this.lbHiVal);
            this.Controls.Add(this.lbZnac);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lbHi);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lbErVar);
            this.Controls.Add(this.lbErMean);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbStatVar);
            this.Controls.Add(this.lbStatMean);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numNumber);
            this.Controls.Add(this.numVar);
            this.Controls.Add(this.numMean);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numMean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numMean;
        private System.Windows.Forms.NumericUpDown numVar;
        private System.Windows.Forms.NumericUpDown numNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbTF;
        private System.Windows.Forms.Label lbHiVal;
        private System.Windows.Forms.Label lbZnac;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbHi;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbErVar;
        private System.Windows.Forms.Label lbErMean;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbStatVar;
        private System.Windows.Forms.Label lbStatMean;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
    }
}

