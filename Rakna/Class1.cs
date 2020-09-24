using System;

namespace Rakna
{
    public class Matte
    {
        public double Add(double tal1, double tal2)
        {
            return tal1 + tal2;
        }

        public double Sub(double tal1, double tal2)
        {
        return tal1-tal2;
        }

        public bool Prim(int Tal)
        {
            bool resultat = true;
            if (Tal > 1)
            {
                for (int i = 2; i <= Tal / 2; i++)
                {
                    if (Tal % i == 0)
                    {
                        resultat = false;
                        break;
                    }
                }
                return resultat;
            }
            else
                return false;
        }


    }
}
