namespace AED_AP2
{
    partial class RegisterProject
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
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdStudent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastNames = new System.Windows.Forms.TextBox();
            this.txtNames = new System.Windows.Forms.TextBox();
            this.txtDaySent = new System.Windows.Forms.TextBox();
            this.txtDayLimit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbLateSent = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.gvStudentProjects = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.idStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daySent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudentProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 90;
            this.iconPictureBox1.Location = new System.Drawing.Point(893, 78);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(113, 90);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.iconPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 90;
            this.iconPictureBox2.Location = new System.Drawing.Point(266, 78);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(148, 90);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox2.TabIndex = 1;
            this.iconPictureBox2.TabStop = false;
            // 
            // btnCreate
            // 
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCreate.Location = new System.Drawing.Point(1234, 165);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(120, 50);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Ingresar";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Location = new System.Drawing.Point(1234, 241);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 48);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(1234, 318);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 52);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(182, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Carnet";
            // 
            // txtIdStudent
            // 
            this.txtIdStudent.Location = new System.Drawing.Point(288, 198);
            this.txtIdStudent.Name = "txtIdStudent";
            this.txtIdStudent.Size = new System.Drawing.Size(175, 22);
            this.txtIdStudent.TabIndex = 6;
            this.txtIdStudent.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtIdStudent_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(182, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(182, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellidos";
            // 
            // txtLastNames
            // 
            this.txtLastNames.Location = new System.Drawing.Point(288, 318);
            this.txtLastNames.Name = "txtLastNames";
            this.txtLastNames.Size = new System.Drawing.Size(175, 22);
            this.txtLastNames.TabIndex = 10;
            // 
            // txtNames
            // 
            this.txtNames.Location = new System.Drawing.Point(288, 255);
            this.txtNames.Name = "txtNames";
            this.txtNames.Size = new System.Drawing.Size(175, 22);
            this.txtNames.TabIndex = 11;
            // 
            // txtDaySent
            // 
            this.txtDaySent.Location = new System.Drawing.Point(947, 255);
            this.txtDaySent.Name = "txtDaySent";
            this.txtDaySent.Size = new System.Drawing.Size(175, 22);
            this.txtDaySent.TabIndex = 17;
            // 
            // txtDayLimit
            // 
            this.txtDayLimit.Location = new System.Drawing.Point(947, 302);
            this.txtDayLimit.Name = "txtDayLimit";
            this.txtDayLimit.Size = new System.Drawing.Size(175, 22);
            this.txtDayLimit.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(740, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Fecha limite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(740, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fecha de entrega";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(947, 210);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(175, 22);
            this.txtProjectName.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(740, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nombre del proyecto";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(947, 348);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(175, 22);
            this.txtGrade.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(744, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Calificacion";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbAll.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbAll.Location = new System.Drawing.Point(395, 472);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(89, 29);
            this.rbAll.TabIndex = 20;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "Todos";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.RbAll_CheckedChanged);
            // 
            // rbLateSent
            // 
            this.rbLateSent.AutoSize = true;
            this.rbLateSent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbLateSent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbLateSent.Location = new System.Drawing.Point(805, 472);
            this.rbLateSent.Name = "rbLateSent";
            this.rbLateSent.Size = new System.Drawing.Size(154, 29);
            this.rbLateSent.TabIndex = 21;
            this.rbLateSent.TabStop = true;
            this.rbLateSent.Text = "Entrega tardia";
            this.rbLateSent.UseVisualStyleBackColor = true;
            this.rbLateSent.CheckedChanged += new System.EventHandler(this.RbLateSent_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(600, 397);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Listar Datos";
            // 
            // gvStudentProjects
            // 
            this.gvStudentProjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvStudentProjects.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.gvStudentProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStudentProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStudent,
            this.names,
            this.lastNames,
            this.daySent,
            this.dayLimit,
            this.state,
            this.projectName,
            this.grade});
            this.gvStudentProjects.Location = new System.Drawing.Point(187, 531);
            this.gvStudentProjects.Name = "gvStudentProjects";
            this.gvStudentProjects.ReadOnly = true;
            this.gvStudentProjects.RowTemplate.Height = 24;
            this.gvStudentProjects.Size = new System.Drawing.Size(1051, 210);
            this.gvStudentProjects.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(851, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "Datos del proyecto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(238, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(189, 25);
            this.label10.TabIndex = 25;
            this.label10.Text = "Datos del estudiante";
            // 
            // idStudent
            // 
            this.idStudent.HeaderText = "Carnet";
            this.idStudent.Name = "idStudent";
            this.idStudent.ReadOnly = true;
            // 
            // names
            // 
            this.names.HeaderText = "Nombres";
            this.names.Name = "names";
            this.names.ReadOnly = true;
            // 
            // lastNames
            // 
            this.lastNames.HeaderText = "Apellidos";
            this.lastNames.Name = "lastNames";
            this.lastNames.ReadOnly = true;
            // 
            // daySent
            // 
            this.daySent.HeaderText = "Fecha de envio";
            this.daySent.Name = "daySent";
            this.daySent.ReadOnly = true;
            // 
            // dayLimit
            // 
            this.dayLimit.HeaderText = "Fecha limite";
            this.dayLimit.Name = "dayLimit";
            this.dayLimit.ReadOnly = true;
            // 
            // state
            // 
            this.state.HeaderText = "Estado de entrega";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            // 
            // projectName
            // 
            this.projectName.HeaderText = "Nombre del proyecto";
            this.projectName.Name = "projectName";
            this.projectName.ReadOnly = true;
            // 
            // grade
            // 
            this.grade.HeaderText = "Calificacion";
            this.grade.Name = "grade";
            this.grade.ReadOnly = true;
            // 
            // RegisterProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1409, 776);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gvStudentProjects);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rbLateSent);
            this.Controls.Add(this.rbAll);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDaySent);
            this.Controls.Add(this.txtDayLimit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNames);
            this.Controls.Add(this.txtLastNames);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.iconPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterProject";
            this.Text = "RegisterProject";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudentProjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastNames;
        private System.Windows.Forms.TextBox txtNames;
        private System.Windows.Forms.TextBox txtDaySent;
        private System.Windows.Forms.TextBox txtDayLimit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbLateSent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView gvStudentProjects;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn names;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNames;
        private System.Windows.Forms.DataGridViewTextBoxColumn daySent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade;
    }
}