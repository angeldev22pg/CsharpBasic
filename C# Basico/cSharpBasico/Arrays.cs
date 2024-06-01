using System;

public class Class1
{
	public Class1()
	{
        /**
             * tipo de dato que va a almacenar el array en su interior
             * llaves de []    //estos corchetes indican al IDE que se trata de un array
             * nombre del array
             */
        // declaracion de un array

        int[] numeros;

        //iniciacion
        /*
         * nombre del array
         * =
         * operador new
         * se repite el tipo de dato del array en este caso int seguido de []
         * con la cantidad de valores que va a almacenar en su interior
         */

        numeros = new int[10];  //aqui vamos a almacenar 10  numeros enteros en este array

        //deckaracion e iniciacion en la misma linea

        int[] numeros1 = new int[10]; // se le cambio el nombre de la variable porque la
                                      //otra ya estaba declarada
    }
}
