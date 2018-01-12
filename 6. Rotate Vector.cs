using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

//Rotate Vector

namespace InfoStrat.VE.Utilities
{
    public static class MathHelper
    {
        public static Vector RotateVector(Vector v, double angle)
        {
            double len = v.Length;

            if (len == 0)
                return v;

            double refAngle = Get2DAngle(v, new Vector(1, 0));

            double dx = len * Math.Cos((refAngle + angle) * Math.PI / 180.0);
            double dy = -len * Math.Sin((refAngle + angle) * Math.PI / 180.0);

            return new Vector(dx, dy);
        }

        public static double Get2DAngle(Vector a, Vector b)
        {
            double cosine = (a.X * b.X + a.Y * b.Y) / (a.Length * b.Length);

            if (cosine > 1)
                cosine = 1;
            else if (cosine < -1)
                cosine = -1;

            if ((a.X * b.Y - a.Y * b.X) < 0)
                return -Math.Acos(cosine) * 180.0 / Math.PI;
            else
                return Math.Acos(cosine) * 180.0 / Math.PI;
        }

        public static double MapValue(double value, double fromMin, double fromMax, double toMin, double toMax)
        {
            //Normalize
            double ret = (value - fromMin) / (fromMax - fromMin);
            //Resize and translate
            return ret * (toMax - toMin) + toMin;
        }

        public static double Clamp(double value, double min, double max)
        {
            double actualMin = Math.Min(min, max);
            double actualMax = Math.Max(min, max);
            return Math.Min(actualMax, Math.Max(actualMin, value));
        }
    }
}