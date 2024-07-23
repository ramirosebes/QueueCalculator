using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class CC_MG1MD1
    {
        private Modelo.MG1MD1 MG1MD1 = new Modelo.MG1MD1(0, 0);

        public CC_MG1MD1(double Lambda, double Mu)
        {
            MG1MD1.Lambda = Lambda;
            MG1MD1.Mu = Mu;
            MG1MD1.Ro = Lambda / Mu;
        }

        public double CalcularRo()
        {
            MG1MD1.Ro = MG1MD1.Lambda / MG1MD1.Mu;
            return MG1MD1.Ro;
        }

        public double CalcularP0()
        {
            MG1MD1.P0 = 1 - MG1MD1.Ro;
            return MG1MD1.P0;
        }

        public double CalcularSigma(double Sigma, bool SigmaBool)
        {
            if (SigmaBool == false)
            {
                MG1MD1.Sigma = 1 / MG1MD1.Mu;
            }
            else if (SigmaBool == true)
            {
                MG1MD1.Sigma = Sigma;
            }
            
            return MG1MD1.Sigma;
        }

        public double CalcularSigmaCuadrado(double SigmaParam, bool SigmaBoolParam)
        {
            double Sigma = CalcularSigma(SigmaParam, SigmaBoolParam);
            //MG1MD1.SigmaCuadrado = 1 / Math.Pow(MG1MD1.Mu, 2);
            MG1MD1.SigmaCuadrado = Math.Pow(Sigma, 2);
            return MG1MD1.SigmaCuadrado;
        }

        public double CalcularLq(double SigmaParam, bool SigmaBoolParam) 
        {
            double Sigma = CalcularSigma(SigmaParam, SigmaBoolParam);

            if (Sigma != 0)
            {
                double SigmaCuadrado = CalcularSigmaCuadrado(SigmaParam, SigmaBoolParam);
                double PrimerTermino = Math.Pow(MG1MD1.Lambda, 2);
                double SegundoTermino = SigmaCuadrado;
                double TercerTermino = Math.Pow(MG1MD1.Ro, 2);
                //double Numerador = (Math.Pow(MG1MD1.Lambda, 2) * SigmaCuadrado * Math.Pow(MG1MD1.Ro, 2));
                double Numerador = PrimerTermino * SegundoTermino * TercerTermino;
                double Denominador = (2 * (1 - MG1MD1.Ro));
                //MG1MD1.Lq = (Math.Pow(MG1MD1.Lambda, 2) * SigmaCuadrado * Math.Pow(MG1MD1.Ro, 2)) / (2 * (1 - MG1MD1.Ro));
                MG1MD1.Lq = Numerador / Denominador;
            }
            else if (Sigma == 0)
            {
                MG1MD1.Lq = (Math.Pow(MG1MD1.Ro, 2)) / (2 * (1 - MG1MD1.Ro));
            }
            
            return MG1MD1.Lq;
        }

        public double CalcularLs(double SigmaParam, bool SigmaBoolParam)
        {
            double Lq = CalcularLq(SigmaParam, SigmaBoolParam);
            MG1MD1.Ls = MG1MD1.Ro + Lq;
            return MG1MD1.Ls;
        }

        public double CalcularWq(double SigmaParam, bool SigmaBoolParam)
        {
            double Lq = CalcularLq(SigmaParam, SigmaBoolParam);
            MG1MD1.Wq = Lq / MG1MD1.Lambda;
            return MG1MD1.Wq;
        }

        public double CalcularWs(double SigmaParam, bool SigmaBoolParam)
        {
            double Wq = CalcularWq(SigmaParam, SigmaBoolParam);
            MG1MD1.Ws = Wq + (1 / MG1MD1.Mu);
            return MG1MD1.Ws;
        }
    }
}
