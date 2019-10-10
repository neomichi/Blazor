using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Data.Service
{
    public class ClickService
    {
        readonly MyDbContext _dbcontext;
        public ClickService(MyDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task Click()
        {
            
        }
    }
}
