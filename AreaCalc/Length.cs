using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalc;

public struct Length
{
    public double Value {
        get { return Value; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Negative length");
            Value = value;
        } 
    }

    public static implicit operator Length(double dbl)
    {
        return new Length { Value = dbl };
    }

    public static explicit operator double(Length length) 
    { 
        return length.Value;
    }
}
