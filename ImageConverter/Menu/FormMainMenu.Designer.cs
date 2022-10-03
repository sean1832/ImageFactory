namespace ImageConverter
{
    partial class FormMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonFolder = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelLogoName = new System.Windows.Forms.Label();
            this.panelWorkspace = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelWorkspace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.buttonFolder);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 484);
            this.panelMenu.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.button1.Location = new System.Drawing.Point(0, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 155);
            this.button1.TabIndex = 3;
            this.button1.Text = "Setting (Coming Soon)";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonFolder
            // 
            this.buttonFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFolder.FlatAppearance.BorderSize = 0;
            this.buttonFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFolder.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.buttonFolder.Location = new System.Drawing.Point(0, 77);
            this.buttonFolder.Name = "buttonFolder";
            this.buttonFolder.Size = new System.Drawing.Size(200, 155);
            this.buttonFolder.TabIndex = 2;
            this.buttonFolder.Text = "Image Convert";
            this.buttonFolder.UseVisualStyleBackColor = true;
            this.buttonFolder.Click += new System.EventHandler(this.buttonFolder_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.panelLogo.Controls.Add(this.labelVersion);
            this.panelLogo.Controls.Add(this.labelLogoName);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 77);
            this.panelLogo.TabIndex = 0;
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelVersion.ForeColor = System.Drawing.SystemColors.Control;
            this.labelVersion.Location = new System.Drawing.Point(31, 39);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(61, 18);
            this.labelVersion.TabIndex = 4;
            this.labelVersion.Text = "Version";
            // 
            // labelLogoName
            // 
            this.labelLogoName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLogoName.AutoSize = true;
            this.labelLogoName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLogoName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelLogoName.Location = new System.Drawing.Point(31, 21);
            this.labelLogoName.Name = "labelLogoName";
            this.labelLogoName.Size = new System.Drawing.Size(106, 18);
            this.labelLogoName.TabIndex = 3;
            this.labelLogoName.Text = "Image Factory";
            // 
            // panelWorkspace
            // 
            this.panelWorkspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.panelWorkspace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWorkspace.Controls.Add(this.pictureBox1);
            this.panelWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWorkspace.Location = new System.Drawing.Point(200, 0);
            this.panelWorkspace.Name = "panelWorkspace";
            this.panelWorkspace.Size = new System.Drawing.Size(842, 484);
            this.panelWorkspace.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::ImageFactory.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(107, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(633, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 484);
            this.Controls.Add(this.panelWorkspace);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1058, 523);
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Factory";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelWorkspace.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button buttonFolder;
        private Panel panelWorkspace;
        private Label labelLogoName;
        private Button button1;
        private Label labelVersion;
        private PictureBox pictureBox1;
    }
}