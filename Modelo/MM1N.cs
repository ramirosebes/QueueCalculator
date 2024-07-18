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
        private double n;
        private double m;
        private double ro;
        private double roEfectivo;
        private double tau;
        private double tauEfectivo;
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

        public MM1N(double Lambda, double Mu, double M, double N)
        {
            this.lambda = Lambda;
            this.mu = Mu;
            this.m = M;
            this.n = N;
        }

        public double Lambda { get; set; }
        public double LambdaEfectiva { get; set; }
        public double Mu { get; set; }
        public double N { get; set; }
        public double M { get; set; }
        public double Ro { get; set; }
        public double RoEfectivo { get; set; }
        public double Tau { get; set; }
        public double TauEfectivo { get; set; }
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
