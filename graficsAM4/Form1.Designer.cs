namespace graficsAM4
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.строитьГрафикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.косинусToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.импульсыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прямоугольныеИмпульсыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.построитьАМToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стеретьГрафикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стеретьАМСигналToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(429, 54);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Blue;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(709, 376);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.строитьГрафикToolStripMenuItem,
            this.построитьАМToolStripMenuItem,
            this.стеретьГрафикToolStripMenuItem,
            this.стеретьАМСигналToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1183, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // строитьГрафикToolStripMenuItem
            // 
            this.строитьГрафикToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.косинусToolStripMenuItem,
            this.импульсыToolStripMenuItem,
            this.прямоугольныеИмпульсыToolStripMenuItem});
            this.строитьГрафикToolStripMenuItem.Name = "строитьГрафикToolStripMenuItem";
            this.строитьГрафикToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.строитьГрафикToolStripMenuItem.Text = "Строить график";
            // 
            // косинусToolStripMenuItem
            // 
            this.косинусToolStripMenuItem.Name = "косинусToolStripMenuItem";
            this.косинусToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.косинусToolStripMenuItem.Text = "Косинус";
            this.косинусToolStripMenuItem.Click += new System.EventHandler(this.косинусToolStripMenuItem_Click);
            // 
            // импульсыToolStripMenuItem
            // 
            this.импульсыToolStripMenuItem.Name = "импульсыToolStripMenuItem";
            this.импульсыToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.импульсыToolStripMenuItem.Text = "Синус";
            this.импульсыToolStripMenuItem.Click += new System.EventHandler(this.импульсыToolStripMenuItem_Click);
            // 
            // прямоугольныеИмпульсыToolStripMenuItem
            // 
            this.прямоугольныеИмпульсыToolStripMenuItem.Name = "прямоугольныеИмпульсыToolStripMenuItem";
            this.прямоугольныеИмпульсыToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.прямоугольныеИмпульсыToolStripMenuItem.Text = "Прямоугольные импульсы";
            this.прямоугольныеИмпульсыToolStripMenuItem.Click += new System.EventHandler(this.прямоугольныеИмпульсыToolStripMenuItem_Click);
            // 
            // построитьАМToolStripMenuItem
            // 
            this.построитьАМToolStripMenuItem.Name = "построитьАМToolStripMenuItem";
            this.построитьАМToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.построитьАМToolStripMenuItem.Text = "Построить АМ";
            this.построитьАМToolStripMenuItem.Click += new System.EventHandler(this.построитьАМToolStripMenuItem_Click);
            // 
            // стеретьГрафикToolStripMenuItem
            // 
            this.стеретьГрафикToolStripMenuItem.Name = "стеретьГрафикToolStripMenuItem";
            this.стеретьГрафикToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.стеретьГрафикToolStripMenuItem.Text = "Стереть s(t)";
            this.стеретьГрафикToolStripMenuItem.Click += new System.EventHandler(this.стеретьГрафикToolStripMenuItem_Click);
            // 
            // стеретьАМСигналToolStripMenuItem
            // 
            this.стеретьАМСигналToolStripMenuItem.Name = "стеретьАМСигналToolStripMenuItem";
            this.стеретьАМСигналToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.стеретьАМСигналToolStripMenuItem.Text = "Стереть АМ сигнал";
            this.стеретьАМСигналToolStripMenuItem.Click += new System.EventHandler(this.стеретьАМСигналToolStripMenuItem_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(32, 146);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(56, 248);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "A";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "f";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(130, 146);
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(56, 248);
            this.trackBar2.TabIndex = 4;
            this.trackBar2.Value = 1;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "d";
            // 
            // trackBar3
            // 
            this.trackBar3.LargeChange = 1;
            this.trackBar3.Location = new System.Drawing.Point(246, 146);
            this.trackBar3.Minimum = 1;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar3.Size = new System.Drawing.Size(56, 248);
            this.trackBar3.TabIndex = 1;
            this.trackBar3.Value = 1;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "fo";
            // 
            // trackBar4
            // 
            this.trackBar4.LargeChange = 1;
            this.trackBar4.Location = new System.Drawing.Point(355, 146);
            this.trackBar4.Maximum = 30;
            this.trackBar4.Minimum = 5;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar4.Size = new System.Drawing.Size(56, 248);
            this.trackBar4.TabIndex = 8;
            this.trackBar4.Value = 5;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 492);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem строитьГрафикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem косинусToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem импульсыToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.ToolStripMenuItem построитьАМToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стеретьГрафикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прямоугольныеИмпульсыToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.ToolStripMenuItem стеретьАМСигналToolStripMenuItem;
    }
}

