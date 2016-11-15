using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanManuelAPITester
{
    public partial class Form1 : Form
    {
        static HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client.BaseAddress = new Uri("http://localhost:50444");
            PutTrial();
        }
        private static void PutTrial()
        {

            string urlstring = string.Format("Api/Lawson/{0}?updatedStatus={1}",1,1);
            var inputMessage = new HttpRequestMessage
            {
                Content = new StringContent(urlstring, Encoding.UTF8, "application/json")
            };
            inputMessage.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage message = client.PutAsync(urlstring, inputMessage.Content).Result;
            if (message.IsSuccessStatusCode)
            {
                var inter = message.Content.ReadAsStringAsync();
              
            }
        }

    }
}
