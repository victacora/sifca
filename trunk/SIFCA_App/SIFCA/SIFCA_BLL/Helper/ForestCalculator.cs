using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIFCA_BLL
{
    public static class ForestCalculator
    {
        public static double BasalAreaDAP(double DAP)
        {
            return (Math.PI * Math.Pow(DAP, 2)) / 4;
        }

        public static double BasalAreaCAP(double CAP)
        {
            return Math.Pow(CAP, 2) /( 4 *Math.PI );
        }

        public static double TreeVolumeByBasalArea(double AB, double formFactor,double treeHeight)
        {
            return AB * treeHeight * formFactor ;
        }
    }
}
