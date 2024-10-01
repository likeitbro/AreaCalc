using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalc;

public struct Length
{
    private double value;
    public double Value {
        get { return value; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Negative length");
            this.value = value;
        } 
    }

    public static implicit operator Length(double dbl)
    {
        return new Length { Value = dbl };
    }
}
