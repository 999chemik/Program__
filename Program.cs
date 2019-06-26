using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program 
    {
    
        static void Main(string[] args)
        {


            DataFormater Data = new DataFormater(args);



            if (Data.Validate_Input_Args())
            {

                Data.ValidationDate();
                
            }

           


        }
    }
}
