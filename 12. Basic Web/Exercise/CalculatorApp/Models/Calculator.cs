using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorApp.Models
{
    public class Calculator
    {
        public Calculator()
        {
            Result = 0;
        }

        public decimal LeftOperand { get; set; }
        public decimal RightOperand { get; set; }
        public string Operator { get; set; }
        public decimal Result {get; set;}

        public void CalculateResult()
        {
            switch (Operator)
            {
                case "+":
                    Result = LeftOperand + RightOperand;
                    break;
                case "-":
                    Result = LeftOperand - RightOperand;
                    break;
                case "*":
                    Result = LeftOperand * RightOperand;
                    break;
                case "/":
                    Result = LeftOperand / RightOperand;
                    break;
                default:
                    break;
            }
        }
    }
}
