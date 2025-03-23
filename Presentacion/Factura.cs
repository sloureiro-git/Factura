using System.Security.Cryptography.X509Certificates;
using Negocio;

namespace Presentacion
{
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        private void buttonFacturar_Click(object sender, EventArgs e)
        {
            /*
            Logica AccesoMetodos = new Logica();

            double subtotal = AccesoMetodos.CalcularSubtotal(double.Parse(textBoxPrecio.Text), double.Parse(textBoxCantidad.Text));
            double iva = AccesoMetodos.CalcularIVA(subtotal);
            double total = AccesoMetodos.CalcularTotal(subtotal, iva);

            textBoxSubtotal.Text = subtotal.ToString();
            textBoxIVA.Text = iva.ToString();
            textBoxTotal.Text = total.ToString();
            */

            CalcularFactura();


        }

        public void CalcularFactura()
        {
            double subtotal = double.Parse(textBoxPrecio.Text) * double.Parse(textBoxCantidad.Text);
            textBoxSubtotal.Text = subtotal.ToString();

            double iva = subtotal * 0.22;
            textBoxIVA.Text = iva.ToString();

            double total = subtotal + iva;
            textBoxTotal.Text = total.ToString();

        }



        
    }
}
