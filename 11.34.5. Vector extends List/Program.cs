using System;
using System.Collections.Generic;
using System.Text;

public static class VectorDelegates
{
    public static int Compare(Vector x, Vector y)
    {
        if (x.R > y.R)
        {
            return 1;
        }
        else if (x.R < y.R)
        {
            return -1;
        }
        return 0;
    }

    public static bool TopRightQuadrant(Vector target)
    {
        if (target.Theta >= 0.0 && target.Theta <= 90.0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

public class Vectors : List<Vector>
{
    public Vectors()
    {
    }

    public Vectors(IEnumerable<Vector> initialItems)
    {
        foreach (Vector vector in initialItems)
        {
            Add(vector);
        }
    }

    public string Sum()
    {
        StringBuilder sb = new StringBuilder();
        Vector currentPoint = new Vector(0.0, 0.0);
        sb.Append("origin");
        foreach (Vector vector in this)
        {
            sb.AppendFormat(" + {0}", vector);
            currentPoint += vector;
        }
        sb.AppendFormat(" = {0}", currentPoint);
        return sb.ToString();
    }
}

public class Vector
{
    public double? R = null;
    public double? Theta = null;

    public double? ThetaRadians
    {
        get
        {
            return (Theta * Math.PI / 180.0);
        }
    }

    public Vector(double? r, double? theta)
    {
        if (r < 0)
        {
            r = -r;
            theta += 180;
        }
        theta = theta % 360;
        R = r;
        Theta = theta;
    }

    public static Vector operator +(Vector op1, Vector op2)
    {
        try
        {
            double newX = op1.R.Value * Math.Sin(op1.ThetaRadians.Value)
               + op2.R.Value * Math.Sin(op2.ThetaRadians.Value);
            double newY = op1.R.Value * Math.Cos(op1.ThetaRadians.Value)
               + op2.R.Value * Math.Cos(op2.ThetaRadians.Value);

            double newR = Math.Sqrt(newX * newX + newY * newY);
            double newTheta = Math.Atan2(newX, newY) * 180.0 / Math.PI;

            return new Vector(newR, newTheta);
        }
        catch
        {
            return new Vector(null, null);
        }
    }

    public static Vector operator -(Vector op1)
    {
        return new Vector(-op1.R, op1.Theta);
    }

    public static Vector operator -(Vector op1, Vector op2)
    {
        return op1 + (-op2);
    }

    public override string ToString()
    {
        string rString = R.HasValue ? R.ToString() : "null";
        string thetaString = Theta.HasValue ? Theta.ToString() : "null";

        return string.Format("({0}, {1})", rString, thetaString);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Vectors route = new Vectors();
        route.Add(new Vector(2.0, 90.0));
        route.Add(new Vector(1.0, 180.0));
        route.Add(new Vector(0.5, 45.0));
        route.Add(new Vector(2.5, 315.0));

        Console.WriteLine(route.Sum());

        Comparison<Vector> sorter = new Comparison<Vector>(VectorDelegates.Compare);
        route.Sort(sorter);
        Console.WriteLine(route.Sum());

        Predicate<Vector> searcher = new Predicate<Vector>(VectorDelegates.TopRightQuadrant);
        Vectors topRightQuadrantRoute = new Vectors(route.FindAll(searcher));
        Console.WriteLine(topRightQuadrantRoute.Sum());
    }
}