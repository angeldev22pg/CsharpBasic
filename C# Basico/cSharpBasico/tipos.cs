using System;

public class Class1
{
	public Class1()
	{
        //tipos de datos
        //en C# se le asigna el tipo de dato que almacena la variable como declarador
        //Declaración de variables :
        //tipo de dato, identificador o nombre de una variable, asignacion, valor y ;
        //long,short,byte,float,decimal tambien son tipos de datos pero hay que estudiarlos

        // variables de Tipo string
        string Nombre = "Juan"; // esta almacena valores de texto
        char inicial = 'J'; //el carapter declarado se pone dentro de comillas simples

        //variables tipo numericos
        int Edad = 20;
        double Peso = 70.5;//numericos con decimales
        bool EsEstudiante = true;       //!muy utilizado

        //a los declaradores float y decimal hay que agregarle una letra al final
        //para que el compilador entienda que tipo de dato le estas poniendo

        decimal primeraNumeracion = 58.59m;  //decimal presicion De 28-29 dígitos aproximadamente
        float otraNumeracion = 7.0f;  //float presicion De De 6 a 9 dígitos aproximadament


        Console.WriteLine("Edad: " + Edad); // imprir

        // datos primitivos o primarios


        //diga sus datos en variables e imprimelas en pantalla          **practica**
        int edad = 23;
        string nombre = "Angel Paredes";
        double estatura = 5.9;
        bool estudiante = true;

        Console.WriteLine(edad);
        Console.WriteLine(nombre);
        Console.WriteLine(estatura);
        Console.WriteLine(estudiante);
    }
}
