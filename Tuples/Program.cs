using System;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            var tuple = (5, 20);
            Console.WriteLine(tuple.Item1); // 5
            Console.WriteLine(tuple.Item2); // 20
            tuple.Item1 += 20;
            Console.WriteLine(tuple.Item1); // 25
            Console.WriteLine();
            #endregion

            #region
            (string, int, double) person = ("Tom", 25, 81.23);
            Console.WriteLine(person.Item1); //Tom
            Console.WriteLine(person.Item2); //25
            Console.WriteLine(person.Item3); //81.23
            Console.WriteLine();
            #endregion
           
            #region
            var tuple1 = (count: 5, sum: 10); //set field name
            Console.WriteLine(tuple1.count); // 5
            Console.WriteLine(tuple1.sum); // 10
            Console.WriteLine();
            #endregion
          
            #region
            var (name, age) = ("Tom", 23);
            Console.WriteLine(name);    // Tom
            Console.WriteLine(age);     // 23
            Console.WriteLine();
            #endregion
           
            #region
            var tuple3 = GetValues();
            Console.WriteLine(tuple3.Item1); // 1
            Console.WriteLine(tuple3.Item2); // 3
            Console.WriteLine();
            #endregion
           
            #region
            var tuple4 = GetNamedValues(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            Console.WriteLine(tuple4.count);
            Console.WriteLine(tuple4.sum);
            Console.WriteLine();
            #endregion

            #region
            var (namePerson, agePerson) = GetTuple(("Tom", 23), 12);
            Console.WriteLine(namePerson);    // Tom
            Console.WriteLine(agePerson);     // 35
            #endregion

            Console.ReadKey();
        }

        #region private methods
        private static (int, int) GetValues()
        {
            var result = (1, 3);
            return result;
        }

        private static (int sum, int count) GetNamedValues(int[] numbers)
        {
            var result = (sum: 0, count: 0);
            for (int i = 0; i < numbers.Length; i++)
            {
                result.sum += numbers[i];
                result.count++;
            }
            return result;
        }

        private static (string name, int age) GetTuple((string n, int a) tuple, int x)
        {
            var result = (name: tuple.n, age: tuple.a + x);
            return result;
        }
        #endregion private methods
    }
}
