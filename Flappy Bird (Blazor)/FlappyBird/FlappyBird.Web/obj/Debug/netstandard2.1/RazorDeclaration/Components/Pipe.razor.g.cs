// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FlappyBird.Web.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\GitHub Repositories\Flappy-Bird--Blazor-\Flappy Bird (Blazor)\FlappyBird\FlappyBird.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub Repositories\Flappy-Bird--Blazor-\Flappy Bird (Blazor)\FlappyBird\FlappyBird.Web\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\GitHub Repositories\Flappy-Bird--Blazor-\Flappy Bird (Blazor)\FlappyBird\FlappyBird.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\GitHub Repositories\Flappy-Bird--Blazor-\Flappy Bird (Blazor)\FlappyBird\FlappyBird.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\GitHub Repositories\Flappy-Bird--Blazor-\Flappy Bird (Blazor)\FlappyBird\FlappyBird.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\GitHub Repositories\Flappy-Bird--Blazor-\Flappy Bird (Blazor)\FlappyBird\FlappyBird.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\GitHub Repositories\Flappy-Bird--Blazor-\Flappy Bird (Blazor)\FlappyBird\FlappyBird.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\GitHub Repositories\Flappy-Bird--Blazor-\Flappy Bird (Blazor)\FlappyBird\FlappyBird.Web\_Imports.razor"
using FlappyBird.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\GitHub Repositories\Flappy-Bird--Blazor-\Flappy Bird (Blazor)\FlappyBird\FlappyBird.Web\_Imports.razor"
using FlappyBird.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\GitHub Repositories\Flappy-Bird--Blazor-\Flappy Bird (Blazor)\FlappyBird\FlappyBird.Web\_Imports.razor"
using FlappyBird.Web.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\GitHub Repositories\Flappy-Bird--Blazor-\Flappy Bird (Blazor)\FlappyBird\FlappyBird.Web\Components\Pipe.razor"
using FlappyBird.Web.Models;

#line default
#line hidden
#nullable disable
    public partial class Pipe : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "D:\GitHub Repositories\Flappy-Bird--Blazor-\Flappy Bird (Blazor)\FlappyBird\FlappyBird.Web\Components\Pipe.razor"
       

    [Parameter] public PipeModel Model { get; set; }
    string _topPipeCss => $"bottom: {Model.DistanceFromBottom + 430}px; left: {Model.DistanceFromLeft}px";
    string _bottomPipeCss => $"bottom: {Model.DistanceFromBottom}px; left: {Model.DistanceFromLeft}px";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591