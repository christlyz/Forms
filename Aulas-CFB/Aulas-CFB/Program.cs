using System;

class Aulas
{
    static void Main()
    {
        int aula;
        aula = int.Parse(Console.ReadLine());

        switch (aula)
        {
            case 19:
                int[] num = new int[10];

                for (int i = 0; i < num.Length; i++)
                {
                    num[i] = 0;
                }

                for (int i = 0; i < num.Length; i++)
                {
                    Console.WriteLine("valor de num na pos{0}: {1}", i, num[i]);
                }
                break;

            case 20:
                int contadorWhile = 0;
                while (contadorWhile < 10)
                {
                    Console.WriteLine("O valor do contador é: {0}", contadorWhile);
                    contadorWhile++;
                }
                Console.WriteLine("Fim do loop");
                break;

            case 21:
                string senha = "123";
                string senhauser;
                int tentativas = 0;

                do
                {
                    Console.Clear();
                    Console.WriteLine("Digite a senha: ");
                    senhauser = Console.ReadLine();
                    tentativas++;
                } while (senha != senhauser);
                Console.WriteLine("Senha Correta!\nTentativas: {0}", tentativas);
                break;

            case 22:
                int[] numForEach = new int[5] { 11, 22, 33, 44, 55 };
                foreach (int n in numForEach)
                {
                    Console.WriteLine(n);
                }
                break;

            case 23:
                int[] vetor1 = new int[5];
                int[] vetor2 = new int[5];
                int[] vetor3 = new int[5];
                int[,] matriz = new int[2, 5] { { 11, 22, 00, 44, 55 }, { 66, 77, 88, 99, 00 } };
                
                Console.WriteLine("Random");

                Random random = new Random();
                for (int i = 0; i < vetor1.Length; i++)
                {
                    vetor1[i] = random.Next(50);
                }

                Console.WriteLine("Elementos do vetor1: ");
                foreach(int n in vetor1)
                {
                    Console.WriteLine(n);
                }
                Console.WriteLine("-------------------------------------------");

                //public static int BinarySearch(array,valor);
                Console.WriteLine("BinarySearch");
                int procurado = 33;
                int pos = Array.BinarySearch(vetor1, procurado);
                Console.WriteLine("Valor {0} está na posição {1}", procurado, pos);
                Console.WriteLine("-------------------------------------------");

                //public static void Copy(Ar_origem, Ar_destino, qtde_elementos);
                Console.WriteLine("Copy");
                Array.Copy(vetor1, vetor2, vetor2.Length);
                foreach(int n in vetor2)
                {
                    Console.WriteLine(n);
                }
                Console.WriteLine("-------------------------------------------");

                //public void CopyTo(Ar_destino, a_partir_desta_pos);
                Console.WriteLine("CopyTo");
                vetor1.CopyTo(vetor3, 0);
                foreach(int n in vetor3)
                {
                    Console.WriteLine(n);
                }
                Console.WriteLine("-------------------------------------------");

                //public long GetLongLenght(dimensao);
                Console.WriteLine("GetLongLenght");
                long qtdeElementosVetor = vetor1.GetLongLength(0);
                Console.WriteLine("Quantidade de elementos {0}", qtdeElementosVetor);
                Console.WriteLine("-------------------------------------------");

                //public int GetLowerBound(dimensao);
                Console.WriteLine("GetLowerBound");
                int MenorIndiceVetor = vetor1.GetLowerBound(0);
                int MenorIndiceMatriz = matriz.GetLowerBound(1);
                Console.WriteLine("Menor índice do vetor1 {0}\nMenor índice Matriz {1}", MenorIndiceVetor, MenorIndiceMatriz);
                Console.WriteLine("-------------------------------------------");

                //public int GetUpperBound
                Console.WriteLine("GetUpperBound");
                int MaiorIndiceVetor = vetor1.GetUpperBound(0);
                int MaiorIndiceMatriz_D1 = matriz.GetUpperBound(1);
                Console.WriteLine("Maior índice do vetor1 {1}\nMenor índice Matriz {1}", MaiorIndiceVetor, MaiorIndiceMatriz_D1);
                Console.WriteLine("-------------------------------------------");

                //public object GetValue(long índice);
                Console.WriteLine("GetValue");
                int valor0 = Convert.ToInt32(vetor1.GetValue(3));
                int valor1 = Convert.ToInt32(matriz.GetValue(1,3));
                Console.WriteLine("Valor da posição 3 do vetor1: {0}\nValor da posição 3 dimensão 1 da matriz: {1}", valor0, valor1);
                Console.WriteLine("-------------------------------------------");

                //public static int IndexOf(array, valor);
                Console.WriteLine("IndexOf");
                int indice1 = Array.IndexOf(vetor1, 3);
                Console.WriteLine("Indice do primeiro valor 3: {0}", indice1);
                Console.WriteLine("-------------------------------------------");

                //public static int LastIndexOf(arra, valor);
                Console.WriteLine("LastIndexOf");
                int indice2 = Array.LastIndexOf(vetor1, 3);
                Console.WriteLine("Indice do último valor 3: {0}", indice2);
                Console.WriteLine("-------------------------------------------");

                //public static void Reverse(array);
                Console.WriteLine("Reverse");
                Array.Reverse(vetor1);
                foreach(int n in vetor1)
                {
                    Console.WriteLine(n);
                }
                Console.WriteLine("-------------------------------------------");

                //public void SetValue(object valor, long pos);
                Console.WriteLine("SetValue");
                vetor2.SetValue(99, 0);
                for(int i = 0; i < vetor2.Length; i++)
                {
                    vetor2.SetValue(0,i);
                }
                Console.WriteLine("Vetor 2");
                foreach (int n in vetor2)
                {
                    Console.WriteLine(n);
                }
                Console.WriteLine("-------------------------------------------");

                //public static void Sort(array);
                Console.WriteLine("Sort");
                Array.Sort(vetor1);
                Array.Sort(vetor2);
                Array.Sort(vetor3);

                Console.WriteLine("Vetor1");
                foreach(int n in vetor1)
                {
                    Console.WriteLine(n);
                }

                Console.WriteLine("\nVetor2");
                foreach(int n in vetor2)
                {
                    Console.WriteLine(n);
                }

                Console.WriteLine("\nVetor3");
                foreach(int n in vetor3)
                {
                    Console.WriteLine(n);
                }
                break;
        }
    }
}