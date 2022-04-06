public class Payload
{
    public Payload(string? id, string? to, string? method, string? uri)
    {
        this.id = id;
        this.to = to;
        this.method = method;
        this.uri = uri;
    }

    public string? id {get; init;}
    public string? to {get; init;}
    public string? method {get; init;}
    public string? uri {get; init;}
}