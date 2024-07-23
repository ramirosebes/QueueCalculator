using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class MG1MD1
    {
        private double lambda;
        private double mu;
        private double ro;
        private double lq;
        private double ls;
        private double wq;
        private double ws;
        private double p0;
        private double sigma;
        private double sigmaCuadrado;
        private bool sigmaBool;

        public MG1MD1(double Lambda, double Mu)
        {
            this.lambda = Lambda;
            this.mu = Mu;
        }

        public double Lambda { get; set; }
        public double Mu { get; set; }
        public double Ro { get; set; }
        public double Lq { get; set; }
        public double Ls { get; set; }
        public double Wq { get; set; }
        public double Ws { get; set; }
        public double P0 { get; set; }
        public double Sigma { get; set; }
        public double SigmaCuadrado { get; set; }
        public bool SigmaBool { get; set; }
    }
}
