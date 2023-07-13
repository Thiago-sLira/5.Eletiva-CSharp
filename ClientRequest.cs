namespace TestApi.Core;

public class Client
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal AccountBalance { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}

public class ClientRequest
{
    public string? Name { get; set; }
    public decimal AccountBalance { get; set; }

    public Client CreateClient(int id)
    {
        return new Client
        {
            Id = id,
            Name = Name,
            AccountBalance = AccountBalance,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };
    }

    public Client UpdateClient(Client client)
    {
        client.Name = Name;
        client.AccountBalance = AccountBalance;
        client.UpdatedAt = DateTime.Now;
        return client;
    }
}
