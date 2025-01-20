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
            double result = 0;

            if (radioButtonInputCelsius.Checked == true)
            {
                if (radioButtonOutFahrenheit.Checked == true)
                {
                    result = Double.Parse(textBoxInput.Text) * 1.8 + 32;
                }
                else if(radioButtonOutKelvin.Checked == true)
                {
                    result = Double.Parse(textBoxInput.Text) + 273.15;
                }
                else
                {
                    MessageBox.Show("Seleciona uma escala para saída!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if(radioButtonInputFahrenheit.Checked == true)
            {
                if (radioButtonOutCelsius.Checked == true)
                {
                    result = (Double.Parse(textBoxInput.Text) - 32) * 5/9;
                }
                else if (radioButtonOutKelvin.Checked == true)
                {
                    result = (Double.Parse(textBoxInput.Text) - 32) * 5/9 + 273.15;
                }
                else
                {
                    MessageBox.Show("Seleciona uma escala para saída!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (radioButtonInputKelvin.Checked == true)
            {
                if (radioButtonOutCelsius.Checked == true)
                {
                    result = Double.Parse(textBoxInput.Text) - 273.15;
                }
                else if (radioButtonOutFahrenheit.Checked == true)
                {
                    result = (Double.Parse(textBoxInput.Text) - 273.15) * 9/5 + 32;
                }
                else
                {
                    MessageBox.Show("Seleciona uma escala para saída!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            textBoxOutput.Text = Math.Round(result, 2).ToString();
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
