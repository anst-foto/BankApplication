﻿namespace BankApplication.DbLib.Models;

public class Client
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public List<Account> Accounts { get; set; }
}