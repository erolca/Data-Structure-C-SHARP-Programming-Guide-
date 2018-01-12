using System;

/////////////////////////////////////////////////////////////////////
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


//Gets the perpendicular vector to a specified vector
//Gets the perpendicular vector to a specified vector

namespace Ale.Tools
{
    /// <summary>
    /// 
    /// </summary>
    public static class AleMathUtils
    {
        public static Random Random = new Random();

        /// <summary>
        /// Gets the perpendicular vector to a specified vector
        /// </summary>
        /// <param name="vec"></param>
        /// <param name="perp"></param>
        /// <returns></returns>
        public static void GetPerpVector(ref Vector3 vec, out Vector3 perp)
        {
            Vector3 vecAbs = new Vector3(Math.Abs(vec.X), Math.Abs(vec.Y), Math.Abs(vec.Z));
            //avoid parallel  vector
            if (vecAbs.X < vecAbs.Y)
            {
                if (vecAbs.X < vecAbs.Z)
                {
                    perp = Vector3.UnitX;
                }
                else
                {
                    perp = Vector3.UnitZ;
                }
            }
            else
            {
                if (vecAbs.Y < vecAbs.Z)
                {
                    perp = Vector3.UnitY;
                }
                else
                {
                    perp = Vector3.UnitZ;
                }
            }
            perp.Normalize();
            Vector3.Cross(ref vec, ref perp, out perp);
        }

        /// <summary>
        /// Gets the perpendicular vector to a specified vector
        /// </summary>
        /// <param name="vec"></param>
        /// <returns></returns>
        public static Vector3 GetPerpVector(ref Vector3 vec)
        {
            Vector3 perp;
            GetPerpVector(ref vec, out perp);
            return perp;
        }

        /// <summary>
        /// Gets the perpendicular vector to a specified vector
        /// </summary>
        /// <param name="vec"></param>
        /// <param name="perp"></param>
        /// <returns></returns>
        public static void GetPerpVector(ref Vector2 vec, out Vector2 perp)
        {
            perp = new Vector2(-vec.Y, vec.X);
        }
    }
}

