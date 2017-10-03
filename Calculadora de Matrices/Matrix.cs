using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_Matrices
{
    // Nombre de la Clase: Matrix
    // Desarrollado por: Guillermo Abneed Rodriguez Velazquez
    // Correo Electronico: Memoboy262@hotmail.com
    // Version 1.0
    class Matrix
    {
        private double[,] _dblElementos;
        private int _intNumeroFilas;
        private int _intNumeroColumnas;
        private double[,] _dblInversa;
        private double[,] _dblTranspuesta;
        private double[,] _dblCofactores;

        public double[,] Elementos
        {
            get
            {
                return _dblElementos;
            }
            set { _dblElementos = value; }
        }

        public int NumeroFilas
        {
            get { return _intNumeroFilas; }
        }

        public int NumeroColumnas
        {
            get { return _intNumeroColumnas; }
        }

        public double Determinante
        {
            get { return ObtenerDeterminante(); }
        }

        public double[,] Inversa
        {
            get
            {
                if (_dblInversa == null)
                {
                    if (NumeroFilas == 1 && NumeroColumnas == 1)
                    {
                        _dblInversa = new double[NumeroFilas, NumeroColumnas];
                        _dblInversa[0, 0] = 1 / _dblElementos[0, 0];
                        return _dblInversa;
                    }
                    _dblInversa = ObtenerInversa();
                }
                return _dblInversa;
            }
        }

        public double[,] Transpuesta
        {
            get
            {
                if (_dblTranspuesta == null)
                {
                    _dblTranspuesta = ObtenerTranspuesta(Elementos);
                }
                return _dblTranspuesta;
            }
        }

        public double[,] Cofactores
        {
            get
            {
                if (_dblCofactores == null)
                {
                    _dblCofactores = ObtenerCofactores();
                }
                return _dblCofactores;
            }
        }
        // Metodo para obtener la matriz Inversa
        private double[,] ObtenerInversa()
        {
            double[,] MatrizCofactoresTranspuesta = ObtenerTranspuesta(ObtenerCofactores());
            double dblDeterminante = Determinante;
            double[,] MatrizInversa = new double[NumeroFilas, NumeroColumnas];

            for (int i = 0; i < NumeroFilas; i++)
            {
                for (int j = 0; j < NumeroColumnas; j++)
                {
                    MatrizInversa[i, j] = (MatrizCofactoresTranspuesta[i, j] / dblDeterminante);
                }
            }
            return MatrizInversa;
        }
        // Metodo para obtener la matriz Transpuesta
        private double[,] ObtenerTranspuesta(double[,] Elementos)
        {
            double[,] dblTranspuesta = new double[NumeroColumnas, NumeroFilas];

            for (int i = 0; i < NumeroFilas; i++)
            {
                for (int j = 0; j < NumeroColumnas; j++)
                {
                    dblTranspuesta[j, i] = Elementos[i, j];
                }
            }
            return (dblTranspuesta);
        }

        private double[,] ObtenerCofactores()
        {
            double[,] dblElementos = new double[NumeroFilas - 1, NumeroColumnas - 1];
            double[,] dblCofactores = new double[NumeroFilas, NumeroColumnas];
            Matrix[,] Cofactores = new Matrix[NumeroFilas, NumeroColumnas];

            int n = 0, m = 0;

            for (int x = 0; x < NumeroFilas; x++)
            {
                for (int y = 0; y < NumeroColumnas; y++)
                {
                    for (int i = 0; i < NumeroFilas; i++)
                    {
                        for (int j = 0; j < NumeroColumnas; j++)
                        {
                            if (x == i || y == j)
                                continue;

                            dblElementos[n, m++] = _dblElementos[i, j];
                            if (m >= NumeroColumnas - 1)
                            {
                                n++; m = 0;
                            }
                        }

                    }
                    n = 0; m = 0;
                    Cofactores[x, y] = new Matrix(dblElementos, NumeroFilas - 1, NumeroColumnas - 1);
                    dblCofactores[x, y] = Math.Pow(-1, (x + y)) * Cofactores[x, y].Determinante;
                }
            }
            Cofactores = null;

            return dblCofactores;
        }

        private double ObtenerDeterminante()
        {
            // i = Numero de Fila
            // j = Numero de Columna
            //
            // | E11 E12 E13 ... E1j
            // | E21 E22 E23 ... E2j
            // | E31 E32 E33 ... E3j
            // | ... ... ... ... ...
            // | Ei1 Ei2 Ei3 ... Eij

            // Si la matriz es de una sola dimension (1 x 1), entonces su unico elemento es la determinante.
            if (NumeroFilas == 1 && NumeroColumnas == 1)
            {
                // La determinante es igual al unico elemento de la matriz de orden 1.
                return Elementos[0, 0];
            }
            // Si es una matriz cuadrada de orden 2 (2 x 2), entonces se aplicara el metodo de Sauss.
            else if (NumeroFilas == 2 && NumeroColumnas == 2)
            {
                // E11E22 - E21E12
                return (Elementos[0, 0] * Elementos[1, 1] - Elementos[1, 0] * Elementos[0, 1]);
            }
            // Si es una matriz cuadrada de orden 3 (3 x 3), entonces se aplicara el metodo de Sauss.
            else if (NumeroFilas == 3 && NumeroColumnas == 3)
            {
                // Se aplica el metodo de Sauss para obtener la determinante.
                //return MetodoSarrus();
                return MetodoGauss();
            }
            // Si es una matriz cuadrada de orden 4 o mayor, entonces se aplicara el metodo de Eliminacion de Gauss.
            else if (NumeroFilas >= 4 && NumeroColumnas >= 4)
            {
                return MetodoGauss();
            }
            // Si las filas o las columnas son "0", la determinante es nula.
            else
            {
                return 0.0;
            }

        }

        private double MetodoGauss()
        {
            // Elementos de la matriz escalonada
            double[,] dblElementos = new double[NumeroFilas, NumeroColumnas];

            for (int i = 0; i < NumeroFilas; i++)
            {
                for (int j = 0; j < NumeroColumnas; j++)
                {
                    dblElementos[i, j] = _dblElementos[i, j];
                }
            }

            // Variable restador
            double Substract = 0.0;

            for (int m = 0; m < NumeroFilas - 1; m++)
            {
                for (int n = m + 1; n < NumeroFilas; n++)
                {
                    Substract = dblElementos[n, m] / dblElementos[m, m];
                    if (double.IsNaN(Substract) || double.IsInfinity(Substract))
                    {
                        for (int i = 0; i < NumeroFilas; i++)
                        {
                            Substract = dblElementos[n, i];
                            dblElementos[n, i] = -dblElementos[m, i];
                            dblElementos[m, i] = Substract;
                        }
                    }
                    else
                        for (int i = 0; i < NumeroFilas; i++)
                            dblElementos[n, i] -= dblElementos[m, i] * Substract;
                }
            }

            // Reusamos la variable Substract para almacenar el producto de los elementos del diagonal principal una vez concluida el Metodo de Eliminacion de Gauss.
            Substract = 1.0;
            for (int i = 0; i < NumeroFilas; i++)
                Substract *= dblElementos[i, i];

            return Substract;
        }

        // Metodo para obtener la determinante SOLAMENTE en las matrices cuadradas de orden 3.
        private double MetodoSarrus()
        {
            double det = 0.0;
            double temp = 1.0;
            int Columnas;

            // (aij)
            // i = Filas
            // j = Columnas

            // [0,0]    [0,2]
            // [1,1]    [1,0]
            // [2,2]    [2,1]
            // [0,1]
            // [1,2]
            // [2,0]

            // Los terminos de signo "+".
            for (int i = 0; i < Elementos.Length / this.NumeroColumnas; i++)
            {
                Columnas = i;
                for (int Filas = 0; Filas < this.NumeroFilas; Filas++)
                {
                    if (Columnas >= this.NumeroFilas)
                        Columnas = 0;
                    temp *= Elementos[Filas, Columnas];
                    Columnas++;
                }
                det += temp;
                temp = 1.0;
            }

            // [0,2]    [0,0]
            // [1,1]    [1,2]
            // [2,0]    [2,1]
            // [0,1]
            // [1,0]
            // [2,2]

            // Los terminos de signo "-".
            for (int i = Elementos.Length / this.NumeroColumnas; i > 0; i--)
            {
                Columnas = i - 1;

                for (int Filas = 0; Filas < this.NumeroFilas; Filas++)
                {
                    if (Columnas < 0)
                        Columnas = (Elementos.Length / this.NumeroColumnas) - 1;

                    temp *= Elementos[Filas, Columnas];
                    Columnas--;
                }
                det -= temp;
                temp = 1.0;
            }

            return det;
        }

        public double[,] Sumar(Matrix Matriz)
        {
            double[,] dblElementosSumados = new double[NumeroFilas, NumeroColumnas];

            for (int i = 0; i < NumeroFilas; i++)
            {
                for (int j = 0; j < NumeroColumnas; j++)
                {
                    dblElementosSumados[i,j] = Elementos[i, j] + Matriz.Elementos[i, j];
                }
            }

            return dblElementosSumados;
        }

        public double[,] Restar(Matrix Matriz)
        {
            double[,] dblElementosRestados = new double[NumeroFilas, NumeroColumnas];

            for (int i = 0; i < NumeroFilas; i++)
            {
                for (int j = 0; j < NumeroColumnas; j++)
                {
                    dblElementosRestados[i, j] = Elementos[i, j] - Matriz.Elementos[i, j];
                }
            }

            return dblElementosRestados;
        }

        public double[,] Elevar(int Exponente)
        {

            if (NumeroFilas != NumeroColumnas)
            {
                throw new Exception("La matriz tiene que ser cuadrada");
            }

            double[,] dblElementos = new double[NumeroFilas, NumeroColumnas];

            for (int e = 0; e < Exponente - 1; e++)
            { 
                for (int i = 0; i < NumeroFilas; i++)
                {
                    for (int j = 0; j < NumeroColumnas; j++)
                    {
                        for (int n = 0; n < NumeroFilas; n++)
                        {
                            dblElementos[i, j] += Elementos[i, n] * Elementos[n, j];
                        }
                    }
                }
            }

            return dblElementos;
        }

        public double[,] Multiplicar(Matrix Matriz)
        {
            double[,] dblElementos = new double[NumeroFilas, NumeroColumnas];
            // Se crea una matriz por el numero de Filas de la Matriz A por el numero de Columnas de la Matriz B
            double[,] dblMatrizProducto = new double[NumeroFilas, Matriz.NumeroColumnas];

            for (int i = 0; i < NumeroFilas; i++)
            {
                for (int j = 0; j < NumeroColumnas; j++)
                {
                    dblElementos[i, j] = Elementos[i, j];
                }
            }

            for (int m = 0; m < NumeroFilas; m++)
            {
                for (int n = 0; n < Matriz.NumeroColumnas; n++)
                {
                    for (int i = 0; i < Matriz.NumeroFilas; i++)
                    {
                        dblMatrizProducto[m, n] += dblElementos[m, i] * Matriz.Elementos[i, n];
                    }
                }
            }

            return dblMatrizProducto;
        }

        public double[,] Multiplicar(double dblMultiplo)
        {
            double[,] dblElementosProducto = new double[NumeroFilas, NumeroColumnas];

            for (int i = 0; i < NumeroFilas; i++)
            {
                for (int j = 0; j < NumeroColumnas; j++)
                {
                    dblElementosProducto[i, j] = Elementos[i, j] * dblMultiplo;
                }
            }

            return dblElementosProducto;
        }

        public Matrix(double[,] dblElementos, int NumeroFilas, int NumeroColumnas)
        {
            _intNumeroFilas = NumeroFilas;
            _intNumeroColumnas = NumeroColumnas;
            _dblElementos = new double[NumeroFilas, NumeroColumnas];

            for (int i = 0; i < NumeroFilas; i++)
            {
                for (int j = 0; j < NumeroColumnas; j++)
                {
                    _dblElementos[i, j] = dblElementos[i, j];
                }
            }
        }

        ~Matrix()
        {

        }
    }
}
