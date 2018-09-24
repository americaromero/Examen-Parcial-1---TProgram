using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MiPrimeraBiblioteca
{
    /*Inicio clase arreglos 10 ejercicios*/
    public class Arreglos_ame
    {
        //Inicio  Metodo para generar un vector de enteros
        public static void GenerarVectorEnteros()
        {
            int[] numeros; // Declaración del array sin numeros   
            int num = 0;


            Console.Write("¿Cuántos números vas a introducir? ");
            num = Convert.ToInt16(Console.ReadLine());

            numeros = new int[num + 1]; // Instanciación del array 

            for (int i = 1; i <= num; i++)
            {
                Console.Write("Ingresa el elemento {0}: ", i);
                numeros[i] = Convert.ToInt16(Console.ReadLine());
            }
        }
        //Fin Metodo para generar un vector de enteros

        //Inicio Metodo para imprimir un vector de enteros
        public static void ImprimirVectorEnteros(int[] vector_entrada)
        {
            int[] vector = vector_entrada;

            for (int i = 0; i < vector.Length; i++)
                Console.Write("{0} ", vector[i + 1]);
            Console.WriteLine();

        }
        //Fin Metodo para imprimir un vector de enteros

        //Inicio Metodo para generar un vector de flotantes

        public static void GenerarVectorFlotantes()
        {
            Double[] numeros; // Declaración del array sin numeros   
            int num = 0;


            Console.Write("¿Cuántos números vas a introducir? ");
            num = Convert.ToInt16(Console.ReadLine());

            numeros = new Double[num + 1]; // Instanciación del array 

            for (int i = 1; i <= num; i++)
            {
                Console.Write("Ingresa el elemento {0}: ", i);
                numeros[i] = Convert.ToDouble(Console.ReadLine());
            }
        }
        //Fin Metodo para generar un vector de flotantes

        //Inicio Metodo para imprimir un vector de flotantes 
        public static void ImprimirVectorFlotantes(Double[] vector_entrada)
        {
            Double[] vector = vector_entrada;

            for (int i = 0; i < vector.Length; i++)
                Console.Write("{0} ", vector[i + 1]);
            Console.WriteLine();

        }
        //Fin Metodo para imprimir un vector de flotantes 

        //Inicio Metodo para generar un vector de cadenas
        public static void GenerarVectorCadenas()
        {
            String[] numeros; // Declaración del array sin numeros   
            int num = 0;


            Console.Write("¿Cuántos números vas a introducir? ");
            num = Convert.ToInt16(Console.ReadLine());

            numeros = new String[num + 1]; // Instanciación del array 

            for (int i = 1; i <= num; i++)
            {
                Console.Write("Ingresa el elemento {0}: ", i);
                numeros[i] = Convert.ToString(Console.ReadLine());
            }
        }
        //Fin Metodo para generar un vector de cadenas

        //Inicio Metodo para imprimir un vector de cadenas
        public static void ImprimirVectorCadenas(String[] vector_entrada)
        {
            String[] vector = vector_entrada;

            for (int i = 0; i < vector.Length; i++)
                Console.Write("{0} ", vector[i + 1]);
            Console.WriteLine();

        }
        //Fin Metodo para imprimir un vector de cadenas

        //Inicio Metodo para generar una matriz de 2 dimensiones  de enteros

        public static int[,] GenerarMatrizDosDimensiones()
        {
            int filas = 0;
            int columnas = 0;
            Console.Write("¿ filas que  vas a introducir? ");
            filas = Convert.ToInt16(Console.ReadLine());
            Console.Write("¿columnas que vas a introducir? ");
            columnas = Convert.ToInt16(Console.ReadLine());

            //Numero de n cuadrado 
            int[,] MatrizA = new int[filas, columnas];

            for (int i = 0; i < filas; i++)
            {// for externo para filas
                for (int j = 0; j < columnas; j++)
                {// for interno para columnas
                    Console.Write("Ingrese el elemento [" + i + "," + j + "]: ");
                    MatrizA[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return MatrizA;
        }
        //Fin Metodo para generar una matriz de 2 dimensiones  de enteros

        //Inicio Metodo para imprimir una matriz de 2 dimensiones de enteros
        public static void PrintArray_int(int[] matriz_ingresada)
        {
            for (int i = 0; i < matriz_ingresada.Length; i++)
            {
                System.Console.Write(matriz_ingresada[i] + "{0}", i < matriz_ingresada.Length - 1 ? " " : "");
            }
            System.Console.WriteLine();
        }


        //Fin Metodo para imprimir una matriz de 2 dimensiones de enteros

        //Inicio Metodo para generar una matriz de 2 dimensiones  de flotantes
        public static int[,] GenerarMatrizDosDimensiones_float()
        {
            int filas = 0;
            int columnas = 0;
            Console.Write("¿ filas que  vas a introducir? ");
            filas = Convert.ToInt16(Console.ReadLine());
            Console.Write("¿columnas que vas a introducir? ");
            columnas = Convert.ToInt16(Console.ReadLine());

            //Numero de n cuadrado 
            int[,] MatrizA = new int[filas, columnas];

            for (int i = 0; i < filas; i++)
            {// for externo para filas
                for (int j = 0; j < columnas; j++)
                {// for interno para columnas
                    Console.Write("Ingrese el elemento [" + i + "," + j + "]: ");
                    MatrizA[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return MatrizA;
        }

        //Fin Metodo para generar una matriz de 2 dimensiones  de flotantes

        //Inicio Metodo para imprimir una matriz de 2 dimensiones de flotantes
        public static void PrintArray_float(float[] matriz_ingresada)
        {
            for (int i = 0; i < matriz_ingresada.Length; i++)
            {
                System.Console.Write(matriz_ingresada[i] + "{0}", i < matriz_ingresada.Length - 1 ? " " : "");
            }
            System.Console.WriteLine();
        }
        //Fin Metodo para imprimir una matriz de 2 dimensiones de flotantes



    }
        /*Fin clase arreglo 10 ejercicios*/

        /*Inicio clase cadenas 3 ejercicios*/
        public class Cadenas
        {

        //Inicio Metodo que reciba como parámetro un "TextBox" y que se imprima una cadena en ese "TextBox".

        //Esto es pasarlo como parámetro de entrada, por decirlo de alguna manera, seria de "solo lectura"

        public string LeerTextoTextBox(TextBox txtBox)
        {
            return txtBox.Text;
        }

        

        //Fin Metodo que reciba como parámetro un "TextBox" y que se imprima una cadena en ese "TextBox".


        //Inicio Metodo que identifique cuando se ingresa una cadena vacía o no se introduce nada 
        public static void ValidarCadenaVacia(string s)
        {
            
            if (String.IsNullOrEmpty(s))
            {
                Console.WriteLine("La cadena está vacía o tiene un valor nulo.");
            }
            else
            {
                Console.WriteLine("La cadena es: '{0}' y tiene {1} caracteres.", s, s.Length);
            }
        }
        //Fin Metodo que identifique cuando se ingresa una cadena vacía o no se introduce nada 


        //Inicio Metodo que despliegue los datos del autor (Cabecera) en un "MessageBox"

       public static void DesplegarMensaje(string s)
        {
            string nombre = "América";
            if (s.Equals(nombre))
                MessageBox.Show("Hola"+nombre);    
        }

        //Fin Metodo que despliegue los datos del autor (Cabecera) en un "MessageBox"



    }
        /*Fin clase arreglo 3 ejercicios*/


        /*Inicio clase ciclos 8 ejercicios*/
        public class Ciclos
        {
            //Inicio 1. Metodo mediante ciclos que permita sumar los elementos de un vector
            public static void SumarElementosVector(int[] numeros)
        {
            
            int suma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                suma += numeros[i];
            }
        }
        //Fin Metodo mediante ciclos que permita sumar los elementos de un vector

        //Inicio 2. Metodo mediante ciclos que permita multiplicar los elementos de un vector.
        public static void MultiplicarElementosVector(int[] numeros)
        {

            int suma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                suma *= numeros[i];
            }
        }
        //Fin 2. Metodo mediante ciclos que permita multiplicar los elementos de un vector.


        //Inicio 3. Metodo mediante ciclos que permita sumar los elementos de una matriz de dos dimensiones.
        public static int SumaMatriz2D(int[,] mn)
        {
            int cont = 0;
            //SUMA DE LINEAS
            for (int i = 0; i < mn.GetLength(0); i++)
            {
                int suma = 0;

                for (int j = 0; j < mn.GetLength(1); j++)
                {
                    suma += mn[i, j];
                }
                cont = cont + suma;
                //Console.WriteLine("Linea " + i + " = " + suma);
            }
            //Console.WriteLine("total" + cont);

            //Console.ReadKey();

            return cont;
        }
        //Fin 3. Metodo mediante ciclos que permita sumar los elementos de una matriz de dos dimensiones.


        //Inicio 4. Metodo mediante ciclos que calcule un numero de la serie fibonacci

        public static void NumSerieFibonacci()
        {
            //Programa que desarrolla la serie de Fibonacci hasta un número dado
            int a, b, n, i, camb; //declaramos las variables, camb me sirve para hacer cambios
            Console.WriteLine("¿Cuantos números Fibonacci quieres?");
            n = int.Parse(Console.ReadLine()); //leemos el número de términos
            a = 0;
            b = 1; //inicializamos
            for (i = 0; i < n; i++)  //se repite para el número de veces deseado
            {
                camb = a;
                a = b; //intercambio valores
                b = camb + a; //cailculo el nuevo valor
                Console.WriteLine(a); //imprimo el valor
            }
            Console.ReadKey(); //para que se quede esperando a que presione una tecla
        }
        //Fin 4. Metodo mediante ciclos que calcule un numero de la serie fibonacci

        //Inicio 5. Metodo mediante ciclos para obtener el factorial de n
        public static int NumeroFactorial(int numero)
        {

            int resultado = 1;
            for (int i = 1; i <= numero; i++)
            {
                resultado = resultado * i;
            }
            //Console.WriteLine("El factorial de " + numero + " es:" + resultado);
            //Console.ReadLine();
            return resultado;

        }
        //Fin 5. Metodo mediante ciclos para obtener el factorial de n

        //Inicio 6. Metodo mediante ciclos para obtener la potencia de un numero 

        public static int Potencia(int num)
        {
            int res = num;

            if (num == 0)
                return 1;
            else
                for (int i = 1; i <= num; i++)
                {
                    res = num * num;
                }
            return res;
        }

        //Fin 6. Metodo mediante ciclos para obtener la potencia de un numero 


        //Inicio 7. Metodo que reciba una cadena y la retorne en minusculas. No debe usar funciones de c# 
        public static String ConvertToLowerCase(String input)
        {
            String output = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 'A' && input[i] <= 'Z')
                {
                    output += (char)(input[i] - 'A' + 'a');
                }
                else
                    output += input[i];
            }
            return output;
        }
        //Fin 7. Metodo que reciba una cadena y la retorne en minusculas. No debe usar funciones de c# 


        //Inicio 8. Metodo que reciba una cadena y la retorne en mayusculas. No debe usar funciones de c#
        public static String ConvertToUpperCase(String input)
        {
            String output = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 'a' && input[i] <= 'z')
                {
                    output += (char)(input[i] - 'a' + 'A');
                }
                else
                    output += input[i];
            }
            return output;
        }

        //Fin 8. Metodo que reciba una cadena y la retorne en mayusculas. No debe usar funciones de c#
    }
    /*Fin clase ciclos 8 ejercicios*/


    /*Inicio clase matriz sobrecarga de operadores*/
    public class SobrecargaV
    {
        private int[] vec;

        public SobrecargaV()
        {
            vec = new int[5];
        }

        public void Cargar()
        {
            for (int f = 0; f < vec.Length; f++)
            {
                Console.Write("Ingrese componente:");
                vec[f] = int.Parse(Console.ReadLine());
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < vec.Length; f++)
            {
                Console.Write(vec[f] + " ");
            }
            Console.WriteLine();
        }

        public static SobrecargaV operator +(SobrecargaV v1, SobrecargaV v2)
        {
            SobrecargaV su = new SobrecargaV();
            for (int f = 0; f < su.vec.Length; f++)
            {
                su.vec[f] = v1.vec[f] + v2.vec[f];
            }
            return su;
        }

    }



    /*class Program
    {
        static void Main(string[] args)
        {
            VectorEnteros v1 = new VectorEnteros();
            Console.WriteLine("Carga del primer vector");
            v1.Cargar();
            VectorEnteros v2 = new VectorEnteros();
            Console.WriteLine("Carga del segundo vector");
            v2.Cargar();
            Console.WriteLine("Primer Vector");
            v1.Imprimir();
            Console.WriteLine("Segundo Vector");
            v2.Imprimir();
            VectorEnteros vt;
            vt = v1 + v2;
            Console.WriteLine("Vector Resultante");
            vt.Imprimir();
            Console.ReadKey();
        }
    }*/
    /*Fin clase matriz sobrecarga de operadores*/

}

