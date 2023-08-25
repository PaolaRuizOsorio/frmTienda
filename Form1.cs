using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmTienda
{
    public partial class FrmCloset : Form
    {
        public FrmCloset()
        {
            InitializeComponent();
        }

        

        private void btEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text != "")
                {
                    if (txtPrecio.Text != "")
                    {
                        if (txtIVA.Text != "")
                        {
                            if (cboTipo.SelectedIndex != -1)
                            {

                                string strNombre = txtNombre.Text;
                                double douPrecio = Convert.ToDouble(txtPrecio.Text);
                                double douIVA = Convert.ToDouble(txtIVA.Text);
                                int intTipo = Convert.ToInt32(cboTipo.SelectedItem);

                                if (intTipo == 4)
                                {
                                    clsTipo4 clsTipo4 = new clsTipo4();
                                    clsTipo4.strNombre = strNombre;
                                    clsTipo4.douPrecio = douPrecio;
                                    clsTipo4.douIVA = douIVA;
                                    clsTipo4.intTipo = intTipo;

                                    MessageBox.Show("Bienvenido a Closet \n \nNombre del producto:  " + strNombre +
                                        "\n \nPrecio:  " + douPrecio + " $ " + "\n \nPorcentaje de IVA:  " + douIVA + " % " + "\n \nTipo de producto:  " +
                                        intTipo + "\n  \n \nProducto con descuento:  " + (Convert.ToString(clsTipo4.aplicarDescuento())) + " $ " +
                                        "\n  \n \nIVA:  " + (Convert.ToString(clsTipo4.aplicarIVA()) + " $ " + "\n \n \n \nPRECIO TOTAL:  " +
                                        (Convert.ToString(clsTipo4.precioTotal()))) + " $ ");
                                }
                                if (intTipo == 7)
                                {
                                    clsTipo7 clsTipo7 = new clsTipo7();
                                    clsTipo7.strNombre = strNombre;
                                    clsTipo7.douPrecio = douPrecio;
                                    clsTipo7.douIVA = douIVA;
                                    clsTipo7.intTipo = intTipo;

                                    MessageBox.Show("Bienvenido a Closet \n \nNombre del producto:  " + strNombre +
                                        "\n \nPrecio:  " + douPrecio + " $ " + "\n \nPorcentaje de IVA:  " + douIVA + " % " + "\n \nTipo de producto:  " +
                                        intTipo + "\n  \n \nProducto con descuento:  " + (Convert.ToString(clsTipo7.aplicarDescuento())) + " $ " +
                                        "\n  \n \nIVA:  " + (Convert.ToString(clsTipo7.aplicarIVA()) + " $ " + "\n \n \n \nPRECIO TOTAL:  " +
                                        (Convert.ToString(clsTipo7.precioTotal()))) + " $ " );
                                }
                                if (intTipo == 16)
                                {
                                    clsTipo16 clsTipo16 = new clsTipo16();
                                    clsTipo16.strNombre =  strNombre;
                                    clsTipo16.douPrecio = douPrecio;
                                    clsTipo16.douIVA = douIVA;
                                    clsTipo16.intTipo = intTipo;

                                    MessageBox.Show("Bienvenido a Closet \n \nNombre del producto:  " + strNombre +
                                        "\n \nPrecio:  " + douPrecio + " $ " + "\n \nPorcentaje de IVA:  " + douIVA + " % " + "\n \nTipo de producto:  " +
                                        intTipo + "\n  \n \nProducto con descuento:  " + (Convert.ToString(clsTipo16.aplicarDescuento())) + " $ " +
                                        "\n  \n \nIVA:  " + (Convert.ToString(clsTipo16.aplicarIVA()) + " $ " + "\n \n \n \nPRECIO TOTAL:  " +
                                        (Convert.ToString(clsTipo16.precioTotal()))) + " $ ");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Por favor ingrese el tipo");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Por favor ingrese el IVA");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor ingrese el precio");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor ingrese el nombre del artículo");
                }



            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
   
        }


        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtIVA.Text = "";
            cboTipo.SelectedIndex = -1;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show(" Por favor ingresa solo un valor numérico ", "Alerta" ,MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtIVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show(" Por favor ingresa solo un valor numérico ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show(" Por favor ingresa solo letras ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
