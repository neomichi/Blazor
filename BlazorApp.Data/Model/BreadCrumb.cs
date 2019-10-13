using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BlazorApp.Data.Model
{
    [NotMapped]
    public class BreadCrumb
    {
        public string Title { get; private set; } = "";
        /// <summary>
        /// (url.text)
        /// </summary>
        public Queue<KeyValuePair<string, string>> Path { get; private set; }

   

        public BreadCrumb(string title,bool Only=true)
        {
            if (Only)
            {
                Title = title;
            }
            else
            {
                Title = title;
                Path = new Queue<KeyValuePair<string, string>>();
                Path.Enqueue(new KeyValuePair<string, string>("/", title));
            }
        }

        public BreadCrumb(string title,List<KeyValuePair<string,string>> listPath )
        {
            Title = title;
            Path = new Queue<KeyValuePair<string, string>>();
            foreach (var path in listPath)
            {
                Path.Enqueue(path);
            }  
        }

    }
}
