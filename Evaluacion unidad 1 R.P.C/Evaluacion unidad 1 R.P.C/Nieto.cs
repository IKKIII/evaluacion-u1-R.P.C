using System;

public class Nieto : Hijo
{
    public string EstadoCivil;
    public bool EstaDormido;

    public Nieto(string nombre, int edad, string ocupacion, double estatura, string estadoCivil)
        : base(nombre, edad, ocupacion, estatura)
    {
        EstadoCivil = estadoCivil;
        EstaDormido = false; // o falso como dicen los chavos

    }

    public void Dormir()
    {
        EstaDormido = true;
        Console.WriteLine(Nombre + " está mimiendo");
        EstaDormido = false;
        Console.WriteLine(Nombre + " ya mandenlo a mimir >:v");
    }

    public void ImprimirInfo()
    {
        Console.WriteLine("Nombre: " + Nombre + ", Edad: " + Edad + ", Estado Civil: " + EstadoCivil + ", Ocupación: " + Ocupacion + ", ¿Está dormido? segun mi ojito: " + EstaDormido);
    }
}