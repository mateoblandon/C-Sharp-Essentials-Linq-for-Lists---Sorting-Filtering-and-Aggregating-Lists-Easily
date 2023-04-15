using LinqLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Person> people = ListManager.LoadSampleData();
      //people = people.OrderBy(x => x.LastName).ToList(); // this line orde th list by LastName
      people = people.OrderByDescending(x => x.LastName).ThenByDescending(x => x.YearsExperience).ToList();
      people = people.Where(x => x.YearsExperience > 5 && x.Birthday.Month == 3).ToList();
      int yearsTotal = people.Sum(x => x.YearsExperience);
      yearsTotal = people.Where(x => x.Birthday.Month == 3).Sum(x => x.YearsExperience);
      foreach (Person person in people)
      {
        Console.WriteLine($"{person.FirstName} {person.LastName} ({person.Birthday.ToShortDateString()}): Experience {person.YearsExperience}");
      }
      Console.ReadLine();
    }
  }
}
