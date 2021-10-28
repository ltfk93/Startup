using System;
using System.Collections.Generic;

namespace Startup
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Console program\n");
            Console.WriteLine("1. Create a person object\n2. Print the list content\n3. Display the options again\n4. Exit the program\n");
            List<Person> personList = new List<Person>();
            int start = 0;
            while(start != 4)
            {
                Console.Write("Choose a number: ");
                int result;
                if(int.TryParse(Console.ReadLine(), out result))
                {
                    start = result;
                    switch(result)
                    {
                        case 1:
                            {
                                Console.WriteLine("Type in the first name");
                                string firstName = Console.ReadLine();

                                Console.WriteLine("Type in the last name");
                                string lastName = Console.ReadLine();

                                Console.WriteLine("Type in the age");
                                int age;
                                int.TryParse(Console.ReadLine(),out age);

                                Person newPerson = new Person(firstName, lastName, age);
                                personList.Add(newPerson);

                                Console.WriteLine($"{newPerson.getfirstName()} {newPerson.getLastName()} has been added to the list!");
                               
                                break;


                            }

                        case 2:
                            {
                                foreach(Person person in personList)
                                {
                                    person.printInfo();

                                    Console.WriteLine("\n");
                                }
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("1. Create a person object\n2. Print the list content\n3. Display the options again\n4. Exit the program\n");
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("Exiting the program...");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Invalid input provided.");
                                break;
                            }

                    }
                }
                else
                {
                    Console.WriteLine("Please provide a number\n");
                }
            }
        }
    }

    class Person
    {
        private string firstName, lastName;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public void printInfo()
        {
            Console.WriteLine($"Full name: {this.firstName} {this.lastName}\nAge: {this.age}");
        }

        public int getAge()
        {
            return age;
        }

        public string getfirstName()
        {
            return firstName;
        }

        public string getLastName()
        {
            return lastName;
        }

    }
}
