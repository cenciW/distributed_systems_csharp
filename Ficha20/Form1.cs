using Ficha20.ServiceReference1;
using Ficha20.WebServiceCalculadora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha20
{
    public partial class Form1 : Form
    {
        WebServiceCalculadoraSoapClient soapClient = new WebServiceCalculadoraSoapClient();

        //WebServiceCalculadoraSoapClient soapClient = new WebServiceCalculadoraSoapClient(
        //    EndPointConfiguration.WebServiceCalculadoraSoap);

        public Form1()
        {
            InitializeComponent();
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Operacao result = new Operacao();
            if (ValidateInput(textBox1.Text) && ValidateInput(textBox2.Text))
            {
                result = soapClient.Soma(float.Parse(textBox1.Text), float.Parse(textBox2.Text));

            }
            labelOperation.Text = result.Operador;
            labelOperation.Visible = true;
            textBoxResult.Text = result.Resultado.ToString();
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            Operacao result = new Operacao();
            if (ValidateInput(textBox1.Text) && ValidateInput(textBox2.Text))
            {
                result = soapClient.Subtracao(float.Parse(textBox1.Text), float.Parse(textBox2.Text));
            }
            labelOperation.Text = result.Operador;
            labelOperation.Visible = true;
            textBoxResult.Text = result.Resultado.ToString();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            Operacao result = new Operacao();
            if (ValidateInput(textBox1.Text) && ValidateInput(textBox2.Text))
            {
                result = soapClient.Multiplicacao(float.Parse(textBox1.Text), float.Parse(textBox2.Text));
            }
            labelOperation.Text = result.Operador;
            labelOperation.Visible = true;
            textBoxResult.Text = result.Resultado.ToString();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {

            Operacao result = new Operacao();
            if (ValidateInput(textBox1.Text) && ValidateInput(textBox2.Text))
            {
                result = soapClient.Divisao(float.Parse(textBox1.Text), float.Parse(textBox2.Text));
            }
            labelOperation.Text = result.Operador;
            labelOperation.Visible = true;
            textBoxResult.Text = result.Resultado.ToString();

        }

        private static bool ValidateInput(string sFloat)
        {
            try
            {
                float.Parse(sFloat);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Por favor, preencha os números para realizar as operações.",
                    "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

    }
}
