namespace Modelo
{
    public class MM1
    {
        private double lambda;
        private double mu;
        private int n;
        private double ro;
        private double lq;
        private double ls;
        private double wq;
        private double ws;
        private double p0;
        private double pns;
        private double pnq;
        private double panq;
        private double pans;

        public MM1(double lambda, double mu, int n)
        {
            this.lambda = lambda;
            this.mu = mu;
            this.n = n;
        }

        public double Lambda { get; set; }
        public double Mu { get; set; }
        public int N { get; set; }
        public double Ro { get; set; }
        public double Lq { get; set; }
        public double Ls { get; set; }
        public double Wq { get; set; }
        public double Ws { get; set; }
        public double P0 { get; set; }
        public double Pns { get; set; }
        public double Pnq { get; set; }
        public double Panq { get; set; }
        public double Pans { get; set; }

    }
}
