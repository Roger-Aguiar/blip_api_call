using System.IO;
using System.Net;
using Newtonsoft.Json;

public class WhatsAppMessage : IWhatsAppMessage
{    
    private readonly PayloadBody payloadBody;
    
    public WhatsAppMessage(PayloadBody payloadBody)
    {
        this.payloadBody = payloadBody;
    }
           
    public void SendMessage()
    {
        var request = (HttpWebRequest)WebRequest.Create("https://msging.net/messages");
        request.ContentType = "application/json";
        request.Method = "POST";
        request.Headers.Add("Authorization", "Key cHNyb3V0ZXI6aWJQaWFXT2Fqb1YzYms2ZUFoRXk=");
        
        var json = JsonConvert.SerializeObject(payloadBody);

        using (var streamWriter = new StreamWriter(request.GetRequestStream()))
        {
            streamWriter.Write(json);
        }

        request.GetResponse();
    }
}