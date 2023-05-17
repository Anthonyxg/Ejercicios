using System;

 namespace contenedor
 {
    class program
    {
        static void Main (string [] args)
        {
            Console.Write("Ingrese un dato:");
            int entrada = int.Parse(Console.ReadLine());

            while (entrada != 99)
            {
                Console.WriteLine("Muestre en pantalla: "+entrada);
                
                Console.Write("Ingrese un dato: ");
                entrada = int.Parse(Console.ReadLine());
            }
        }
    }
 }