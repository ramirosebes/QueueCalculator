using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class MM2
    {
        private double lambda;
        private double mu1;
        private double mu2;
        private double ro;
        private double n;
        private double pn;
        private double p0;
        private double ls;
        private double ws;
        private double lq;
        private double wq;
        private double pc2;
        private double aPrima;
        private double r;
        private double pc;
        private double a;
        private bool seleccion;

        public MM2(double Lambda, double Mu1, double Mu2, double N, bool seleccion)
        {
            this.lambda = Lambda;
            this.mu1 = Mu1;
            this.mu2 = Mu2;
            this.n = N;
            this.seleccion = seleccion;
        }

        public double Lambda { get; set; }
        public double Mu1 { get; set; }
        public double Mu2 { get; set; }
        public double Ro { get; set; }
        public double N { get; set; }
        public double Pn { get; set; }
        public double P0 { get; set; }
        public double Ls { get; set; }
        public double Ws { get; set; }
        public double Lq { get; set; }
        public double Wq { get; set; }
        public double Pc2 { get; set; }
        public double APrima { get; set; }
        public double R { get; set; }
        public double Pc { get; set; }
        public double A { get; set; }
        public bool Seleccion { get; set; }
    }
}
