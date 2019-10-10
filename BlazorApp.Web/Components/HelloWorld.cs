using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace BlazorApp.Web.Components
{
    public class HelloWorld : ComponentBase
    {
        public const string Title = "Hello World - Class Only";

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.OpenElement(1, "h1");
            builder.AddContent(2, Title);
            builder.CloseElement();
        }
    }
}
