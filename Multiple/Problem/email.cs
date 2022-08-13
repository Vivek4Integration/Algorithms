using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Problem
{
    public class email
    {
        public static int NumUniqueEmails(string[] emails)
        {
            List<string> uniqueemail = new List<string>();
            foreach (string email in emails)
            {
                var localnameArray = email.Split('@');
                var localname = localnameArray[0];
              
                    localname = localname.Contains(".")? localname.Replace(".",""):localname;

                    localname = localname.Contains("+") ? localname.Substring(0, localname.IndexOf("+")):localname;
                    var uniquemail = string.Concat(localname, "@", localnameArray[1]);
                    if (!uniqueemail.Contains(uniquemail))
                    uniqueemail.Add(uniquemail);
            }

            return uniqueemail.Count;
        }
    }
}
