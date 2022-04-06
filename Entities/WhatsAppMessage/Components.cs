using System.Collections.Generic;

public class Components
{
    public string? type;
    public List<Parameters> parameters = new List<Parameters>();

    public Components(string? type, List<Parameters> parameters)
    {
        this.type = type;
        this.parameters = parameters;
    }
}