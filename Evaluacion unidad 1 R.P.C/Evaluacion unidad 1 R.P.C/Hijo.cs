using System;

public class Hijo : Padre
{
    public double Estatura;

    public Hijo(string nombre, int edad, string ocupacion, double estatura)
        : base(nombre, edad, ocupacion)
    {
        Estatura = estatura;
    }

    public void Comer()
    {
        Console.WriteLine(Nombre + " está comiendo :) ");
    }

    public void ImprimirInfo()
    {
        Console.WriteLine("Nombre: " + Nombre + ", Estatura de mi chavo: " + Estatura + ", Ocupación segun: " + Ocupacion);
    }
}