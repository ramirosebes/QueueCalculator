using Modelo;

namespace Controladora
{
    public class CC_MM1
    {
        private Modelo.MM1 MM1 = new Modelo.MM1(0, 0, 0);

        public CC_MM1(double Lambda, double Mu, int N)
        {
            MM1.Lambda = Lambda;
            MM1.Mu = Mu;
            MM1.N = N;
            MM1.Ro = Lambda / Mu;
        }

        public double CalcularRo()
        {
            MM1.Ro = MM1.Lambda / MM1.Mu;
            return MM1.Ro;
        }

        public double CalcularLq()
        {
            MM1.Lq = Math.Pow(MM1.Lambda, 2) / (MM1.Mu * (MM1.Mu - MM1.Lambda));
            return MM1.Lq;
        }

        public double CalcularLs()
        {
            MM1.Ls = MM1.Lambda / (MM1.Mu - MM1.Lambda);
            return MM1.Ls;
        }

        public double CalcularWq()
        {
            MM1.Wq = MM1.Lambda / (MM1.Mu * (MM1.Mu - MM1.Lambda));
            return MM1.Wq;
        }

        public double CalcularWs()
        {
            MM1.Ws = 1 / (MM1.Mu - MM1.Lambda);
            return MM1.Ws;
        }

        public double CalcularP0()
        {
            MM1.P0 = 1 - MM1.Ro;
            return MM1.P0;
        }

        public double CalcularPns()
        {
            MM1.Pns = (1 - MM1.Ro) * Math.Pow(MM1.Ro, MM1.N);
            //MM1.Pns = (1 - (MM1.Lambda / MM1.Mu)) * Math.Pow((MM1.Lambda / MM1.Mu), MM1.N);
            return MM1.Pns;

        }

        public double CalcularPnq()
        {
            //Revisar
            //Segundo la calculadora de internet es igual Pns
            MM1.Pnq = (1 - MM1.Ro) * Math.Pow(MM1.Ro, MM1.N + 1);
            //MM1.Pnq = (1 - (MM1.Lambda / MM1.Mu)) * Math.Pow((MM1.Lambda / MM1.Mu), MM1.N + 1);
            return MM1.Pnq;
        }

        public double CalcularPans()
        {
            double sum = 0;
            for (int i = 0; i < MM1.N; i++)
            {
                sum += (1 - MM1.Ro) * Math.Pow(MM1.Ro, i);
                //sum += (1 - (MM1.Lambda / MM1.Mu)) * Math.Pow((MM1.Lambda / MM1.Mu), i);
            }
            MM1.Pans = 1 - sum;
            return MM1.Pans;
        }

        public double CalcularPanq()
        {
            double sum = 0;
            for (int i = 0; i < MM1.N + 1; i++)
            {
                sum += (1 - MM1.Ro) * Math.Pow(MM1.Ro, i);
                //sum += (1 - (MM1.Lambda / MM1.Mu)) * Math.Pow((MM1.Lambda / MM1.Mu), i + 1);
            }
            MM1.Panq = 1 - sum;
            return MM1.Panq;
        }
    }
}
