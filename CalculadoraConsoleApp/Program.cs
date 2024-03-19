using System.Globalization;

namespace calculadora;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            int operacao = MostrarMenu();

            if (OpcaoSaidaSelecionada(operacao))
            {
                break;
            } else if (OpcaoValida(operacao))
            {
                MensagemDeErro();
                continue;
            } else
            {
                RealizarCalculo(operacao);
            }
        }
    }


    static int MostrarMenu()
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

        return operacao;
    }

    static bool OpcaoSaidaSelecionada(int operacao)
    {
        bool opcaoSaidaSelecionada = operacao == 5;
         
        return opcaoSaidaSelecionada;
    }

    static bool OpcaoValida(int operacao)
    {
        bool opcaoValida = operacao > 5 || operacao < 1;

        return opcaoValida;
    }
    static void MensagemDeErro()
    {
        Console.WriteLine("Por favor digite uma opção válida!!!");
        Console.WriteLine("Digite qualquer tecla para continuar... ");
        Console.ReadKey();
    }
    private static double ObterValorNumerico(string texto)
    {
        Console.WriteLine(texto);
        return double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    }
    private static void RealizarCalculo(int operacao)
    {
        double primeironumero = ObterValorNumerico("Digite o primeiro número: ");
        double segundonumero = ObterValorNumerico("Digite o segundo numero: ");

        double resultado = 0;

        switch (operacao)
        {
            case 1:
                resultado = primeironumero + segundonumero;
                break;
            case 2:
                resultado = primeironumero - segundonumero;
                break;
            case 3:
                resultado = primeironumero * segundonumero;
                break;
            case 4:
                if (segundonumero == 0)
                {
                    Console.WriteLine("Não é possível dividir um número por zero");
                    Console.WriteLine("Digite qualquer tecla para continuar...");
                    Console.ReadKey();
                    //continue;
                }
                else
                {
                    resultado = primeironumero / segundonumero;
                }
                break;
            default:
                Console.WriteLine("Por favor digite uma opção válida!!! ");
                break;
        }

        MostrarResultados(resultado);


    }

    static void MostrarResultados(double resultado)
    {
        Console.WriteLine("O resultado é " + resultado.ToString("F2", CultureInfo.InvariantCulture));

        Console.WriteLine("Digite qualquer tecla para continuar...");
        Console.ReadKey();
    }
}
