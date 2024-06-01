using System;

public class Class1
{
	public Class1()
	{
        // investiga flujo de ejecucion



        // otro tema readline, pedir informacion al usuario por medio de la terminal

        string nombreCliente;
        Console.WriteLine("Como te llamas ?");
        nombreCliente = Console.ReadLine();

        // saludando al usuario que puso su nombre

        Console.WriteLine("Hola " + nombreCliente);
    }
}
