using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDLL
{
    
    public class Operaciones
    {
        float R ;
        public float Suma (float V1, float V2)
        {
            R = V1 + V2;
            return R;
        }
        public float Resta(float V1, float V2)
        {
            R = V1 - V2;
            return R;
        }
        public float Multiplicacion(float V1, float V2)
        {
            R = V1 * V2;
            return R;
        }
        public float Division(float V1, float V2)
        {
            R = V1 / V2;
            return R;
        }
    }
}
