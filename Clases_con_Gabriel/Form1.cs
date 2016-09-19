using Clases_con_Gabriel.EjemploPF;
using Clases_con_Gabriel.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clases_con_Gabriel
{
    public class ItemCombo
    {
        public ItemCombo() 
        { 
        
        }
        
        public ItemCombo(string v, string t)
        {
            this.value = v;
            this.text = t;
        }

        public string value
        { 
            get; set;
        }

        public string text
        {
            get; set;
        }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            var items = new ItemCombo[]
            {
                new ItemCombo("1", "Ficohsa"),
                new ItemCombo("2", "Movistar"),
                new ItemCombo("3", "Kuiki")
            };
            cmbColectores.DataSource = items;
            cmbColectores.DisplayMember = "text";
            cmbColectores.ValueMember = "value";
            //var items = new ItemCombo[3];

            //items[0] = new ItemCombo("2", "Movistar");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PagoFactura fact = new PagoFactura();

            Factura data = new Factura();

            data.Colector = (cmbColectores.SelectedItem as ItemCombo).text;
            data.FechaCorte = dtFechaCorte.Value;
            data.FechaPago = dtFechaPaga.Value;
            data.IdFactura = FacturaId.Text;
            data.IdPago = PagoId.Text;
            data.MontoPagar = montoPagarValue.Value;
            data.MontoTotal = montoTotalValue.Value;

            var result = fact.Pagar(data);

            MessageBox.Show(result.message);
        
        }
    }
}
