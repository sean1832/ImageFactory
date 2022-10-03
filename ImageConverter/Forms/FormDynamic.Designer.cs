namespace ImageConverter.Forms
{
    partial class FormDynamics
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
            this.comboConvertTo = new System.Windows.Forms.ComboBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboConvertFrom = new System.Windows.Forms.ComboBox();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.panelControls = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboConvertTo
            // 
            this.comboConvertTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboConvertTo.BackColor = System.Drawing.Color.White;
            this.comboConvertTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboConvertTo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboConvertTo.FormattingEnabled = true;
            this.comboConvertTo.Items.AddRange(new object[] {
            "png",
            "jpeg",
            "jpg",
            "heic",
            "psd",
            "svg",
            "tiff",
            "tga",
            "ico",
            "bmp"});
            this.comboConvertTo.Location = new System.Drawing.Point(329, 42);
            this.comboConvertTo.Name = "comboConvertTo";
            this.comboConvertTo.Size = new System.Drawing.Size(250, 38);
            this.comboConvertTo.TabIndex = 3;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.buttonConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConvert.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonConvert.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonConvert.Location = new System.Drawing.Point(610, 42);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(131, 38);
            this.buttonConvert.TabIndex = 1;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.FilePath});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
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
            this.dataGridView1.Size = new System.Drawing.Size(800, 338);
            this.dataGridView1.TabIndex = 0;
            // 
            // FileName
            // 
            this.FileName.HeaderText = "File Name";
            this.FileName.Name = "FileName";
            this.FileName.Width = 150;
            // 
            // FilePath
            // 
            this.FilePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FilePath.HeaderText = "File Path";
            this.FilePath.Name = "FilePath";
            // 
            // comboConvertFrom
            // 
            this.comboConvertFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboConvertFrom.BackColor = System.Drawing.Color.White;
            this.comboConvertFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboConvertFrom.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboConvertFrom.FormattingEnabled = true;
            this.comboConvertFrom.Items.AddRange(new object[] {
            ".HEIC",
            ".PNG"});
            this.comboConvertFrom.Location = new System.Drawing.Point(63, 41);
            this.comboConvertFrom.Name = "comboConvertFrom";
            this.comboConvertFrom.Size = new System.Drawing.Size(225, 38);
            this.comboConvertFrom.TabIndex = 4;
            // 
            // labelFrom
            // 
            this.labelFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFrom.ForeColor = System.Drawing.Color.White;
            this.labelFrom.Location = new System.Drawing.Point(63, 19);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(106, 19);
            this.labelFrom.TabIndex = 5;
            this.labelFrom.Text = "Input Format";
            // 
            // labelTo
            // 
            this.labelTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTo.ForeColor = System.Drawing.Color.White;
            this.labelTo.Location = new System.Drawing.Point(329, 20);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(119, 19);
            this.labelTo.TabIndex = 6;
            this.labelTo.Text = "Output Format";
            // 
            // panelControls
            // 
            this.panelControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.panelControls.Controls.Add(this.labelTo);
            this.panelControls.Controls.Add(this.comboConvertFrom);
            this.panelControls.Controls.Add(this.comboConvertTo);
            this.panelControls.Controls.Add(this.buttonConvert);
            this.panelControls.Controls.Add(this.labelFrom);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControls.Location = new System.Drawing.Point(0, 338);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(800, 112);
            this.panelControls.TabIndex = 8;
            // 
            // FormDynamics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelControls);
            this.Name = "FormDynamics";
            this.Text = "FormDynamics";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dataGridView1;
        private Button buttonConvert;
        private ComboBox comboConvertTo;
        private ComboBox comboConvertFrom;
        private Label labelFrom;
        private Label labelTo;
        private Panel panelControls;
        private DataGridViewTextBoxColumn FileName;
        private DataGridViewTextBoxColumn FilePath;
    }
}