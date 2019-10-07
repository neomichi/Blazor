using System.Threading.Tasks;

namespace BlazorApp.Data.Service
{
    public interface ITestService
    {
        string GetTest1();
        Task<string> GetTest2();
    }
}