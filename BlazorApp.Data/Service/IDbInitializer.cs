using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Data.Services
{
    public interface IDbInitializer
    {
        Task Initialize();
    }
}
