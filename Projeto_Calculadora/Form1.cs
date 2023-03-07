namespace Projeto_Calculadora
{
    public partial class Form1 : Form
    {
        float primeiroNumero = 0;
        float segundoNumero = 0;
        string operador = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + btnQuatro.Text;
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            primeiroNumero = float.Parse(textResultado.Text);
            operador = btnSoma.Text;
            textResultado.Text = "";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + btnSeis.Text;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            segundoNumero = float.Parse(textResultado.Text);
            textResultado.Text = "";
            if(operador == "+")
            {
                textResultado.Text = (primeiroNumero + segundoNumero).ToString();
            }
            else if (operador == "-")
            {
                textResultado.Text = (primeiroNumero - segundoNumero).ToString();

            }
            else if (operador == "x")
            {
                textResultado.Text = (primeiroNumero * segundoNumero).ToString();

            }
            else if (operador == "/")
            {
                
                textResultado.Text = (primeiroNumero / segundoNumero).ToString();

            }
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + btnUm.Text;
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + btnDois.Text;
        }

        private void btntres_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + btntres.Text;
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + btnCinco.Text;
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + btnSete.Text;
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + btnOito.Text;
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + btnNove.Text;
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            primeiroNumero = float.Parse(textResultado.Text);
            operador = btnSubtracao.Text;
            textResultado.Text = "";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            primeiroNumero = float.Parse(textResultado.Text);
            operador = btnMultiplicacao.Text;
            textResultado.Text = "";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            primeiroNumero = float.Parse(textResultado.Text);
            operador = btnDivisao.Text;
            textResultado.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
            primeiroNumero = 0;
            segundoNumero = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + btnZero.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}