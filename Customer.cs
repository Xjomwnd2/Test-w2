namespace TeachLib;

public class Customer
{
    public string Name { get; }
    public string AccountId { get; }
    public string Problem { get; }

    public Customer(string name, string accountId, string problem)
    {
        Name = name;
        AccountId = accountId;
        Problem = problem;
    }

    public override string ToString()
    {
        return $"{Name} ({AccountId})  : {Problem}";
    }
}
