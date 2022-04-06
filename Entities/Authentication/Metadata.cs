public class Metadata
{
    private string commandUri = string.Empty;
    private string uberTraceIid = string.Empty;

    public string CommandUri { get => commandUri; set => commandUri = value; }
    public string UberTraceIid { get => uberTraceIid; set => uberTraceIid = value; }
}