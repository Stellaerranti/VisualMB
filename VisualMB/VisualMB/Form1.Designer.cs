namespace VisualMB
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fileButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.fileLabel = new System.Windows.Forms.Label();
            this.StartStopButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BcalText = new System.Windows.Forms.TextBox();
            this.McalText = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.inputPort = new System.IO.Ports.SerialPort(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.COMportBox = new System.Windows.Forms.ComboBox();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileButton,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1600, 50);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // fileButton
            // 
            this.fileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileButton.Image = ((System.Drawing.Image)(resources.GetObject("fileButton.Image")));
            this.fileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(55, 44);
            this.fileButton.Text = "File";
            this.fileButton.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(98, 44);
            this.toolStripButton1.Text = "options";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.MainChart, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97.59036F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1600, 723);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // MainChart
            // 
            chartArea5.AxisX.Title = "B";
            chartArea5.AxisY.Title = "M";
            chartArea5.Name = "ChartArea1";
            this.MainChart.ChartAreas.Add(chartArea5);
            this.MainChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainChart.Location = new System.Drawing.Point(326, 6);
            this.MainChart.Margin = new System.Windows.Forms.Padding(6);
            this.MainChart.Name = "MainChart";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series5.IsVisibleInLegend = false;
            series5.Name = "MB";
            this.MainChart.Series.Add(series5);
            this.MainChart.Size = new System.Drawing.Size(1268, 711);
            this.MainChart.TabIndex = 2;
            this.MainChart.Text = "chart1";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.fileLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.StartStopButton, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.ClearButton, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.BLabel, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.MLabel, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.BcalText, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.McalText, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.COMportBox, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.ButtonConnect, 1, 8);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11037F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11037F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11037F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11037F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11037F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11037F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11037F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11371F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11371F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(308, 499);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(8, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "File:";
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileLabel.Location = new System.Drawing.Point(161, 2);
            this.fileLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(139, 53);
            this.fileLabel.TabIndex = 1;
            this.fileLabel.Text = "-";
            // 
            // StartStopButton
            // 
            this.StartStopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartStopButton.Location = new System.Drawing.Point(8, 118);
            this.StartStopButton.Margin = new System.Windows.Forms.Padding(6);
            this.StartStopButton.Name = "StartStopButton";
            this.StartStopButton.Size = new System.Drawing.Size(139, 41);
            this.StartStopButton.TabIndex = 2;
            this.StartStopButton.Text = "Start";
            this.StartStopButton.UseVisualStyleBackColor = true;
            this.StartStopButton.Click += new System.EventHandler(this.StartStopButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearButton.Location = new System.Drawing.Point(161, 118);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(6);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(139, 41);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(8, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 53);
            this.label2.TabIndex = 4;
            this.label2.Text = "B:";
            // 
            // BLabel
            // 
            this.BLabel.AutoSize = true;
            this.BLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BLabel.Location = new System.Drawing.Point(161, 167);
            this.BLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(139, 53);
            this.BLabel.TabIndex = 5;
            this.BLabel.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(8, 222);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 53);
            this.label4.TabIndex = 6;
            this.label4.Text = "M:";
            // 
            // MLabel
            // 
            this.MLabel.AutoSize = true;
            this.MLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MLabel.Location = new System.Drawing.Point(161, 222);
            this.MLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.MLabel.Name = "MLabel";
            this.MLabel.Size = new System.Drawing.Size(139, 53);
            this.MLabel.TabIndex = 7;
            this.MLabel.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(8, 277);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 53);
            this.label3.TabIndex = 10;
            this.label3.Text = "B_cal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(8, 332);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 53);
            this.label5.TabIndex = 11;
            this.label5.Text = "M_cal:";
            // 
            // BcalText
            // 
            this.BcalText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BcalText.Location = new System.Drawing.Point(158, 280);
            this.BcalText.Name = "BcalText";
            this.BcalText.Size = new System.Drawing.Size(145, 31);
            this.BcalText.TabIndex = 12;
            this.BcalText.Text = "1";
            this.BcalText.TextChanged += new System.EventHandler(this.BcalText_TextChanged);
            // 
            // McalText
            // 
            this.McalText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.McalText.Location = new System.Drawing.Point(158, 335);
            this.McalText.Name = "McalText";
            this.McalText.Size = new System.Drawing.Size(145, 31);
            this.McalText.TabIndex = 13;
            this.McalText.Text = "1";
            this.McalText.TextChanged += new System.EventHandler(this.McalText_TextChanged);
            // 
            // inputPort
            // 
            this.inputPort.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.inputPort_ErrorReceived);
            this.inputPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.inputPort_DataReceived);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // COMportBox
            // 
            this.COMportBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.COMportBox.FormattingEnabled = true;
            this.COMportBox.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4"});
            this.COMportBox.Location = new System.Drawing.Point(5, 445);
            this.COMportBox.Name = "COMportBox";
            this.COMportBox.Size = new System.Drawing.Size(145, 33);
            this.COMportBox.TabIndex = 14;
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonConnect.Location = new System.Drawing.Point(158, 445);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(145, 49);
            this.ButtonConnect.TabIndex = 15;
            this.ButtonConnect.Text = "select";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 773);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Please give me the name";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripButton fileButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.Button StartStopButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label BLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label MLabel;
        private System.IO.Ports.SerialPort inputPort;
        private System.Windows.Forms.ToolStripButton toolStripButton1;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BcalText;
        private System.Windows.Forms.TextBox McalText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox COMportBox;
        private System.Windows.Forms.Button ButtonConnect;
    }
}

