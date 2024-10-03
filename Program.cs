using System;

public class Program
{
    public static void Main()
    {
        int boia1, boia2, boia3;
        bool valvulaLigada, bombaLigada;
        Console.WriteLine("Informe o estado da boia 1 (0 ou 1): ");
        boia1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o estado da boia 2 (0 ou 1): ");
        boia2 = int.Parse(Console.ReadLine());
          
        Console.WriteLine("Informe o estado da boia 3 (0 ou 1): ");
        boia3 = int.Parse(Console.ReadLine());
        if (boia1 == 0 || boia2 == 0 || boia3 == 0)
        {
            Console.WriteLine("Ligar válvula e deligar a bomba.");
        }

        else if (boia1 == 0 || boia2 == 0 || boia3 == 1)
        {
            Console.WriteLine("Ligar válvula e desligar bomba.");
        }

        else if (boia1 == 0 || boia2 == 1 || boia3 == 0)
        {
            Console.WriteLine("Falha na válvula ou na bomba.");
        }
        else if (boia1 == 0 || boia2 == 1 || boia3 == 1 )
        {
            Console.WriteLine("Falha na válvula ou na bomba.");
        }

        else if(boia1 == 1 || boia2 == 0 || boia3 == 0)
        {
            Console.WriteLine("Ligar válvula e ligar bomba.");
        }

        else if(boia1 == 1 || boia2 == 0 || boia3 == 1)
        {
            Console.WriteLine("Ligar válvula e desligar bomba.");
        }
