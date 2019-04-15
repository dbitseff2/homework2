using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<Models.User>();

            users.Add(new Models.User { Name = "Dave", Password = "hello" });
            users.Add(new Models.User { Name = "Steve", Password = "steve" });
            users.Add(new Models.User { Name = "Lisa", Password = "hello" });

            //1.Display to the console, all the passwords that are "hello".Hint: Where
            var helloPasswords = users.Where(u => u.Password == "hello");
            helloPasswords.ToList().ForEach(u => Console.WriteLine(u.Name + " " + u.Password));
            Console.WriteLine("----------------------------------------------------------------");

            //2.Delete any passwords that are the lower-cased version of their Name. Do not just look for "steve".It has to be data - driven.Hint: Remove or RemoveAll
            users.RemoveAll(u => u.Name.ToLower() == u.Password);

            //3.Delete the first User that has the password "hello".Hint: First or FirstOrDefault            
            users.Remove(users.FirstOrDefault(u => u.Password == "hello"));

            //4.Display to the console the remaining users with their Name and Password.
            users.ToList().ForEach(u => Console.WriteLine(u.Name + " " + u.Password));


        }
    }
}
