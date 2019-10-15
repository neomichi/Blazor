using System;
using BlazorApp.Data.Model;

namespace BlazorApp.Web.Store
{
    public interface IStoreState
    {
        BreadCrumb BreadCrumb { get; }
        int Counter { get; }
        string Search { get; }
        string Title { get; }

        event Action OnChange;

        T SetState<T>(T state);
        void StateChanged();
    }
}