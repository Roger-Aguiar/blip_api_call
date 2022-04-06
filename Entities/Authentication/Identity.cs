public class Identity
{
    private string type = string.Empty;
    private Resource resource = new Resource();
    private string method = string.Empty;
    private string status = string.Empty;
    private string id = string.Empty;
    private string from = string.Empty;
    private string to = string.Empty;
    private Metadata metadata = new Metadata();

    public string Type { get => type; set => type = value; }
    public Resource Resource { get => resource; set => resource = value; }
    public string Method { get => method; set => method = value; }
    public string Status { get => status; set => status = value; }
    public string Id { get => id; set => id = value; }
    public string From { get => from; set => from = value; }
    public string To { get => to; set => to = value; }
    public Metadata Metadata { get => metadata; set => metadata = value; }
}