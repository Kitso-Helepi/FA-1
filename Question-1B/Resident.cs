using System;

public class Resident
{
	public string Name { get; set; }
    public string Address { get; set; }
    public string AccountNumber { get; set; }
    public double MonthlyUsage { get; set; }

    public Resident(string name, string address, string accountNumber, double usage )
	{
        Name = name;
        Address = address;
        AccountNumber = accountNumber;
        MonthlyUsage = usage;


	}

    public override string ToString()
    {
        
      return $"""
            Resident Name: {Name} 
            Address: {Address} 
            Account Number: {AccountNumber} 
            Monthly Usage: {MonthlyUsage} kWh
            """;

    }


}
