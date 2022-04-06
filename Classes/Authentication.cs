using System.Net;
using System.IO;
using Newtonsoft.Json;

public class Authentication : IAuthentication
{    
    private string identityResponse = string.Empty;
    
    private readonly Payload payload;

    public Authentication(Payload payload)
    {        
        this.payload = payload;
    }

    public string GetIdentity()
    {
        var request = (HttpWebRequest)WebRequest.Create("https://http.msging.net/commands");
        request.ContentType = "application/json";
        request.Method = "POST";
        request.Headers.Add("Authorization", "Key cHNyb3V0ZXI6aWJQaWFXT2Fqb1YzYms2ZUFoRXk=");
        
        var json = JsonConvert.SerializeObject(payload);

        using (var streamWriter = new StreamWriter(request.GetRequestStream()))
        {
            streamWriter.Write(json);
        }

        var response = (HttpWebResponse)request.GetResponse();

        using (var streamReader = new StreamReader(response.GetResponseStream()))
        {
            identityResponse = streamReader.ReadToEnd();
        }

        var identity = JsonConvert.DeserializeObject<Identity>(identityResponse);
        
        return identity.Resource.Identity;
    }
}