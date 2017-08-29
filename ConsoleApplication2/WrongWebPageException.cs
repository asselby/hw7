using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ConsoleApplication2
{
   public  class WrongWebPageException:WebException
    {
        public override string Message
        {
           get
            {
                return string.Format("Wrong web page!");
            }
        }
    }
}
