using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionBancaraWindowsFormsG3_2022_I
{
    public partial class Form1 : Form
    {

        public delegate void MensajeDelegado();
        Banco mibanco;
        public Form1()
        {
            InitializeComponent();
            mibanco = new Banco();
            
        }





        private void ValidaCampos(object sender)
        {
            try
            {
                if (txtbNT1.Text == "" || txtbNT2.Text == "" || txtbNT3.Text == "" || txtbNT4.Text == "" || txtbNIP.Text == "")
                {
                    throw new ApplicationException("No debe dejar ningún cuadro en blanco");
                }
                if(txtbNT1.Text.Length != 4 || txtbNT2.Text.Length != 4 || txtbNT3.Text.Length != 4 || txtbNT4.Text.Length != 4  )
                {
                    throw new ApplicationException("Debe contener máximo 4 dígitos");
                }
                if( txtbNIP.Text.Length != 3 )
                {
                    throw new ApplicationException("Debe contener máximo 3 dígitos");
                }
            }
            catch (ApplicationException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            ValidaCampos(sender);
        }

        private void txtbNT1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar  == (char)Keys.Enter   )
            {
                ValidaCampos(sender);
            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Está cerrando la aplicación y no se realizó ninguna transacción");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MensajeDelegado mimensaje = new MensajeDelegado(mibanco.MensajeBienvenida);
            mimensaje();
        }
    }
}
