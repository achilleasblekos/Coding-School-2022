using System;


public class Customer : Person
{
    public string PhoneNumber { get; set; }
    public string Tin { get; set; }

    public Customer()
    {

    }

    public Customer(string name, string surname, string phoneNumber, string tin):base(name,surname)
    {
       PhoneNumber = phoneNumber;
       Tin = tin;
      
    }
}
