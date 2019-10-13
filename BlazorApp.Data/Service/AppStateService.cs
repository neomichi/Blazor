using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BlazorApp.Data.Model;

namespace BlazorApp.Data.Service
{
    public class AppStateService : IAppStateService
    {
        public BreadCrumb breadCrumb { get; private set; }
        public string search { get; private set; }
        public string title { get; private set; }

        public event Action OnChange;

        public async Task SetState<T>(T state)
        {
            try
            {
                switch (typeof(T).Name)
                {
                    case "BreadCrumb": breadCrumb = state as BreadCrumb; break;
                    case "Search": search = state as string; break;
                    case "Title": title = state as string; break;

                }
                await NotifyStateChanged();
            }
            catch (Exception e)
            {
                throw new Exception();
            }

        }

       

        private async Task NotifyStateChanged()
        {
            //logloglog
        }

        
    }
}
