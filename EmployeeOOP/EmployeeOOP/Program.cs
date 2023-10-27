﻿//Ubicaciónde clases a utilizar.
using EmployeeOOP.Classes;


// See https://aka.ms/new-console-template for more information
Console.WriteLine("OOP  APLICATION!");
Console.WriteLine("----------------");

//Recordemos que la clase program.cs es la primera que se ejectuta.

try
{
    //Declaración de variables
    int day, month, year;

    Console.WriteLine("OOP APPLICATION");
    Console.WriteLine("---------------");

    Console.Write("Ingresar el día: ");
    day = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el mes: ");
    month = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el año: ");
    year = Convert.ToInt32(Console.ReadLine());

    //Inicialización de la clase Date
     Date dateObject = new Date(day, month, year);
    Console.WriteLine("\n");
    Console.WriteLine(dateObject.ToString()); // así imprimo el objeto para poder verlo. 
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message); // desde acá controlo las excepciones
}

