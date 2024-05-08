namespace GerenciamentoIgrega.Models;

public class Department 
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Person Leader { get; set; }
    public Person ViceLeader { get; set; }
}