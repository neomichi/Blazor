using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BlazorApp.Data.Model
{

    public struct BreadCrumbStruct
    {
        public List<KeyValuePair<string, string>> Path;
        public string Title;
        //{
        //    get
        //    {
        //        return _title;
        //    }

        //}
        //private string _title;
        ///// <summary>
        ///// (url.text)
        ///// </summary>

        //public List<KeyValuePair<string, string>> Path
        //{
        //    get
        //    {
        //        return _path;
        //    }
        //}
  

        public BreadCrumbStruct(string title, List<KeyValuePair<string, string>> path)
        {
            Title = title;
            Path = path;
        }

        public void Init(string title, bool only)
        {
            Title = title;
            Path = new List<KeyValuePair<string, string>>();
            if (!only)
            {
                Path.Add(new KeyValuePair<string, string>(title, title));
            }
        }

   

        //public BreadCrumb(string title, List<KeyValuePair<string, string>> listPath)
        //{
        //    _title = title;
        //    _path = new List<KeyValuePair<string, string>>();
        //    foreach (var path in listPath)
        //    {
        //        _path.Add(path);
        //    }
        //}

    }
}

