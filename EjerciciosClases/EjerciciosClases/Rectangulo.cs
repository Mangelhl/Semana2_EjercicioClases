using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Rectangulo : EjercicioFigura
    {
        private int b;
        private int a;

        public Rectangulo(int bas, int alt)
    {
        b = bas;
        a = alt;
    }

    public override double CalculaArea()
    {
        return b * a;
    }
}
