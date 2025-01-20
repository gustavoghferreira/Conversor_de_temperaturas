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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
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
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(192, 58);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(150, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Saída";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 9F);
            radioButton1.Location = new Point(3, 69);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(57, 19);
            radioButton1.TabIndex = 2;
            radioButton1.Text = "Kelvin";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 9F);
            radioButton2.Location = new Point(3, 44);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(81, 19);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "Fahrenheit";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton3.Location = new Point(3, 19);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(62, 19);
            radioButton3.TabIndex = 0;
            radioButton3.Text = "Celsius";
            radioButton3.UseVisualStyleBackColor = true;
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
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private TextBox textBoxInput;
        private TextBox textBoxOutput;
        private Button buttonConvert;
        private Button buttonClean;
    }
}
