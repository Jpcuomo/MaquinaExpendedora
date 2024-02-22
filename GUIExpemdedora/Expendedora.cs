using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Clases;
using Consola;
namespace GUIExpendedora
{
    public partial class Expendedora : Form
    {
        public Expendedora()
        {
            InitializeComponent();
        }

        Dictionary<short, Stack<Producto>> expendedora = InicializadorDiccionario.InicializarDiccionario();


        private void Expendedora_Load(object sender, EventArgs e)
        {
            this.rtbMensaje.BackColor = Color.LightGray;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (tbxPosicion.Text.Count() < 2)
                tbxPosicion.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (tbxPosicion.Text.Count() < 2)
                tbxPosicion.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (tbxPosicion.Text.Count() < 2)
                tbxPosicion.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (tbxPosicion.Text.Count() < 2)
                tbxPosicion.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (tbxPosicion.Text.Count() < 2)
                tbxPosicion.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (tbxPosicion.Text.Count() < 2)
                tbxPosicion.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (tbxPosicion.Text.Count() < 2)
                tbxPosicion.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (tbxPosicion.Text.Count() < 2)
                tbxPosicion.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (tbxPosicion.Text.Count() < 2)
                tbxPosicion.Text = "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (tbxPosicion.Text.Count() < 2)
            {
                tbxPosicion.Text += "0";
            }
        }

        private bool ValidarPosicionProductoSeleccionado(out short seleccion)
        {
            string patron = @"(^[0]?[1-9]{1}$)|(^[1]{1}[0-6]{1}$)";
            string seleccionTxt = tbxPosicion.Text;
            if(Regex.IsMatch(seleccionTxt, patron))
            {
                seleccion = short.Parse(seleccionTxt);
                return true;
            }
            else
            {
                seleccion = 0;
                return false;
            }
        }

        // Toma la posición ingresada 
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            short seleccion;
            if (ValidarPosicionProductoSeleccionado(out seleccion))
            {
                RecibirProductoSeleccionado(seleccion, expendedora);
            }
            else
            {
                rtbMensaje.BackColor = Color.Salmon;
                rtbMensaje.Text = "Número de producto no válido";
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            rtbMensaje.BackColor = Color.LightGray;
            rtbMensaje.Clear();
            tbxPosicion.Clear();
        }


        private void RecibirProductoSeleccionado(short posicion, Dictionary<short, Stack<Producto>> expendedora)
        {
            if (expendedora.ContainsKey(posicion))
            {
                try
                {
                    Producto producto = expendedora[posicion].Pop();
                    rtbMensaje.BackColor = Color.GreenYellow;
                    rtbMensaje.Text = 
                        $"Se eligió el producto n°{posicion} " +
                        $"- {producto.Nombre} " +
                        $"- $ {producto.Precio} " +
                        $"- {producto.CodigoDeProducto}";
                    if (expendedora[posicion].Count() == 0)
                    {
                        EliminarProducto(posicion);
                    }
                }
                catch (InvalidOperationException)
                {
                    rtbMensaje.BackColor = Color.Salmon;
                    rtbMensaje.Text = $"El producto {posicion} no está disponible";
                }
            }
        }

        private void EliminarProducto(short posicion)
        {
            switch (posicion)
            {
                case 1:
                    pb1.Image = null;
                    break;  
                case 2:
                    pb2.Image = null;
                    break;
                case 3:
                    pb3.Image = null;
                    break;
                case 4:
                    pb4.Image = null;
                    break;
                case 5:
                    pb5.Image = null;
                    break;
                case 6:
                    pb6.Image = null;
                    break;
                case 7:
                    pb7.Image = null;
                    break;
                case 8:
                    pb8.Image = null;
                    break;
                case 9:
                    pb9.Image = null;
                    break;
                case 10:
                    pb10.Image = null;
                    break;
                case 11:
                    pb11.Image = null;
                    break;
                case 12:
                    pb12.Image = null;
                    break;
                case 13:
                    pb13.Image = null;
                    break;
                case 14:
                    pb14.Image = null;
                    break;
                case 15:
                    pb15.Image = null;
                    break;
                case 16:
                    pb16.Image = null;
                    break;
            }
        }

    }
}
