using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sharp_API_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GoBtn_Click(object sender, EventArgs e)
        {
            string json = "{\"method_name\":\"feed_get\",\"private_key\":\"f120a99e16f077df3d73e39e78692b5bdb6c42fb4e56f1d65d125ac663747772\",\"m\":\"1\",\"id\":\"9\" }";

            var httpRequest = (HttpWebRequest)WebRequest.Create("http://api.ru/api");
            httpRequest.Method = "POST";
            httpRequest.ContentType = "application/json";
            using (var requestStream = httpRequest.GetRequestStream())
            using (var writer = new StreamWriter(requestStream))
            {
                writer.Write(json);
            }
            using (var httpResponse = httpRequest.GetResponse())
            using (var responseStream = httpResponse.GetResponseStream())
            using (var reader = new StreamReader(responseStream))
            {
                string response = reader.ReadToEnd();
                dynamic res = JsonConvert.DeserializeObject(response);

                string id = res.response.id;
                string title = res.response.title;
                string text = res.response.text;
                
                Idlabel.Text = id;
                Titlelabel.Text = title;
                textBox.Text = text;
            }
        }
    }
}
