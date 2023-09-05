using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Cuadrado : EjercicioFigura
    {
    private int l;

    public Cuadrado(int lado)
    {
        l = lado;
    }

    public override double CalculaArea()
    {
        return l * l;
    }
}

