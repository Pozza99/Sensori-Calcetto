using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Sensori_Calcetto.Services
{
    class InvioService : IInvioService
    {
            public void invio(string sq)
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://192.168.102.11:8011/tables/AB123");
                httpWebRequest.ContentType = "text/json";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(sq);
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                Console.Out.WriteLine(httpResponse.StatusCode);

                httpResponse.Close();

                System.Threading.Thread.Sleep(1000);
            }
        
    }
}
