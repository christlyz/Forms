using System;

class Aulas
{
    static void Main()
    {
        Inicio:
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

                break;
        }
    }
}