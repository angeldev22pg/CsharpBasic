using System;

public class Class1
{
	public Class1()
	{

        //operadores aritmeticos
        //si movemos este codigo a Program.cs si se ejecuta correctamente


        int a = 10;
        int b = 5;
        int suma = a + b;
        int resta = a - b;
        int multiplicacion = a * b;
        int division = a / b;
        int modulo = a % b;
        int resul = a + 3 + (a / b) * 2;
        Console.WriteLine("Suma: " + suma);
        Console.WriteLine("Resta: " + resta);
        Console.WriteLine("Multiplicación: " + multiplicacion);
        Console.WriteLine("División: " + division);

        // operadores aritmeticos        Unarios     ,       Binarios



        // los operadores aritmeticos Unarios solo necesitan de un operando para funcionar
        /*   ++ incremento  ,  -- decremento,  + mas  , - menos 

         */


        //operadores aritmeticos Binarios estos necesitan 2 operando para funcionar
        //      + suma,  - resta,   * multiplicacion,  /divicion ,   % modulo o resto

        int suma1 = 10;
        int suma2 = 10;
        int resultado1 = suma1 + suma2 + suma1 + suma1;
        Console.WriteLine(resultado1);
        Console.WriteLine(suma2 + 23);
        Console.WriteLine(10 + 10);
        Console.WriteLine(5 + 8 + 9 + 6 + 5);




        //uando el operador aritmetico de resta -
        Console.WriteLine(50 - 25);

        // usando el operador aritmetico de multiplicacion *
        Console.WriteLine(25 * 3);

        // usando el operador aritmetico de Divicion 

        Console.WriteLine(50 / 3); // si el resultado tiene flotantes hay que ponerle a cualquiera de los 2 divisores un .0 por ejemplo al 50   = 50.0 ejemplo
        Console.WriteLine(50.0 / 3); // o en el caso del 3 = 3.0
                                     // 3 y 3.0 es lo mismo, el cero no vale pero para el compilador es distinto con el .0 el compilador tomara el valor como .flotante y lo pondra de la manera correcta como el ejemplo pasado

        // no se puede dividir entre 0 ej 5 / 0 va a dar un error por el compilador
        // y si se divide 0 /5 va dar = 0
        // es importante saber la presicion de los flotantes 

        /*
         * float 	 	De 6 a 9 dígitos aproximadamente 	4 bytes 	System.Single
         * double 	    De 15 a 17 dígitos aproximadamente 	8 bytes 	System.Double
         * decimal 	 	De 28-29 dígitos 	16 bytes 	System.Decimal
         */

        // usando el operador aritmetico de modulo, residuo o resto
        // lo utilizamos para ver el residuo de una operacion 

        Console.WriteLine(5 % 2);// el residuo



        // practica

        //calcula usando los operadores aritmeticos

        // los platanos son a 17 pesos cuantos son 15 platanos
        int platanos = 17;
        int cantidad = 15;
        Console.WriteLine(platanos * cantidad);

        //Tengo 12 pedazos de pizzas quiero dividir en 4 personas
        int pedazosDePizza = 12;
        int invitados = 4;
        Console.WriteLine(pedazosDePizza / invitados);

        //calcula 27 años mas 10
        int edadEstudiante = 27;
        int aparienciaEdad = 10;
        Console.WriteLine(edadEstudiante + aparienciaEdad);

        //Resta 30 pesos a un pago de 50

        int montoCobrar = 30;
        int pago = 50;
        Console.WriteLine(pago - montoCobrar);



    }
}
