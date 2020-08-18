using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tratamento_erros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num1, num2, resultado;

            try
            {
                num1 = int.Parse(TxtNum1.Text);
                num2 = int.Parse(TxtNum2.Text);
                resultado = num1 + num2;
                TxtResultado.Text = resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Digite apenas numeros", "Catch");
            }
            finally
            {
                MessageBox.Show("Aperte OK para sair");
                
            }
        }
    }
}
