using System;
public class Program
{
    public static void Main(String[] args)
    {
        const int oportunidadesTotales = 3;
        int numero;
        var generadorAleatorio = new Random();
        int numeroParaAdivinar = generadorAleatorio.Next(0, 16);
        Console.WriteLine(@"El número aleatorio está comprendido entre el 0 y el 15.
        Tiene tres oportunidades para adivinar el número aleatorio");
        int numeroOportunidadesQueLleva = 1;
        do
        {
            Console.WriteLine("Introduzca un número");
            numero = Int32.Parse(Console.ReadLine());
            if (numero == numeroParaAdivinar)
            {
                Console.WriteLine("¡ENHORABUENA!. Has adivinado el número");
            }
            else 
            {
                if (numero > numeroParaAdivinar)
                 {
                    Console.WriteLine("El número a adivinar es menor que el número introducido");
                    numeroOportunidadesQueLleva++;
                 }
                 
                 else if (numero < numeroParaAdivinar)
                 {
                    Console.WriteLine("El número a adivinar es mayor que el número introducido");
                    numeroOportunidadesQueLleva++;
                 }
                 
            }
        } while(numeroOportunidadesQueLleva <= oportunidadesTotales && numero != numeroParaAdivinar);

        if ( numeroOportunidadesQueLleva >= oportunidadesTotales && numero != numeroParaAdivinar)
        {
            Console.WriteLine("Perdiste, se acabaron los 3 intentos");
            Console.WriteLine($"El numero a adivinar era {numeroParaAdivinar}");
        }
    }
}
