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

namespace RUAP_spam_ham
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private async Task InvokeRequestResponseService()
        {
            using (var client = new HttpClient())
            {
                var scoreRequest = new
                {

                    Inputs = new Dictionary<string, StringTable> () { 
                        { 
                            "input1", 
                            new StringTable() 
                            {
                                ColumnNames = new string[] {"v2"},
                                //Values = new string[,] {  { "value" },  { "value" },  }
                                Values = new string[,] {  { rtbText.Text } }
                            }
                        },
                    },
                    GlobalParameters = new Dictionary<string, string>() {
}
                };
                const string apiKey = "wa7PJm0JAcEQ2w0os9cXSgj+GvCd0j8tZEqus4Yqp2CodMtp4AMOwsXQ5Cq9SgV7nB7NCgwHE11pa6SvUAKTpQ=="; // Replace this with the API key for the web service
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue( "Bearer", apiKey);

                client.BaseAddress = new Uri("https://ussouthcentral.services.azureml.net/workspaces/72be0458837440c49c931631169970be/services/e195e015f24d4aefb37fae91bfa80993/execute?api-version=2.0&details=true");
                
                // WARNING: The 'await' statement below can result in a deadlock if you are calling this code from the UI thread of an ASP.Net application.
                // One way to address this would be to call ConfigureAwait(false) so that the execution does not attempt to resume on the original context.
                // For instance, replace code such as:
                //      result = await DoSomeTask()
                // with the following:
                //      result = await DoSomeTask().ConfigureAwait(false)


                HttpResponseMessage response = await client.PostAsJsonAsync("", scoreRequest);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    string resLabel = "";
                    //Console.WriteLine("Result: {0}", result);

                    resLabel = GetParsedResult(result, 4);
                    lblDetection.Text = resLabel;
                }
                else
                {
                    Console.WriteLine(string.Format("The request failed with status code: {0}", response.StatusCode));

                    // Print the headers - they include the requert ID and the timestamp, which are useful for debugging the failure
                    Console.WriteLine(response.Headers.ToString());

                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseContent);
                }
            }
        }

        private string GetParsedResult(string result, int n)
        {
            string receivedResult = "";
            int count = 0;
            int position = 0;
            for (int i = result.Length - 1; count != n; i--)
            {
                if (result[i] == '"')
                {
                    count++;
                    if (count == n)
                    {
                        position = i;
                    }
                }
            }
            for (int i = position + 1; i < result.Length; i++)
            {
                if (result[i] == '"')
                {
                    break;
                }
                receivedResult += result[i].ToString();
            }
            if (receivedResult == "ham")
            {
                receivedResult = "It is ham :)";
            }
            else if (receivedResult == "spam")
            {
                receivedResult = "It is spam :(";
            }
            return receivedResult;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rtbText.Text = "";
            lblDetection.Text = "spam or ham?";
            btnCheck.Enabled = true;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            InvokeRequestResponseService();
            btnCheck.Enabled = false;
        }
    }
    public class StringTable
    {
        public string[] ColumnNames { get; set; }
        public string[,] Values { get; set; }
    }
}
