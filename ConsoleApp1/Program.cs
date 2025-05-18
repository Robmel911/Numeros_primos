using System;
class Program
{
    static void Main(string[] args)
    {
        int a = 1;
        int numero;
        bool primo;
        Console.WriteLine("Ingrese un número: ");
        numero = int.Parse(Console.ReadLine());
        Console.WriteLine("su número es " + numero);
        int b = numero - a;
        

        primo = true;

        if (numero <= 1 ) {
            primo = false;
        }
        
        for (int i = 2; i<=b  ; i++)
        {
            if (numero % i==0)
            {
                primo = false;
                break;
            }
        }

        
        if (primo == true)
        {
            Console.WriteLine("es primo");
        }
        else {
            Console.WriteLine(" no es primo");
        }

    }
}
