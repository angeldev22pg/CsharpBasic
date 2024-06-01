using System;

public class Class1
{
	public Class1()
	{
        //cuando una estructura de control lleva mas de 2 else if o condiciones lo recomendable es
        // un switch porque hace ver tu codigo mas limpio  y organizado


        //ejemplo principal
        int dia = 3;

        switch (dia)
        {
            case 1:
                Console.WriteLine("Lunes");
                break;
            case 2:
                Console.WriteLine("Martes");
                break;
            case 3:
                Console.WriteLine("Miercoles");
                break;
            case 4:
                Console.WriteLine("Jueves");
                break;
            case 5:
                Console.WriteLine("Viernes");
                break;
            case 6:
                Console.WriteLine("Sabado");
                break;
            case 7:
                Console.WriteLine("Domingo");
                break;
            default:
                Console.WriteLine("No es un dia de la semana");
                break;
        }
    }
}
