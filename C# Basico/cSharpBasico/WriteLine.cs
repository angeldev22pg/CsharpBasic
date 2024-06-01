using System;

public class Class1
{
	public Class1()
    {
        // investiga flujo de ejecucion

        // mostrando valores en consola.
        Console.WriteLine("esto es un valor de texto");
        Console.WriteLine(25);
        int definicion = 58;
        char letra = 'b';
        Console.WriteLine(definicion);
        Console.WriteLine(definicion + letra);

        /* 
         las cadenas interpoladas

        te permiten crear cadena de textos con valores de 
        variables incrustados de una manera más sencilla y legible. 
        Esto hace que el código sea más fácil de entender y mantener.

        example
         */

        int edad4 = 29;
        double estatura = 70.5;

        Console.WriteLine($"Hola pedro tienes {edad4} anos de edad y {estatura}" +
            $" de estatura");
        // en la primera le dimos enter para bajar a la 2da linea

        Console.WriteLine($"juan tiene {edad4} y mide {estatura}");
        //

        /*las cadenas de formato 

        una cadena de formato es una herramienta que te permite crear cadenas de texto de una manera 
        estructurada y dinámica. En lugar de concatenar manualmente valores de variables a una cadena, 
        puedes utilizar una cadena de formato para definir un patrón con marcadores de posición, 
        y luego llenar esos marcadores con los valores de las variables. 

        osea establecer una lista de variables y llamarlas por indice, recuerda que la 1ra variable
        seria la numero 0 = {0} 


         */

        string mensaje3 = string.Format("hola {0} {1} {2} {3}", libros1s, estatura, definicion, edad4);
        Console.WriteLine(mensaje3);

        //o solo imprimiendo en consola

        Console.WriteLine("hola aqui tengo los numero {1}", estatura, libros1s, libros1s);

        // diferencias

        /* si te fijas las cadenaas interpoladas usan el signo $*/
        /*las cadenas de formato no usan $ y usa indices de la lista de variables segun el orden comenzando desde 0*/


        // configuracion para que las letras del IDE se extiendan o disminuyan segun el tama;o de la pestana
        /*
         * herramientas
         * opciones
         * editor de texto
         * todos los lenguajes
         * ajuste de lineas
         * mostrar glifos de lineas visuales para ajuste de lineas
         */

        /* operador de acceso a miembros punto . este te permite acceder a los miembros de una clase (los metodos)
         * son miembros de la clase, ej la clase Console/ el operador . y el metodo Write = Console.Write
        */


        // nota si sumamos un numero flotante la variable que almacene la respuesta debe ser de punto flotante
        double suma = 3.58;
        double resultadow = 24 + suma;
        Console.WriteLine(resultadow);
        // ahora vamos a intentar sumar strings que se le llama concatenar o sumar a las cadenas
        string namepeople = "Angel";
        string namepeople1 = "Paredes";
        Console.WriteLine(namepeople + namepeople1);
        // maneras de ponerle un espacio al name
        Console.WriteLine(namepeople1 + " " + namepeople1);// esta es la manera practica
        Console.WriteLine(namepeople1 + " " + namepeople1 + "Como estas ?");
        // la otra "Angel "   o  " Paredes"
    }
}
