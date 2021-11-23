using System;


namespace Laboratorio5v2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] intArray = new int[5] { 1, 2, 3, 4, 5 };
            Object[] objArray = new Object[5] { 26, 27, 28, 29, 30 };

            Circulo circ1 = new Circulo();
            Console.WriteLine(circ1);
            Circulo circ2 = new Circulo(2.4, 5, 3);
            Console.WriteLine(circ2);
            CirculoColorido circ3 = new CirculoColorido();
            Console.WriteLine(circ3);
            CirculoColorido circ4 = new CirculoColorido(1.5, 3.1, 1, "vermelho");
            Console.WriteLine(circ4);
            CirculoColoridoPreenchido circ5 = new CirculoColoridoPreenchido();
            Console.WriteLine(circ5);

            Console.Write("int array: ");
            Console.WriteLine(intArray);
            Console.Write("Object array: ");
            Console.WriteLine(objArray);

        }

       

    }
   
}

