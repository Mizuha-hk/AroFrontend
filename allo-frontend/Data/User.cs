namespace allo_frontend;

public class User
{
    public string? key { get; set; }
    public DateTime createdAt { get; set; }
    public string? userName { get; set;}
    public string? tokenName { get; set; }
    public bool isResived { get; set; }
    public Dictionary<string, double>? tokenList { get; set; }
    public List<string>? follows { get; set; }
    public List<string>? followers { get; set; }
    public double? myToken { get; set; }
    public DateTime? deletedAt { get; set; }
}