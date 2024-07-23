using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class MMP
    {
        private double w1;
        private double wq1;
        private double w0;
        private double q1;
        private double q2;
        private double ts1;
        private double ts2;

        public MMP (double W0, double Q1, double Ts1)
        {
            this.w0 = W0;
            this.q1 = Q1;
            this.ts1 = Ts1;
        }

        public double W1 { get; set; }
        public double Wq1 { get; set; }
        public double W0 { get; set; }
        public double Q1 { get; set; }
        public double Q2 { get; set; }
        public double Ts1 { get; set; }
        public double Ts2 { get; set; }
    }
}
