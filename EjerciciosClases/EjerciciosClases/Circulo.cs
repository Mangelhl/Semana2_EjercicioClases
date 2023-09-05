using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Circulo : EjercicioFigura
{

    private int rad;

    public Circulo(int r) 
     {
        rad = r;
     }

    public override double CalculaArea()
    {
        return Math.PI * rad * rad;
    }
}
