
using System.Windows.Forms.DataVisualization.Charting;

namespace COPIA
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.progressBarHumedad = new CircularProgressBar.CircularProgressBar();
            this.progressBarLuz = new CircularProgressBar.CircularProgressBar();
            this.btn1Dia = new System.Windows.Forms.Button();
            this.btn3Dias = new System.Windows.Forms.Button();
            this.btn7Dias = new System.Windows.Forms.Button();
            this.btn1Mes = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnGuardarGrafico = new System.Windows.Forms.Button();
            this.panelValoresActuales = new System.Windows.Forms.Panel();
            this.lblLuz = new System.Windows.Forms.Label();
            this.lblHumedad = new System.Windows.Forms.Label();
            this.columnChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).BeginInit();
            this.panelValoresActuales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.columnChart)).BeginInit();
            this.SuspendLayout();
            // 
            // lineChart
            // 
            this.lineChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineChart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lineChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            this.lineChart.BorderlineColor = System.Drawing.Color.Black;
            this.lineChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.lineChart.BorderlineWidth = 4;
            chartArea3.AxisX.InterlacedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            chartArea3.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea3.AxisX.IsMarginVisible = false;
            chartArea3.AxisX.LabelAutoFitMaxFontSize = 12;
            chartArea3.AxisX.LineWidth = 2;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.Minimum = 1D;
            chartArea3.AxisX.Title = "Días";
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.InterlacedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            chartArea3.AxisY.Interval = 20D;
            chartArea3.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisY.IsInterlaced = true;
            chartArea3.AxisY.LabelAutoFitMaxFontSize = 12;
            chartArea3.AxisY.LineWidth = 2;
            chartArea3.AxisY.MajorGrid.Enabled = false;
            chartArea3.AxisY.Maximum = 100D;
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.AxisY.Title = "Valores";
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            chartArea3.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea3.BorderWidth = 2;
            chartArea3.Name = "ChartArea";
            chartArea3.ShadowColor = System.Drawing.Color.Empty;
            chartArea3.Visible = false;
            this.lineChart.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend3.IsTextAutoFit = false;
            legend3.Name = "Humedad";
            this.lineChart.Legends.Add(legend3);
            this.lineChart.Location = new System.Drawing.Point(21, 108);
            this.lineChart.Name = "lineChart";
            series7.BackImage = "None";
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.Red;
            series7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series7.Legend = "Humedad";
            series7.Name = "Humedad";
            series7.ShadowColor = System.Drawing.Color.IndianRed;
            series7.ShadowOffset = 2;
            series8.BorderWidth = 3;
            series8.ChartArea = "ChartArea";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Color = System.Drawing.Color.Blue;
            series8.Legend = "Humedad";
            series8.Name = "Luz";
            series8.ShadowColor = System.Drawing.Color.CornflowerBlue;
            series8.ShadowOffset = 2;
            series9.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series9.BorderWidth = 5;
            series9.ChartArea = "ChartArea";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series9.Legend = "Humedad";
            series9.Name = "Hum. recomendada";
            series10.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series10.BorderWidth = 5;
            series10.ChartArea = "ChartArea";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series10.Legend = "Humedad";
            series10.Name = "Luz recomendada";
            this.lineChart.Series.Add(series7);
            this.lineChart.Series.Add(series8);
            this.lineChart.Series.Add(series9);
            this.lineChart.Series.Add(series10);
            this.lineChart.Size = new System.Drawing.Size(750, 535);
            this.lineChart.TabIndex = 0;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Titulo";
            title2.Text = "Información de la planta";
            this.lineChart.Titles.Add(title2);
            // 
            // progressBarHumedad
            // 
            this.progressBarHumedad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.progressBarHumedad.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("progressBarHumedad.AnimationFunction")));
            this.progressBarHumedad.AnimationSpeed = 500;
            this.progressBarHumedad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.progressBarHumedad.Font = new System.Drawing.Font("Microsoft JhengHei UI", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBarHumedad.ForeColor = System.Drawing.Color.Aqua;
            this.progressBarHumedad.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.progressBarHumedad.InnerMargin = 2;
            this.progressBarHumedad.InnerWidth = -1;
            this.progressBarHumedad.Location = new System.Drawing.Point(42, 9);
            this.progressBarHumedad.MarqueeAnimationSpeed = 2000;
            this.progressBarHumedad.Name = "progressBarHumedad";
            this.progressBarHumedad.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.progressBarHumedad.OuterMargin = -25;
            this.progressBarHumedad.OuterWidth = 26;
            this.progressBarHumedad.ProgressColor = System.Drawing.Color.Aqua;
            this.progressBarHumedad.ProgressWidth = 10;
            this.progressBarHumedad.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.progressBarHumedad.Size = new System.Drawing.Size(180, 180);
            this.progressBarHumedad.StartAngle = 270;
            this.progressBarHumedad.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarHumedad.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBarHumedad.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progressBarHumedad.SubscriptText = "";
            this.progressBarHumedad.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBarHumedad.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progressBarHumedad.SuperscriptText = "";
            this.progressBarHumedad.TabIndex = 5;
            this.progressBarHumedad.Text = "%";
            this.progressBarHumedad.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.progressBarHumedad.Value = 80;
            // 
            // progressBarLuz
            // 
            this.progressBarLuz.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.progressBarLuz.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("progressBarLuz.AnimationFunction")));
            this.progressBarLuz.AnimationSpeed = 500;
            this.progressBarLuz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.progressBarLuz.Font = new System.Drawing.Font("Microsoft JhengHei UI", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBarLuz.ForeColor = System.Drawing.Color.Aqua;
            this.progressBarLuz.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.progressBarLuz.InnerMargin = 2;
            this.progressBarLuz.InnerWidth = -1;
            this.progressBarLuz.Location = new System.Drawing.Point(293, 9);
            this.progressBarLuz.MarqueeAnimationSpeed = 2000;
            this.progressBarLuz.Name = "progressBarLuz";
            this.progressBarLuz.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.progressBarLuz.OuterMargin = -25;
            this.progressBarLuz.OuterWidth = 26;
            this.progressBarLuz.ProgressColor = System.Drawing.Color.Aqua;
            this.progressBarLuz.ProgressWidth = 10;
            this.progressBarLuz.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.progressBarLuz.Size = new System.Drawing.Size(180, 180);
            this.progressBarLuz.StartAngle = 270;
            this.progressBarLuz.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarLuz.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBarLuz.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progressBarLuz.SubscriptText = "";
            this.progressBarLuz.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBarLuz.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progressBarLuz.SuperscriptText = "";
            this.progressBarLuz.TabIndex = 6;
            this.progressBarLuz.Text = "%";
            this.progressBarLuz.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.progressBarLuz.Value = 80;
            // 
            // btn1Dia
            // 
            this.btn1Dia.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn1Dia.BackColor = System.Drawing.Color.Transparent;
            this.btn1Dia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1Dia.FlatAppearance.BorderSize = 0;
            this.btn1Dia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn1Dia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn1Dia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1Dia.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1Dia.ForeColor = System.Drawing.Color.Black;
            this.btn1Dia.Location = new System.Drawing.Point(23, 650);
            this.btn1Dia.Name = "btn1Dia";
            this.btn1Dia.Size = new System.Drawing.Size(120, 63);
            this.btn1Dia.TabIndex = 8;
            this.btn1Dia.Text = "1D";
            this.btn1Dia.UseVisualStyleBackColor = false;
            this.btn1Dia.Click += new System.EventHandler(this.btn1Dia_Click);
            // 
            // btn3Dias
            // 
            this.btn3Dias.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn3Dias.BackColor = System.Drawing.Color.Transparent;
            this.btn3Dias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3Dias.FlatAppearance.BorderSize = 0;
            this.btn3Dias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn3Dias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn3Dias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3Dias.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3Dias.ForeColor = System.Drawing.Color.Black;
            this.btn3Dias.Location = new System.Drawing.Point(173, 650);
            this.btn3Dias.Name = "btn3Dias";
            this.btn3Dias.Size = new System.Drawing.Size(120, 63);
            this.btn3Dias.TabIndex = 9;
            this.btn3Dias.Text = "3D";
            this.btn3Dias.UseVisualStyleBackColor = false;
            this.btn3Dias.Click += new System.EventHandler(this.btn3Dias_Click);
            // 
            // btn7Dias
            // 
            this.btn7Dias.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn7Dias.BackColor = System.Drawing.Color.Transparent;
            this.btn7Dias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7Dias.FlatAppearance.BorderSize = 0;
            this.btn7Dias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn7Dias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn7Dias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7Dias.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7Dias.ForeColor = System.Drawing.Color.Black;
            this.btn7Dias.Location = new System.Drawing.Point(323, 650);
            this.btn7Dias.Name = "btn7Dias";
            this.btn7Dias.Size = new System.Drawing.Size(120, 63);
            this.btn7Dias.TabIndex = 10;
            this.btn7Dias.Text = "7D";
            this.btn7Dias.UseVisualStyleBackColor = false;
            this.btn7Dias.Click += new System.EventHandler(this.btn7Dias_Click);
            // 
            // btn1Mes
            // 
            this.btn1Mes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn1Mes.BackColor = System.Drawing.Color.Transparent;
            this.btn1Mes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1Mes.FlatAppearance.BorderSize = 0;
            this.btn1Mes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn1Mes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn1Mes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1Mes.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1Mes.ForeColor = System.Drawing.Color.Black;
            this.btn1Mes.Location = new System.Drawing.Point(473, 650);
            this.btn1Mes.Name = "btn1Mes";
            this.btn1Mes.Size = new System.Drawing.Size(120, 63);
            this.btn1Mes.TabIndex = 11;
            this.btn1Mes.Text = "1M";
            this.btn1Mes.UseVisualStyleBackColor = false;
            this.btn1Mes.Click += new System.EventHandler(this.btn1Mes_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMax.BackColor = System.Drawing.Color.Transparent;
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.ForeColor = System.Drawing.Color.Black;
            this.btnMax.Location = new System.Drawing.Point(623, 650);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(134, 63);
            this.btnMax.TabIndex = 12;
            this.btnMax.Text = "Max.";
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnGuardarGrafico
            // 
            this.btnGuardarGrafico.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardarGrafico.BackgroundImage = global::COPIA.Properties.Resources.btnGuardarGrafico;
            this.btnGuardarGrafico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarGrafico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarGrafico.FlatAppearance.BorderSize = 0;
            this.btnGuardarGrafico.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardarGrafico.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardarGrafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarGrafico.Location = new System.Drawing.Point(40, 122);
            this.btnGuardarGrafico.Name = "btnGuardarGrafico";
            this.btnGuardarGrafico.Size = new System.Drawing.Size(50, 50);
            this.btnGuardarGrafico.TabIndex = 13;
            this.btnGuardarGrafico.UseVisualStyleBackColor = false;
            this.btnGuardarGrafico.Visible = false;
            this.btnGuardarGrafico.Click += new System.EventHandler(this.btnGuardarGrafico_Click);
            // 
            // panelValoresActuales
            // 
            this.panelValoresActuales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelValoresActuales.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panelValoresActuales.Controls.Add(this.lblLuz);
            this.panelValoresActuales.Controls.Add(this.progressBarHumedad);
            this.panelValoresActuales.Controls.Add(this.progressBarLuz);
            this.panelValoresActuales.Controls.Add(this.lblHumedad);
            this.panelValoresActuales.Location = new System.Drawing.Point(802, 108);
            this.panelValoresActuales.Name = "panelValoresActuales";
            this.panelValoresActuales.Size = new System.Drawing.Size(522, 236);
            this.panelValoresActuales.TabIndex = 14;
            // 
            // lblLuz
            // 
            this.lblLuz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLuz.AutoSize = true;
            this.lblLuz.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuz.Location = new System.Drawing.Point(357, 189);
            this.lblLuz.Name = "lblLuz";
            this.lblLuz.Size = new System.Drawing.Size(50, 29);
            this.lblLuz.TabIndex = 8;
            this.lblLuz.Text = "Luz";
            // 
            // lblHumedad
            // 
            this.lblHumedad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHumedad.AutoSize = true;
            this.lblHumedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumedad.Location = new System.Drawing.Point(60, 189);
            this.lblHumedad.Name = "lblHumedad";
            this.lblHumedad.Size = new System.Drawing.Size(118, 29);
            this.lblHumedad.TabIndex = 7;
            this.lblHumedad.Text = "Humedad";
            // 
            // columnChart
            // 
            this.columnChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.columnChart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.columnChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            this.columnChart.BorderlineColor = System.Drawing.Color.Black;
            this.columnChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.columnChart.BorderlineWidth = 3;
            chartArea4.AxisX.InterlacedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            chartArea4.AxisX.IsLabelAutoFit = false;
            chartArea4.AxisX.IsMarginVisible = false;
            chartArea4.AxisX.LabelAutoFitMinFontSize = 10;
            chartArea4.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.AxisX.LineWidth = 2;
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisX.Minimum = 1D;
            chartArea4.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.AxisY.InterlacedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            chartArea4.AxisY.Interval = 20D;
            chartArea4.AxisY.IsLabelAutoFit = false;
            chartArea4.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.AxisY.LineWidth = 2;
            chartArea4.AxisY.MajorGrid.Enabled = false;
            chartArea4.AxisY.Maximum = 100D;
            chartArea4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            chartArea4.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea4.BorderWidth = 2;
            chartArea4.Name = "ChartArea";
            this.columnChart.ChartAreas.Add(chartArea4);
            legend4.Enabled = false;
            legend4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend4.IsTextAutoFit = false;
            legend4.Name = "Legend";
            this.columnChart.Legends.Add(legend4);
            this.columnChart.Location = new System.Drawing.Point(802, 366);
            this.columnChart.Name = "columnChart";
            series11.BorderWidth = 3;
            series11.ChartArea = "ChartArea";
            series11.Color = System.Drawing.Color.Red;
            series11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series11.Legend = "Legend";
            series11.Name = "Humedad";
            series11.ShadowColor = System.Drawing.Color.IndianRed;
            series11.ShadowOffset = 1;
            series12.BorderWidth = 3;
            series12.ChartArea = "ChartArea";
            series12.Color = System.Drawing.Color.Blue;
            series12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series12.Legend = "Legend";
            series12.Name = "Luz";
            series12.ShadowColor = System.Drawing.Color.CornflowerBlue;
            series12.ShadowOffset = 1;
            this.columnChart.Series.Add(series11);
            this.columnChart.Series.Add(series12);
            this.columnChart.Size = new System.Drawing.Size(522, 277);
            this.columnChart.TabIndex = 15;
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::COPIA.Properties.Resources.FondoForm1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.columnChart);
            this.Controls.Add(this.panelValoresActuales);
            this.Controls.Add(this.btnGuardarGrafico);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btn1Mes);
            this.Controls.Add(this.btn7Dias);
            this.Controls.Add(this.btn3Dias);
            this.Controls.Add(this.btn1Dia);
            this.Controls.Add(this.lineChart);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).EndInit();
            this.panelValoresActuales.ResumeLayout(false);
            this.panelValoresActuales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.columnChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CircularProgressBar.CircularProgressBar progressBarHumedad;
        private CircularProgressBar.CircularProgressBar progressBarLuz;
        private System.Windows.Forms.Button btn1Dia;
        private System.Windows.Forms.Button btn3Dias;
        private System.Windows.Forms.Button btn7Dias;
        private System.Windows.Forms.Button btn1Mes;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnGuardarGrafico;
        private System.Windows.Forms.Panel panelValoresActuales;
        private System.Windows.Forms.Label lblLuz;
        private System.Windows.Forms.Label lblHumedad;
        private Chart columnChart;
        private Chart lineChart;
    }
}