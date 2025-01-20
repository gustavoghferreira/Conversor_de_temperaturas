namespace Conversor_de_temperaturas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            radioButtonInputKelvin = new RadioButton();
            radioButtonInputFahrenheit = new RadioButton();
            radioButtonInputCelsius = new RadioButton();
            groupBox2 = new GroupBox();
            radioButtonOutKelvin = new RadioButton();
            radioButtonOutFahrenheit = new RadioButton();
            radioButtonOutCelsius = new RadioButton();
            textBoxInput = new TextBox();
            textBoxOutput = new TextBox();
            buttonConvert = new Button();
            buttonClean = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonInputKelvin);
            groupBox1.Controls.Add(radioButtonInputFahrenheit);
            groupBox1.Controls.Add(radioButtonInputCelsius);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(150, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Entrada";
            // 
            // radioButtonInputKelvin
            // 
            radioButtonInputKelvin.AutoSize = true;
            radioButtonInputKelvin.Font = new Font("Segoe UI", 9F);
            radioButtonInputKelvin.Location = new Point(3, 69);
            radioButtonInputKelvin.Name = "radioButtonInputKelvin";
            radioButtonInputKelvin.Size = new Size(57, 19);
            radioButtonInputKelvin.TabIndex = 2;
            radioButtonInputKelvin.Text = "Kelvin";
            radioButtonInputKelvin.UseVisualStyleBackColor = true;
            radioButtonInputKelvin.CheckedChanged += radioButtonInputKelvin_CheckedChanged;
            // 
            // radioButtonInputFahrenheit
            // 
            radioButtonInputFahrenheit.AutoSize = true;
            radioButtonInputFahrenheit.Font = new Font("Segoe UI", 9F);
            radioButtonInputFahrenheit.Location = new Point(3, 44);
            radioButtonInputFahrenheit.Name = "radioButtonInputFahrenheit";
            radioButtonInputFahrenheit.Size = new Size(81, 19);
            radioButtonInputFahrenheit.TabIndex = 1;
            radioButtonInputFahrenheit.Text = "Fahrenheit";
            radioButtonInputFahrenheit.UseVisualStyleBackColor = true;
            radioButtonInputFahrenheit.CheckedChanged += radioButtonInputFahrenheit_CheckedChanged;
            // 
            // radioButtonInputCelsius
            // 
            radioButtonInputCelsius.AutoSize = true;
            radioButtonInputCelsius.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonInputCelsius.Location = new Point(3, 19);
            radioButtonInputCelsius.Name = "radioButtonInputCelsius";
            radioButtonInputCelsius.Size = new Size(62, 19);
            radioButtonInputCelsius.TabIndex = 0;
            radioButtonInputCelsius.Text = "Celsius";
            radioButtonInputCelsius.UseVisualStyleBackColor = true;
            radioButtonInputCelsius.CheckedChanged += radioButtonInputCelsius_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButtonOutKelvin);
            groupBox2.Controls.Add(radioButtonOutFahrenheit);
            groupBox2.Controls.Add(radioButtonOutCelsius);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(192, 58);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(150, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Saída";
            // 
            // radioButtonOutKelvin
            // 
            radioButtonOutKelvin.AutoSize = true;
            radioButtonOutKelvin.Font = new Font("Segoe UI", 9F);
            radioButtonOutKelvin.Location = new Point(3, 69);
            radioButtonOutKelvin.Name = "radioButtonOutKelvin";
            radioButtonOutKelvin.Size = new Size(57, 19);
            radioButtonOutKelvin.TabIndex = 2;
            radioButtonOutKelvin.Text = "Kelvin";
            radioButtonOutKelvin.UseVisualStyleBackColor = true;
            // 
            // radioButtonOutFahrenheit
            // 
            radioButtonOutFahrenheit.AutoSize = true;
            radioButtonOutFahrenheit.Font = new Font("Segoe UI", 9F);
            radioButtonOutFahrenheit.Location = new Point(3, 44);
            radioButtonOutFahrenheit.Name = "radioButtonOutFahrenheit";
            radioButtonOutFahrenheit.Size = new Size(81, 19);
            radioButtonOutFahrenheit.TabIndex = 1;
            radioButtonOutFahrenheit.Text = "Fahrenheit";
            radioButtonOutFahrenheit.UseVisualStyleBackColor = true;
            // 
            // radioButtonOutCelsius
            // 
            radioButtonOutCelsius.AutoSize = true;
            radioButtonOutCelsius.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonOutCelsius.Location = new Point(3, 19);
            radioButtonOutCelsius.Name = "radioButtonOutCelsius";
            radioButtonOutCelsius.Size = new Size(62, 19);
            radioButtonOutCelsius.TabIndex = 0;
            radioButtonOutCelsius.Text = "Celsius";
            radioButtonOutCelsius.UseVisualStyleBackColor = true;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(12, 164);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(150, 23);
            textBoxInput.TabIndex = 2;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Enabled = false;
            textBoxOutput.Location = new Point(192, 164);
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.Size = new Size(150, 23);
            textBoxOutput.TabIndex = 3;
            // 
            // buttonConvert
            // 
            buttonConvert.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            buttonConvert.Location = new Point(12, 193);
            buttonConvert.Name = "buttonConvert";
            buttonConvert.Size = new Size(150, 30);
            buttonConvert.TabIndex = 4;
            buttonConvert.Text = "Converter";
            buttonConvert.UseVisualStyleBackColor = true;
            buttonConvert.Click += buttonConvert_Click;
            // 
            // buttonClean
            // 
            buttonClean.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            buttonClean.Location = new Point(192, 193);
            buttonClean.Name = "buttonClean";
            buttonClean.Size = new Size(150, 30);
            buttonClean.TabIndex = 5;
            buttonClean.Text = "Limpar";
            buttonClean.UseVisualStyleBackColor = true;
            buttonClean.Click += buttonClean_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 231);
            Controls.Add(buttonClean);
            Controls.Add(buttonConvert);
            Controls.Add(textBoxOutput);
            Controls.Add(textBoxInput);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conversor de temperaturas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButtonInputKelvin;
        private RadioButton radioButtonInputFahrenheit;
        private RadioButton radioButtonInputCelsius;
        private GroupBox groupBox2;
        private RadioButton radioButtonOutKelvin;
        private RadioButton radioButtonOutFahrenheit;
        private RadioButton radioButtonOutCelsius;
        private TextBox textBoxInput;
        private TextBox textBoxOutput;
        private Button buttonConvert;
        private Button buttonClean;
    }
}
