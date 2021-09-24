using System;
using System.Windows;
using System.Windows.Controls;


namespace CalculadoraBasica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Calcular()
        {
            try
            {
                double operando1, operando2;
                operando1 = double.Parse(operando1TextBox.Text);
                operando2 = double.Parse(operando2TextBox.Text);

                switch (operadorTextBox.Text)
                {
                    case "+":
                        resultadoTextBox.Text = $"{operando1 + operando2}";
                        break;
                    case "-":
                        resultadoTextBox.Text = $"{operando1 - operando2}";
                        break;
                    case "*":
                        resultadoTextBox.Text = $"{operando1 * operando2}";
                        break;
                    case "/":
                        resultadoTextBox.Text = $"{operando1 / operando2}";
                        break;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Has introducido un valor incorrecto", "-- ERROR --");
            }
        }

        private bool OperadorCorrecto()
        {
            switch (operadorTextBox.Text)
            {
                case "+":
                    return true;
                case "-":
                    return true;
                case "*":
                    return true;
                case "/":
                    return true;
                default:
                    return false;
            }
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            Calcular();
        }

        private void LimpiarButton_Click(object sender, RoutedEventArgs e)
        {
            operando1TextBox.Clear();
            operando2TextBox.Clear();
            operadorTextBox.Clear();
            resultadoTextBox.Clear();
        }

        private void operadorTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (OperadorCorrecto()) calcularButton.IsEnabled = true;
            else calcularButton.IsEnabled = false;
        }
    }
}
