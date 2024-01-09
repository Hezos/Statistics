using System;

namespace Common{
    public abstract class BaseCalculation{

        public double Division(double num1, double num2){
            return num1 / num2;
        }

        public double SquareRoot(double num1, double num2){
            return Math.Sqrt(num1);
        }

        public double Multiply(double num1, double num2){
            return num1 * num2;
        }

        public double Addition(double num1, double num2){
            return num1 + num2;
        }

        public double Substraction(double num1, double num2){
            return num1 - num2;
        }

        public double Power(double number, double powerValue){
            return Math.Pow(number, powerValue);
        }

        public double Sum(List<double> Numbers){
            double sum = 0;
            foreach(double number in Numbers){
                sum += number;
            }
            
            return sum;
        }
    }
}