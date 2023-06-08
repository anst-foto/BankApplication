namespace BankApplication.DbLib.Models;

public class Account
{
    public int Id { get; set; }
    
    public int ClientId { get; set; }
    public Client Client { get; set; }
    public double Balance { get; set; }
}