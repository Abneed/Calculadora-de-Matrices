using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Calculadora_de_Matrices
{
    public partial class Form1 : Form
    {
        Matrix Matriz_A;
        int NumeroFilas_A = 0;
        int NumeroColumnas_A = 0;

        Matrix Matriz_B;
        int NumeroFilas_B = 0;
        int NumeroColumnas_B = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // Metodo para leer la matriz del rtxtInput.
        private double[,] LeerMatriz(ref int NumeroFilas, ref int NumeroMaximoColumnas, string NombreMatriz)
        {
            double[,] dblElementos;
            string[] strElementosMatriz;
            string[] Separadores = new string[] { " ", "\n", "," };
            int NumeroColumnas = 0;
            NumeroFilas = 0;
            NumeroMaximoColumnas = 0;

            // Se elimina los espacios que se encuentran en rtxtInput.Text;
            if (NombreMatriz == "A")
            {
                strElementosMatriz = rtxtInput.Text.Split(Separadores, StringSplitOptions.RemoveEmptyEntries);
            }
            else
            {
                strElementosMatriz = rtxtInputB.Text.Split(Separadores, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (string elemento in strElementosMatriz)
            {
                NumeroColumnas++;
                if (elemento.Contains(";"))
                {
                    NumeroFilas++;
                    if (NumeroMaximoColumnas == 0)
                    {
                        NumeroMaximoColumnas = NumeroColumnas;
                    }
                    else if (NumeroMaximoColumnas > NumeroColumnas || NumeroMaximoColumnas < NumeroColumnas)
                    {
                        throw new Exception("Error de sintatix");
                    }
                    NumeroColumnas = 0;
                }
            }

            Separadores = new string[] { " ", "\n", ",", ";" };

            if (NombreMatriz == "A")
            {
                strElementosMatriz = rtxtInput.Text.Split(Separadores, StringSplitOptions.RemoveEmptyEntries);
            }
            else
            {
                strElementosMatriz = rtxtInputB.Text.Split(Separadores, StringSplitOptions.RemoveEmptyEntries);
            }

            dblElementos = new double[NumeroFilas, NumeroMaximoColumnas];

            for (int i = 0, p = 0; i < NumeroFilas; i++)
            {
                for (int j = 0; j < NumeroMaximoColumnas; j++)
                {
                    dblElementos[i, j] = double.Parse(strElementosMatriz[p], CultureInfo.InvariantCulture);
                    p++;
                }
            }

            return dblElementos;
        }

        private void btnDeterminante_Click_1(object sender, EventArgs e)
        {
            double[,] dblElementos;

            try
            { 
                dblElementos = LeerMatriz(ref NumeroFilas_A, ref NumeroColumnas_A, "A");

                if (NumeroFilas_A != NumeroColumnas_A)
                    throw new Exception("La matriz no es cuadrada.");

                Matriz_A = new Matrix(dblElementos, NumeroFilas_A, NumeroColumnas_A);

                rtxtOutput.Text = "Determinante: " + Matriz_A.Determinante.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnDeterminanteB_Click(object sender, EventArgs e)
        {
            double[,] dblElementos;

            try
            {
                dblElementos = LeerMatriz(ref NumeroFilas_B, ref NumeroColumnas_B, "B");

                if (NumeroFilas_B != NumeroColumnas_B)
                    throw new Exception("La matriz no es cuadrada.");

                Matriz_B = new Matrix(dblElementos, NumeroFilas_B, NumeroColumnas_B);

                rtxtOutput.Text = "Determinante: " + Matriz_B.Determinante.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnTranspuesta_Click_1(object sender, EventArgs e)
        {
            rtxtOutput.Text = "";

            double[,] dblElementos;

            try
            {
                dblElementos = LeerMatriz(ref NumeroFilas_A, ref NumeroColumnas_A, "A");

                Matriz_A = new Matrix(dblElementos, NumeroFilas_A, NumeroColumnas_A);

                int swap = NumeroFilas_A;
                NumeroFilas_A = NumeroColumnas_A;
                NumeroColumnas_A = swap;

                for (int i = 0; i < NumeroFilas_A; i++)
                {
                    for (int j = 0; j < NumeroColumnas_A; j++)
                    {
                        rtxtOutput.Text += Matriz_A.Transpuesta[i, j] + "\t";
                    }
                    rtxtOutput.Text += "\n";
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnTranspuestaB_Click(object sender, EventArgs e)
        {
            rtxtOutput.Text = "";

            double[,] dblElementos;

            try
            {
                dblElementos = LeerMatriz(ref NumeroFilas_B, ref NumeroColumnas_B, "B");

                Matriz_B = new Matrix(dblElementos, NumeroFilas_B, NumeroColumnas_B);

                int swap = NumeroFilas_B;
                NumeroFilas_B = NumeroColumnas_B;
                NumeroColumnas_B = swap;

                for (int i = 0; i < NumeroFilas_B; i++)
                {
                    for (int j = 0; j < NumeroColumnas_B; j++)
                    {
                        rtxtOutput.Text += Matriz_B.Transpuesta[i, j] + "\t";
                    }
                    rtxtOutput.Text += "\n";
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnInversa_Click_1(object sender, EventArgs e)
        {
            rtxtOutput.Text = "";

            double[,] dblElementos;

            try
            {
                dblElementos = LeerMatriz(ref NumeroFilas_A, ref NumeroColumnas_A, "A");

                Matriz_A = new Matrix(dblElementos, NumeroFilas_A, NumeroColumnas_A);

                if (Matriz_A.Determinante == 0)
                    throw new Exception("La determinante es nulo.\n\nLa matriz no es invertible.");

                for (int i = 0; i < NumeroFilas_A; i++)
                { 
                    for (int j = 0; j < NumeroColumnas_A; j++)
                    {
                        rtxtOutput.Text += Fraction.ToFraction(Matriz_A.Inversa[i, j]).ToString() + "\t";
                    }
                    rtxtOutput.Text += "\n";
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnInversaB_Click(object sender, EventArgs e)
        {
            rtxtOutput.Text = "";

            double[,] dblElementos;

            try
            {
                dblElementos = LeerMatriz(ref NumeroFilas_B, ref NumeroColumnas_B, "B");

                Matriz_B = new Matrix(dblElementos, NumeroFilas_B, NumeroColumnas_B);

                if (Matriz_B.Determinante == 0)
                    throw new Exception("La determinante es nulo.\n\nLa matriz no es invertible.");

                for (int i = 0; i < NumeroFilas_B; i++)
                {
                    for (int j = 0; j < NumeroColumnas_B; j++)
                    {
                        rtxtOutput.Text += Fraction.ToFraction(Fraction.ToFraction(Matriz_B.Inversa[i, j]).ToString()).ToString() + "\t";
                    }
                    rtxtOutput.Text += "\n";
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnCofactores_Click_1(object sender, EventArgs e)
        {
            rtxtOutput.Text = "";

            double[,] dblElementos;

            try
            {
                dblElementos = LeerMatriz(ref NumeroFilas_A, ref NumeroColumnas_A, "A");

                Matriz_A = new Matrix(dblElementos, NumeroFilas_A, NumeroColumnas_A);

                for (int i = 0; i < NumeroFilas_A; i++)
                {
                    for (int j = 0; j < NumeroColumnas_A; j++)
                    {
                        rtxtOutput.Text += Matriz_A.Cofactores[i, j] + "\t";
                    }
                    rtxtOutput.Text += "\n";
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnCofactoresB_Click(object sender, EventArgs e)
        {
            rtxtOutput.Text = "";

            double[,] dblElementos;

            try
            {
                dblElementos = LeerMatriz(ref NumeroFilas_B, ref NumeroColumnas_B, "B");

                Matriz_B = new Matrix(dblElementos, NumeroFilas_B, NumeroColumnas_B);

                for (int i = 0; i < NumeroFilas_B; i++)
                {
                    for (int j = 0; j < NumeroColumnas_B; j++)
                    {
                        rtxtOutput.Text += Matriz_B.Cofactores[i, j] + "\t";
                    }
                    rtxtOutput.Text += "\n";
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            rtxtOutput.Text = "";

            double[,] dblElementosA;
            double[,] dblElementosProducto;

            try
            {
                dblElementosA = LeerMatriz(ref NumeroFilas_A, ref NumeroColumnas_A, "A");

                Matriz_A = new Matrix(dblElementosA, NumeroFilas_A, NumeroColumnas_A);

                dblElementosProducto = Matriz_A.Multiplicar(double.Parse(rtxtboxMultiplicarA.Text));

                for (int i = 0; i < NumeroFilas_A; i++)
                {
                    for (int j = 0; j < NumeroColumnas_A; j++)
                    {
                        rtxtOutput.Text += dblElementosProducto[i, j] + "\t";
                    }
                    rtxtOutput.Text += "\n";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Solo se permiten ingresar numeros reales.");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnMultiplicarB_Click(object sender, EventArgs e)
        {
            rtxtOutput.Text = "";

            double[,] dblElementosB;
            double[,] dblElementosProducto;

            try
            {
                dblElementosB = LeerMatriz(ref NumeroFilas_B, ref NumeroColumnas_B, "B");

                Matriz_B = new Matrix(dblElementosB, NumeroFilas_B, NumeroColumnas_B);

                dblElementosProducto = Matriz_B.Multiplicar(double.Parse(rtxtboxMultiplicarB.Text));

                for (int i = 0; i < NumeroFilas_B; i++)
                {
                    for (int j = 0; j < NumeroColumnas_B; j++)
                    {
                        rtxtOutput.Text += dblElementosProducto[i, j] + "\t";
                    }
                    rtxtOutput.Text += "\n";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Solo se permiten ingresar numeros reales.");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnElevar_Click(object sender, EventArgs e)
        {
            rtxtOutput.Text = "";

            double[,] dblElementosA;
            double[,] dblElementosProducto;

            try
            {
                dblElementosA = LeerMatriz(ref NumeroFilas_A, ref NumeroColumnas_A, "A");

                Matriz_A = new Matrix(dblElementosA, NumeroFilas_A, NumeroColumnas_A);

                dblElementosProducto = Matriz_A.Elevar(int.Parse(rtxtboxElevarA.Text));

                for (int i = 0; i < NumeroFilas_A; i++)
                {
                    for (int j = 0; j < NumeroColumnas_A; j++)
                    {
                        rtxtOutput.Text += dblElementosProducto[i, j] + "\t";
                    }
                    rtxtOutput.Text += "\n";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Solo se permiten ingresar numeros reales.");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnElevarB_Click(object sender, EventArgs e)
        {
            rtxtOutput.Text = "";

            double[,] dblElementosB;
            double[,] dblElementosProducto;

            try
            {
                dblElementosB = LeerMatriz(ref NumeroFilas_B, ref NumeroColumnas_B, "B");

                Matriz_B = new Matrix(dblElementosB, NumeroFilas_B, NumeroColumnas_B);
                
                dblElementosProducto = Matriz_B.Elevar(int.Parse(rtxtboxElevarB.Text));

                for (int i = 0; i < NumeroFilas_B; i++)
                {
                    for (int j = 0; j < NumeroColumnas_B; j++)
                    {
                        rtxtOutput.Text += dblElementosProducto[i, j] + "\t";
                    }
                    rtxtOutput.Text += "\n";
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Solo se permiten ingresar numeros reales.");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnIntercambiar_Click(object sender, EventArgs e)
        {
            string strIntercambiar = rtxtInput.Text;
            rtxtInput.Text = rtxtInputB.Text;
            rtxtInputB.Text = strIntercambiar;
        }

        private void btnSumarAB_Click(object sender, EventArgs e)
        {
            rtxtOutput.Text = "";

            double[,] dblElementosA;
            double[,] dblElementosB;
            double[,] dblElementosSumados;

            try
            {
                dblElementosA = LeerMatriz(ref NumeroFilas_A, ref NumeroColumnas_A, "A");
                dblElementosB = LeerMatriz(ref NumeroFilas_B, ref NumeroColumnas_B, "B");

                if (NumeroFilas_A != NumeroFilas_B || NumeroColumnas_A != NumeroColumnas_B)
                    throw new Exception("Las matrices deben de tener el mismo tamaño.");
                
                Matriz_A = new Matrix(dblElementosA, NumeroFilas_A, NumeroColumnas_A);
                Matriz_B = new Matrix(dblElementosB, NumeroFilas_B, NumeroColumnas_B);

                dblElementosSumados = Matriz_A.Sumar(Matriz_B);

                for (int i = 0; i < NumeroFilas_A; i++)
                {
                    for (int j = 0; j < NumeroColumnas_A; j++)
                    {
                        rtxtOutput.Text += dblElementosSumados[i, j] + "\t";
                    }
                    rtxtOutput.Text += "\n";
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void btnRestarAB_Click(object sender, EventArgs e)
        {
            rtxtOutput.Text = "";

            double[,] dblElementosA;
            double[,] dblElementosB;
            double[,] dblElementosRestados;

            try
            {
                dblElementosA = LeerMatriz(ref NumeroFilas_A, ref NumeroColumnas_A, "A");
                dblElementosB = LeerMatriz(ref NumeroFilas_B, ref NumeroColumnas_B, "B");

                if (NumeroFilas_A != NumeroFilas_B || NumeroColumnas_A != NumeroColumnas_B) 
                    throw new Exception("Las matrices deben de tener el mismo tamaño.");
                
                Matriz_A = new Matrix(dblElementosA, NumeroFilas_A, NumeroColumnas_A);
                Matriz_B = new Matrix(dblElementosB, NumeroFilas_B, NumeroColumnas_B);

                dblElementosRestados = Matriz_A.Restar(Matriz_B);

                for (int i = 0; i < NumeroFilas_A; i++)
                {
                    for (int j = 0; j < NumeroColumnas_A; j++)
                    {
                        rtxtOutput.Text += dblElementosRestados[i, j] + "\t";
                    }
                    rtxtOutput.Text += "\n";
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnMultiplicarAB_Click(object sender, EventArgs e)
        {
            rtxtOutput.Text = "";

            double[,] dblElementosA;
            double[,] dblElementosB;
            double[,] dblElementosProducto;

            try
            {

                dblElementosA = LeerMatriz(ref NumeroFilas_A, ref NumeroColumnas_A, "A");
                dblElementosB = LeerMatriz(ref NumeroFilas_B, ref NumeroColumnas_B, "B");

                if (NumeroColumnas_A != NumeroFilas_B)
                    throw new Exception("El numero de columnas de la Matriz A, es diferente al numero de filas de la Matriz B.");
                
                Matriz_A = new Matrix(dblElementosA, NumeroFilas_A, NumeroColumnas_A);
                Matriz_B = new Matrix(dblElementosB, NumeroFilas_B, NumeroColumnas_B);

                dblElementosProducto = Matriz_A.Multiplicar(Matriz_B);

                for (int i = 0; i < NumeroFilas_A; i++)
                {
                    for (int j = 0; j < NumeroColumnas_B; j++)
                    {
                        rtxtOutput.Text += dblElementosProducto[i, j] + "\t";
                    }
                    rtxtOutput.Text += "\n";
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //
        // Limpiar cuadros de texto
        //

        private void btnLimpiarA_Click(object sender, EventArgs e)
        {
            rtxtInput.Text = "";
        }

        private void btnLimpiarB_Click(object sender, EventArgs e)
        {
            rtxtInputB.Text = "";
        }

        private void btnLimpiarOutput_Click(object sender, EventArgs e)
        {
            rtxtOutput.Text = "";
        }

    }
}
