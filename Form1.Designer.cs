namespace AED_AP2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnRegisterDebts = new FontAwesome.Sharp.IconButton();
            this.btnRegisterProjects = new FontAwesome.Sharp.IconButton();
            this.btnDevelopers = new FontAwesome.Sharp.IconButton();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelCurrentChild = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnRegisterDebts);
            this.panelMenu.Controls.Add(this.btnRegisterProjects);
            this.panelMenu.Controls.Add(this.btnDevelopers);
            this.panelMenu.Controls.Add(this.panelTitle);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(330, 1100);
            this.panelMenu.TabIndex = 0;
            // 
            // btnRegisterDebts
            // 
            this.btnRegisterDebts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegisterDebts.FlatAppearance.BorderSize = 0;
            this.btnRegisterDebts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterDebts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegisterDebts.IconChar = FontAwesome.Sharp.IconChar.CreditCard;
            this.btnRegisterDebts.IconColor = System.Drawing.Color.White;
            this.btnRegisterDebts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegisterDebts.IconSize = 50;
            this.btnRegisterDebts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegisterDebts.Location = new System.Drawing.Point(0, 348);
            this.btnRegisterDebts.Margin = new System.Windows.Forms.Padding(7);
            this.btnRegisterDebts.Name = "btnRegisterDebts";
            this.btnRegisterDebts.Padding = new System.Windows.Forms.Padding(10, 20, 20, 0);
            this.btnRegisterDebts.Size = new System.Drawing.Size(330, 75);
            this.btnRegisterDebts.TabIndex = 3;
            this.btnRegisterDebts.Text = "Registro de deudas";
            this.btnRegisterDebts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegisterDebts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegisterDebts.UseVisualStyleBackColor = true;
            this.btnRegisterDebts.Click += new System.EventHandler(this.BtnRegisterDebts_Click);
            // 
            // btnRegisterProjects
            // 
            this.btnRegisterProjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegisterProjects.FlatAppearance.BorderSize = 0;
            this.btnRegisterProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterProjects.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegisterProjects.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnRegisterProjects.IconColor = System.Drawing.Color.White;
            this.btnRegisterProjects.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegisterProjects.IconSize = 50;
            this.btnRegisterProjects.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegisterProjects.Location = new System.Drawing.Point(0, 273);
            this.btnRegisterProjects.Margin = new System.Windows.Forms.Padding(7);
            this.btnRegisterProjects.Name = "btnRegisterProjects";
            this.btnRegisterProjects.Padding = new System.Windows.Forms.Padding(10, 20, 20, 0);
            this.btnRegisterProjects.Size = new System.Drawing.Size(330, 75);
            this.btnRegisterProjects.TabIndex = 2;
            this.btnRegisterProjects.Text = "Registro de Proyectos";
            this.btnRegisterProjects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegisterProjects.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegisterProjects.UseVisualStyleBackColor = true;
            this.btnRegisterProjects.Click += new System.EventHandler(this.BtnRegisterProjects_Click);
            // 
            // btnDevelopers
            // 
            this.btnDevelopers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDevelopers.FlatAppearance.BorderSize = 0;
            this.btnDevelopers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevelopers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDevelopers.IconChar = FontAwesome.Sharp.IconChar.Code;
            this.btnDevelopers.IconColor = System.Drawing.Color.White;
            this.btnDevelopers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDevelopers.IconSize = 50;
            this.btnDevelopers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevelopers.Location = new System.Drawing.Point(0, 192);
            this.btnDevelopers.Margin = new System.Windows.Forms.Padding(7);
            this.btnDevelopers.Name = "btnDevelopers";
            this.btnDevelopers.Padding = new System.Windows.Forms.Padding(10, 20, 20, 0);
            this.btnDevelopers.Size = new System.Drawing.Size(330, 81);
            this.btnDevelopers.TabIndex = 1;
            this.btnDevelopers.Text = "Desarrolladoras";
            this.btnDevelopers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevelopers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDevelopers.UseVisualStyleBackColor = true;
            this.btnDevelopers.Click += new System.EventHandler(this.BtnDevelopers_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.pictureBox1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Padding = new System.Windows.Forms.Padding(10, 20, 20, 0);
            this.panelTitle.Size = new System.Drawing.Size(330, 192);
            this.panelTitle.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.lbTitleChildForm);
            this.panel1.Controls.Add(this.iconCurrentChildForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(330, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1588, 137);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // lbTitleChildForm
            // 
            this.lbTitleChildForm.AutoSize = true;
            this.lbTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbTitleChildForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTitleChildForm.Location = new System.Drawing.Point(128, 59);
            this.lbTitleChildForm.Name = "lbTitleChildForm";
            this.lbTitleChildForm.Size = new System.Drawing.Size(185, 29);
            this.lbTitleChildForm.TabIndex = 1;
            this.lbTitleChildForm.Text = "Desarrolladoras";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.DarkOrchid;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Code;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.DarkOrchid;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 50;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(45, 43);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(68, 50);
            this.iconCurrentChildForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(330, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1588, 26);
            this.panel2.TabIndex = 4;
            // 
            // panelCurrentChild
            // 
            this.panelCurrentChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelCurrentChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCurrentChild.Location = new System.Drawing.Point(330, 163);
            this.panelCurrentChild.Name = "panelCurrentChild";
            this.panelCurrentChild.Size = new System.Drawing.Size(1588, 937);
            this.panelCurrentChild.TabIndex = 5;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconButton1.IconColor = System.Drawing.Color.Red;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(1391, 12);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(117, 86);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.IconButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1918, 1100);
            this.ControlBox = false;
            this.Controls.Add(this.panelCurrentChild);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximumSize = new System.Drawing.Size(2000, 1100);
            this.MinimumSize = new System.Drawing.Size(1918, 1028);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelMenu.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitle;
        private FontAwesome.Sharp.IconButton btnDevelopers;
        private FontAwesome.Sharp.IconButton btnRegisterDebts;
        private FontAwesome.Sharp.IconButton btnRegisterProjects;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelCurrentChild;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

