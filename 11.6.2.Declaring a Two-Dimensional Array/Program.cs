﻿using System;
class MainClass
{
    static void Main()
    {

        int[,] cells = new int[3, 3];

        int[,] d = {
            {1, 0, 2},
            {0, 2, 0},
            {1, 2, 1}
        };
        // Set the winning tic-tac-toe move to be player 1.
        d[1, 0] = 1;
       

    }
}