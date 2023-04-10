

//Mostramos como ejecutar multiples hilos 

public class EjemploHilo03
{

    private static bool ejecutar = true; 
    public static void Main()
    {
        int n = 0;
        //Aqui estamos creando multiples hilos 
        for (int i =0; i<8; i++)
        {
            Thread miHilo = new Thread(Mensaje);
            miHilo.Start(i);
      
        }


        while (ejecutar)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Mensaje desde el main {0}",n);
            n++;
                if (n==250)
            {
                ejecutar= false;

            }

        }
    }

    private static void Mensaje(object? obj)
    {
        int n = 0; 
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Mensaje desde mi hilo {0}-{1}", obj,n);

        n++;


    }
}

