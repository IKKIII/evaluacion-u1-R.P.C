using System;

class Program
{
    static void Main(string[] args)
    {
       
        Padre padre = new Padre("gael", 45, "Ingeniero");
        padre.ImprimirInfo();
        padre.Trabajar();

     
        Hijo hijo = new Hijo("aldrin", 20, "Estudiante", 1.75);
        hijo.ImprimirInfo();
        hijo.Comer();

      // haha jhona 
        Nieto nieto = new Nieto("jhona XD", 5, "pisteador", 2.10, "Soltero y viudo a la vez");
        nieto.ImprimirInfo();
        nieto.Dormir();
        nieto.ImprimirInfo();
    }
}