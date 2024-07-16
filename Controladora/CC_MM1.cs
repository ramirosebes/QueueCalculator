using Modelo;

namespace Controladora
{
    public class CC_MM1
    {
        private Modelo.MM1 mm1 = new Modelo.MM1(0, 0, 0);

        public CC_MM1(double lambda, double mu, int n)
        {
            mm1.Lambda = lambda;
            mm1.Mu = mu;
            mm1.N = n;
            mm1.Ro = lambda/mu;
        }

        public double CalcularRo()
        {
            mm1.Ro = mm1.Lambda / mm1.Mu;
            return mm1.Ro;
        }

        public double CalcularLq()
        {
            mm1.Lq = Math.Pow(mm1.Lambda, 2) / (mm1.Mu * (mm1.Mu - mm1.Lambda));
            return mm1.Lq;
        }

        public double CalcularLs()
        {
            mm1.Ls = mm1.Lambda / (mm1.Mu - mm1.Lambda);
            return mm1.Ls;
        }

        public double CalcularWq()
        {
            mm1.Wq = mm1.Lambda / (mm1.Mu * (mm1.Mu - mm1.Lambda));
            return mm1.Wq;
        }

        public double CalcularWs()
        {
            mm1.Ws = 1 / (mm1.Mu - mm1.Lambda);
            return mm1.Ws;
        }

        public double CalcularP0()
        {
            mm1.P0 = 1 - mm1.Ro;
            return mm1.P0;
        }

        public double CalcularPns()
        {
            mm1.Pns = (1 - mm1.Ro) * Math.Pow(mm1.Ro, mm1.N);
            //mm1.Pns = (1 - (mm1.Lambda / mm1.Mu)) * Math.Pow((mm1.Lambda / mm1.Mu), mm1.N);
            return mm1.Pns;

        }

        public double CalcularPnq()
        {
            //Revisar
            mm1.Pnq = (1 - mm1.Ro) * Math.Pow(mm1.Ro, mm1.N + 1);
            //mm1.Pnq = (1 - (mm1.Lambda / mm1.Mu)) * Math.Pow((mm1.Lambda / mm1.Mu), mm1.N + 1);
            return mm1.Pnq;
        }

        public double CalcularPans()
        {
            double sum = 0;
            for (int i = 0; i < mm1.N; i++)
            {
                sum += (1 - mm1.Ro) * Math.Pow(mm1.Ro, i);
                //sum += (1 - (mm1.Lambda / mm1.Mu)) * Math.Pow((mm1.Lambda / mm1.Mu), i);
            }
            mm1.Pans = 1 - sum;
            return mm1.Pans;
        }

        public double CalcularPanq()
        {
            //Revisar
            double sum = 0;
            for (int i = 0; i < mm1.N; i++)
            {
                sum += (1 - mm1.Ro) * Math.Pow(mm1.Ro, i + 1);
                //sum += (1 - (mm1.Lambda / mm1.Mu)) * Math.Pow((mm1.Lambda / mm1.Mu), i + 1);
            }
            mm1.Panq = 1 - sum;
            return mm1.Panq;
        }
    }
}
