using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlazorApp.Data.Service
{
    public class TestService : ITestService
    {
        //HttpClient _httpClient;
        public TestService()//HttpClient httpClient)
        {
           // _httpClient = httpClient;
        }
        public string GetTest1()
        {
            return "Hello my frend";

        }

        public async Task<string> GetTest2()
        {
            return "123";  //_httpClient.GetStringAsync("/api/values");
        }
    }
}
