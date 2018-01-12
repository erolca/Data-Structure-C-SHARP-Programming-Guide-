using System;
using Microsoft.Xna.Framework;

//Truncate Vector2

namespace Core
{
    public class Vector2Utilities
    {
        public static void Truncate(Vector2 original, float max)
        {
            if (original.Length() > max)
            {
                original.Normalize();

                original *= max;
            }
        }

    }
}