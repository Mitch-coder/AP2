using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AED_AP2
{
    public partial class RegisterProject : Form
    {

        private Projects[] dataProject;
        int position = 0;
        public RegisterProject()
        {
            InitializeComponent();
        }
        
        #region Events
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                //Se manda a validar los datos ingresados
                validateDataProject();
                //Se manda a comprobar que no exista ya un usuario con esa cedula
                isAlredaryRegistered();
                //Si los datos son correctos procedemos a guardar y aumentamos el arreglo de la clase
                Array.Resize(ref dataProject, position + 1);
                getDataProject(position);
                InsertByDateOrder(dataProject);
                position++;
                //Mandamos a mostrar el estudiante ingresado
                AuxiliarMethods.FillDataSource(gvStudentProjects, dataProject, position, "HA ocurrido una falla");
                //Mandamos a limpiar los textBox  
                clearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //Se manda a validar los datos ingresados
                validateDataProject();
                getDataProject(getIndex());

                //Mandamos a limpiar los textBox  
                clearTextBoxes();
                //Mandamos a mostrar el estudiante ingresado
                AuxiliarMethods.FillDataSource(gvStudentProjects, dataProject, position,"Ha ocurrido una falla");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = getIndex(); i < position - 1; i++)
                    dataProject[i] = dataProject[i + 1];

                position--;
                dataProject[position] = new Projects();
                AuxiliarMethods.FillDataSource(gvStudentProjects, dataProject, position,"ha ocurrido una falla");
                clearTextBoxes();
                MessageBox.Show("Se ha eliminado correctamente el estudiante");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error inesperado");
            }

        }
        private void RbAll_CheckedChanged(object sender, EventArgs e)
        {
            
            AuxiliarMethods.FillDataSource(gvStudentProjects, dataProject,position,"No hay registro");
             
        }
        private void RbLateSent_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                AuxiliarMethods.sentLateDataSource(gvStudentProjects, dataProject);
            }
            catch (Exception)
            {

                MessageBox.Show("No hay entregas tardes");
            }
        }
        private void TxtIdStudent_KeyUp(object sender, KeyEventArgs e)
        {
            int index = getIndex();
            try
            {
                if (index >= 0)
                {
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCreate.Enabled = false;
                    txtNames.Text = dataProject[index].names;
                    txtLastNames.Text = dataProject[index].lastNames;
                    txtProjectName.Text = dataProject[index].projectName;
                    txtDayLimit.Text = dataProject[index].dayLimit.ToString();
                    txtDaySent.Text = dataProject[index].daySent.ToString();
                    txtGrade.Text = dataProject[index].grade.ToString();
                }
                else
                {
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCreate.Enabled = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
           
           
        }
        #endregion
        #region Funtions
        public void validateDataProject()
        {
            //Que Los campos no esten vacios
            if (string.IsNullOrWhiteSpace(txtIdStudent.Text) || string.IsNullOrWhiteSpace(txtNames.Text) || string.IsNullOrWhiteSpace(txtLastNames.Text) || string.IsNullOrWhiteSpace(txtProjectName.Text) || string.IsNullOrWhiteSpace(txtDaySent.Text) || string.IsNullOrWhiteSpace(txtDayLimit.Text) || string.IsNullOrWhiteSpace(txtGrade.Text))
                throw new Exception("Todos los campos son requeridos");

            //Que los datos sean del tipo correcto
            if (!DateTime.TryParse(txtDaySent.Text, out DateTime exi)|| !DateTime.TryParse(txtDayLimit.Text, out DateTime exi2))
                throw new Exception("Introducir una fecha en formato valido mes/dia/ano");
            // prguntamos sila nota es correcta
            if (!int.TryParse(txtGrade.Text, out int exi3))
                throw new Exception("El tipo de dato en calificaion no es correcto");
        }
        public void isAlredaryRegistered()
        {
            //Que no este repetido el ID siempre y cuando no sea el primer registro
            if (position > 0)
            {
                for (int i = 0; i < dataProject.Length; i++)
                {
                    if (txtIdStudent.Text == dataProject[i].idStudent)
                        throw new Exception("Ya existe un estudiante con ese carnet");
                }
            }
        }
        public void getDataProject(int index)
        {
            dataProject[index] = new Projects()
            {
                idStudent = txtIdStudent.Text,
                names = txtNames.Text,
                lastNames = txtLastNames.Text,
                projectName = txtProjectName.Text,
                grade = int.Parse(txtGrade.Text),
                dayLimit = DateTime.Parse(txtDayLimit.Text),
                daySent = DateTime.Parse(txtDaySent.Text),
                lateSent = DateTime.Parse(txtDayLimit.Text) < DateTime.Parse(txtDaySent.Text)
            };
        }
        public void clearTextBoxes()
        {
            txtIdStudent.Clear();
            txtNames.Clear();
            txtLastNames.Clear();
            txtProjectName.Clear();
            txtDayLimit.Clear();
            txtDaySent.Clear();
            txtGrade.Clear();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnCreate.Enabled = true;
        }
        public int getIndex()
        {
            string idStudent = txtIdStudent.Text;

            for (int i = 0; i < position; i++)
                if (dataProject[i].idStudent == idStudent)
                    return i;
            return -1;
        }
        private void InsertByDateOrder(Projects[] dataProject)
        {
            Projects aux= new Projects();
            int size = dataProject.Length;
            for (int i = size - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (dataProject[j].daySent > dataProject[j + 1].daySent)
                    {
                        aux= dataProject[j];
                        dataProject[j] = dataProject[j + 1];
                        dataProject[j + 1] = aux;
                    }
                }
            }
        }

        #endregion

        //
        private void TxtNames_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateTextBox.justLetters(e);
        }

        private void TxtLastNames_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateTextBox.justLetters(e);
        }

        private void TxtProjectName_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateTextBox.justLetters(e);
        }

        private void TxtGrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateTextBox.justNumbers(e);
        }
    }
}
