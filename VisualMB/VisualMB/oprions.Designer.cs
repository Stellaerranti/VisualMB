namespace VisualMB
{
    partial class oprions
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.McalText = new System.Windows.Forms.TextBox();
            this.BcalText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveOptionsButton = new System.Windows.Forms.Button();
            this.COMportBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.McalText, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BcalText, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.SaveOptionsButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.COMportBox, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(222, 118);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // McalText
            // 
            this.McalText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.McalText.Location = new System.Drawing.Point(114, 33);
            this.McalText.Margin = new System.Windows.Forms.Padding(2);
            this.McalText.Name = "McalText";
            this.McalText.Size = new System.Drawing.Size(104, 20);
            this.McalText.TabIndex = 17;
            this.McalText.Text = "1";
            // 
            // BcalText
            // 
            this.BcalText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BcalText.Location = new System.Drawing.Point(114, 4);
            this.BcalText.Margin = new System.Windows.Forms.Padding(2);
            this.BcalText.Name = "BcalText";
            this.BcalText.Size = new System.Drawing.Size(104, 20);
            this.BcalText.TabIndex = 16;
            this.BcalText.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "B cal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(5, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "M cal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(5, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Port:";
            // 
            // SaveOptionsButton
            // 
            this.SaveOptionsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveOptionsButton.Location = new System.Drawing.Point(115, 92);
            this.SaveOptionsButton.Name = "SaveOptionsButton";
            this.SaveOptionsButton.Size = new System.Drawing.Size(102, 21);
            this.SaveOptionsButton.TabIndex = 19;
            this.SaveOptionsButton.Text = "Save";
            this.SaveOptionsButton.UseVisualStyleBackColor = true;
            this.SaveOptionsButton.Click += new System.EventHandler(this.SaveOptionsButton_Click);
            // 
            // COMportBox
            // 
            this.COMportBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.COMportBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMportBox.Items.AddRange(new object[] {
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8"});
            this.COMportBox.Location = new System.Drawing.Point(114, 62);
            this.COMportBox.Margin = new System.Windows.Forms.Padding(2);
            this.COMportBox.Name = "COMportBox";
            this.COMportBox.Size = new System.Drawing.Size(104, 21);
            this.COMportBox.TabIndex = 18;
            // 
            // oprions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 118);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "oprions";
            this.Text = "oprions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.oprions_FormClosing);
            this.Load += new System.EventHandler(this.oprions_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveOptionsButton;
        private System.Windows.Forms.ComboBox COMportBox;
        private System.Windows.Forms.TextBox BcalText;
        private System.Windows.Forms.TextBox McalText;
    }
}