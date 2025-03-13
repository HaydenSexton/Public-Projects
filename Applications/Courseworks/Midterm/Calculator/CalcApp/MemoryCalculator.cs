using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcApp
{
    public class MemoryCalculator : Calculator
    { // MC = memory clear; MS = memory save; MR = memory recall, display memory value in textbox; M+ = add memory value to what is displayed in textbox
        private string _first;
        private string _second;
        private char _function;
        private string _userInput;
        private double _result;
        private string _memory;
        public MemoryCalculator()
        {

        }
        public MemoryCalculator(string first, string second, char function, string userInput) : base(first, second, function, userInput)
        {
            _first = first;
            _second = second;
            _function = function;
            _userInput = userInput;
        }

        public string First
        {
            get { return _first; }
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
        public string Memory
        {
            get { return _memory; }
            set { _memory = value; }
        }
        public string MemoryAdd()
        {
            string currentInput = Convert.ToString(UserInput); 
            double firstNum = Convert.ToDouble(First);
            double secondNum = Convert.ToDouble(UserInput);
            double finalInput = firstNum + secondNum;
            Memory = Convert.ToString(finalInput);

            return Memory;
        }
    }
}
