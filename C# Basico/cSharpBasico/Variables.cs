using System;

public class Class1
{
	public Class1()
	{
        //                          notaciones variables
        //notacion pascal = NotacionPascalCadaLetraMayuscula incluyendo la inicial
        // camel case = para variables todasMenosLaInicial

        //las variables que no sean inicializadas con un valor Visual Studio le asigna 0 
        //int = 0, bool = false, char = (un espacio vacio)


        // tipo Declaración explícita de tipo
        int libros;
        int revistas;
        int testamentos;
        int articulos;
        string nombre;
        string apellido;
        string ciudad;

        // De otra manera
        int libros1, revistas2, testamentos3, articulos4;
        string nombre1, nombre2, nombre3, nombre4, nombre5, nombre6;
        int libros1s = 23, revistas2s = 58, testamentos3s = 85, articulos4s = 74;


        //Inicialización de variables al momento de la declaración

        string tituloDelLibro = "Santa Biblia";
        int seDivideEn = 2;

        //Inicialización de variables en múltiples líneas

        int numero;
        numero = 10;

        // Inicialización condicional: Puedes inicializar una variable basada en una condición.

        int numero7 = (condicion) ? valorVerdadero : valorFalso;  //esta tengo que estudiarla
    }
}
