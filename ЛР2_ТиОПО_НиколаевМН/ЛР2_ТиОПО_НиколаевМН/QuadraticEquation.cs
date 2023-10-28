using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР2_ТиОПО_НиколаевМН
{
    internal class QuadraticEquation
    {
        double a, b, c;

        public QuadraticEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void ShowEquation()
        {
            string equation = $"{a}x^2";
            if (b >= 0)
                equation = equation + $"+{b}x";
            else
                equation = equation + $"{b}x";
            if (c >= 0)
                equation = equation + $"+{c}=0";
            else
                equation = equation + $"{c}=0";

            Console.WriteLine($"Полученное квадратное уравнение: {equation}");
        }

        public void SolveEquation()
        {
            if (a == 0)
                throw new FirstArgumentException("Аргумент a не может быть равен нулю");

            double D = b * b - 4 * a * c;

            if (D < 0)
                throw new FirstArgumentException("Уравнение не имеет решений, т.к. дискриминант отрицательный");

            double x1 = (-1 * b + Math.Sqrt(D)) / (2 * a);
            double x2 = (-1 * b - Math.Sqrt(D)) / (2 * a);

            if (x1 == x2)
                Console.WriteLine($"Решение квадратного уравнения: {x1}");

            Console.WriteLine($"Решение квадратного уравнения: {x1}, {x2}");
        }
    }
}
