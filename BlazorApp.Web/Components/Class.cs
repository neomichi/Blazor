using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace BlazorApp.Web.Components
{
    public class BCrumb : ComponentBase
    {
        [Parameter]
        public int Id { get; set; } = 314;


    }
}
