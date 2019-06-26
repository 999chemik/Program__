using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class DataFormater : ValidationDate
    {



        public DataFormater(string[] args) :base(args)
        {
                  this.args = args;
         }

        

        public string ValidationDate()
        {
           
            var StartDate = args[0].Split('.');
            var EndDate = args[1].Split('.');



            string date_desc;

            if ((StartDate[1]) == EndDate[1] && StartDate[2] == EndDate[2])  //dd1 - dd2.mm2.yy2
            {
                date_desc = StartDate[0] + " - " + EndDate[0] + "." + EndDate[1] + "." + EndDate[2];
            }

            else if (StartDate[2] == EndDate[2] && StartDate[1] != EndDate[1]) //dd1.mm2 - dd2.mm2.yy2
            {
                date_desc = StartDate[0] + "." + StartDate[1] + " - " + EndDate[0] + "." + EndDate[1] + "." + EndDate[2];
            }


            else //dd1.mm1.yy1 - dd2.mm2.yy2
            {
                date_desc = StartDate[0] + "." + StartDate[1] + "." + StartDate[2] + " - " + EndDate[0] + "." + EndDate[1] + "." + EndDate[2];
            }

           
            print_message(date_desc);
            return date_desc;
        }






    }
}
