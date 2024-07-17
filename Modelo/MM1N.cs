using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class MM1N
    {
        private double lambda;
        private double lambdaEfectiva;
        private double mu;
        private int n;
        private double ro;
        private double roEfectivo;
        private double tau;
        private double tauEentrada;
        private double tauSalida;
        private double lq;
        private double ls;
        private double wq;
        private double wqEfectivo;
        private double ws;
        private double wsEfectivo;
        private double p0;
        private double pns;
        private double pnq;
        private double panq;
        private double pans;
        private double pb;
        private double lb;
        private double wb;

        public MM1N(double lambda, double mu, int n)
        {
            this.lambda = lambda;
            this.mu = mu;
            this.n = n;
        }

        public double Lambda { get; set; }
        public double LambdaEfectiva { get; set; }
        public double Mu { get; set; }
        public int N { get; set; }
        public double Ro { get; set; }
        public double RoEfectivo { get; set; }
        public double Tau { get; set; }
        public double TauEentrada { get; set; }
        public double TauSalida { get; set; }
        public double Lq { get; set; }
        public double Ls { get; set; }
        public double Wq { get; set; }
        public double WqEfectivo { get; set; }
        public double Ws { get; set; }
        public double WsEfectivo { get; set; }
        public double P0 { get; set; }
        public double Pns { get; set; }
        public double Pnq { get; set; }
        public double Panq { get; set; }
        public double Pans { get; set; }
        public double Pb { get; set; }
        public double Lb { get; set; }
        public double Wb { get; set; }
    }
}
