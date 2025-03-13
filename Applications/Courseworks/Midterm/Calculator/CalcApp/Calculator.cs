using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CalcApp
{
    public class Calculator
    {
        private string _first;
        private string _second;
        private char _function;
        private string _userInput;
        private double _result;

        public Calculator()
        {
            
        }

        public Calculator(string first, string second, char function, string userInput)
        {
            _first = first;
            _second = second;
            _function = function;
            _userInput = userInput;
        }

        public string First
        {
            get { return  _first; }
            set { _first = value; }
        }
        public string Second
        {
            get { return _second; }
            set { _second = value; }
        }
        public char Function
        {
            get { return _function; }
            set { _function = value; }
        }
        public string UserInput
        {
            get { return _userInput; }
            set { _userInput = value; }
        }
        public double Result
        {
            get { return _result; }
            set { _result = value; }
        }
        public string AddingNumbertoTXT(string buttonText)
        {
            UserInput += buttonText;
            return UserInput;
        }
        public string ConvertNum(double tempvalue)
        {
            tempvalue = -tempvalue;
            UserInput = Convert.ToString(tempvalue);
            return UserInput;
        }

        public void EqualsButton()
        {
            Second = UserInput;
            double firstNum;
            double secondNum;
            firstNum = Convert.ToDouble(First);
            secondNum = Convert.ToDouble(Second);
            if (Function == '+')
            {
                Result = firstNum + secondNum;
            }
            else if (Function == '-')
            {
                Result = firstNum - secondNum;
            }
            else if (Function == '/')
            {
                try
                {
                    if (secondNum == 0)
                    {
                        throw new DivideByZeroException("Error: Divide by Zero.");
                    }
                    Result = firstNum / secondNum;
                }
                catch (DivideByZeroException ZeroEx)
                {
                    MessageBox.Show(ZeroEx.Message, "Calculator");
                }
            }
            else if (Function == '*')
            {
                Result = firstNum * secondNum;
            }
        }
        public string Reciprocal(double tempvalue)
        {
            double reciprocal = 0;
            if (tempvalue != 0)
            {
                reciprocal = 1 / tempvalue;
            }
            UserInput = Convert.ToString(reciprocal);
            return UserInput;
        }
        public string BackKey()
        {
            if (UserInput != "")
            {
                UserInput = UserInput.Remove(UserInput.Length - 1);
            }
            if (UserInput == "")
            {
                UserInput = "0";
            }
            return UserInput;
        }
        public string SquareRoot(double tempvalue)
        {
            if (tempvalue >= 0)
            {
                tempvalue = Math.Sqrt(tempvalue);
            }
            UserInput = Convert.ToString(tempvalue);
            return UserInput;
        }
    }
}
