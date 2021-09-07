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
    public partial class RegisterDebts : Form
    {
        private Debt[] dataDebts;
        int position=0;
        int Pos = 0;
        public RegisterDebts()
        {
            InitializeComponent();
        }
        #region Events
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                //Se manda a validar los datos ingresados
                validateDataUser();
                //Se manda a comprobar que no exista ya un usuario con esa cedula
                isAlredaryRegistered();
                //Si los datos son correctos procedemos a guardar y aumentamos el arreglo de la clase
                Array.Resize(ref dataDebts, position + 1);
                getDataUser(position);
                InsertById(dataDebts);
                position++;
                //Mandamos a mostrar el estudiante ingresado
                AuxiliarMethods.FillDataSource(gvClients, dataDebts);
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
                validateDataUser();
                getDataUser(getIndex());
                //Mandamos a limpiar los textBox  
                clearTextBoxes();
                //Mandamos a mostrar 
                AuxiliarMethods.FillDataSource(gvClients, dataDebts);

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
                    dataDebts[i] = dataDebts[i + 1];

                position--;
                dataDebts[position] = new Debt();
                AuxiliarMethods.FillDataSource(gvClients, dataDebts);
                clearTextBoxes();
                MessageBox.Show("Se ha eliminado correctamente el estudiante");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error inesperado");
            }

        }
        private void RegisterDebts_Load(object sender, EventArgs e)
        {
            cbStateDebt.Items.Add("Pagada");
            cbStateDebt.Items.Add("No pagada");
        }
        private void RbAll_CheckedChanged(object sender, EventArgs e)
        {
            AuxiliarMethods.FillDataSource(gvClients, dataDebts);
        }

        private void RbWithDebt_CheckedChanged(object sender, EventArgs e)
        {
            AuxiliarMethods.isNotPayDataSource(gvClients, dataDebts);
        }

        private void RbWithoutDebt_CheckedChanged(object sender, EventArgs e)
        {
            AuxiliarMethods.isPayDataSource(gvClients, dataDebts);
        }
        private void TxtIdDebt_KeyUp(object sender, KeyEventArgs e)
        {
           
            try
            {
                int index = getIndex();
                if (index >= 0)
                {
                    double amount = dataDebts[index].amount;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCreate.Enabled = false;
                    txtNames.Text = dataDebts[index].names;
                    txtLastNames.Text = dataDebts[index].lastNames;
                    txtAdress.Text = dataDebts[index].address;
                    txtPhone.Text = dataDebts[index].phone;
                    txtAmountDebt.Text =amount.ToString();
                    if (dataDebts[index].isPay == true)
                        cbStateDebt.Text = "Pagada";
                    else
                        cbStateDebt.Text = "No pagada";
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
        public void validateDataUser()
        {
            //Que Los campos no esten vacios
            if (string.IsNullOrWhiteSpace(txtIdDebt.Text) || string.IsNullOrWhiteSpace(txtNames.Text) || string.IsNullOrWhiteSpace(txtLastNames.Text) || string.IsNullOrWhiteSpace(txtAdress.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(cbStateDebt.Text) || string.IsNullOrWhiteSpace(txtAmountDebt.Text))
                throw new Exception("Todos los campos son requeridos");
            //Que los datos sean del tipo correcto
            if (!int.TryParse(txtIdDebt.Text, out int exi3))
                throw new Exception("El tipo de dato en el Id no es valido");
            if (!double.TryParse(txtAmountDebt.Text, out double exi4))
                throw new Exception("El tipo de dato en el monto de deuda no es valido");
        }
        public void isAlredaryRegistered()
        {
            //Que no este repetido el ID siempre y cuando no sea el primer registro
            if (position > 0)
            {
                for (int i = 0; i < dataDebts.Length; i++)
                {
                    int idCurrent = int.Parse(txtIdDebt.Text);
                    if (idCurrent== dataDebts[i].id)
                        throw new Exception("Ya existe un estudiante con ese carnet");
                }
            }
        }
        public void getDataUser(int index)
        {
            bool aux = false;
            if (cbStateDebt.Text=="Pagada")
            {
                aux = true;
            }
            dataDebts[index] = new Debt()
            {
                id = int.Parse(txtIdDebt.Text),
                names = txtNames.Text,
                lastNames = txtLastNames.Text,
                address = txtAdress.Text,
                phone = txtPhone.Text,
                amount = double.Parse(txtAmountDebt.Text),
                isPay = aux

            };
        
        }
    
        private void InsertById(Debt[] dataDebts)
        {
            Debt aux = new Debt();
            int size = dataDebts.Length;
            for (int i = size - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (dataDebts[j].id > dataDebts[j + 1].id)
                    {
                        aux = dataDebts[j];
                        dataDebts[j] = dataDebts[j + 1];
                        dataDebts[j + 1] = aux;
                    }
                }
            }
        }
        public int getIndex()
        {
            int id= int.Parse(txtIdDebt.Text);

            for (int i = 0; i < position; i++)
                if (dataDebts[i].id == id)
                    return i;
            return -1;
        }
        public void clearTextBoxes()
        {
            txtIdDebt.Clear();
            txtNames.Clear();
            txtLastNames.Clear();
            txtAdress.Clear();
            txtPhone.Clear();
            cbStateDebt.Text = string.Empty;
            txtAmountDebt.Clear();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnCreate.Enabled = true;
        }

        #endregion
        #region validation field
        private void TxtIdDebt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateTextBox.justNumbers(e);
        }

        private void TxtNames_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateTextBox.justLetters(e);
        }

        private void TxtLastNames_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateTextBox.justLetters(e);
        }

        private void TxtAdress_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateTextBox.justLetters(e);
        }

        private void TxtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateTextBox.justNumbers(e);
        }

        private void TxtAmountDebt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateTextBox.allowDecimals(e);
        }
        #endregion


    }
}
