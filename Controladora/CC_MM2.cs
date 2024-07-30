using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controladora
{
    public class CC_MM2
    {
        private Modelo.MM2 MM2 = new Modelo.MM2(0, 0, 0, 0, false);

        public CC_MM2(double Lambda, double Mu1, double Mu2, double N, bool Seleccion)
        {
            MM2.Lambda = Lambda;
            MM2.Mu1 = Mu1;
            MM2.Mu2 = Mu2;
            MM2.N = N;
            MM2.Seleccion = Seleccion;
            MM2.Ro = Lambda / (Mu1 + Mu2);
        }

        public double CalcularRo()
        {
            MM2.Ro = MM2.Lambda / (MM2.Mu1 + MM2.Mu2);
            return MM2.Ro;
        }

        public double CalcularA()
        {
            if (MM2.Mu1 == MM2.Mu2)
            {
                MM2.A = 0;
                return MM2.A;
            }
            else
            {
                if (MM2.Seleccion == true)
                {
                    double Numerador = (2 * MM2.Lambda + (MM2.Mu1 + MM2.Mu2)) * (MM2.Mu1 * MM2.Mu2);
                    double Denominador = (MM2.Mu1 + MM2.Mu2) * (MM2.Lambda + MM2.Mu2);
                    MM2.APrima = Numerador / Denominador;
                    return MM2.APrima;
                }
                else
                {
                    double Numerador = (2 * MM2.Mu1 * MM2.Mu2);
                    double Denomiador = (MM2.Mu1 + MM2.Mu2);
                    MM2.A = Numerador / Denomiador;
                    return MM2.A;
                }
            }
           
        }

        public double CalcularP0()
        {
            if (MM2.Mu1 == MM2.Mu2)
            {
                MM2.P0 = 1 - MM2.Ro;
            }
            else
            {
                if (MM2.Seleccion == true)
                {
                    double Aprima = CalcularA();
                    double Numerador = 1 - MM2.Ro;
                    double Denominador = 1 - MM2.Ro + (MM2.Lambda / Aprima);
                    MM2.P0 = Numerador / Denominador;
                }
                else
                {
                    double A = CalcularA();
                    double Numerador = 1 - MM2.Ro;
                    double Denominador = 1 - MM2.Ro + (MM2.Lambda / A);
                    MM2.P0 = Numerador / Denominador;
                }
            }

            return MM2.P0;
        }

        public double CalcularPn()
        {
            MM2.Pn = (1 - MM2.N) * Math.Pow(MM2.Ro, MM2.N);
            return MM2.Pn;
        }

        public double CalcularLs()
        {
            if (MM2.Mu1 == MM2.Mu2)
            {
                MM2.Ls = MM2.Ro / (1 - MM2.Ro);
            }
            else
            {
                if (MM2.Seleccion == true)
                {
                    double APrima = CalcularA();
                    double Numerador = MM2.Lambda;
                    double Denominador = (1 - MM2.Ro) * (MM2.Lambda + (1 - MM2.Ro) * APrima);
                    MM2.Ls = Numerador / Denominador;
                }
                else
                {
                    double A = CalcularA();
                    double Numerador = MM2.Lambda;
                    double Denominador = (1 - MM2.Ro) * (MM2.Lambda + (1 - MM2.Ro) * A);
                    MM2.Ls = Numerador / Denominador;
                }
            }

            return MM2.Ls;
        }

        public double CalcularLq()
        {
            MM2.Lq = Math.Pow(MM2.Ro, 2) / (1 - MM2.Ro);

            return MM2.Lq;
        }

        public double CalcularWs()
        {
            MM2.Ws = MM2.Ls / MM2.Lambda;
            return MM2.Ws;
        }

        public double CalcularWq()
        {
            MM2.Wq = MM2.Lq / MM2.Lambda;
            return MM2.Wq;
        }

        public double CalcularR()
        {
            if (MM2.Seleccion == true) 
            {
                //MM2.R = MM2.Mu1 * MM2.Mu2;
                MM2.R = MM2.Mu1 / MM2.Mu2;
            }
            else
            {
                MM2.R = MM2.Mu1 / MM2.Mu2;
            }

            return MM2.R;
        }

        public double CalcularPc()
        {
            double R = CalcularR();

            double Pc = 1 - (R * ((1 + R) / (1 + Math.Pow(R, 2))));

            if (MM2.Seleccion == true)
            {
                MM2.Pc = Pc;
            }
            else
            {
                MM2.Pc2 = (1 + Math.Pow(R, 2)) - Pc * (2 + Math.Pow(R, 2)) - (2 * R - 1) * (1 + R);
            }

            return MM2.Pc;
        }
    }
}
