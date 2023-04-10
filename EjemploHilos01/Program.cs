Thread t = new Thread(new ThreadStart(ThreadProc));
    t.Start();


//Instanciamos el objeto thread 7hilo y colocamos el delegado correspondiente
Thread miHilo = new Thread(Saludos);
miHilo.Start();

//Forma de pasar datos al hilo 
Thread miOtroHilo = new Thread(MiMensaje);
miOtroHilo.Start(5);

for(int i = 0; i < 4; i++)
{

    Console.WriteLine("Main thread : do some work ");
    Thread.Sleep(1000);
}
static void ThreadProc()
{
    for (int i=0; i<10; i++)
    {
        Console.WriteLine("ThreadProc : {0} ",i );
        Thread.Sleep(1000);
    }


}

//creamos el método que se ejecutara en el segundo hilo 
//Debe coincidir con el delegado 
static void Saludos(object obj)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Saludo desde el hilo");

}
//Este metodo se ejecutara en el segundo hilo 
//Y recibe un parametro del exterior

static void MiMensaje(object obj)
{
    int n= Convert.ToInt32(obj);
    Console.ForegroundColor= ConsoleColor.Red;
    Console.WriteLine("Saludos desde mi mensaje {0}, {1}", n, n*2);
}