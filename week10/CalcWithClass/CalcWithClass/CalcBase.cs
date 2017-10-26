using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcWithClass
{
    public class CalcBase
    {
        public float firstNumber;
        public float secondNumber;
        public float result;
        public string operation;
        public float tmp;

        public float getResult()
        {
            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
            }
            return result;
        }

        public float PM()
        {
            tmp *= -1;
            return tmp;
        }

    }
}
