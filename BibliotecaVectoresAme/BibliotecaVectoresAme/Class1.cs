using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVectoresAme
{
    /*Inicio clase arreglos 10 ejercicios*/
    public class Arreglos
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
        
    static int[,] GenerarMatrizDosDimensiones()
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

        public static void ImprimirMatriz(int[,] Matriz3)
        {
            /*int filas = 0;
            int columnas = 0;

            for (int i = 0; i < Matriz3.Length; i++)
                {
                    Console.Write("\n");
                    for (int j = 0; j < Matriz3[i,0].Length; j++)
                    {
                        Console.Write("\t" + Matriz3[i, j] + "\t");
                    }
                }*/
        }



        //Fin Metodo para imprimir una matriz de 2 dimensiones de enteros

        //Inicio Metodo para generar una matriz de 2 dimensiones  de flotantes
        //Fin Metodo para generar una matriz de 2 dimensiones  de flotantes

        //Inicio Metodo para imprimir una matriz de 2 dimensiones de flotantes
        //Fin Metodo para imprimir una matriz de 2 dimensiones de flotantes



    }
    /*Fin clase arreglo 10 ejercicios*/

    /*Inicio clase cadenas 3 ejercicios*/
    public class Cadenas
    {

        //Inicio Metodo que reciba como parámetro un "TextBox" y que se imprima una cadena en ese "TextBox".
        //Fin Metodo que reciba como parámetro un "TextBox" y que se imprima una cadena en ese "TextBox".


        //Inicio Metodo que identifique cuando se ingresa una cadena vacía o no se introduce nada 
        //Fin Metodo que identifique cuando se ingresa una cadena vacía o no se introduce nada 


        //Inicio Metodo que despliegue los datos del autor (Cabecera) en un "MessageBox"
        //Fin Metodo que despliegue los datos del autor (Cabecera) en un "MessageBox"



    }
    /*Fin clase arreglo 3 ejercicios*/


    /*Inicio clase ciclos 8 ejercicios*/
    public class Ciclos
    {
        //Inicio Metodo mediante ciclos que permita sumar los elementos de un vector
        //Fin Metodo mediante ciclos que permita sumar los elementos de un vector

        //Inicio 2. Metodo mediante ciclos que permita multiplicar los elementos de un vector.
        //Fin 2. Metodo mediante ciclos que permita multiplicar los elementos de un vector.


        //Inicio 3. Metodo mediante ciclos que permita sumar los elementos de una matriz de dos dimensiones.
        //Fin 3. Metodo mediante ciclos que permita sumar los elementos de una matriz de dos dimensiones.


        //Inicio 4. Metodo mediante ciclos que calcule un numero de la serie fibonacci
        //Fin 4. Metodo mediante ciclos que calcule un numero de la serie fibonacci

        //Inicio 5. Metodo mediante ciclos para obtener el factorial de n
        //Fin 5. Metodo mediante ciclos para obtener el factorial de n

        //Inicio 6. Metodo mediante ciclos para obtener la potencia de un numero 
        //Fin 6. Metodo mediante ciclos para obtener la potencia de un numero 


        //Inicio 7. Metodo que reciba una cadena y la retorne en minusculas. No debe usar funciones de c# 
        //Fin 7. Metodo que reciba una cadena y la retorne en minusculas. No debe usar funciones de c# 


        //Inicio 8. Metodo que reciba una cadena y la retorne en mayusculas. No debe usar funciones de c#
        //Fin 8. Metodo que reciba una cadena y la retorne en mayusculas. No debe usar funciones de c#
    }
    /*Fin clase ciclos 8 ejercicios*/


        /*Inicio clase matriz sobrecarga de operadores*/
        public class SobrecargaOperadores
    {

        //Inicio 
        //Fin
    }
    /*Fin clase matriz sobrecarga de operadores*/











}
