#pragma checksum "D:\copia\JovemProgramador\Views\Usuario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b12862e10195f42b783ffcb4969fa6962fe3e39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Index), @"mvc.1.0.view", @"/Views/Usuario/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\copia\JovemProgramador\Views\_ViewImports.cshtml"
using JovemProgramador;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\copia\JovemProgramador\Views\_ViewImports.cshtml"
using JovemProgramador.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b12862e10195f42b783ffcb4969fa6962fe3e39", @"/Views/Usuario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62f0db6bfa5ffcb4ad9cc3d31525e635be6f96f8", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EventoModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Usuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Participar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Evento", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Filtro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("inicial"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\copia\JovemProgramador\Views\Usuario\Index.cshtml"
  
    ViewData["Title"] = "Usuario";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b12862e10195f42b783ffcb4969fa6962fe3e397776", async() => {
                WriteLiteral(@"
       <style>
        body {
            background-color: #696969;
            background-size: cover;
        }

        label{
            
            color: white;
        }

        h1 {
            margin-top: -40px;
            margin-bottom: 40px;
            margin-left: 10px;
            color: white;
        }

        #h2 {
            color: white;
            font-style: inherit;
            margin-top: -100px;
            padding-inline: 10px;
            padding-block-end: 40px;
        }

        #sidebar {
            position: absolute;
            top: 0;
            right: 10%;
            left: 5%;
            margin-right: 400px;
            width: 1450px;
            height: 100%;
            float: right;
            background-color: black;
        }

        #img {
            margin-left: 1200px;
        }

        a[type=submit], a[type=button]{
            background-color: white;
            color: mediumpurple;
            border");
                WriteLiteral(@"-color: mediumpurple;
            margin-top: 0px;
        }
        
        #inicial{
            float: right;
            left: auto;
            margin-left: 400px;
            margin-top: 260px;
            margin-right: 10px;
        }

    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b12862e10195f42b783ffcb4969fa6962fe3e3910069", async() => {
                WriteLiteral(@"

    <div id=""sidebar"">
        <div class=""text-center"">
            <img id=""img"" src=""data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAOEAAADhCAMAAAAJbSJIAAAAgVBMVEUAAAD////x8fH8/Pz39/fMzMyRkZHU1NSJiYnn5+e8vLz09PTt7e3j4+P4+Pi2trZ5eXmYmJhYWFitra3c3NyioqJra2uCgoKcnJzJyclJSUnAwMA+Pj5mZmZwcHBWVlYnJydCQkIbGxs0NDQUFBRLS0s3NzcjIyOnp6cMDAwuLi49T08gAAAMSklEQVR4nO1d14KqMBB1bWBbG65tVWx73f3/D7yCjZyZQCAJ+JDziBgyJJk5UxJqNQcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHh7fC92Qz8tvjcdsffU3Op6q7YxD/Nu2h1/8g6AXr2ein6t7pYjPzmlS2JBrBcPSv6m4WxHkWpAv3Qn24rbq3ubHpZowdgef/Vt1pdZy7jZzi3YUcVd1zNbQZraKM4b7q7mfhp6shXozgrZfkrqUrX4T6vGo5ZDh7JuSL0HtLGY9Gxu+B+vvN1aHS2PQ7g8GgU1e5N3gvnTNP7WxjsF6MdmHyD7+rTXvqpYvK2479uFW+7H8p5KUzTOOep81Cvni75PbDfB0TiZlFYTiMZV1srpVM+Hk24Aa+FcJ989eQ98scxoNkABvDiXoj/9piK8FsR+7ZC3eUN4xbXr7lJm9D4ax3H5/hF3tDT3xCf6XddyWwKrQxOxRqbBv01nOZK7Ukj5kW77YyfrkFZIeS+NyTzjaelMSKcSHqdvyDH34xWB5GZgk2fEvPkvkrdaqRzKFd4itN8ViGtp5Zm5FnBUdbzxrJBbxSwRxWKQ+m5EkmJiivSMM0AW0NI7ESgXbA7NhuSaZ5J1W+YGZjEImAC732DqNubNApFa2J0+VTXP59W0G6C8jX0NJom+lzkFrc");
                WriteLiteral(@"z8knXR90utv+Tzk70AZq0UHxplaib8G0dKJTZVL/8No2uTfawbVGW+A79ekdSUoeaDwpB84goBbLR0NHbkgapYbOk9RxAqqmZyTQquLvu+SPlgwfAlS3pi7DJR3C78/X6Y3Lcnq7RgUkbAWG6bZMB5fc3qaxHmlbowlIKDq/iyu17pabzAD+pO8J7kFCcVUvfWtUVwbR49UkMjFAQhXFfNj4l2G3O5z65lWPqPl07OATIGGW/7Uft4TEZDA2WhDwLXTGjPmF+NIy7d7VEO6+vWiD3E2Yo00Lbaa+Nl/qYozNdAVtl6EoUDZtu2GRllb2zPTlV2i0babR2lrsq4SYzTPS5tIXU7QvBgkGxgq4e364oKUIDffm9ZhHW2YJBiY9/ugtTMiLwoBijySsd7emq7WQttHJoZh5NeDs7/xQvxGCL+goTpCDamVHSa5Vfuyho0AEw09FAc0wLBs4QD9FHf0vT+lRRRJkArop0jaOw0jxlgUcV0D9m6ATlUv/YpQUxckN0CRJekLj6jH6rXV3zQn/pqV/0NXO6xf0jiN8Dp/Kdkt46psW/kFut/76hS7CvigDBqbtpaG0gAmC5w/Yf4YLQ9DIBHWzgIVEwhNc/+gxdTmyt/NWwAT9IzKDY9vn9AjcVKxAwjYwR/DQJHC5wSpKeD0lhYxzYgei3Bk0+hw0uxX6S2Q81RQ0nr5m60H/2pfPvjdlNh5glcVdnYCZBDV52na5qj9bdRIp2E3RaA2IQoQbLvFFlDv5h81U5hEbC9go4u/C70iAiCH8ehst0LDP3PBqnFaIXG7N4i6lKwJHhul2SwMD04lVSDhfZmziKFPCczppTmaz4c4bfxavXb3b7VChsrhECddZfem/oiEw1jFtE2PPH01FJ6O0dZha4PPo9NM6c7RNpQUGZVHvzAGM8aTYyD+ja9KyYzkG07KSjP9UQ0cPTxCDhRFtU6r8f6HUJONKvV/3VYMzMkoXqE2DGA2bScZwO75ML36SUCEHS0UY/2UDV6M0MC0I5hEs");
                WriteLiteral(@"LBbRbtcv47R+UN4cI/jxsBlIX3xFCTt2F94FSO+t8vIvl4D3/NUvXBwrSNhbj+xulWZUXZxvUNruk8BtEOFiRNvS9vg1Wm3b+6MPDPGNmUj+vV2xUYR4TBRPlETZ+I0YxoFVXzEipsmV0380u/GuoH2b9QfiSDy4H5EVYdNNnSm7EePLXHjm1j4X44vNNAmsXDFI9GnD0OY4dsikgUmRvLzU8qq9myZmbey1RBrzG58dI5pZdI5+gs/NsMuwRoxf73rp+EGv8bi9C03nPvSXtwxQ5Njx/suGs4Q0u05rDaLZzaWBMT4hi8A8/lvcq/hNei19mTKJ6jLIADFZWUw03RQnauYo5oTOJZ+T2L0YYtFiBRDogPnMO6aM/uEKmqkGibQEaqjvGo2ictnBo2A1+2EhCWFazSUGb09tdJ1vkCQ8a5S2RVSFkiMUcUKmU6FYIkgoyVdGGhGvScwW2YdSo8Mf+wk0aREkmjxfuHddJIGYvtPhgTadabLqLaKKV5TrxT4HZ/P7w/nX5mt+8SRvOrQm4Ylqhm9Zi/juoykJl+JYnGSzWhpMzFIeHu2kPB2Lq+eL/vkWOsx9fEGxJHfKY3rd+fnv8L2dNkaU6MhrwjBmEdlqNg3MksMUFIx3S31tT/TN0KRJJymxF9EYgikdZL5dBkXLFCQcv4e+J74JeYsoYdQSzNw7RcvasSagcNaJLymjxpwfBZUWoyovSRpYqZ4tRkFrH4E9DYJJl4MhT6FQXMpXtq1ENVqjs3UV6UYEjo4p3HIHzOfP6BpH22JkV11e0dfyife0QZaOwT0pYwj2JzYr6A2+upwtYkOzlJcJLbFrGu6Rm0P0LuIJhrYm4e1lBUb0czGkSX548MVK2+OMBXmP7ZQ/JFE3kYkhDJCPUeJdTKXvDUiS2L8LA/NPpm/yH73BApMQn/xt+HQZwUD/ssX+HXYDH4fkPSueC6MC9NwlPgMOjWwhIu8esZfpQzYX7+FO1YPhXE6Z8gNXumTmE4bF9wFN+2O9cgqW4vDz");
                WriteLiteral(@"/We+/BD7JAlqEXbHKiQSUH0sOHiPkviAHSDdkPA/mrNl1glVi49fgAaobzg6+9qFXvjaJRIyLJkcAURzEU+dqbKthOAY10R1sm9MB9IN/oAjNicjvowvGnh56WUc3ezdaKNHTZT2fiCkGzIzwKWlE4R4zgULXm8LCX5W2jOxbtlzJvIA6YZsUwOfzVjPJz8r2ZFsiYgxEPwg45Cr5MP0C/ShW9JC47ypQ0Fh7l+XJQkmAcllG5qWULrHM3d9SLK84K6oVM/ySBAtA9vyYGzkflFOASf4Z/XM7j7RjIHidfDQ5O+MZBpSAcwh1yE6yUlqgH0D3ZAw7wh5VmL2WktB0u7otHNH5uEjT+QopdGqx04q3tSt34pAuhHKb6Wnf/HoS71HJSRnlYnCbi76p/JsOTRttBAH0WvqBqQbqStIoQy0qasbkmkBbUITAeOJ6RwiM8J50e5QsjUjRW2Y8MsI/qSvxaH+ppYks9D2K2KgX5QVX15JE3KNi4lStGTIxtD2Cuhn9r73EVtC2zKzn0Ugh0ZazJOSeGICn34weDJenumkChgRxbn/M7+svSDw1tP2xmD0SLDOpnaqgXNn6NCWYhC8VSOmIgIaAFPtFoHwto0dvFMoSmQHQkTP3KZf9IoqPNBfCO6b2y+K8cQSD4cDCOtFnxw9gcmUyja9C3PU5Ekm6PaVvYvxAZFcmXzPSNsMTo9cENig2SMwQEIj59DlhxhrMLsdASQ0dHJYToj6zvBOymK0zSzEkLqZs8teEOKJg0sVu/rBSTWZAo7wjL7Uu9tqToA5iHl849o8XuOfS18vQqaBXzExZ14RTD+8RUlfPOEhhpotnFomHbujv5RWrJvDCWLp1r9L8sAzCWuZp4aQOy7p6AvhtAurRHUvylfK13NqJKVt8SQDpP1l0Q3MhprIj7BA37S8g6CwrLtj5zMMmAcps5KI5GAsnO6zx/qUXqnfgSblFcYiXw+QwoBmyedckVE0++WlkKSxeqUf5EU3mxg88o4WBdQroMR0t0nD");
                WriteLiteral(@"kGmc0MxHNcfpMSXYAwOcivtka8r2Bqvg9sy2NAMMB+44hZKYDIMf7ozYloYjcmSPi6j0cFm2KC8oWC5Dt/ZGaFb82Vy+nq03C/M29Cv5YnlVS/CFleQ04yCXnzOSVapUcFAghfRQp2CsFDP6a0s3Uw4qC52ImMhL2prLdqoB+fbXKfVwpj7AYADpRSad9WK0AtJ1+t6Ou+kVRt5bHbj6l13x1ej1A6+1XLa8oNPLPmu9Xl0aT4KJ2t59RehuK7SDrepZdNko+9PiyqCHiBdB423li7DJfRQCov8WFjANx2meLzYgWm+nX1iMCg5kx+wHuKzi188tZGdmOmlmHSP2QGoWjZaVb9iUgL95N1O79pbj0pItlrDzp60+p316Xtdo4WLF+Pe9Gfnj2XQ6nF4W7fn2HFbdIwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBweHAvgPP2yQxs1Rad4AAAAASUVORK5CYII="" height=""150"" width=""150""  />    
            <div class=""text-left"">
    <div>
        <h1>Eventos Disponíveis</h1>
    </div>

    <table class=""table table-dark table-striped"">
        <thead>
            <tr>
                <th scope=""col"">Evento</th>
                <th scope=""col"">Sobre</th>
                <th scope=""col"">Data</th>
                <th scope=""col"">Rua</th>
                <th scope=""col"">Bairro</th>
                <th scope=""col"">Cidade</th>
                <th scope=""col"">Contato</th>
           ");
                WriteLiteral(@"     <th scope=""col"">Capacidade</th>
            </tr>
        </thead>
        <tbody>


                                <tr> 
                        <td>Festa Junina</td> 
                        <td>muito legal</td>
                        <td>17/04/2021 12:20</td>
                        <td>Rua pedro alvares</td>
                        <td>Domja</td>
                        <td>Brusque</td>
                        <td>(47)98457-2353</td>
                        <td>50</td>
                         <td>
                            <div class=""d-grid gap-2 d-md-block"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b12862e10195f42b783ffcb4969fa6962fe3e3916289", async() => {
                    WriteLiteral("Participar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </div>
                        </td>
                    </tr>
                    <tr>
                    <td> </td>
                    <td> </td>
                    <td> </td>
                    <td> </td>
                    <td> </td>
                    </tr>
                          <tr> 
                        <td>Festa Junina</td> 
                        <td>muito legal</td>
                        <td>17/04/2021 12:20</td>
                        <td>Rua pedro alvares</td>
                        <td>Domja</td>
                        <td>Brusque</td>
                        <td>(47)98457-2353</td>
                        <td>50</td>
                         <td>
                            <div class=""d-grid gap-2 d-md-block"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b12862e10195f42b783ffcb4969fa6962fe3e3918824", async() => {
                    WriteLiteral("Participar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 132 "D:\copia\JovemProgramador\Views\Usuario\Index.cshtml"
             if (Model != null && Model.Any())
            {
                foreach (EventoModel evento in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 137 "D:\copia\JovemProgramador\Views\Usuario\Index.cshtml"
                       Write(evento.Nome);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                        <td>");
#nullable restore
#line 138 "D:\copia\JovemProgramador\Views\Usuario\Index.cshtml"
                       Write(evento.Sobre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 139 "D:\copia\JovemProgramador\Views\Usuario\Index.cshtml"
                       Write(evento.Data);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 140 "D:\copia\JovemProgramador\Views\Usuario\Index.cshtml"
                       Write(evento.Rua);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 141 "D:\copia\JovemProgramador\Views\Usuario\Index.cshtml"
                       Write(evento.Bairro);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 142 "D:\copia\JovemProgramador\Views\Usuario\Index.cshtml"
                       Write(evento.Cidade);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 143 "D:\copia\JovemProgramador\Views\Usuario\Index.cshtml"
                       Write(evento.Contato);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 144 "D:\copia\JovemProgramador\Views\Usuario\Index.cshtml"
                       Write(evento.Capacidade);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>\r\n                            <div class=\"d-grid gap-2 d-md-block\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b12862e10195f42b783ffcb4969fa6962fe3e3923115", async() => {
                    WriteLiteral("Participar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 151 "D:\copia\JovemProgramador\Views\Usuario\Index.cshtml"


                }
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        
                <tr>
                    <td> </td>
                    <td> </td>
                    <td> </td>
                    <td> </td>
                    <td> </td>
               </tr>
        </tbody>
    </table>
    <div class=""text-center"">
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b12862e10195f42b783ffcb4969fa6962fe3e3925426", async() => {
                    WriteLiteral(" Filtro ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b12862e10195f42b783ffcb4969fa6962fe3e3927044", async() => {
                    WriteLiteral(" Voltar ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n    <div>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b12862e10195f42b783ffcb4969fa6962fe3e3928689", async() => {
                    WriteLiteral(" Pagina Inicial ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_12.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n</div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EventoModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
