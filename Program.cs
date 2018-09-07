using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPCalculator
{
    class Opetn
    {
        public string name;
        public int coursesoff;
//comment by fam

        public void getDetails()
        {

            Console.WriteLine("Enter your name in full");
            name = Console.ReadLine();

            Console.WriteLine("Enter the number of courses you offered");
            coursesoff = int.Parse(Console.ReadLine());

            do
            {

                try
                {
                    if (coursesoff <= 1)
                        Console.WriteLine("The number of course offered must be greater than 1");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }


            } while (coursesoff <= 1);



        }
        public void calc()
        {
            string Choice;
            do
            {
                getDetails();
                int[] courseunit = new int[coursesoff];
                int[] coursegrade = new int[coursesoff];
                float cgpa;
                Console.WriteLine("Your grades and course unit must be numeric values");
                for (int i = 0; i < coursesoff; i++)
                {
                    Console.WriteLine("Enter your  course grade:", i);
                    coursegrade[i] = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the unit of the course ", i);
                    courseunit[i] = int.Parse(Console.ReadLine());

                }

                float sum = 0;

                float mulsum = 0;

                for (int i = 0; i < courseunit.Length; i++)
                {
                    sum += courseunit[i];
                }
                Console.WriteLine("Your Total unit was {0}", sum);

                int[] mul = new int[coursesoff];
                for (int i = 0, j = 0; i < courseunit.Length; i++, j++)
                {
                    mul[i] = ((courseunit[i] * coursegrade[j]));
                }
                for (int i = 0; i < mul.Length; i++)
                {
                    mulsum += mul[i];
                }

                cgpa = mulsum / sum;
                Console.WriteLine("Your GP is {0}", cgpa);

                do
                {
                    Console.WriteLine("DO You want to calaculate another GP,YES/NO??");
                    Choice = Console.ReadLine().ToUpper();
                } while ((Choice != "YES") && (Choice != "NO"));

                //Console.WriteLine(Choice);
            } while (Choice == "YES");

        }

        class Program
        {
            static void Main(string[] args)
            {
                Opetn gp = new Opetn();
   
                gp.calc();
                Console.ReadLine();
                #region obsoletemethod
                /*
                 Console.WriteLine("How many course are you offering");
                int nocourse;
                nocourse = int.Parse(Console.ReadLine());
                if (nocourse <= 1)
                {
                    Console.WriteLine("Enter at least 2 or more courses");
                }
                else
                {
                    int[] courseunit = new int[nocourse];
                    int[] coursegrade = new int[nocourse];
                    float cgpa;

                    for (int i = 0; i < nocourse; i++)
                    {

                        Console.WriteLine("Enter your {0} course grade:", ++i);
                        coursegrade[i] = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the {0} unit of the course ", i);
                        courseunit[i] = int.Parse(Console.ReadLine());
                        --i;

                    }

                    float sum = 0;

                    float mulsum = 0;

                    for (int i = 0; i < courseunit.Length; i++)
                    {
                        sum += courseunit[i];
                    }
                    Console.WriteLine(sum);

                    int[] mul = new int[nocourse];
                    for (int i = 0, j = 0; i < courseunit.Length; i++, j++)
                    {
                        mul[i] = ((courseunit[i] * coursegrade[j]));
                    }
                    for (int i = 0; i < mul.Length; i++)
                    {
                        mulsum += mul[i];
                    }

                    cgpa = mulsum / sum;
                    Console.WriteLine(cgpa);
                }
                **/
                #endregion

            }

            


        }
    }
}

