using System.Collections.Generic;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var identity = GetIdentity();
            var payload = FillPayload(identity);
            var whatsAppMessage = new WhatsAppMessage(payload);
            whatsAppMessage.SendMessage();      
        }

        static string GetIdentity()
        {
            var phoneNumber = "31983453069";
            var id = "a456-42665544000-0123e4567-e89b-12d3";
            var to = "postmaster@wa.gw.msging.net";
            var method = "get";
            var uri = $"lime://wa.gw.msging.net/accounts/+55{phoneNumber}";
            
            var payload = new PayloadAuthentication(id, to, method, uri);

            var authentication = new Authentication(payload);
            return authentication.GetIdentity();
        }

        static PayloadBody FillPayload(string identity)
        {
            List<Parameters> parameters = new List<Parameters>();
            List<Components> components = new List<Components>();
            parameters.Add(new Parameters("text", "c3b9d872-d137-3f79-b801-8ac182f8379f"));
            parameters.Add(new Parameters("text", "e57c37fc-236b-3204-9e54-aa25abde9111"));            
            components.Add(new Components("body", parameters));
            var language = new Language("pt_BR", "deterministic");
            var template = new Template("bd157ac2_833d_47a5_9b2d_b9af2862367a", "clientid", language, components);
            var content = new Content("template", template);
            var payloadBody = new PayloadBody("ec350799-3185-494e-92c6-1ccda78c8398", identity, "application/json", content);
            
            return payloadBody;
        }
    }
}