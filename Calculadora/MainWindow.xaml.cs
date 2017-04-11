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

namespace Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string cadena = "0";
        double[] numeros = new double[2];
        bool banderaPunto = false;
        bool banderaSigno = false;

        public MainWindow()
        {
            InitializeComponent();
            comboModo.SelectedIndex = 0; //Por defecto inicia en modo estándar
        }

        private void btnIgual_Click(object sender, RoutedEventArgs e)
        {
            string operacion = txtOperacion.Text;
            double resultado = 0;
            if (!operacion.Contains("+") && !operacion.Contains("-") && !operacion.Contains("X") && !operacion.Contains("/"))
            {
                resultado = int.Parse(cadena);
            }
            else
            {
                if (operacion.Contains("+"))
                {
                    resultado = suma(numeros[0]);
                }
                else if (operacion.Contains("-"))
                {
                    //Método para restar
                }
                else if (operacion.Contains("X"))
                {
                    //Método para multiplicar
                }
                else if (operacion.Contains("/"))
                {
                    //Método para dividir
                }
            }
            cadena = resultado.ToString();
            txtRes.Text = cadena;
            banderaPunto = false;
        }

        /*** Métodos para agregar los números y signos ***/
        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (cadena.Length == 1)
            {
                cadena = "0";
            }
            else
            {
                cadena += "0";
            }
            txtRes.Text = cadena;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (cadena.Length == 1 && cadena[0] == '0')
            {
                cadena = "1";
            }
            else
            {
                cadena += "1";
            }
            txtRes.Text = cadena;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (cadena.Length == 1 && cadena[0] == '0')
            {
                cadena = "2";
            }
            else
            {
                cadena += "2";
            }
            txtRes.Text = cadena;
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (cadena.Length == 1 && cadena[0] == '0')
            {
                cadena = "3";
            }
            else
            {
                cadena += "3";
            }
            txtRes.Text = cadena;
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (cadena.Length == 1 && cadena[0] == '0')
            {
                cadena = "4";
            }
            else
            {
                cadena += "4";
            }
            txtRes.Text = cadena;
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (cadena.Length == 1 && cadena[0] == '0')
            {
                cadena = "5";
            }
            else
            {
                cadena += "5";
            }
            txtRes.Text = cadena;
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (cadena.Length == 1 && cadena[0] == '0')
            {
                cadena = "6";
            }
            else
            {
                cadena += "6";
            }
            txtRes.Text = cadena;
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (cadena.Length == 1 && cadena[0] == '0')
            {
                cadena = "7";
            }
            else
            {
                cadena += "7";
            }
            txtRes.Text = cadena;
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (cadena.Length == 1 && cadena[0] == '0')
            {
                cadena = "8";
            }
            else
            {
                cadena += "8";
            }
            txtRes.Text = cadena;
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (cadena.Length == 1 && cadena[0] == '0')
            {
                cadena = "9";
            }
            else
            {
                cadena += "9";
            }
            txtRes.Text = cadena;
        }

        private void btnPunto_Click(object sender, RoutedEventArgs e)
        {
            if (!banderaPunto)
            {
                cadena += ".";
                banderaPunto = true;
            }
            txtRes.Text = cadena;
        }

        private void btnSigno_Click(object sender, RoutedEventArgs e)
        {
            string nueva = "";
            if (cadena.Length == 1 && cadena[0] == '0')
            {
                nueva = "0";
            }
            else
            {
                if (!banderaSigno)
                {
                    nueva += "-";
                    for (int i = 0; i < cadena.Length; i++)
                    {
                        nueva += cadena[i];
                    }
                    banderaSigno = true;
                }
                else
                {
                    for (int i = 1; i < cadena.Length; i++)
                    {
                        nueva += cadena[i];
                    }
                    banderaSigno = false;
                }
            }
            cadena = nueva;
            txtRes.Text = cadena;
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            cadena = "0";
            banderaPunto = false;
            txtRes.Text = cadena;
            txtOperacion.Text = "";
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            string nueva = "";
            if (cadena.Length == 1)
            {
                cadena = "0";
            }
            else
            {
                for (int i = 0; i < cadena.Length - 1; i++)
                {
                    nueva += cadena[i];
                }
                if (cadena[cadena.Length - 1] == '.')
                {
                    banderaPunto = false;
                }
                cadena = nueva;
            }
            txtRes.Text = cadena;
        }
        /*** Fin de métodos para agregar los números y signos ***/

        /*** Métodos para operaciones ***/

        //Suma:
        private void btnMas_Click(object sender, RoutedEventArgs e)
        {
            numeros[0] = double.Parse(cadena);
            cadena += "+";
            txtOperacion.Text = cadena;
            cadena = "0";
            txtRes.Text = cadena;
        }

        private double suma(double num1)
        {
            numeros[1] = double.Parse(cadena);
            txtOperacion.Text = txtOperacion.Text + cadena;
            return num1 + numeros[1];
        }
        //Fin suma.
    }
}
