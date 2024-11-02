internal class Program
{
  
    private static void Main(string[] args)
    {

        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("10S =  10 segundos");
        Console.WriteLine("1M = 1 minuto");
        Console.WriteLine("0 S/M --  Fechar cronometro");
        Console.WriteLine("Quanto tempo deseja cronometrar");
        string tempo_do_udusrio = Console.ReadLine().ToLower();
        char tipo = char.Parse(tempo_do_udusrio.Substring(tempo_do_udusrio.Length - 1, 1));
        int tempo = int.Parse(tempo_do_udusrio.Substring(0, tempo_do_udusrio.Length - 1));
        int multiplicador = 1;

        if (tipo == 'm')
        {
            multiplicador = 60;
        }
        if (tempo == 0)
        {
            System.Environment.Exit(0);
        }

        CountDown(tempo * multiplicador);


    }


    static void CountDown(int tempo)

    {
        Console.Clear();
        Console.Write("...");
        Thread.Sleep(1000);
        Console.Clear();
        Console.Write("..");
        Thread.Sleep(1000);
        Console.Clear();
        Console.Write(".");
        Thread.Sleep(1000);
        Temporizador(tempo);

    }
    static void Temporizador(int tempo)
    {


        for (; tempo >= 0; tempo--)
        {
            Console.Clear();
            Console.WriteLine(tempo);
            Thread.Sleep(1000);


        }

        Console.WriteLine("Contagem finalizada");
        Thread.Sleep(2500);
        Menu();
    }
}