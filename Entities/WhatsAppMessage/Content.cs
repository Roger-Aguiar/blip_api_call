public class Content
{
    public string? type;
    public Template? template;

    public Content(string? type, Template? template)
    {
        this.type = type;
        this.template = template;
    }
}