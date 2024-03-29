﻿using System;
using BlazorApp.Data.Model;

namespace BlazorApp.Data.Service
{
    public interface IAppStateService
    {
        BreadCrumb BreadCrumb { get; }
        string Search { get; }
        string Title { get; }

        event Action OnChange;

        void SetState<T>(T state);
    }
}