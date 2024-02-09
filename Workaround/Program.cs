using Business.Concrete;
using Entities.Concrete;

Person person1= new Person();
person1.FirstName = "Ümeyir";
person1.LastName = "ATASOY";
person1.NationalIdentity = 123; //fake
person1.DateOfBirthYear = 2001;


PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);

Console.ReadLine();