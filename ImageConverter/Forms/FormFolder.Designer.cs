﻿namespace ImageConverter.Forms
{
    partial class FormFolder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBot = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboConvertTo = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelFrom = new System.Windows.Forms.Label();
            this.checkOverride = new System.Windows.Forms.CheckBox();
            this.comboConvertFrom = new System.Windows.Forms.ComboBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.buttonBrowseInput = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelBot.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBot
            // 
            this.panelBot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.panelBot.Controls.Add(this.panel3);
            this.panelBot.Controls.Add(this.panel2);
            this.panelBot.Controls.Add(this.panel1);
            this.panelBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBot.Location = new System.Drawing.Point(0, 371);
            this.panelBot.Name = "panelBot";
            this.panelBot.Size = new System.Drawing.Size(832, 170);
            this.panelBot.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboConvertTo);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.labelFrom);
            this.panel3.Controls.Add(this.checkOverride);
            this.panel3.Controls.Add(this.comboConvertFrom);
            this.panel3.Controls.Add(this.labelTo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(725, 159);
            this.panel3.TabIndex = 17;
            // 
            // comboConvertTo
            // 
            this.comboConvertTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboConvertTo.BackColor = System.Drawing.Color.White;
            this.comboConvertTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboConvertTo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboConvertTo.FormattingEnabled = true;
            this.comboConvertTo.Location = new System.Drawing.Point(411, 62);
            this.comboConvertTo.Name = "comboConvertTo";
            this.comboConvertTo.Size = new System.Drawing.Size(250, 38);
            this.comboConvertTo.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::ImageFactory.Properties.Resources.Arrow;
            this.pictureBox1.Location = new System.Drawing.Point(329, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // labelFrom
            // 
            this.labelFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFrom.ForeColor = System.Drawing.Color.White;
            this.labelFrom.Location = new System.Drawing.Point(74, 40);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(106, 19);
            this.labelFrom.TabIndex = 10;
            this.labelFrom.Text = "Input Format";
            // 
            // checkOverride
            // 
            this.checkOverride.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkOverride.AutoSize = true;
            this.checkOverride.FlatAppearance.BorderSize = 0;
            this.checkOverride.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkOverride.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkOverride.ForeColor = System.Drawing.SystemColors.Control;
            this.checkOverride.Location = new System.Drawing.Point(411, 106);
            this.checkOverride.Name = "checkOverride";
            this.checkOverride.Size = new System.Drawing.Size(113, 19);
            this.checkOverride.TabIndex = 12;
            this.checkOverride.Text = "Enable Override";
            this.checkOverride.UseVisualStyleBackColor = true;
            // 
            // comboConvertFrom
            // 
            this.comboConvertFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboConvertFrom.BackColor = System.Drawing.Color.White;
            this.comboConvertFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboConvertFrom.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboConvertFrom.FormattingEnabled = true;
            this.comboConvertFrom.Location = new System.Drawing.Point(74, 62);
            this.comboConvertFrom.Name = "comboConvertFrom";
            this.comboConvertFrom.Size = new System.Drawing.Size(249, 38);
            this.comboConvertFrom.TabIndex = 9;
            this.comboConvertFrom.SelectedIndexChanged += new System.EventHandler(this.comboConvertFrom_SelectedIndexChanged);
            this.comboConvertFrom.TextUpdate += new System.EventHandler(this.comboConvertFrom_TextUpdate);
            // 
            // labelTo
            // 
            this.labelTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTo.ForeColor = System.Drawing.Color.White;
            this.labelTo.Location = new System.Drawing.Point(411, 40);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(119, 19);
            this.labelTo.TabIndex = 11;
            this.labelTo.Text = "Output Format";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(725, 11);
            this.panel2.TabIndex = 16;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(180)))), ((int)(((byte)(217)))));
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(725, 11);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonConvert);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(725, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(107, 170);
            this.panel1.TabIndex = 15;
            // 
            // buttonConvert
            // 
            this.buttonConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.buttonConvert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConvert.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonConvert.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonConvert.Location = new System.Drawing.Point(0, 40);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(107, 130);
            this.buttonConvert.TabIndex = 7;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = false;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.button1);
            this.panelTop.Controls.Add(this.textBoxOutput);
            this.panelTop.Controls.Add(this.labelInput);
            this.panelTop.Controls.Add(this.buttonBrowseInput);
            this.panelTop.Controls.Add(this.textBoxInput);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(832, 98);
            this.panelTop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Output";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(679, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Browse Output";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxOutput.Location = new System.Drawing.Point(88, 55);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(573, 23);
            this.textBoxOutput.TabIndex = 3;
            // 
            // labelInput
            // 
            this.labelInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInput.ForeColor = System.Drawing.Color.White;
            this.labelInput.Location = new System.Drawing.Point(13, 16);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(61, 24);
            this.labelInput.TabIndex = 2;
            this.labelInput.Text = "Input";
            // 
            // buttonBrowseInput
            // 
            this.buttonBrowseInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBrowseInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.buttonBrowseInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowseInput.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBrowseInput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBrowseInput.Location = new System.Drawing.Point(679, 16);
            this.buttonBrowseInput.Name = "buttonBrowseInput";
            this.buttonBrowseInput.Size = new System.Drawing.Size(102, 23);
            this.buttonBrowseInput.TabIndex = 1;
            this.buttonBrowseInput.Text = "Browse Input";
            this.buttonBrowseInput.UseVisualStyleBackColor = false;
            this.buttonBrowseInput.Click += new System.EventHandler(this.buttonBrowseInput_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInput.Location = new System.Drawing.Point(88, 16);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(573, 23);
            this.textBoxInput.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(0, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(180)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(832, 273);
            this.dataGridView1.TabIndex = 2;
            // 
            // FormFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 541);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBot);
            this.Name = "FormFolder";
            this.Text = "FormFolder";
            this.Load += new System.EventHandler(this.FormFolder_Load);
            this.panelBot.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelBot;
        private Panel panelTop;
        private TextBox textBoxInput;
        private Label labelInput;
        private Button buttonBrowseInput;
        private Label label1;
        private Button button1;
        private TextBox textBoxOutput;
        private Label labelTo;
        private ComboBox comboConvertFrom;
        private ComboBox comboConvertTo;
        private Button buttonConvert;
        private Label labelFrom;
        private DataGridView dataGridView1;
        private Button button2;
        private CheckBox checkOverride;
        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
    }
}