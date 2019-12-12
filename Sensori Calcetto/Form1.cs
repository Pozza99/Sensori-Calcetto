using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using Npgsql;
using System.Net;
using System.IO;
using System.Collections;
using Sensori_Calcetto.Services;
using MQTTnet;
using MQTTnet.Client.Options;
using MQTTnet.Client;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

namespace Sensori_Calcetto
{
    
    public partial class Form1 : Form 
    {
        IInvioService _invio = new InvioService();
        


        public Form1()
        {
            InitializeComponent();
        }
        int inizio_Partita = 0;
        int goalR = 0;
        int goalB = 0;
        int Giocatori_ok = 0;
        int goalMB = 0;
        int goalMR = 0;

        public int Controllo_Giocatori()
        {
            if (G1BP == 1 && G1RP == 1 && G2RP == 1 && G2BP == 1)
                return Giocatori_ok = 4;
            else
                return Giocatori_ok;
        }


        public async Task invioAsync(string sq)
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
            /*
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

                          System.Threading.Thread.Sleep(1000);*/
        }

        private void GR(object sender, EventArgs e)
        {
            

            if (inizio_Partita == 1)
            {
                DateTime ora = DateTime.Now;
                NoGiocatori.Hide();
                goalR = goalR + 1;
                label2.Text = " " + goalR;
                string dato = "{\"golaR\": " + goalR + ", \"ora\": " + "\"" + ora.ToString("HH:mm") + "\"" + "}";

                _invio.invio(dato);
                //invioAsync(dato);
            }
            else
            {
                NoGiocatori.Show();
                NoGiocatori.Text = "Partita non iniziata";
            }

            
        }

        private void GB(object sender, EventArgs e)
        {
           

            if (inizio_Partita == 1)
            {
                DateTime ora = DateTime.Now;
                NoGiocatori.Hide();
                goalB = goalB + 1;
                LR.Text = " " + goalB;

                string dato = "{\"golaB\": " + goalB + ", \"ora\": " + "\"" + ora.ToString("HH:mm") + "\"" + "}";

                _invio.invio(dato);
                //invioAsync(dato);

            }
            else
            {
                NoGiocatori.Show();
                NoGiocatori.Text = "Partita non iniziata";
            }
        }

        private void GMB_Click(object sender, EventArgs e)
        {
            goalMB = goalMB + 1; 
            string dato = "{\"GoalMancatoBlu\": " + goalMB + "}";

            _invio.invio(dato);
            //invioAsync(dato);
        }

        private void GMR_Click(object sender, EventArgs e)
        {
            goalMR = goalMR + 1;
            string dato = "{\"GoalMancatoRosso\": " + goalMR + "}";

            _invio.invio(dato);
            //invioAsync(dato);
        }
        int G1BP,G1RP, G2BP, G2RP = 0;
        private void G1B_TextChanged(object sender, EventArgs e)
        {
            Controllo_Giocatori();

            G1BP = 1;
        }

        private void inizio_Click(object sender, EventArgs e)
        {
            inizio_Partita = 1;
            if (Giocatori_ok == 4)
            {
                DateTime ora = DateTime.Now;

                string G1blu = G1B.Text;
                string G2blu = G2B.Text;
                string G1ros = G1R.Text;
                string G2ros = G2R.Text;

                NoGiocatori.Hide();
                var random = new Random();
                int Tavolo = random.Next(1, 6);

                string dato = "{\"Tavolo\": " + Tavolo + ", \"G1blu\":" + "\""+ G1blu + "\"" + ", \"G2blu\":" + "\"" + G2blu + "\"" + ", \"G1ros\":" + "\"" + G1ros + "\"" + ", \"G1blu\":" + "\"" + G2ros + "\"" + ", \"Ora_Inizio\": " + "\"" + ora.ToString("HH:mm") + "\"" + "}";

                _invio.invio(dato);
                //invioAsync(dato);
            }
            else
            {
                NoGiocatori.Show();
                NoGiocatori.Text = "Giocatori non pronti";
            }

        }

        private void fine_Click(object sender, EventArgs e)
        {
            if (inizio_Partita == 1)
            {
                DateTime ora = DateTime.Now;

                
                NoGiocatori.Hide();

                string dato = "{\"Ora_fine\": " + ora.ToString("HH:mm") + "}";

                _invio.invio(dato);
                //invioAsync(dato);

            }
            else
            {
                NoGiocatori.Show();
                NoGiocatori.Text = "Partita non inizita";
            }       
        }

        private void G2B_TextChanged(object sender, EventArgs e)
        {
           Controllo_Giocatori();
            G2BP = 1;
        }
        private void G1R_TextChanged(object sender, EventArgs e)
        {
           Controllo_Giocatori();
            G1RP = 1;
        }
        private void G2R_TextChanged(object sender, EventArgs e)
        {
            Controllo_Giocatori();
            G2RP = 1;
        }

    }
}
