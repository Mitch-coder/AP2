namespace AED_AP2
{
    partial class RegisterDebts
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNames = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtLastNames = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmountDebt = new System.Windows.Forms.TextBox();
            this.txtIdDebt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gvClients = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adrress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDebt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbWithoutDebt = new System.Windows.Forms.RadioButton();
            this.rbWithDebt = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbStateDebt = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 86;
            this.iconPictureBox1.Location = new System.Drawing.Point(352, 60);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(125, 86);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Tag = "Datos del Cliente";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.CreditCard;
            this.iconPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 86;
            this.iconPictureBox2.Location = new System.Drawing.Point(912, 60);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(111, 86);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox2.TabIndex = 1;
            this.iconPictureBox2.TabStop = false;
            // 
            // btnCreate
            // 
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCreate.Location = new System.Drawing.Point(1326, 158);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(175, 52);
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
            this.btnUpdate.Location = new System.Drawing.Point(1326, 236);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(175, 52);
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
            this.btnDelete.Location = new System.Drawing.Point(1326, 314);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(175, 52);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(232, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombres";
            // 
            // txtNames
            // 
            this.txtNames.Location = new System.Drawing.Point(352, 211);
            this.txtNames.Name = "txtNames";
            this.txtNames.Size = new System.Drawing.Size(208, 22);
            this.txtNames.TabIndex = 8;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(352, 362);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(208, 22);
            this.txtPhone.TabIndex = 9;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(352, 312);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(208, 22);
            this.txtAdress.TabIndex = 10;
            // 
            // txtLastNames
            // 
            this.txtLastNames.Location = new System.Drawing.Point(352, 263);
            this.txtLastNames.Name = "txtLastNames";
            this.txtLastNames.Size = new System.Drawing.Size(208, 22);
            this.txtLastNames.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(229, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(232, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(232, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Telefono";
            // 
            // txtAmountDebt
            // 
            this.txtAmountDebt.Location = new System.Drawing.Point(872, 172);
            this.txtAmountDebt.Name = "txtAmountDebt";
            this.txtAmountDebt.Size = new System.Drawing.Size(208, 22);
            this.txtAmountDebt.TabIndex = 15;
            // 
            // txtIdDebt
            // 
            this.txtIdDebt.Location = new System.Drawing.Point(352, 158);
            this.txtIdDebt.Name = "txtIdDebt";
            this.txtIdDebt.Size = new System.Drawing.Size(208, 22);
            this.txtIdDebt.TabIndex = 17;
            this.txtIdDebt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtIdDebt_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(232, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(766, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Monto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(766, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Estado";
            // 
            // gvClients
            // 
            this.gvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvClients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.gvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.names,
            this.lastNames,
            this.adrress,
            this.amountDebt,
            this.state});
            this.gvClients.Location = new System.Drawing.Point(197, 513);
            this.gvClients.Name = "gvClients";
            this.gvClients.ReadOnly = true;
            this.gvClients.RowTemplate.Height = 24;
            this.gvClients.Size = new System.Drawing.Size(1034, 246);
            this.gvClients.TabIndex = 21;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
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
            // adrress
            // 
            this.adrress.HeaderText = "Direccion";
            this.adrress.Name = "adrress";
            this.adrress.ReadOnly = true;
            // 
            // amountDebt
            // 
            this.amountDebt.HeaderText = "Monto de Deuda";
            this.amountDebt.Name = "amountDebt";
            this.amountDebt.ReadOnly = true;
            // 
            // state
            // 
            this.state.HeaderText = "Estado";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbAll.ForeColor = System.Drawing.SystemColors.Control;
            this.rbAll.Location = new System.Drawing.Point(282, 460);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(89, 29);
            this.rbAll.TabIndex = 22;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "Todos";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.RbAll_CheckedChanged);
            // 
            // rbWithoutDebt
            // 
            this.rbWithoutDebt.AutoSize = true;
            this.rbWithoutDebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbWithoutDebt.ForeColor = System.Drawing.SystemColors.Control;
            this.rbWithoutDebt.Location = new System.Drawing.Point(921, 460);
            this.rbWithoutDebt.Name = "rbWithoutDebt";
            this.rbWithoutDebt.Size = new System.Drawing.Size(132, 29);
            this.rbWithoutDebt.TabIndex = 23;
            this.rbWithoutDebt.TabStop = true;
            this.rbWithoutDebt.Text = "Sin deudas";
            this.rbWithoutDebt.UseVisualStyleBackColor = true;
            this.rbWithoutDebt.CheckedChanged += new System.EventHandler(this.RbWithoutDebt_CheckedChanged);
            // 
            // rbWithDebt
            // 
            this.rbWithDebt.AutoSize = true;
            this.rbWithDebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbWithDebt.ForeColor = System.Drawing.SystemColors.Control;
            this.rbWithDebt.Location = new System.Drawing.Point(605, 460);
            this.rbWithDebt.Name = "rbWithDebt";
            this.rbWithDebt.Size = new System.Drawing.Size(140, 29);
            this.rbWithDebt.TabIndex = 24;
            this.rbWithDebt.TabStop = true;
            this.rbWithDebt.Text = "Con deudas";
            this.rbWithDebt.UseVisualStyleBackColor = true;
            this.rbWithDebt.CheckedChanged += new System.EventHandler(this.RbWithDebt_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(600, 401);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "Listar datos ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(882, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 25);
            this.label10.TabIndex = 26;
            this.label10.Text = "Datos del Prestamo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(330, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 25);
            this.label11.TabIndex = 27;
            this.label11.Text = "Datos del Cliente";
            // 
            // cbStateDebt
            // 
            this.cbStateDebt.FormattingEnabled = true;
            this.cbStateDebt.Location = new System.Drawing.Point(872, 225);
            this.cbStateDebt.Name = "cbStateDebt";
            this.cbStateDebt.Size = new System.Drawing.Size(208, 24);
            this.cbStateDebt.TabIndex = 28;
            // 
            // RegisterDebts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1531, 762);
            this.Controls.Add(this.cbStateDebt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rbWithDebt);
            this.Controls.Add(this.rbWithoutDebt);
            this.Controls.Add(this.rbAll);
            this.Controls.Add(this.gvClients);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIdDebt);
            this.Controls.Add(this.txtAmountDebt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLastNames);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtNames);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.iconPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterDebts";
            this.Text = "RegisterDebts";
            this.Load += new System.EventHandler(this.RegisterDebts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNames;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtLastNames;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAmountDebt;
        private System.Windows.Forms.TextBox txtIdDebt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView gvClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn names;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNames;
        private System.Windows.Forms.DataGridViewTextBoxColumn adrress;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDebt;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbWithoutDebt;
        private System.Windows.Forms.RadioButton rbWithDebt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbStateDebt;
    }
}