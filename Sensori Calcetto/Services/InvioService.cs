using MQTTnet;
using MQTTnet.Client.Options;
using MQTTnet.Client;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Sensori_Calcetto.Services
{
    public class InvioService : IInvioService
    {
            public async void invio(string sq)
            {

            var factory = new MqttFactory();
            var mqttClient = factory.CreateMqttClient();

            var options = new MqttClientOptionsBuilder()
                .WithTcpServer("192.168.101.49", 1883) // Port is optional
                .Build();


            await mqttClient.ConnectAsync(options, CancellationToken.None);

            var message = new MqttApplicationMessageBuilder()
                        .WithTopic("")
                        .WithPayload(sq)
                        .WithExactlyOnceQoS()
                        .WithRetainFlag()
                        .Build();

            await mqttClient.PublishAsync(message);

            /* HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://192.168.102.11:8011/tables/AB123");
             httpWebRequest.ContentType = "text/json";
             httpWebRequest.Method = "POST";

             using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
             {
                 streamWriter.Write(sq);
             }

             var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

             Console.Out.WriteLine(httpResponse.StatusCode);

             httpResponse.Close();

             System.Threading.Thread.Sleep(1000);*/
        }
        
    }
}
