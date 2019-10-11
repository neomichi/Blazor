using System;
using System.Threading.Tasks;
using BlazorApp.Data.Model;

namespace BlazorApp.Data.Service
{
    public interface IAppStateService
    {
        BreadCrumb breadCrumb { get; }
        string search { get; }
        string title { get; }

        event Action OnChange;

        Task SetState<T>(T state);
    }
}