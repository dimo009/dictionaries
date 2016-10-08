using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Homework_Fix_Emails
{
    class FixEmailsWithUsOrUk
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> contacts = new Dictionary<string, string>();

            string name = Console.ReadLine();

            while (!name.Equals("stop"))
            {

                string email = Console.ReadLine().ToLower();
                //string[] reworkedMail = email.Split('.').ToArray();

                //if ((!contacts.ContainsKey(name)) && (!reworkedMail[1].Equals("uk") && !reworkedMail[1].Equals("us")))
                //{

                //        contacts.Add(name, email);


                //}
                string endingsuffix = email.Substring(email.Length - 2, 2).ToLower();

                if (endingsuffix != "uk" && endingsuffix != "us")

                {
                    contacts.Add(name, email);
                }
                name = Console.ReadLine();


            }
            foreach (var entry in contacts)
            {
                Console.WriteLine("{0} -> {1}", entry.Key, entry.Value);
            }



        }
    }
}
