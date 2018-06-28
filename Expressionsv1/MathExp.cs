using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Expressionsv1
{
    class MathExp
    {
        private Regex regex = new Regex(@"\W");
        private string userExpression;
        private Stack<string> operands = new Stack<string>();
        private Stack<string> operations = new Stack<string>();
        private string test = "";
        public MathExp(string userExpression)
        {
            this.userExpression = userExpression;
            FindOperands();
            test += "\n";
            FindOperations();
        }
        public void FindOperations()
        {
            foreach (Match match in regex.Matches(userExpression))
            {
                operations.Push(match.ToString());
                test += match.ToString() + " ";
            }
        }
        public void FindOperands()
        {
            List<string> preOperands = Regex.Split(userExpression, @"\W").ToList();
            foreach (string i in preOperands)
            {
                operands.Push(i);
                test += i.ToString()+" ";
            }
        }
        public string getTest()
        {
            return test;
        }
    }
}
