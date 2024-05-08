namespace GerenciamentoIgrega.Models;

public class Person 
{
    public Guid Id { get; set;}
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly BirthDate { get; set; }
    public char Gender { get; set; }
    public bool Batized { get; set; }
    public string Telephone { get; set; }
    public Address address { get; set; }
}