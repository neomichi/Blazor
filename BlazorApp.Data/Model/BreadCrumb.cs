using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp.Data.Model
{
    public class BreadCrumb
    {
        public List<KeyValuePair<string, string>> Path { get; private set; }
        public string Title { get; private set; }


        public BreadCrumb(string title, bool only = true)
        {
            Init(title);
            if (!only)
            {
                Path.Add(new KeyValuePair<string, string>(title, title));
            }        
        }

        public BreadCrumb(string title, List<KeyValuePair<string, string>> pairs)
        { 
            Init(title);
            foreach(var pair in pairs)
            {
                Path.Add(new KeyValuePair<string, string>(pair.Key, pair.Value));
            }           
        }

        private void Init(string title="")
        {
            Title = title;
            Path = new List<KeyValuePair<string, string>>();
        }
    }



}
