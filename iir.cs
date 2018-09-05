using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECG_Viewer
{
    class iir
    {
        static double[] x; 
        static double[] y;

        int index = new int();

        //double[] ACoef;
        //double[] BCoef;

        double[] ACoef = 
        {            
            0.79546960104432807000,
            -4.51377003964725530000,
            12.78663888657151500000,
            -22.62476640826281500000,
            27.20375589496556400000,
            -22.62476640826281500000,
            12.78663888657151500000,
            -4.51377003964725530000,
            0.79546960104432807000
        };

        double[] BCoef = 
        {
            1.00000000000000000000,
            -5.32979971467644820000,
            14.17254140121803000000,
            -23.54172433401651100000,
            26.57522474067498700000,
            -20.75436583867821500000,
            11.01524444681319400000,
            -3.65208680323105740000,
            0.60419285010192969000
        };


        public iir()
        {
            x = new double[ACoef.Length];
            y = new double[BCoef.Length];
        }

        public double Calc(double val)
        {
            for (int i = x.Length-1; i>0; i--)
            {
                x[i] = x[i-1];
                y[i] = y[i-1];
            }

            x[0] = val;
            y[0] = ACoef[0]*x[0];

            for (int i = 1; i<=x.Length-1;i++)
            {
                y[0] += ACoef[i]*x[i] - BCoef[i]*y[i];
            }
            return y[0];
        }


    }
}
