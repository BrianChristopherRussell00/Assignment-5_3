using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_3
{
    public class FlowerBed
    {
        public static bool AdjacentFlowers(int[] flowers, int n)
        {
            int planted = 0;
           if (n == 0)
            {
                return true;
                planted = 0;

            }
            foreach (int i in flowers)   
            { var leftIsEmpty= (i==0) || (flowers[i-1]==0);
              var rightIsEmpty= (i==flowers.Length-1) ||(flowers[i+1]==0);
                if(flowers[i] == 0 && leftIsEmpty && rightIsEmpty)
                {
                    flowers[i] = 1;
                    planted += 1;

                }
                if (planted == n)
                {
                    return true ;
                }
                return false ;
            }

        return true ;
        
        }



    }
}
