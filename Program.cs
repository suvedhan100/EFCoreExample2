using System;
using System.Linq;
using EFCoreExample2.Models;

namespace EFCoreExample2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Console.WriteLine("Hello World!");
            var context = new testdbContext();
            var result = context.Personsview.Where(s => s.Id == 1)
                                              .FirstOrDefault();
            var del= context.Personsview.Where(s => s.Id == 2)
                                              .FirstOrDefault();
            // var list = context.Personsviews.ToList();
            Console.WriteLine(result.Firstname + " " + result.Lastname);

            if (result != null)
            {
                result.Firstname = "Sri";
                result.Lastname = "Balaji";
                context.Personsview.Update(result);

                Personsview personsview = new Personsview()
                {
                    Id = 6,
                    Firstname = "hari",
                    Lastname = "hari"
                };
                context.Add(personsview);
                if(del!=null)
                {
                    context.Remove(del);
                }
                context.SaveChanges();
            }

        }
    }
}
