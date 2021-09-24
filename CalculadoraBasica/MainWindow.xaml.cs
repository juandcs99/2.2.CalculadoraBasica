using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculadoraBasica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string operando1;
        private string operando2;
        private string resultado;

        public string Operando1
        {
            get { return operando1TextBox.Text; }
            private set { operando1 = value; }
        }
        public string Operando2
        {
            get { return operando2TextBox.Text; }
            private set { operando2 = value; }
        }
        public string Resultado
        {
            get { return resultadoTextBox.Text; }
            private set { resultado = value; }
        }

        public MainWindow()
        {
            InitializeComponent();

        }

        private void Calcular()
        {
            double operando1d, operando2d, resultadod;
            operando1d = double.Parse(Operando1);
            operando2d = double.Parse(Operando2);
            resultadod = double.Parse(Resultado);


            switch (char.Parse(operadorTextBox.Text))
            {
                case '+':
                    resultadod = operando1d + operando2d;
                    break;
                case '-':
                    resultadod = operando1d - operando2d;
                    break;
                case '*':
                    resultadod = operando1d * operando2d;
                    break;
                case '/':
                    resultadod = operando1d / operando2d;
                    break;
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
