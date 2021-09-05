using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;


namespace AED_AP2
{
    /*Realizamos una estructura de los colores Rgb para intercalarlos en el diseño*/
    public struct RgbColors
    {
        public static Color color1 = Color.FromArgb(172, 126, 241);
        public static Color color2 = Color.FromArgb(249, 118, 176);
        public static Color color3 = Color.FromArgb(253, 138, 114);
        public static Color color4 = Color.FromArgb(95, 77, 221);
        public static Color color5 = Color.FromArgb(249, 88, 155);
        public static Color color6 = Color.FromArgb(24, 161, 251);
    }
    public static class Buttoms
    {
        /*Esta clase es para la personalizacion de los botones del menu lateral*/

        /*El metodo Active lo personaliza si el boton esta siendo presionado*/
        public static void Active(object senderBtn, Color color, IconButton currentBtn, Panel leftBorderBtn, IconPictureBox iconCurrentChildForm)
        {
            if (senderBtn != null)
            {
                Disable(currentBtn);
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Despues de cambiar los colores procedemos a cambiarlos de posicion
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                //Mostramos los cambios realizados
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Cambiamos el titulo del formulario que este presente
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        /*El metodo Disable le quita la personalizacion si el boton no esta siendo presionado*/
        public static void Disable(IconButton currentBtn)
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 60);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        public static void OpenForm(Form current,Form Secundary, Form third,Label lbTitle,IconButton currentIcon)
        {
            current.Show();
            Secundary.Hide();
            third.Hide();
            lbTitle.Text = currentIcon.Text;
        }
    }
   
}
