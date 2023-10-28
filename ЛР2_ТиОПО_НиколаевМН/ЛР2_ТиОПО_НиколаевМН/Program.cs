using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ЛР2_ТиОПО_НиколаевМН
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа 'Решение квадратного уравнения'");
            Console.WriteLine("Данная программа получает переменные a, b и с из текстового файла, затем подставляет их в формулу квадратного уравнения и решает его\n");
            Console.WriteLine("Получение данных...");

            string path = String.Concat(Directory.GetParent(Convert.ToString(Directory.GetParent(Directory.GetCurrentDirectory()))), "\\input_data.txt");
            string text = null;
            try
            {
                text = File.ReadAllText(path);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.WriteLine("\nНажмите Enter, чтобы выйти");
                Console.ReadLine();
                return;
            }
            string[] input_data = text.Split(' ');
            try
            {
                string pattern = @"^-?\d+(,\d)?\d*$";
                if (input_data.Length < 3 || !Regex.IsMatch(input_data[0], pattern) || !Regex.IsMatch(input_data[1], pattern) || !Regex.IsMatch(input_data[2], pattern))
                    throw new InputDataException("Входные данные отсутствуют или имеют неверный формат");
            }
            catch (InputDataException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.WriteLine("\nНажмите Enter, чтобы выйти");
                Console.ReadLine();
                return;
            }
            finally
            {
                Console.WriteLine("Данные получены");
            }
            double a = Convert.ToDouble(input_data[0]);
            double b = Convert.ToDouble(input_data[1]);
            double c = Convert.ToDouble(input_data[2]);
            QuadraticEquation equation = new QuadraticEquation(a, b, c);
            equation.ShowEquation();
            try
            {
                equation.SolveEquation();
            }
            catch (FirstArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (NegativeDiscriminantException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            Console.WriteLine("\nНажмите Enter, чтобы выйти");
            Console.ReadLine();
        }
    }
}
