using System;

    class CompareFloats
    {
        static void Main()
        {
            float eps = 0.000001f;

            //example 1
            CompareTwoFloats(5.3, 6.01, eps);

            //example 2
            CompareTwoFloats(5.00000001, 5.00000003, eps);

            //example 3
            CompareTwoFloats(5.00000005, 5.00000001, eps);

            //example 4
            CompareTwoFloats(-0.0000007, 0.00000007, eps);

            //example 5
            CompareTwoFloats(-4.999999, -4.999998, eps);

            //example 6
            CompareTwoFloats(4.999999, 4.999998, eps);
        }

        static bool CompareTwoFloats(double f1, double f2, float eps)
        {
            float difference = (float)Math.Abs(f1 - f2);
            bool result = difference < eps;

            Console.WriteLine(result);
            if (difference > eps)
            {
                Console.WriteLine("The difference of {0:##.####################} is too big (> eps)", difference);
            }
            else if (difference < eps)
            {
                Console.WriteLine("The difference {0:##.####################} < eps", difference);
            }
            else if (difference == eps)
            {
                Console.WriteLine("Border case. The difference {0:##.####################} == eps. We consider the numbers are different.", difference);
            }
            
            return result;
        }
    }

