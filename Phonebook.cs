using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HomeworkPhonebook
{
    class Phonebook
    {
       
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            string commandLine = Console.ReadLine();

            while (!commandLine.Equals("END"))
            {
               string[]commandArgs = commandLine.Split(' ').ToArray();
                
                if (commandArgs[0].Equals("A"))
                {
                    // add to dictionary

                    string contact = commandArgs[1];
                    string number = commandArgs[2];
                    // first option for adding things in the Dictionary
                    //phonebook.Add(contact, number);
                    //second option for adding in a phonebook
                    phonebook[contact] = number; //- намира ключа и замества стойността, която му отговаря, докато при 
                    //първия вариант ако намери същия ключ ще даде Exception. Tъй като в задачата условието е да се ползва винаги
                    //последното, което е дадено, ще позлваме втората опция
                }
                else if (commandArgs[0].Equals("S"))
                {
                    string contact = commandArgs[1];
                    if (phonebook.ContainsKey(contact))
                    {
                        Console.WriteLine("{0} -> {1}", contact, phonebook[contact]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", contact);
                    }
                    
                }

                commandLine = Console.ReadLine();


            }
        }
    }
}
