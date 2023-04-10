

//foregorun thread son hilos que siguyen existiendo, aun asi
// la aplicacion termina de ejecutar el main
//Pueden evitar que ola aplicacion termine

//Background threads son hilos que se finalizan si la aplicaciion termina de ejecutar el main 


public class EjemploHilo04
{

    private static bool ejecutar = true;
    public static void Main()
    {
        int n = 0;
        //de esta forma creamos un hilo que es backGround thread 
        Thread miHilo = new Thread(new ThreadStart(Mensaje));
        miHilo.IsBackground = true;
        miHilo.Start();

        while (ejecutar)
        {


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Mensaje desde el hilo principal {0}", n);
            n++;

            if (n == 25)
            {
                ejecutar = false;

            }
        }
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Salimos del main");

    }

    private static void Mensaje()
    {
        int n = 0;
        bool ejecutarMiMensaje = true;

        while (ejecutarMiMensaje)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Mensaje desde el hilo {0}",n);
            n++;

                if (n > 250)
            {
                ejecutarMiMensaje = false;

            }


        }


    }
}