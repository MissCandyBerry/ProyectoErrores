namespace ProyectoErrores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblErrorAbsoluto_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtValorReal.Text, out double valorReal) &&
               double.TryParse(txtValorAproximado.Text, out double valorAproximado))
            {
                double errorAbsoluto = Math.Abs(valorReal - valorAproximado);
                double errorRelativo = valorReal != 0 ? (errorAbsoluto / Math.Abs(valorReal)) * 100 : 0;

                lblErrorAbsoluto.Text = $"Error absoluto: {errorAbsoluto:F6}";
                lblErrorRelativo.Text = $"Error relativo: {errorRelativo:F2}%";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
