using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlazorApp.Data.Service
{
    public class HelloService : IHelloService
    {        
        public string GetTest()
        { 
            return "Hello my frend";

        }
    }
}
