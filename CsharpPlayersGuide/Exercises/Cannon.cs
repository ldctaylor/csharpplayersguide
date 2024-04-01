using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

//p89

namespace CsharpPlayersGuide.Exercises
{
    internal class Cannon
    {
        public static int FireCannon(int turnNumber)
        {
            int damage = 0;

            if (turnNumber % 3 == 0 && turnNumber % 5 == 0)
                damage = 10;

            else if (turnNumber % 3 == 0 || turnNumber % 5 == 0)
                damage = 3;

            else
                damage = 1;

            return damage;
        }
    }
}
