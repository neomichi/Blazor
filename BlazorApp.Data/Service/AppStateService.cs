using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BlazorApp.Data.Model;

namespace BlazorApp.Data.Service
{
    public class AppStateService : IAppStateService
    {

        public BreadCrumb BreadCrumb { get; private set; }
        public string Search { get; private set; }
        public string Title { get; private set; }

    

        public event Action OnChange;

       

        public void SetState<T>(T state)
        {
            try
            {           
                    switch (typeof(T).Name)
                    {
                        case "BreadCrumb":
                            {
                                var bc = state as BreadCrumb;
                                BreadCrumb = bc;
                            }
                            break;

                        case "Search": Search = state as string; break;
                        case "Title": Title = state as string; break;

                    }
           
                NotifyStateChanged();
            }
            catch (Exception e)
            {
                throw new Exception();
            }

        }

        private void NotifyStateChanged() => OnChange?.Invoke();



    }
}
