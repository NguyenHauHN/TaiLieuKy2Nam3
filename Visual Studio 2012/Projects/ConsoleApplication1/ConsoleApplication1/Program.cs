using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApplication1
{
 
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            for (x = 10; x <= 15; x++)
                while(Convert.ToBoolean(Convert.ToInt32(x)))
            {
                do
                {
                    Console.Write(1);
                    if (Convert.ToBoolean(x >> 1))
                        continue;
                } while (Convert.ToBoolean(0));
                break;
            }
                Console.ReadLine();
        }
        
       
    }
}
