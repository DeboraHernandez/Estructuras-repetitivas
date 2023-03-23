// See https://aka.ms/new-console-template for more information

class ejercicio
{
    public void metodo1()
    {
        int num = 0;
        do
        {
            Console.WriteLine("Ingrese un numero entero positivo");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine(num + " es un numero par");
            }
            else
            {

            }
        } while (num != 99);
    }
    public void metodo2()
    {
        Console.WriteLine("Ingrese el numero de lineas");
        int y = Convert.ToInt32(Console.ReadLine());
        string fila = " ";

        for (int i = 1; i <=y; i++)
        {
            fila = fila + i;
            Console.WriteLine(fila + '\n');
        }
    }
    public void metodo3()
    {
        int suma = 0;
        Console.WriteLine("Ejercicio 3");

        for (int i = 100; i <= 200; i++)
        {
            if (i % 9 == 0)
            {
                Console.WriteLine(i);
                suma = suma + i;
            }
            else
            {

            }
        }
        Console.WriteLine(suma);
    }

    public void metodo4()
    {
        Console.WriteLine("Ejercicio 4");
        Console.WriteLine("Ingrese un numero entero positivo");
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <=num; i++)
        {
            Console.WriteLine(i+": ");
            for(int j = 1; j <=10; j++)
            {
                Console.WriteLine((i * j) + "\t");
            }
            Console.WriteLine("\n");
        }
    }
    static void Main(string[] args)
    {
        ejercicio x = new ejercicio();
        x.metodo1();
        x.metodo2();
        x.metodo3();
        x.metodo4();
    }
}

