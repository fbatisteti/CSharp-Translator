#pragma checksum "C:\Users\fabio.batisteti\OneDrive - Blink Systems\Documentos\fabio\cst\client\Shared\About.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee69a0d191fafccf6dfe69895404aa1c750f5e2b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace cstranslator.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\fabio.batisteti\OneDrive - Blink Systems\Documentos\fabio\cst\client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fabio.batisteti\OneDrive - Blink Systems\Documentos\fabio\cst\client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\fabio.batisteti\OneDrive - Blink Systems\Documentos\fabio\cst\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\fabio.batisteti\OneDrive - Blink Systems\Documentos\fabio\cst\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\fabio.batisteti\OneDrive - Blink Systems\Documentos\fabio\cst\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\fabio.batisteti\OneDrive - Blink Systems\Documentos\fabio\cst\client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\fabio.batisteti\OneDrive - Blink Systems\Documentos\fabio\cst\client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\fabio.batisteti\OneDrive - Blink Systems\Documentos\fabio\cst\client\_Imports.razor"
using cstranslator.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\fabio.batisteti\OneDrive - Blink Systems\Documentos\fabio\cst\client\_Imports.razor"
using cstranslator.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\fabio.batisteti\OneDrive - Blink Systems\Documentos\fabio\cst\client\_Imports.razor"
using cstranslator.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\fabio.batisteti\OneDrive - Blink Systems\Documentos\fabio\cst\client\_Imports.razor"
using cstranslator.Shared.Models;

#line default
#line hidden
#nullable disable
    public partial class About : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\fabio.batisteti\OneDrive - Blink Systems\Documentos\fabio\cst\client\Shared\About.razor"
       
    // Parameters and callbacks to parent component
    [Parameter] public bool showAbout { get; set; }
    [Parameter] public EventCallback<bool> showAboutChanged { get; set; }
    private Task showAboutHasChanged() => showAboutChanged.InvokeAsync(showAbout);

    // Methods
    void ToggleAbout() {
        showAbout = !showAbout;
        showAboutHasChanged();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
