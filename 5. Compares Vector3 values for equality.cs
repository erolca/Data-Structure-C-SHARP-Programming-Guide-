using System;


//////////////////////////////////////////////////////////////////////
//  Copyright (C) 2010 by Conquera Team
//  Part of the Conquera Project
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 2 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;


//Compares Vector3 values for equality

namespace Ale.Tools
{
    /// <summary>
    /// 
    /// </summary>
    public static class AleMathUtils
    {
        public static Random Random = new Random();
        /// <summary>
        /// Compares values for equality
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <param name="epsilon"></param>
        /// <returns></returns>
        public static bool Equals(float v1, float v2, float epsilon)
        {
            return (Math.Abs(v1 - v2) < epsilon);
        }

        /// <summary>
        /// Compares values for equality (epsion = 0.00001)
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool Equals(float v1, float v2)
        {
            return Equals(v1, v2, 0.00001f);
        }

        /// <summary>
        /// Compares values for equality
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <param name="epsilon"></param>
        /// <returns></returns>
        public static bool Equals(ref Vector2 v1, ref Vector2 v2, float epsilon)
        {
            return (Equals(v1.X, v2.X, epsilon) &&
                    Equals(v1.Y, v2.Y, epsilon));

        }

        /// <summary>
        /// Compares values for equality (epsion = 0.00001)
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool Equals(ref Vector2 v1, ref Vector2 v2)
        {
            return Equals(ref v1, ref v2, 0.00001f);
        }

        /// <summary>
        /// Compares values for equality
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <param name="epsilon"></param>
        /// <returns></returns>
        public static bool Equals(Vector2 v1, Vector2 v2, float epsilon)
        {
            return Equals(ref v1, ref v2, epsilon);
        }

        /// <summary>
        /// Compares values for equality (epsion = 0.00001)
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool Equals(Vector2 v1, Vector2 v2)
        {
            return Equals(ref v1, ref v2, 0.00001f);
        }

        /// <summary>
        /// Compares values for equality
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <param name="epsilon"></param>
        /// <returns></returns>
        public static bool Equals(ref Vector3 v1, ref Vector3 v2, float epsilon)
        {
            return (Equals(v1.X, v2.X, epsilon) &&
                    Equals(v1.Y, v2.Y, epsilon) &&
                    Equals(v1.Z, v2.Z, epsilon));

        }

        /// <summary>
        /// Compares values for equality (epsion = 0.00001)
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool Equals(ref Vector3 v1, ref Vector3 v2)
        {
            return Equals(ref v1, ref v2, 0.00001f);
        }

        /// <summary>
        /// Compares values for equality
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <param name="epsilon"></param>
        /// <returns></returns>
        public static bool Equals(Vector3 v1, Vector3 v2, float epsilon)
        {
            return Equals(ref v1, ref v2, epsilon);
        }

        /// <summary>
        /// Compares values for equality (epsion = 0.00001)
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool Equals(Vector3 v1, Vector3 v2)
        {
            return Equals(ref v1, ref v2, 0.00001f);
        }

    }
}