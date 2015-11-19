using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TeamCityCSharp.TeamCityModels;

namespace TeamCityCSharp.Integration
{
    public static class TeamCity
    {

        public static async Task<Build> GetBuildById(string buildId)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ConfigurationManager.AppSettings["TeamCityServer"]);

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1")
                    .GetBytes(
                    ConfigurationManager.AppSettings["UserName"] + ":" + ConfigurationManager.AppSettings["Password"]));
                client.DefaultRequestHeaders.Add("Authorization", "Basic " + encoded);

                var response = await client.GetAsync("app/rest/builds/id:" + buildId);
                var responseAsyncString = response.Content.ReadAsStringAsync();
                var responseResult = responseAsyncString.Result;

                return JsonConvert.DeserializeObject<Build>(responseResult);
          
            }
        }

        public static async Task<TeamCityBuild> GetAllBuilds()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ConfigurationManager.AppSettings["TeamCityServer"]);

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1")
                    .GetBytes(
                    ConfigurationManager.AppSettings["UserName"] + ":" + ConfigurationManager.AppSettings["Password"]));
                client.DefaultRequestHeaders.Add("Authorization", "Basic " + encoded);

                var response = await client.GetAsync("app/rest/builds");
                var responseAsyncString = response.Content.ReadAsStringAsync();
                var responseResult = responseAsyncString.Result;

                return JsonConvert.DeserializeObject<TeamCityBuild>(responseResult);

            }
        }
    }
}
