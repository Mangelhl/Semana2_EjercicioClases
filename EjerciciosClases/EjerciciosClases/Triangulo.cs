using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Triangulo : EjercicioFigura
{
    private int b;
    private int a;

    public Triangulo(int bas, int alt)
    {
        bas = b;
        alt = a;
    }

    public override double CalculaArea()
    {
        return 0.5 * b * a;
    }
}

