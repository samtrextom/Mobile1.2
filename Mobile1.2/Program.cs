using System;
using System.Collections.Generic;

namespace Mobile1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            bool inProgram = true;
            do
            {

                Console.WriteLine("Please Enter A:");
                Console.WriteLine("1) Stdent");
                Console.WriteLine("2) Teacher");
                Console.WriteLine("3) Exist");

                String response = Console.ReadLine();

                switch(response)
                {
                    case "1":
                        {
                            Student tempStudent = new Student();
                            Console.WriteLine("Name:");
                            tempStudent.Name = Console.ReadLine();
                            Console.WriteLine("Age:");
                            tempStudent.Age = int.Parse(Console.ReadLine());
                            Console.WriteLine("ID:");
                            tempStudent.ID = int.Parse(Console.ReadLine());
                            

                            bool validProgram;

                            do
                            {
                                Console.WriteLine("Program:");
                                Console.WriteLine("1) Computer Science");
                                Console.WriteLine("2) Accounting");
                                Console.WriteLine("3) Marketing");
                                Console.WriteLine("4) Nursing");

                                switch (int.Parse(Console.ReadLine()))
                                {
                                    case 1: { tempStudent.Program = ProgramEnum.Computer_Science; validProgram = true; break; }
                                    case 2: { tempStudent.Program = ProgramEnum.Accounting; validProgram = true; break; }
                                    case 3: { tempStudent.Program = ProgramEnum.Marketing; validProgram = true; break; }
                                    case 4: { tempStudent.Program = ProgramEnum.Nursing; validProgram = true; break; }
                                    default: { Console.WriteLine("Not a Valid entry"); validProgram = false; break; }
                                }

                            } while (!validProgram);

                            Console.WriteLine("Credits:");
                            tempStudent.CreditsEarned = int.Parse(Console.ReadLine());

                            people.Add(tempStudent);
                            break;
                        }
                    case "2":
                        {
                            Teahcer tempTeacher = new Teahcer();
                            Console.WriteLine("Name:");
                            tempTeacher.Name = Console.ReadLine();
                            Console.WriteLine("Age:");
                            tempTeacher.Age = int.Parse(Console.ReadLine());
                            Console.WriteLine("ID:");
                            tempTeacher.ID = int.Parse(Console.ReadLine());


                            bool validProgram;

                            do
                            {
                                Console.WriteLine("Program:");
                                Console.WriteLine("1) Computer Science");
                                Console.WriteLine("2) Accounting");
                                Console.WriteLine("3) Marketing");
                                Console.WriteLine("4) Nursing");

                                switch (int.Parse(Console.ReadLine()))
                                {
                                    case 1: { tempTeacher.Program = ProgramEnum.Computer_Science; validProgram = true; break; }
                                    case 2: { tempTeacher.Program = ProgramEnum.Accounting; validProgram = true; break; }
                                    case 3: { tempTeacher.Program = ProgramEnum.Marketing; validProgram = true; break; }
                                    case 4: { tempTeacher.Program = ProgramEnum.Nursing; validProgram = true; break; }
                                    default: { Console.WriteLine("Not a Valid entry"); validProgram = false; break; }
                                }

                            } while (!validProgram);

                            Console.WriteLine("Years Of Service:");
                            tempTeacher.YearsOfService = int.Parse(Console.ReadLine());
                            people.Add(tempTeacher);

                            break;
                            
                        }
                    case "3":
                        {
                            inProgram = false;
                            break;
                        }
                    default: { Console.WriteLine("Invalid Entry"); break; }

                }


            } while (inProgram);

            foreach(Person p in people)
            {
                Console.WriteLine(p.ToString());
            }
        }
            
    }
}
