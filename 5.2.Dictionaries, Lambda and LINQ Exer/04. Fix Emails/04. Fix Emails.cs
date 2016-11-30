using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> usersEmails = new Dictionary<string, string>();
            string[] domains = { ".us", ".uk" };

            string userName = Console.ReadLine();

            while (!userName.Equals("stop"))
            {
                string userEmail = Console.ReadLine();

                usersEmails.Add(userName, userEmail);

                userName = Console.ReadLine();
            }

            RemoveEmailsByDomain(usersEmails, ".uk");
            RemoveEmailsByDomain(usersEmails, ".us");
            
            foreach (var item in usersEmails)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }

        private static void RemoveEmailsByDomain(Dictionary<string, string> usersEmails, string domain)
        {
            var filteredEmails = usersEmails.Where(x => x.Value.EndsWith(domain)).ToList();

            foreach (var userEntry in filteredEmails)
            {
                usersEmails.Remove(userEntry.Key);
            }
        }
    }
}
