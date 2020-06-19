using System;

namespace Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            [console: Bhaskara] Calcule as raízes de uma equação de segundo grau, utilizando o método de Bhaskara.
            Uma equação do segundo grau é dada pela expressão abaixo:

            Assim, devemos receber do usuário os valores de a, b e c, e aplicar a fórmula de Bhaskara:

            Dicas:
            Precisamos validar se o valor de a não é zero, porque nesse caso a equação não é do segundo grau.
            Calculamos o discriminante Δ (delta):

            Como a raiz quadrada de um número negativo não é um número real, precisamos validar se Δ não é negativo.
            Depois, é só calcular e exibir as duas raízes:


            Exemplo 1 (a == 0):
            -- Equação do segundo grau --
            (a): 0
            (b): 2
            (c): 5

            Não é uma equação de segundo grau!
            Exemplo 2 (Δ < 0):
            -- Equação do segundo grau --
            (a): 1
            (b): 2
            (c): 3

            Como delta = -8,00, a equação não possui raízes reais!
            Exemplo 3:
            -- Equação do segundo grau --
            (a): 1
            (b): 2
            (c): -3

            x1 = 1,00 e x2 = -3,00
            */

            double A;
            double B;
            double C;
            double Valorx1;
            double Valorx2;
            double ValorDelta;

            Console.WriteLine("Olá usuário irei ajuda-lo a caulcular sua fórmula de Bhaskara");

            Console.Write("Digite o valor de A...:");
            A = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor de B...:");
            B = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor de C...:");
            C = Convert.ToDouble(Console.ReadLine());

            // Agora vamos verificar se o valor de A é igual a 0, pois caso seja, a equação não é de segundo grau.

            if (A == 0)
            {
                Console.WriteLine("Ops... parece que sua equação não é de segundo grau, pois o valor de A é igual a 0");
                Environment.Exit(-1);
            }

            // É necessário coocar 2 iguais (==) para que não seja confundido com a função de armazenar algo.

            ValorDelta = (B*B) - (4*A*C);

            // Acima temos a equação, caso o delta tenha valor é refetente a u valor positivo.

            if (ValorDelta <0)
            {
                Console.Write("Ops... o valor de delta é negativo, a equação não poderá ser calculada");
                Environment.Exit(-1);
            }

            Valorx1 = (-B + Math.Sqrt(ValorDelta)) / (2 * A);

            Valorx2 = (-B - Math.Sqrt(ValorDelta)) / (2 * A);

            // Acima temos a segunda parte da equação..

            Console.WriteLine($"O valor de X1 é = {Valorx1} e o valor de X2 = {Valorx2}");
        }
    }
}
