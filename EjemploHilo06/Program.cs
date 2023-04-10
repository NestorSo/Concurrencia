

public class Ejemplo06
{

    //la prioridad del hilo determina cuanto tiempo de
    //ejecucion va a recibir con relacion a los otros hilos 
    //Solo es importante cuando tenemos multiples hilos
    //activos . puede tener los valores: 
    //lowest, BlowNormal, Normal, AboveNormal,Highest


    private static bool ejecutar1 = true;
    private static int conteo1 = 0;

    private static bool ejecutar2 = true;
    private static int conteo2 = 0;

    public static void Main()
    {
        Thread hilo1 = new Thread(Incremento1);
        hilo1.Priority = ThreadPriority.Lowest;
        hilo1.Start();

        Thread hilo2 = new Thread(Incremento2);
        hilo2.Priority = ThreadPriority.Highest;
        hilo2.Start();
    }

    private static void Incremento2(object? obj)
    {
        while (ejecutar2)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            conteo2++;
            Console.WriteLine("H{0}", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine(" -> {0}", conteo2);

            if (conteo1 > 1000)
            {
                ejecutar1 = false;
                ejecutar2 = false;

            }
            Thread.Sleep(1000);
        }
       

    }

    private static void Incremento1(object? obj)
    {
        while (ejecutar1)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            conteo1++;
            Console.WriteLine("l {0}",Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine(" -> {0}", conteo1);

            if(conteo1 > 1000)
            {
                ejecutar1=false;
                ejecutar2=false;

            }
            Thread.Sleep(1000);
        }
       
    }
}


