using System.Collections.Generic;
using System.Text.Json.Serialization;

public class Test
{
    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("userName")]
    public string UserName { get; set; }

    [JsonPropertyName("tokenName")]
    public string TokenName { get; set; }

    [JsonPropertyName("isReceived")]
    public bool IsReceived { get; set; }

    [JsonPropertyName("tokenList")]
    public Dictionary<string, int> TokenList { get; set; }

    [JsonPropertyName("follows")]
    public List<string> Follows { get; set; }

    [JsonPropertyName("followers")]
    public List<string> Followers { get; set; }

    [JsonPropertyName("myToken")]
    public int MyToken { get; set; }

    [JsonPropertyName("deletedAt")]
    public DateTime? DeletedAt { get; set; }
}
