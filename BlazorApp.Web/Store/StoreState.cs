using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp.Data.Model;

namespace BlazorApp.Web.Store
{
    public class StoreState : IStoreState
    {
        public int Counter { get; private set; } = 1;
        public BreadCrumb BreadCrumb { get; private set; }
        public string Search { get; private set; }
        public string Title { get; private set; }

        private static readonly object Instancelock = new object();

        public event Action OnChange;
        public T SetState<T>(T state)
        {


            lock (Instancelock)
            {
                try
                {
                    switch (typeof(T).Name)
                    {
                        case "BreadCrumb":
                            {
                                BreadCrumb = state as BreadCrumb;
                                break;
                            }
                        case "Int32":
                            {
                                Counter = new Random().Next() + (int)(object)state;
                                return (T)(object)Counter;
                            }
                    }
                }
                catch (Exception e)
                {
                    throw new Exception();
                }
            }
            ///увеlog
            StateChanged();
            return state;
        }

        public void StateChanged() => OnChange?.Invoke();
    }

}

