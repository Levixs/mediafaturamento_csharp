using System;

namespace Faturamento
{
    class Program
    {
        static void Main(string[] args)
        {
            // faturamento mensal por estado conforme informado na questão
            double SP = 67836.43;
            double RJ = 36678.66;
            double MG = 29229.88;
            double ES = 27165.48;
            double OUT = 19849.53;

            // calcula o total do faturamento mensal somando o faturamento de todos os estados informados
            double total = SP + RJ + MG + ES + OUT;

            // calcula o percentual de representação de cada estado, obtendo o faturamento do estado e divigindo pelo total do faturamento para saber quanto ele representa sobre o fat.total
            // multiplica por 100 para obter o percentual formatado
            double percSP = (SP / total) * 100;
            double percRJ = (RJ / total) * 100;
            double percMG = (MG / total) * 100;
            double percES = (ES / total) * 100;
            double percOutros = (OUT / total) * 100;

            // exibe o resultado com porcentagem no final já que anteriormente já foi multiplicado por 100
            Console.WriteLine("Percentual de representação por estado:");
            Console.WriteLine("São Paulo: " + percSP.ToString("F2") + " %");
            Console.WriteLine("Rio de Janeiro: " + percRJ.ToString("F2") + " %");
            Console.WriteLine("Minas Gerais: " + percMG.ToString("F2") + " %");
            Console.WriteLine("Espirito Santo: " + percES.ToString("F2") + " %");
            Console.WriteLine("Outros: " + percOutros.ToString("F2") + " %");

            Console.ReadKey();
        }
    }
}
