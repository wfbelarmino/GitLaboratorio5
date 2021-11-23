using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5v2
{
    class CirculoColoridoPreenchido : CirculoColorido
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
        public CirculoColoridoPreenchido()
        {
            minhaCor = "Verde";
        }
        public CirculoColoridoPreenchido(double x, double y, double r, string p) : base(x, y, r)
        {
            minhaCor = p;
        }
        public override string ToString()
        {
            return base.ToString() + " cor=" + Cor;
        }

    }
}
