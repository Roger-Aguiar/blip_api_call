public class PayloadBody
{
    public string? id;
    public string? to;
    public string? type;
    public Content? content;

    public PayloadBody(string? id, string? to, string? type, Content? content)
    {
        this.id = id;
        this.to = to;
        this.type = type;
        this.content = content;
    }
}