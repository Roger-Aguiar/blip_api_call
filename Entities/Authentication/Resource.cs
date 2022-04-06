public class Resource
{
    private string alternativeAccount = string.Empty;
    private string identity = string.Empty;
    private string phoneNumber = string.Empty;
    private string source = string.Empty;

    public string AlternativeAccount { get => alternativeAccount; set => alternativeAccount = value; }
    public string Identity { get => identity; set => identity = value; }
    public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    public string Source { get => source; set => source = value; }
}