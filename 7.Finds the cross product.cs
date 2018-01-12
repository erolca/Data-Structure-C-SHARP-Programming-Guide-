using System;

//Finds the cross product of the 2 vectors created by the 3 vertices.
namespace ComputationalGeometry.Shapes
{
    public static class MathUtility
    {

        /// <summary>
        /// Finds the cross product of the 2 vectors created by the 3 vertices.
        /// Vector 1 = v1 -> v2, Vector 2 = v2 -> v3
        /// The vectors make a "right turn" if the sign of the cross product is negative.
        /// The vectors make a "left turn" if the sign of the cross product is positive.
        /// The vectors are colinear (on the same line) if the cross product is zero.
        /// </summary>
        /// <param name="p1">First point.</param>
        /// <param name="p2">Second point.</param>
        /// <param name="p3">Third point.</param>
        /// <returns>Cross product of the two vectors.</returns>
        public static double CrossProduct(Point2D p1, Point2D p2, Point2D p3)
        {
            return (p2.X - p1.X) * (p3.Y - p1.Y) - (p3.X - p1.X) * (p2.Y - p1.Y);
        }

    }
}