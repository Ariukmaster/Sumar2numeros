namespace Sumar2numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int resultado;

            resultado = Convert.ToInt32(tbNumero1.Text) + Convert.ToInt32(tbNumero2.Text);

            tbResultado.Text = resultado.ToString();
        }
    }
}