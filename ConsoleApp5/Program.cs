// See https://aka.ms/new-console-template for more information
using ConsoleApp5.Contracts;
using ConsoleApp5.Data;
using ConsoleApp5.Repository;
using Microsoft.EntityFrameworkCore;
Console.WriteLine("Hello, World!");

var context = new IdentityDBContext();

var person = context.People.Where(s => s.Name == "Ata").FirstOrDefault();
//var personIdentity = context.People
//var personIdentity = context.Identities.Where(q => q.PersonId == 1).FirstOrDefault();

//Console.WriteLine(personIdentity.TCNo);

//context.Add(new Person
//{
//    Name = "Dogus",
//    Id = 
//}
    
    //);

//PersonRepository pr = new PersonRepository(context);


//PersonIdentity pi = pr.GetIdentityInfos(1);
//Console.WriteLine(pi.Id + " " + pi.MaritalStat + " " + pi.person.Name);
//IEnumerable<Person> People =  pr.GetAll();

//Console.WriteLine(People.Count());
//Console.WriteLine("\n\n");
//foreach (var item in People)
//{
//    Console.WriteLine(item.Name); 
//}


