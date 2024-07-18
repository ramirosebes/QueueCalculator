using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class CC_MM1N
    {
        private Modelo.MM1N MM1N = new Modelo.MM1N(0, 0, 0, 0);

        public CC_MM1N(double Lambda, double Mu, double M, double N)
        {
            MM1N.Lambda = Lambda;
            MM1N.Mu = Mu;
            MM1N.M = M;
            MM1N.N = N;
            MM1N.Ro = Lambda / Mu;
        }

        public double CalcularLambdaEfectiva()
        {
            double Pb = CalcularPb();
            //MM1N.LambdaEfectiva = MM1N.Lambda * (1 - MM1N.Pb);
            MM1N.LambdaEfectiva = MM1N.Lambda * (1 - Pb);
            return MM1N.LambdaEfectiva;
        }

        public double CalcularPb()
        {
           //MM1N.Pb = Math.Pow(MM1N.Ro, MM1N.N) * (1 - MM1N.Ro);
           MM1N.Pb = (Math.Pow(MM1N.Ro, MM1N.M) * (1 - MM1N.Ro)) / (1 - Math.Pow(MM1N.Ro, MM1N.M + 1));
           return MM1N.Pb;
        }

        public double CalcularTau()
        {
            double Pb = CalcularPb();
            MM1N.Tau = MM1N.Lambda * Pb;
            return MM1N.Tau;
        }

        public double CalcularTauEfectivo()
        {
            double LambdaEfectiva = CalcularLambdaEfectiva();
            double Pb = CalcularPb();
            MM1N.TauEfectivo = LambdaEfectiva * Pb;
            return MM1N.TauEfectivo;
        }

        public double CalcularTauEntrada()
        {
            double Tau = CalcularTau();
            MM1N.TauEentrada = MM1N.Lambda - Tau;
            return MM1N.TauEentrada;
        }

        public double CalcularTauSalida()
        {
            double P0 = CalcularP0();
            MM1N.TauSalida = MM1N.Mu - (MM1N.Mu * P0);
            return MM1N.TauSalida;
        }

        public double CalcularP0()
        {
            MM1N.P0 = (1 - MM1N.Ro) / (1 - Math.Pow(MM1N.Ro, MM1N.M + 1));
            return MM1N.P0;
        }

        public double CalcularRo()
        {
            MM1N.Ro = MM1N.Lambda / MM1N.Mu;
            return MM1N.Ro;
        }

        public double CalcularRoEfectivo()
        {
            double LambdaEfectiva = CalcularLambdaEfectiva();
            MM1N.RoEfectivo = LambdaEfectiva / MM1N.Mu;
            return MM1N.RoEfectivo;
        }

        public double CalcularLs()
        {
            if (MM1N.Ro == 1)
            {
                MM1N.Ls = MM1N.M / 2;
            }
            else if (MM1N.Ro != 1)
            {
                double PrimerTermino = MM1N.Ro / (1 - MM1N.Ro);
                double SegundoTerminoNumerador = (MM1N.M + 1) * Math.Pow(MM1N.Ro, MM1N.M + 1);
                double SegundoTerminoDenominador = (1 - Math.Pow(MM1N.Ro, MM1N.M + 1));
                double SegundoTermino = SegundoTerminoNumerador / SegundoTerminoDenominador;
                MM1N.Ls = PrimerTermino - SegundoTermino;
            }

            return MM1N.Ls;
        }

        public double CalcularLq()
        {
            if (MM1N.Ro == 1)
            {
                //MM1N.Lq = MM1N.M / 2;
                MM1N.Lq = (MM1N.M * (MM1N.M - 1)) / (2 * (MM1N.M + 1));
            }
            else if (MM1N.Ro != 1)
            {
                double Ls = CalcularLs();
                double SegundoTerminoNumerador = (1 - Math.Pow(MM1N.Ro, MM1N.M)) * MM1N.Ro;
                double SegundoTerminoDenominador = 1 - Math.Pow(MM1N.Ro, MM1N.M + 1);
                double SegundoTermino = SegundoTerminoNumerador / SegundoTerminoDenominador;
                MM1N.Lq = Ls - SegundoTermino;
            }
            return MM1N.Lq;
        }

        public double CalcularWs()
        {
            double Ls = CalcularLs();
            MM1N.Ws = Ls / MM1N.Lambda;
            return MM1N.Ws;
        }

        public double CalcularWsEfectivo()
        {
            double Ls = CalcularLs();
            double LambdaEfectiva = CalcularLambdaEfectiva();
            MM1N.WsEfectivo = Ls / LambdaEfectiva;
            return MM1N.WsEfectivo;
        }

        public double CalcularWq()
        {
            double Lq = CalcularLq();
            MM1N.Wq = Lq / MM1N.Lambda;
            return MM1N.Wq;
        }

        public double CalcularWqEfectivo()
        {
            double Lq = CalcularLq();
            double LambdaEfectiva = CalcularLambdaEfectiva();
            MM1N.WqEfectivo = Lq / LambdaEfectiva;
            return MM1N.WqEfectivo;
        }

        public double CalcularLb()
        {
            double Lq = CalcularLq();
            double P0 = CalcularP0();
            MM1N.Lb = Lq / 1 - P0;
            return MM1N.Lb;
        }

        public double CalcularWb()
        {
            double Wq = CalcularWq();
            double P0 = CalcularP0();
            MM1N.Wb = Wq / 1 - P0;
            return MM1N.Wb;
        }

        public double CalcularPnq()
        {
            double P0 = CalcularP0();
            MM1N.Pnq = P0 * Math.Pow(MM1N.Ro, MM1N.N);
            return MM1N.Pnq;
        }

        public double CalcularPns()
        {
            double P0 = CalcularP0();
            MM1N.Pans = P0 * Math.Pow(MM1N.Ro, MM1N.N + 1);
            return MM1N.Pans;
        }

        public double CalcularPans()
        {
            double sum = 0;
            for (int i = 0; i < MM1N.N; i++)
            {
                sum += (1 - MM1N.Ro) * Math.Pow(MM1N.Ro, i);
                //sum += (1 - (MM1.Lambda / MM1.Mu)) * Math.Pow((MM1.Lambda / MM1.Mu), i);
            }
            MM1N.Pans = 1 - sum;
            return MM1N.Pans;
        }

        public double CalcularPanq()
        {
            double sum = 0;
            for (int i = 0; i < MM1N.N + 1; i++)
            {
                sum += (1 - MM1N.Ro) * Math.Pow(MM1N.Ro, i);
                //sum += (1 - (MM1.Lambda / MM1.Mu)) * Math.Pow((MM1.Lambda / MM1.Mu), i + 1);
            }
            MM1N.Panq = 1 - sum;
            return MM1N.Panq;
        }
    }
}
