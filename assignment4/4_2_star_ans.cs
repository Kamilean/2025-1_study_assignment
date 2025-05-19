using System;

namespace star
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius: ");
            int radius = int.Parse(Console.ReadLine());
            int size = 2 * (radius + 1);

            // ---------- TODO ----------
            for (int i=0;i<size;i++)
            {
                string line ="";
                for (int j=0;j<size;j++)
                {
                    if (i==0||i==size-1)
                    {
                        if (j<size*2/3)
                            line += "*";
                        else
                            line += " ";
                    }
                    else if (j==0)
                    {
                        line+= "*";
                    }
                    else
                    {
                        line += " ";
                    }
                }
                line += "    ";
                for (int j=0;j<size;j++)
                {
                    if (i==size/3||i==2*size/3||j==size/3||j==2*size/3)
                        line += "*";
                    else
                        line += " ";
                }
                Console.WriteLine(line);
            }
            // --------------------
        }

        // calculate the distance between (x1, y1) and (x2, y2)
        static double SqrDistance2D(double x1, double y1, double x2, double y2)
        {
            return Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2);
        }

        // Checks if two values a and b are within a given distance.
        // |a - b| < distance
        static bool IsClose(double a, double b, double distance)
        {
            return Math.Abs(a - b) < distance;
        }
    }
}


/* example output
Enter the radius: 
>> 5
                *   *   
  *********     *   *   
 *              *   *   
 *              *   *   
 *          ************
 *              *   *   
 *              *   *   
 *              *   *   
 *          ************
 *              *   *   
 *              *   *   
  *********     *   *   

*/

/* example output (CHALLANGE)
Enter the radius: 
>> 5
                *   *  
      *         *   *  
   *     *      *   *  
  *                    
           ************
               *   *   
 *             *   *   
               *   *   
           ************
  *                    
   *     *    *   *    
      *       *   *    

*/
