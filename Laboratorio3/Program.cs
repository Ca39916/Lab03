using System;

namespace Laboratorio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----exercício 2 -----");
            int[] array = new int[5] { 10, 20, 30, 40, 50 };
            int i;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Indice = " + i + " & Valor = " + array[i]);
                Console.ReadLine();
            }

            Console.WriteLine("-----exercício 4 -----");
            string[] str = new string[3]; int iStr;
            str[0] = "Um";
            str[1] = "Dois";
            str[2] = "Tres";
            for (iStr = 0; iStr < 3; iStr++)
            {
                Console.WriteLine("Indice = " + iStr + " & Valor = " + str[iStr]);
                Console.ReadLine();
            }

            Console.WriteLine("-----exercício 6 -----");
            //aray usando o laço for
            DateTime[] dt = new DateTime[2];
            int iDate;
            dt[0] = new DateTime(2002, 5, 1); 
            dt[1] = new DateTime(2002, 6, 1);
            for (iDate = 0; iDate < 2; iDate++)
            {
               Console.WriteLine("Indice = " + iDate + " & Data = " + dt[iDate].ToShortDateString());
               Console.ReadLine();
            }

            Console.WriteLine("-----exercício 8 -----");
            //aray usando o laço foreach
            DateTime[] dataHora = new DateTime[2];
            dataHora[0] = new DateTime(2002, 5, 1);
            dataHora[1] = new DateTime(2002, 6, 1);
            foreach (DateTime Date in dt)
            {
                Console.WriteLine("Data = " + Date.ToShortDateString());
                Console.ReadLine();
            }

            Console.WriteLine("-----exercício 4.1 -----");
            int[] numeros = new int[5]; //Array com 5 linhas
            numeros[0] = 10;
            numeros[1] = 20;
            numeros[2] = 30;
            numeros[3] = 40;
            numeros[4] = 50;
            int[] numeros2 = new int[5]; // 2 Array com 5 linhas
            int posicao = 0; //variável 
            foreach (int item in numeros)
            {
                numeros2[posicao] = item;
                posicao++;
            }

            foreach (int valor in numeros2)
            {
                Console.WriteLine("Numeros = " + valor);
                Console.ReadLine();
            }

            Console.WriteLine("-----exercício 4.2 -----");
            int[,] matriz = new int[5, 5]; //linha x coluna
            matriz[0, 0] = 1;
            matriz[0, 1] = 2; //0 = linha, 1 = coluna
            matriz[0, 2] = 3;
            matriz[0, 3] = 4;
            matriz[0, 4] = 5;

            matriz[1, 0] = 6;
            matriz[1, 1] = 7;
            matriz[1, 2] = 8;
            matriz[1, 3] = 9;
            matriz[1, 4] = 10;

            matriz[2, 0] = 11;
            matriz[2, 1] = 12;
            matriz[2, 2] = 13;
            matriz[2, 3] = 14;
            matriz[2, 4] = 15;

            matriz[3, 0] = 16;
            matriz[3, 1] = 17;
            matriz[3, 2] = 18;
            matriz[3, 3] = 19;
            matriz[3, 4] = 20;

            matriz[4, 0] = 21;
            matriz[4, 1] = 22;
            matriz[4, 2] = 23;
            matriz[4, 3] = 24;
            matriz[4, 4] = 25;

            int linha = 0;
            int coluna = 0;
            int soma = 0;
            for (coluna = 0; coluna < 5; coluna++) 
            {
                for (linha = 0; linha < 5; linha++) 
                {
                    soma = soma + matriz[coluna, linha];
                }

                Console.WriteLine(soma);
                Console.ReadLine();
                soma = 0;
            }

            //Array jagged
            Console.WriteLine("-----exercício 4.2 -----");
            //uma matriz de valores inteiros
            int[][] jagged = new int[5][];
            //Inicialize os elementos
            jagged[0] = new int[] {1,6,11,16,21};
            jagged[1] = new int[] {2,7,12,17,22};
            jagged[2] = new int[] {3,8,13,18,23};
            jagged[3] = new int[] {4,9,14,19,24};
            jagged[4] = new int[] {5,10,15,20,25};


            // Exibir os elementos da matriz:
            for (coluna = 0; coluna < jagged.Length; coluna++)
            {
             
                for (linha = 0; linha < jagged[coluna].Length; linha++)
                {
                    soma = soma + jagged[linha][coluna];
                }

                Console.WriteLine(soma);
                Console.ReadLine();
                soma = 0;
            }
            
        }
    }
}
