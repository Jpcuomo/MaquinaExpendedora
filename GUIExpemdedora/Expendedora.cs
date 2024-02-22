using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Clases;
using Consola;
namespace GUIExpendedora
{
    public partial class Expendedora : Form
    {

        List<PictureBox> listaPB = new List<PictureBox>();
        
        public Expendedora()
        {
            InitializeComponent();
        }

        Dictionary<short, Stack<Producto>> expendedora = InicializadorDiccionario.InicializarDiccionario();


        private void Expendedora_Load(object sender, EventArgs e)
        {
            rtbMensaje.BackColor = Color.LightGray;

            //for (int i = 0; i < 16; i++)
            //{
            //    PictureBox pb = new PictureBox();
            //    listaPB.Add(pb);
            //    Controls.Add(pb);
            //}
        }


        private void btnNumero_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && tbxPosicion.Text.Count() < 2)
            {
                tbxPosicion.Text += btn.Text;
            }
        }


        private bool ValidarPosicionProductoSeleccionado(out short seleccion)
        {
            string patron = @"(^[0]?[1-9]{1}$)|(^[1]{1}[0-6]{1}$)";
            string seleccionTxt = tbxPosicion.Text;
            if (Regex.IsMatch(seleccionTxt, patron))
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

        // Limpia los números ingresados en el textBox
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            rtbMensaje.BackColor = Color.LightGray;
            rtbMensaje.Clear();
            tbxPosicion.Clear();
        }

        // Elimina del diccionario el producto de la posición seleccionada
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
                        EliminarImagenDeProducto(posicion);
                    }
                }
                catch (InvalidOperationException)
                {
                    rtbMensaje.BackColor = Color.Salmon;
                    rtbMensaje.Text = $"El producto {posicion} está agotado";
                }
            }

            if(expendedora.Values.All(p => p.Count() == 0))
            {
                btnIngresar.Enabled = false;
                rtbMensaje.BackColor = Color.Salmon;
                rtbMensaje.Text = "La máquina está vacía";
            }
        }

        // Borra la imágen del producto cuyo stock se agotó
        private void EliminarImagenDeProducto(short posicion)
        {
            listaPB.Add(pb1);
            listaPB.Add(pb2);
            listaPB.Add(pb3);
            listaPB.Add(pb4);
            listaPB.Add(pb5);
            listaPB.Add(pb6);
            listaPB.Add(pb7);
            listaPB.Add(pb8);
            listaPB.Add(pb9);
            listaPB.Add(pb10);
            listaPB.Add(pb11);
            listaPB.Add(pb12);
            listaPB.Add(pb13);
            listaPB.Add(pb14);
            listaPB.Add(pb15);
            listaPB.Add(pb16);

            int indice = posicion - 1;
            listaPB[indice].Image = null;
        }
    }
}
