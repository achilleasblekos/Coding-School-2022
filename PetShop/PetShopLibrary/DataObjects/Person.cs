using PetShopLibrary.DataObjects;
using System;



public interface IPerson
{

    public Guid ID { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Fullname { get; }
}


public class Person : CurrentStatus, IPerson
{ 
    public Guid ID { get; set; } =  Guid.NewGuid();
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Fullname { get => $"{Name} {Surname}"; }//oxi mesa edo

    public Person()
    {

    }

    public Person(string name, string surname)
    {
        Name = name;
        Surname = surname;
    }
}
