using System;
class Program
{
    static void Main()
    {
        string nome = Console.ReadLine();
        double quilometrosPorDia = double.Parse(Console.ReadLine());
        int horasDeEletronicos = int.Parse(Console.ReadLine());
        int refeicoesComCarne = int.Parse(Console.ReadLine());

        double pegadaDeCarbono = CalcularPegadaDeCarbono(quilometrosPorDia, horasDeEletronicos, refeicoesComCarne);

        Console.WriteLine(nome + ", sua pegada de carbono e de " + pegadaDeCarbono + " toneladas de CO2 por ano.");
        Console.ReadLine();
    }

    static double CalcularPegadaDeCarbono(double quilometrosPorDia, int horasDeEletronicos, int refeicoesComCarne) 
    {
        double result = 0.0;
        double hEletronicos = 0.0;
        double rComCarne = 0.0;

        quilometrosPorDia = quilometrosPorDia * 365 * 0.2;
        hEletronicos = horasDeEletronicos * 0.1;
        rComCarne = refeicoesComCarne * 0.5;

        result = quilometrosPorDia + hEletronicos + rComCarne;

        return result;
    }
}