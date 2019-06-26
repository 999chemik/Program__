using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Program
{
    public class ValidationDate 
    {



        #region Constructor
        public ValidationDate(string[] args) 
        {

            this.args = args;

        }
        #endregion

      

        public string[] args { get; set; }


        public bool Validate_Input_Args()
        {

            DateTime StartDate, EndDate;
  
            // check number parameters  
            if (args.Length != 2)
            {

                print_message("\nError! Input parameters is not correct ! You should use 2 dates ! Click enter and finish program...  ");
                return false;

            }


            //verificate 2 input value - correct format DD.MM.YYYY
            else if ((     args[0]).IndexOf("/") != -1 || args[1].IndexOf("/") != -1  ||
                           !(DateTime.TryParse((args[0]).Replace(".", "/"), CultureInfo.CreateSpecificCulture("fr-FR"), DateTimeStyles.AssumeLocal | DateTimeStyles.AdjustToUniversal, out StartDate))
                            || !(DateTime.TryParse((args[1]).Replace(".", "/"), CultureInfo.CreateSpecificCulture("fr-FR"), DateTimeStyles.AssumeLocal | DateTimeStyles.AdjustToUniversal, out EndDate)))
            {

                print_message("\nError! Input Date/-s is not correct ! Correct format : DD.MM.YYYY  Click enter and finish program... ");
                return false;

            }

            // Date end must be bigger than std 
            else if ((EndDate - StartDate).Days <= 0)
            {
                print_message("\nError! The second date is smaller than the first !  Click enter and finish program... ");
                return false;

            }




            return true;
        }


        public void print_message(string info)
        {
            Console.WriteLine(info);
            Console.Read();
        }




    }
}
