#pragma checksum "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "834310a1891e00c0d8ff22ce24dd8fc1e800df6d"
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
#nullable restore
#line 5 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\Pages\Index.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\Pages\Index.razor"
 if (resultVisible)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "result-wrapper");
            __builder.OpenElement(2, "p");
            __builder.AddAttribute(3, "class", "result-width");
#nullable restore
#line 10 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\Pages\Index.razor"
__builder.AddContent(4, resultBasePlate.Width);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "p");
            __builder.AddAttribute(7, "class", "result-height");
#nullable restore
#line 11 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\Pages\Index.razor"
__builder.AddContent(8, resultBasePlate.Height);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "baseplate-result");
            __builder.AddAttribute(12, "style", 
#nullable restore
#line 12 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\Pages\Index.razor"
                                              BasePlateSyle()

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 14 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\Pages\Index.razor"
         foreach( var plate in resultPlates)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "style", 
#nullable restore
#line 16 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\Pages\Index.razor"
                        ResultPlateStyle(plate)

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(15, "p");
            __builder.AddAttribute(16, "class", "result-plate-heigth");
#nullable restore
#line 17 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\Pages\Index.razor"
__builder.AddContent(17, plate.Height);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "p");
            __builder.AddAttribute(20, "class", "result-plate-width");
#nullable restore
#line 18 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\Pages\Index.razor"
__builder.AddContent(21, plate.Width);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "p");
            __builder.AddAttribute(24, "class", "result-plate-x");
            __builder.AddContent(25, "X: ");
#nullable restore
#line 19 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\Pages\Index.razor"
__builder.AddContent(26, plate.X-1);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "p");
            __builder.AddAttribute(29, "class", "result-plate-y");
            __builder.AddContent(30, "Y: ");
#nullable restore
#line 20 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\Pages\Index.razor"
__builder.AddContent(31, plate.Y-1);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 23 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "class", "form-button close-button");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\Pages\Index.razor"
                                                           ()=>resultVisible= false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(36, " schlie??en ");
            __builder.CloseElement();
#nullable restore
#line 28 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\Pages\Index.razor"
    }
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "rawplate-wrapper");
#nullable restore
#line 32 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\Pages\Index.razor"
     foreach (var plate in Plates)
{   

#line default
#line hidden
#nullable disable
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "rawplate");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "rectangle-raw");
            __builder.AddAttribute(43, "style", 
#nullable restore
#line 35 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\Pages\Index.razor"
                                      RectangeStyle(plate)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n    ");
            __builder.AddMarkupContent(45, "<p class=\"widthlabel\">Breite:</p>\r\n    ");
            __builder.OpenElement(46, "p");
            __builder.AddAttribute(47, "class", "width");
#nullable restore
#line 37 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\Pages\Index.razor"
__builder.AddContent(48, plate.Width);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n    ");
            __builder.AddMarkupContent(50, "<p class=\"heightlabel\">H??he:</p>\r\n    ");
            __builder.OpenElement(51, "p");
            __builder.AddAttribute(52, "class", "height");
#nullable restore
#line 39 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\Pages\Index.razor"
__builder.AddContent(53, plate.Height);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n    ");
            __builder.OpenElement(55, "button");
            __builder.AddAttribute(56, "class", "form-button plate-delete-button");
            __builder.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\Pages\Index.razor"
                                                              ()=>DeletePlate(plate)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(58, "L??schen");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 42 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "form-wrapper");
            __builder.AddMarkupContent(61, "<h3 class=\"form-header\">Neues Holzteil hinzuf??gen</h3>\r\n");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "form");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "form-item");
            __builder.AddMarkupContent(66, "<p>Breite</p>\r\n    ");
            __builder.OpenElement(67, "input");
            __builder.AddAttribute(68, "class", "form-input");
            __builder.AddAttribute(69, "tabindex", "1");
            __builder.AddAttribute(70, "min", "0");
            __builder.AddAttribute(71, "step", "1");
            __builder.AddAttribute(72, "onkeydown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\Pages\Index.razor"
                                                                  HideError

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(73, "placeholder", "Breite");
            __builder.AddAttribute(74, "type", "number");
            __builder.AddAttribute(75, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 51 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\Pages\Index.razor"
                                                                                          widthNew

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(76, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => widthNew = __value, widthNew, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "    \r\n    \r\n    ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "form-item");
            __builder.AddMarkupContent(80, "<p>H??he</p>\r\n    ");
            __builder.OpenElement(81, "input");
            __builder.AddAttribute(82, "class", "form-input");
            __builder.AddAttribute(83, "tabindex", "2");
            __builder.AddAttribute(84, "min", "0");
            __builder.AddAttribute(85, "step", "1");
            __builder.AddAttribute(86, "onkeydown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 56 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\Pages\Index.razor"
                                                                  HideError

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(87, "placeholder", "H??he");
            __builder.AddAttribute(88, "type", "number");
            __builder.AddAttribute(89, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 56 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\Pages\Index.razor"
                                                                                         heightNew

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(90, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => heightNew = __value, heightNew, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n    \r\n    ");
            __builder.OpenElement(92, "button");
            __builder.AddAttribute(93, "class", "form-button");
            __builder.AddAttribute(94, "tabindex", "3");
            __builder.AddAttribute(95, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\Pages\Index.razor"
                                                     AddNewRectangle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(96, "Hinzuf??gen");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n");
            __builder.OpenElement(98, "div");
            __builder.AddAttribute(99, "class", "calculate-button-wrapper");
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "class", "switchbutton-wrapper");
            __builder.AddMarkupContent(102, "<p>Drehen erlauben</p>\r\n");
            __builder.OpenComponent<WoodCutterAlg.SwitchButton>(103);
            __builder.AddAttribute(104, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 64 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\Pages\Index.razor"
                     turningEnabled

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(105, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 64 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\Pages\Index.razor"
                                                 TurningEnabledChanged

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n");
            __builder.OpenElement(107, "button");
            __builder.AddAttribute(108, "class", "form-button");
            __builder.AddAttribute(109, "tabindex", "-1");
            __builder.AddAttribute(110, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\Pages\Index.razor"
                                                   CalculateBasePlate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(111, "Holzplatte Berechnen");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n");
            __builder.OpenElement(113, "div");
            __builder.AddAttribute(114, "style", "height:20px;");
            __builder.OpenElement(115, "p");
            __builder.AddAttribute(116, "style", "text-align: center; color: red;");
#nullable restore
#line 69 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\Pages\Index.razor"
__builder.AddContent(117, errorString);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 72 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "C:\Users\Micha\Documents\C# Projects\WoodCutter\WoodCutterAlg\WoodCutterAlg\Pages\Index.razor"
      

    private int widthNew;
    private int heightNew;
    private string errorString;
    private bool resultVisible;
    private bool turningEnabled;
    private BasicPlateModel resultBasePlate = new BasicPlateModel();
    private List<PlateModel> resultPlates= new();
    private double resultScale;
    private void HideError() => errorString = "";
    private void TurningEnabledChanged(bool enabled) => turningEnabled = enabled;
    public List<PlateModel> Plates { get; set; } = new();


    private void AddNewRectangle()
    {
        if(widthNew <1 || heightNew <1)
        {
            errorString="Breite und H??he m??ssen mindestens 1 sein.";
            return;
        }
        errorString = "";
        Plates.Add(new PlateModel(widthNew, heightNew));
        widthNew = 0;
        heightNew = 0;
    }

    private void DeletePlate(PlateModel plate) => Plates.Remove(plate);

    private string RectangeStyle(PlateModel plate)
    {
        double height = plate.Height*10;
        double width = plate.Width*10;
        Random rand = new Random();
        if (plate.Height> 10 && plate.Height > plate.Width)
        {
            height = 100;
            width = Math.Round(((double)plate.Width / (double)plate.Height)*100);
        }

        if (plate.Width> 10 && plate.Width > plate.Height)
        {
            width = 100;
            height = Math.Round(((double)plate.Height / (double)plate.Width)*100);
        }
        plate.Color = String.IsNullOrEmpty(plate.Color) ? $"rgb({rand.Next(256)},{rand.Next(256)},{rand.Next(256)})" : plate.Color;
        return $"background-color:{plate.Color}; height: {height}px; width:{width}px;";
    }

    private string BasePlateSyle()
    {
        resultScale = resultBasePlate.Height > resultBasePlate.Width ? 500/resultBasePlate.Height : 500/resultBasePlate.Width;
        return $"width:{resultBasePlate.Width*resultScale}px; height:{resultBasePlate.Height*resultScale}px";

    }

    private string ResultPlateStyle(PlateModel plate)
    {
        return $"background:{plate.Color};opacity:0.7; position:absolute; left:{(plate.X-1)*resultScale}px; top:{(plate.Y-1)*resultScale}px; width:{plate.Width*resultScale}px; height:{plate.Height*resultScale}px";
    }

    private void CalculateBasePlate()
    {
        if (!Plates.Any())
        {
            errorString="Es muss mindestens eine Form hinzugef??gt werden";
            return;

        }
        var result = _woodCutter.CalculateMinimumBasicPlate(Plates,turningEnabled);
        resultBasePlate = result.Item1;
        resultPlates = result.Item2;
        resultVisible = true;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWoodCutterAlgorithm _woodCutter { get; set; }
    }
}
#pragma warning restore 1591
