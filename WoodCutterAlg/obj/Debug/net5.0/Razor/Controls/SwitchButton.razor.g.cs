#pragma checksum "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\Controls\SwitchButton.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2452a54f634bbcaf2bb333551a605e8c8dd9cb38"
// <auto-generated/>
#pragma warning disable 1591
namespace WoodCutterAlg
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\_Imports.razor"
using WoodCutterAlg;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\_Imports.razor"
using WoodCutterAlg.Shared;

#line default
#line hidden
#nullable disable
    public partial class SwitchButton : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>

    .slider {
        width: 40px;
        height: 27px;
        border-radius: 13px;
        background: #71a2c0;
        position: relative;
        margin-top:5px;
        left: 50%;
        transform: translateX(-50%);
    }

    .sliderbullet {
        position: absolute;
        border-radius: 100%;
        width: 21px;
        height: 21px;
        background-color: #71a2c0;
        top: 50%;
        transform: translateY(-50%);
        margin-left: 3px;
        box-shadow: -2px 0px 7px 0px #3d4f5a;
        transition: 300ms;
    }



    

    .aktivbutton {
        margin-left: 17px;
        background: #71a2c0;
    }

    .aktivslider {
        background: #71a2c0;
    }

    .redbullet, .redslider {
        background-color: #c19494;
    }

    @media(max-width:767px) {

        .sliderbullet {
            width: 15px;
            height: 15px;
        }

        .slider {
            width: 35px;
            height: 21px;
            border-radius: 10px;
        }
    }


</style>

");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "id", "slider");
            __builder.AddAttribute(3, "class", 
#nullable restore
#line 63 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\Controls\SwitchButton.razor"
                         silderclasslist

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\Controls\SwitchButton.razor"
                                                    async () => { if(enabled) Value = !Value;  }

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", 
#nullable restore
#line 63 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\Controls\SwitchButton.razor"
                                                                                                               bulletclasslist

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\Controls\SwitchButton.razor"
       
    private bool _value;
    private string silderclasslist = "slider";
    private string bulletclasslist = "sliderbullet";


    [Parameter]
    public bool enabled { get; set; } = true;

    [Parameter]
    public bool red { get; set; } = true;

    [Parameter]
    public EventCallback<bool> ValueChanged { get; set; }

    [Parameter]
    public bool Value
    {
        get => _value;
        set
        {
            if (_value == value) return;
            _value = value;
            toggle();
            ValueChanged.InvokeAsync(value);

        }


    }

    protected override async Task OnParametersSetAsync()
    {

        if (red)
        {
            if (Value)
            {
                silderclasslist = "slider aktivslider";
                bulletclasslist = "sliderbullet aktivbutton";
            }
            else
            {
                silderclasslist = "slider redslider";
                bulletclasslist = "sliderbullet redbullet";
            }

        }
        else
        {
            if (Value)
            {
                silderclasslist = "slider aktivslider";
                bulletclasslist = "sliderbullet aktivbutton";
            }
            else
            {
                silderclasslist = "slider ";
                bulletclasslist = "sliderbullet ";
            }
        }


        await base.OnParametersSetAsync();

    }





    private void toggle() {

        if (red)
        {
            silderclasslist = silderclasslist == "slider redslider" ? "slider aktivslider" : "slider redslider";
            bulletclasslist = bulletclasslist == "sliderbullet redbullet" ? "sliderbullet aktivbutton" : "sliderbullet redbullet";
        }
        else
        {
            silderclasslist = silderclasslist == "slider" ? "slider aktivslider" : "slider";
            bulletclasslist = bulletclasslist == "sliderbullet" ? "sliderbullet aktivbutton" : "sliderbullet";
        }

        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
