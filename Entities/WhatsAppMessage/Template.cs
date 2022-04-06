using System.Collections.Generic;
using Newtonsoft.Json;

public class Template
{
    [JsonProperty("namespace")]
    public string? _namespace;
    public string? name;
    public Language? language;
    public List<Components>? components;

    public Template(string? @namespace, string? name, Language? language, List<Components>? components)
    {
        _namespace = @namespace;
        this.name = name;
        this.language = language;
        this.components = components;
    }
}