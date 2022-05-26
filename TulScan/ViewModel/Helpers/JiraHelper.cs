using Newtonsoft.Json;
using RestSharp;
using System;
using System.Threading.Tasks;
using TulScan.Model;

namespace TulScan.ViewModel.Helpers
{
    public class JiraHelper
    {
        public static Task<JiraResponse> CreateIssue(JiraRequest jiraRequest)
        {
            try
            {
                var domain = Properties.Settings.Default.DomainName;
                var client = new RestClient($"https://{domain}/jira/rest/api/latest/issue");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Authorization", "Basic YOUR_CONVERTED_KEY");
                request.AddHeader("Content-Type", "application/json");
                var json = JsonConvert.SerializeObject(jiraRequest);
                request.AddParameter("application/json", json, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                if(response != null)
                {
                    return Task.FromResult(JsonConvert.DeserializeObject<JiraResponse>(response.Content));
                }
                else
                {
                    return null;
                }
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
