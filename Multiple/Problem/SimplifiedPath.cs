using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Problem
{
    public class SimplifiedPath
    {
        public static string SimplifyPathUnix(string path)
        {
            // Initialize a stack
            Stack<String> stack = new Stack<String>();
            String[] components = path.Split('/');

            // Split the input string on "/" as the delimiter
            // and process each portion one by one
            foreach (String directory in components)
            {

                // A no-op for a "." or an empty string
                if (directory.Equals(".") || string.IsNullOrEmpty(directory))
                {
                    continue;
                }
                else if (directory.Equals(".."))
                {

                    // If the current component is a "..", then
                    // we pop an entry from the stack if it's non-empty
                    if (stack.Count>0)
                    {
                        stack.Pop();
                    }
                }
                else
                {

                    // Finally, a legitimate directory name, so we add it
                    // to our stack
                    stack.Push(directory);
                }
            }

            var stackLenght = stack.Count;
            // Stich together all the directory names together
            // Stich together all the directory names together
            StringBuilder result = new StringBuilder();
            //for (int i = 0; i < stackLenght; i++)
            //{
            //    result.Append("/");
            //    result.Append(stack.Pop());

            var reverse = stack.Reverse();
            foreach (var item in reverse)
            {
                result.Append("/");
                result.Append(item);
            }
            return result.Length > 0 ? result.ToString() : "/";

          
        }
    }
    
}
