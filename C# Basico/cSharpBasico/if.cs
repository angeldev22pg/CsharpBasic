using System;

public class Class1
{
	public Class1()
	{
        //el codigo entre llaves () se ejecuta siempre que la condicion es verdadera
        //el if puede existir solo pero el else y el else-if no pueden existir sin un if
        //cuando una condicional lleva mas de 2 else if o condiciones lo recomendable es-
        // un switch porque hace ver tu codigo mas limpio  y organizado.

        int estudiante = 18;


        if (estudiante >= 18)
        {
            Console.WriteLine("felicidades eres un estudiante");
        }



        //ejemplo con un ejercicio  *******


        /*
                         diferentes precios de zapatos 77
            2
            // Si
            compro un zapato quiero que aplique los siguientes descuen
            3
            11 A
            si es mayor a 200 un descuento de 15 peso
            4
            11 B
            si es igual a 150 menor o igual aplicar un 10 peso
            5
            // c)
            De lo contrario no aplicar desuento

         */


        int precioZapato = 700;

        if (precioZapato > 200)
        {
            Console.WriteLine("tienes un descuento de 15 pesos");

        }

        else if (precioZapato <= 150)
        {

        }
        else

        {

        }

        // nota debemos hacer este ejercicio en diferentes estructuras de control como
        //en switch entre otras si es posible
    }
}
