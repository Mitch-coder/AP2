using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
namespace AED_AP2
{
    public partial class Form1 : Form
    {
        #region SizableCustom
        /*----------------Para permitirno arrastrar el formulario desde la barra de titulo--------------*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        /*---------------------------------------------------------------------------------------------*/
        #endregion
        #region Declarations
        // Declaramos variables de la libreria FontAwesome para cambiar sus propiedades
        public IconButton currentBtn;
        public Panel leftBorderBtn;
        public Panel MainContainer;
        RegisterProject frmRProject = new RegisterProject() { Dock = DockStyle.Fill };
        RegisterDebts frmRDebts = new RegisterDebts() { Dock = DockStyle.Fill };
        Developers frmDevelopers = new Developers() { Dock = DockStyle.Fill };
        #endregion
        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(17, 75);
            panelMenu.Controls.Add(leftBorderBtn);
            frmDevelopers.TopLevel = false;
            frmRDebts.TopLevel = false;
            frmRProject.TopLevel = false;
            panelCurrentChild.Controls.Add(frmDevelopers);
            panelCurrentChild.Controls.Add(frmRDebts);
            panelCurrentChild.Controls.Add(frmRProject);
            Buttoms.OpenForm(frmDevelopers, frmRDebts, frmRProject, lbTitleChildForm, btnDevelopers);
        }
        #region Events
        private void BtnDevelopers_Click(object sender, EventArgs e)
        {
            Buttoms.OpenForm(frmDevelopers, frmRDebts, frmRProject,lbTitleChildForm,btnDevelopers);
            Buttoms.Active(sender, RgbColors.color1, currentBtn, leftBorderBtn,iconCurrentChildForm);
            Buttoms.Disable(btnRegisterProjects);
            Buttoms.Disable(btnRegisterDebts);
        }
        private void BtnRegisterProjects_Click(object sender, EventArgs e)
        {
            Buttoms.OpenForm( frmRProject, frmRDebts, frmDevelopers, lbTitleChildForm,btnRegisterProjects);
            Buttoms.Active(sender, RgbColors.color2, currentBtn, leftBorderBtn,iconCurrentChildForm);
            Buttoms.Disable(btnDevelopers);
            Buttoms.Disable(btnRegisterDebts);
        }
        private void BtnRegisterDebts_Click(object sender, EventArgs e)
        {
            Buttoms.OpenForm( frmRDebts, frmDevelopers, frmRProject, lbTitleChildForm,btnRegisterDebts);
            Buttoms.Active(sender, RgbColors.color3, currentBtn, leftBorderBtn,iconCurrentChildForm);
            Buttoms.Disable(btnDevelopers);
            Buttoms.Disable(btnRegisterProjects);
        }
        private void IconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region CallFuntcionSizableForm
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            // Permitimos que arrestre el formulario padre desde la barra de titulo
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion 
    }
}
