
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using MyTeamCity.TeamCityModels;
using Newtonsoft.Json;

namespace MyTeamCity
{
    public class MyTeamCity
    {
        public HttpClient webClient;
        private readonly string Username;
        private readonly string Password;
        private readonly string TeamCityServer;

        public MyTeamCity(string username, string password, string teamCityServer)
        {
            this.Username = username;
            this.Password = password;
            this.TeamCityServer = teamCityServer;
        }

        public async Task<TeamCityBuildList> GetAllBuilds()
        {
            using (webClient = new HttpClient())
            {
                webClient.BaseAddress = new Uri(TeamCityServer);
                webClient.DefaultRequestHeaders.Accept.Clear();
                webClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1")
                  .GetBytes(
                  Username + ":" + Password));
                webClient.DefaultRequestHeaders.Add("Authorization", "Basic " + encoded);
                var response = await webClient.GetAsync("app/rest/builds");
                var responseAsyncString = response.Content.ReadAsStringAsync();
                var responseResult = responseAsyncString.Result;

                return JsonConvert.DeserializeObject<TeamCityBuildList>(responseResult);
            }
        }


        public async Task<UserList> GetAllUsers()
        {
            using (webClient = new HttpClient())
            {
                webClient.BaseAddress = new Uri(TeamCityServer);
                webClient.DefaultRequestHeaders.Accept.Clear();
                webClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1")
                  .GetBytes(
                  Username + ":" + Password));
                webClient.DefaultRequestHeaders.Add("Authorization", "Basic " + encoded);
                var response = await webClient.GetAsync("app/rest/users");
                var responseAsyncString = response.Content.ReadAsStringAsync();
                var responseResult = responseAsyncString.Result;

                return JsonConvert.DeserializeObject<UserList>(responseResult);
            }
        }

        public async Task<ProjectList> GetAllProjects()
        {
            using (webClient = new HttpClient())
            {
                webClient.BaseAddress = new Uri(TeamCityServer);
                webClient.DefaultRequestHeaders.Accept.Clear();
                webClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1")
                  .GetBytes(
                  Username + ":" + Password));
                webClient.DefaultRequestHeaders.Add("Authorization", "Basic " + encoded);
                var response = await webClient.GetAsync("app/rest/projects");
                var responseAsyncString = response.Content.ReadAsStringAsync();
                var responseResult = responseAsyncString.Result;

                return JsonConvert.DeserializeObject<ProjectList>(responseResult);
            }
        }

        public async Task<AgentList> GetAllAgents()
        {
            using (webClient = new HttpClient())
            {
                webClient.BaseAddress = new Uri(TeamCityServer);
                webClient.DefaultRequestHeaders.Accept.Clear();
                webClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1")
                  .GetBytes(
                  Username + ":" + Password));
                webClient.DefaultRequestHeaders.Add("Authorization", "Basic " + encoded);
                var response = await webClient.GetAsync("app/rest/agents");
                var responseAsyncString = response.Content.ReadAsStringAsync();
                var responseResult = responseAsyncString.Result;

                return JsonConvert.DeserializeObject<AgentList>(responseResult);
            }
        }
    }
}
