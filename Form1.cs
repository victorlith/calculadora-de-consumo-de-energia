using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void LimparCampos()
        {
            txtValor1.Clear();
            txtValor2.Clear();
            txtResultado.Clear();
            txtResultado2.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtValor1.Text == "")
            {
                MessageBox.Show("Por favor preencha os Campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtValor1.Focus();
                return;
            }

            else if (txtValor2.Text == "")
            {
                MessageBox.Show("Por favor preencha os Campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtValor1.Focus();
                return;
            }
            else if (txtValor2.Text == "A")
            {

                MessageBox.Show("somente valores numericos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            double resultado1, resultado2, resultado3, resultado4, resultado5;
            double valor1, valor2;
            double valor3;

            valor1 = Double.Parse(txtValor1.Text);
            valor2 = Double.Parse(txtValor2.Text);
            valor3 = Double.Parse(cbxValor3.Text);

            if (valor3 == 0)
            {
                //Converção da potência em watts (W) para QuiloWatt (kW)//
                resultado1 = valor1 / 1000;

                resultado2 = resultado1 * valor2;

                //O valor 0.30 é a Taxa de cosumo cobrado pelo concesionaria de energia//
                resultado3 = resultado2 * 0.52;

                txtResultado.Text = resultado3.ToString("R$: 0.00");
                txtResultado2.Text = resultado2.ToString("kWh: 00");
            }

            else
            {
                //Converção da potência em watts (W) para QuiloWatt (kW)//
                resultado1 = valor1 / 1000;

                resultado2 = resultado1 * valor2;

                //O valor 0.30 é a Taxa de cosumo cobrado pelo concesionaria de energia//
                resultado3 = resultado2 * 0.52;

                resultado4 = resultado3 * valor3;

                resultado5 = resultado2 * valor3;

                txtResultado.Text = resultado4.ToString("R$: 0.00");
                txtResultado2.Text = resultado5.ToString("kWh: 00");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mskResultado_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void txtValor3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
