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
            int h = 5;
            int g = 4;
            int m;

           // multiplicar_opcional(g,h);

            var valor = multiplicar_valor(h);
            var refer = multiplicar_ref(ref g);
            var refout = multiplicar_refout(out m, 8);

            MessageBox.Show(valor + ": " + h);
            MessageBox.Show(refer + ": " + g);
            MessageBox.Show(refout + ": " + m);

            eliminar(8, "2", "4", "89", "2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PagoFactura fact = new PagoFactura();
            

            Factura data = new Factura();
            Factura data2 = data;

            data.Colector = "primero";
            data2.Colector = "lo que sea";

            MessageBox.Show(data.Colector);

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
        /**metodo con parametro opcopnal*/
        public int multiplicar_opcional(int d, int j=3)
        {
            d = j * d;

            return d;
        }

        /*metodo con  paso de parametro por valor*/
        public int multiplicar_valor(int d) {
            d = 3 * d;

            return d;
        }

        /*metodo con paso de parametro por referencia*/
        public int multiplicar_ref(ref int d)
        {
            d = 3 * d;

            return d;
        }

        /*metodo con paso de parametro por referencia out*/
        public int multiplicar_refout(out int d, int a)
        {
            d = 3 * a;

            return d;
        }
     

        /*metodo q recibe un numero variable de  parametros(un arreglo) */
        public void eliminar(int d, params string[] ids){
            
            foreach (var item in ids)
            {
                MessageBox.Show(item);
            }
        }
    }
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
            get;
            set;
        }

        public string text
        {
            get;
            set;
        }
    }
}
