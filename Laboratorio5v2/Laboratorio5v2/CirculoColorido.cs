using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5v2
{
    class CirculoColorido : Circulo
    {
        private string minhaCor;
        public string Cor
        {

            get
            {
                return minhaCor;
            }
            set
            {
                minhaCor = value;
            }
        }
        public CirculoColorido()
        {
            minhaCor = "preto";
        }
        public CirculoColorido(double x, double y, double r, string c) : base(x, y, r)
        {
            minhaCor = c;
        }

        public CirculoColorido(double x, double y, double r) : base(x, y, r)
        {
        }

        public override string ToString()
        {
            return base.ToString() + " cor=" + Cor;
        }

    }

}
