using System;

 namespace contenedor
 {
    class program
    {
        static void Main (string [] args)
        {
            Console.Write("Ingrese un dato:");
            string entrada = Console.ReadLine();

            while (entrada != "99")
            {
                Console.WriteLine("Muestre en pantalla: "+entrada);
                
                Console.Write("Ingrese un dato: ");
                entrada = Console.ReadLine();
            }
        }
    }
 }