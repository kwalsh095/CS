using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace HW3
{
    class Calculator
    {
        private static Stack s = new Stack();

        /// <summary>
        /// Main entry point into the postfix calculator
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            Console.WriteLine("This is a Postfix Calculator, accepted operators are: + - * /");

            bool playAgain = true;
            while (playAgain)
            {
                playAgain = DoCalc();
            }
            Console.WriteLine("Goodbye.");
        }
        
        /// <summary>
        /// Run the calculation or quit.
        /// </summary>
        /// <returns></returns>
        private static bool DoCalc()
        {
            Console.WriteLine("Press q to Quit.");
            Console.WriteLine(">>");
            
            //Store input
            string input = Console.ReadLine();
            
            // See if the user wishes to quit
            if (input.StartsWith("q") || input.StartsWith("Q"))
            {
                return false;
            }

            string output;

            try
            {
                output = Evaluate(input);
                Console.WriteLine(input + " equals " + output);
                return true;
            }
            catch (ArgumentOutOfRangeException e)
            {

                output = e.Message;
                Console.WriteLine(output);
                return true;
            }
            
        }
        /// <summary>
        /// Evaluate an arithmetic expression written in postfix form.
        /// </summary>
        /// <param name="input">the equation given by the user</param>
        /// <returns>the solved equation</returns>
        public static string Evaluate(string input)
        {
            if (input == null || input.Equals(""))
            {
                throw new ArgumentOutOfRangeException("The equation is empty.");
            }

            s.Clear();

            string token = ""; //current read
            int a, b, c; //Temporary holders for equation

            StringReader st = new StringReader(input);
            char current = (char)st.Read();

            while (current != 65535)
            {
                if (current > 47 && current < 58) //ASCII decimal values for 0 - 9
                {
                    token += current;
                    current = (char)st.Read();
                }
                else if (current.Equals(' ')) {
                    if (token.Length > 0)
                    {
                        s.Push(int.Parse(token)); 
                    }
                    token = "";
                    current = (char)st.Read();
                }
                else
                {
                    
                    if (s.Count == 0)
                        throw new ArgumentOutOfRangeException("Improper input format. Stack became empty when expecting second operand.");
                    b = (int)s.Pop();
                    if (s.Count == 0)
                        throw new ArgumentOutOfRangeException("Improper input format. Stack became empty when expecting second operand.");
                    a = (int)s.Pop();
                    c = DoOperation(a, b, current);
                    s.Push(c);
                    current = (char)st.Read();
                }

            }
            return s.Pop().ToString();
        }

        /// <summary>
        /// Perform arithmetic.  Put it here so as not to clutter up the previous method, which is already pretty ugly.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="s"></param>
        /// <returns>operation result</returns>
        public static int DoOperation(int a, int b, char s)
        {
            int c = 0;
            if (s.Equals('+'))      // Can't use a switch-case with chars, so we do if-else
                c = (a + b);
            else if (s.Equals('-'))
                c = (a - b);
            else if (s.Equals('*'))
                c = (a * b);
            else if (s.Equals('/'))
            {
                try
                {
                    c = (a / b);
                }
                catch (Exception e)
                {
                    throw new ArgumentOutOfRangeException("Cannot divide by zero");
                }
            }
            else
                throw new ArgumentOutOfRangeException("Improper operator: " + s + ", is not one of +, -, *, or /");

            return c;
        }

        
    }
}
