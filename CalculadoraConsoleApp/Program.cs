using System.Globalization;

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.Clear();

                Console.WriteLine("-- Calculadora Tabajara 2024 --");
                Console.WriteLine();
                Console.WriteLine("[ 1 ] Somar");
                Console.WriteLine("[ 2 ] Subtrair");
                Console.WriteLine("[ 3 ] Multiplicar");
                Console.WriteLine("[ 4 ] Dividir");
                Console.WriteLine("[ 5 ] Sair do sistema");
                Console.Write("->");

                int operacao = int.Parse(Console.ReadLine());

                if (operacao == 5)
                {
                    Console.WriteLine("Encerrando programa...");
                    break;
                } 

                if (operacao > 5 || operacao < 1)
                {
                    Console.WriteLine("Por favor digite uma opção válida!!!");
                    Console.WriteLine("Digite qualquer tecla para continuar... ");
                    Console.ReadKey();
                    continue;
                }

                Console.WriteLine("Digite o primeiro numero: ");
                double primeironumero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Digite o segundo numero: ");
                double segundonumero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado = 0;

                if (operacao == 1)
                {
                    resultado = primeironumero + segundonumero;

                } else if (operacao == 2) 
                {
                    resultado = primeironumero - segundonumero;
                } else if (operacao == 3) 
                {
                    resultado = primeironumero * segundonumero;
                } else if(operacao == 4)
                {   
                    if (segundonumero == 0)
                    {
                        Console.WriteLine("Não é possível dividir um número por zero");
                        Console.WriteLine("Digite qualquer tecla para continuar...");
                        Console.ReadKey();
                        continue;
                    } else
                    {
                        resultado = primeironumero / segundonumero;
                    }
                } else
                {
                    Console.WriteLine("Por favor digite uma opção válida!!! ");
                }
           
                Console.WriteLine("O resultado é " + resultado.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine("Digite qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
