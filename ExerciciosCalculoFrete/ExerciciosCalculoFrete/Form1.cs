using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciciosCalculoFrete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularFrete_Click(object sender, EventArgs e)
        {
            CalcularFrete();
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            LimparCampos();   
        }


        void CalcularFrete()
        {
            var frete = 0.0;
            var total = 0.0;
            var valor = 0.0;
            string uf = cbxUf.Text;
            valor = double.Parse(txtValor.Text);

            if (valor > 1000.0)
            {
                frete = 0;
            }
            else if (uf == "SP")
            {
                frete = 5.0;
            }
            else if (uf == "RJ")
            {
                frete = 10.0;
            }
            else if (uf == "AM")
            {
                frete = 20.0;
            }
            else if (uf != "SP" && uf != "RJ" && uf != "AM")
            {
                frete = 15.0;
            }

            total = valor + frete;

            lblValorCompra.Text = valor.ToString("C");
            lblFrete.Text = frete.ToString("C");
            lblTotal.Text = total.ToString("C");
          
            /*
            vendas acima de 1000 reais o frete será gratis 
            SP frete de 5 reais
            RJ frete de 10 reais
            AM frete de 20 reais
            RS frete 15 reais
            SC frete 15 reais
             */
        }

        void LimparCampos()
        {
            txtNome.Text = "";//"" deixam o texto nulo ou  = string.empty
            txtValor.Text = "";
            cbxUf.Text = "";
        }
    }
}
