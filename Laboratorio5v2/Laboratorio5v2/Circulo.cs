﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5v2
{
    class Circulo
    {
        private double coordX;
        private double coordY;
        private double raio;

        public Circulo() : this(0, 0, 1)
        {

        }
        public Circulo(double x, double y, double r)
        {
            coordX = x; coordY = y;
            raio = Math.Abs(r);
        }

        public double CentroX
        {

            get
            {
                return coordX;
            }
            set
            {
                coordX = value;
            }
        }
        public double CentroY
        {

            get
            {
                return coordY;
            }
            set
            {
                coordY = value;
            }
        }
        public double Raio
        {

            get
            {
                return raio;
            }
            set
            {
                raio = value;
            }
        }
        public override string ToString()
        {
            return "(" + string.Format("{0:F2}", CentroX) + ";"
            + string.Format("{0:F2}", CentroY) + ")"
            + " raio=" + string.Format("{0:F2}", Raio);
        }

        public static void PrintValues(Object[] Array)
        {
            foreach (Object i in Array)
            {
                Console.Write("\t{0}", i);
            }
            Console.WriteLine();
        }

        public static void PrintValues(int[] Array)
        {
            foreach (int i in Array)
            {
                Console.Write("\t{0}", i);
            }
            Console.WriteLine();
        }
    }
}

}
