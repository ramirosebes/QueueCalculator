using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class CC_MMP
    {
        private Modelo.MMP MMP = new Modelo.MMP(0, 0, 0);

        public CC_MMP(double W0, double Q1, double Ts1)
        {
            MMP.W0 = W0;
            MMP.Q1 = Q1;
            MMP.Ts1 = Ts1;
        }

        public double CalcularW1()
        {
            MMP.W1 = MMP.W0 + MMP.Q1 * MMP.Ts1 + MMP.Ts1;
            return MMP.W1;
        }

        public double CalcularWq1()
        {
            MMP.Wq1 = MMP.W0 + MMP.Q1 * MMP.Ts1;
            return MMP.Wq1;
        }
    }
}
