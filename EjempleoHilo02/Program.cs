
public class EjemploHilo02
{
   
    public static void Main()
    {
        //Instanciamos el onjeto thread/ hilo y 
        // colocamos el delegado que corresponde 

        //Thread miHilo = new Thread(Mensaje);
        //miHilo.Start();
        //Console.ForegroundColor = ConsoleColor.Red;
        //Console.WriteLine("Mensaje desde mi main");
        Thread miHilo02 = new Thread(MensajeConParametro);
        miHilo02.Start(5);   
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Mensaje desde el main");
        


    }
    //Creamos el metodo que se ejecutará en el segundo hilo 
    //Debe coincidir con el delegado 
    private static void Mensaje(object? obj)
    {
       Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Mensaje desde mi segundo hilo ");
    }

    //Este metodo se ejecutara en el segundo hilo 
    //Y recibe un parametro del exterior 

    private static void MensajeConParametro(object? obj)
    {
        int p = Convert.ToInt32(obj);
        Console.ForegroundColor= ConsoleColor.Yellow;
        Console.WriteLine("Mensaje con parametro {0} {1}", p,p*2);


    }


}

