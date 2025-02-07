using System;

public class Padre
{
    public string Nombre;
    public int Edad;
    public string Ocupacion;

    public Padre(string nombre, int edad, string ocupacion)
    {
        Nombre = nombre;
        Edad = edad;
        Ocupacion = ocupacion;
    }

    public void Trabajar()
    {
        Console.WriteLine(Nombre + " está trabajando como " + Ocupacion + " asi veo a mi chavo en un futuro.");
    }

    public void ImprimirInfo()
    {
        Console.WriteLine("Nombre: " + Nombre + ", Edad: " + Edad + ", Ocupación: " + Ocupacion);
    }
}