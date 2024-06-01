using System;

public class Class1
{
	public Class1()
	{
        // estructura de control

        //si compro un zapato quiero que aplique los siguientes descuentos
        /*
         * 1. si es mayor a 200 un descuento de 15 pesos
         * 2. si es menor a 150 y mayor a 50 pesos, aplicar 10 pesos
         * 3. de lo contrario no aplicar descuento
         */
        int precioZapato = 30;

        if (precioZapato >= 200)
        {
            Console.WriteLine("Felicitaciones tienes un descuento de 15 pesos");

        }

        else if (precioZapato < 150 && precioZapato > 50)
        {
            Console.WriteLine("Felicidades tienes un descuento de 10 pesos");

        }
        else

        {
            Console.WriteLine("no te vallas");
            Console.WriteLine("alcanza el minimo de 50 pesos para obtener tu descuento");
        }


        /* practica 2 */

        double a = 20;
        double b = 10;

        if (a == b)
        {
            Console.WriteLine("estos operadores son iguales");
        }


        /*    ******* pendiente hacer el mismo ejercicio utilizando switch ******
        switch (precioZapato)
        {
        }
        */

    }
}
