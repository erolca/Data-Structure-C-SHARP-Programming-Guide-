using System;
using Microsoft.Xna.Framework;
//Perpendicular Vector2
namespace Core
{
    public class Vector2Utilities
    {

        public static Vector2 Perpendicular(Vector2 original)
        {
            //To create a perpendicular vector switch X and Y, then make Y negative
            float x = original.X;
            float y = original.Y;

            y = -y;

            return new Vector2(y, x);
        }
    }
}

