using CommandPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Concrete
{
    class CalculatorCommand : Command
    {
        private char _operator;
        private int operand;
        private Calculator calculator;

        public CalculatorCommand(Calculator calculator, char @operator, int operand)
        {
            this.calculator = calculator;
            this._operator = @operator;
            this.operand = operand;
        }

        public int Operand
        {
            get { return operand; }
        }


        public char Operator
        {
            get { return _operator; }
        }

        public override void Execute()
        {
            calculator.Operation(_operator, operand);
        }

        public override void UnExecute()
        {
            calculator.Operation(Undo(_operator), operand);
        }

        private char Undo(char @operator)
        {
            switch (@operator)
            {
                case '+':
                    return '-';
                case '-':
                    return '+';
                case '*':
                    return '/';
                case '/':
                    return '*';
                default:
                    throw new ArgumentException("@operator");
            }
        }
    }
}
