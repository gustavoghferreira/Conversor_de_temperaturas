namespace Conversor_de_temperaturas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButtonInputCelsius_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonOutCelsius.Checked = false;

            radioButtonOutCelsius.Enabled = false;
            radioButtonOutFahrenheit.Enabled = true;
            radioButtonOutKelvin.Enabled = true;
        }

        private void radioButtonInputFahrenheit_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonOutFahrenheit.Checked = false;

            radioButtonOutCelsius.Enabled = true;
            radioButtonOutFahrenheit.Enabled = false;
            radioButtonOutKelvin.Enabled = true;
        }

        private void radioButtonInputKelvin_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonOutKelvin.Checked = false;

            radioButtonOutCelsius.Enabled = true;
            radioButtonOutFahrenheit.Enabled = true;
            radioButtonOutKelvin.Enabled = false;
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            radioButtonInputCelsius.Checked = false;
            radioButtonInputFahrenheit.Checked = false;
            radioButtonInputKelvin.Checked = false;

            radioButtonOutCelsius.Checked = false;
            radioButtonOutFahrenheit.Checked = false;
            radioButtonOutKelvin.Checked = false;

            radioButtonOutCelsius.Enabled = true;
            radioButtonOutFahrenheit.Enabled = true;
            radioButtonOutKelvin.Enabled = true;

            textBoxInput.Text = "";
            textBoxOutput.Text = "";
        }
    }
}
