#pragma checksum "C:\Users\jerry\Documents\OnlineJewelry\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c84d68727081af9dad7bae841cf0f8df907c8894"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\jerry\Documents\OnlineJewelry\Views\_ViewImports.cshtml"
using OnlineJewelry.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jerry\Documents\OnlineJewelry\Views\_ViewImports.cshtml"
using OnlineJewelry.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c84d68727081af9dad7bae841cf0f8df907c8894", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20f815b00f7d8194de22b39c57e60ca61033be63", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JewelryListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Jewelry", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<main>
    <div class=""container"">
        <!--  <div class=""row"">
              <!--
                  <div class=""col-lg-3"">

                      <h1 class=""my-4"">Maggievee</h1>
                      <div class=""list-group"">
                          <h5>
                              <a href=""#"" class=""list-group-item"">Anklet</a>
                              <a href=""#"" class=""list-group-item"">Bracelet</a>
                              <a href=""#"" class=""list-group-item"">Earrings</a>
                              <a href=""#"" class=""list-group-item"">Necklace</a>
                              <a href=""#"" class=""list-group-item"">Ring</a>
                              <a href=""#"" class=""list-group-item"">Silk Ribbon Bracelet</a>
                          </h5>
                      </div>

                  </div>

              <!-- /.col-lg-3
              <div class=""col-lg-9"">
                  <div id=""carouselExampleIndicators"" class=""carousel slide my-4"" data-ride=""carousel"">
  ");
            WriteLiteral(@"                    <ol class=""carousel-indicators"">
                          <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
                          <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
                          <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
                      </ol>
                      <div class=""carousel-inner"" role=""listbox"">
                          <div class=""carousel-item active"">
                              <img class=""d-block img-fluid"" src=""~/Images/slider-one.jpg"" alt=""First slide"">
                          </div>
                          <div class=""carousel-item"">
                              <img class=""d-block img-fluid"" src=""~/Images/slider-five.jpg"" alt=""Second slide"">
                          </div>
                          <div class=""carousel-item"">
                              <img class=""d-block img-fluid"" src=""~/Images/slider-four.jpg"" alt=""Third slid");
            WriteLiteral(@"e"">
                          </div>
                      </div>
                      <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                          <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                          <span class=""sr-only"">Previous</span>
                      </a>
                      <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                          <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                          <span class=""sr-only"">Next</span>
                      </a>
                  </div>

              </div>

          </div>
            -->

        <div class=""slider-active dot-style"">
            <!-- Single -->
            <div class=""single-slider slider-bg1 hero-overly slider-height d-flex align-items-center"">
                <div class=""container"">
                    <div cl");
            WriteLiteral(@"ass=""row justify-content-center"">
                        <div class=""col-xl-8 col-lg-9"">
                            <!-- Hero Caption -->
                            <div class=""hero__caption"">
                                <h1>fashion<br>changing<br>always</h1>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c84d68727081af9dad7bae841cf0f8df907c88947589", async() => {
                WriteLiteral("Shop Now");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Single -->
            <div class=""single-slider slider-bg2 hero-overly slider-height d-flex align-items-center"">
                <div class=""container"">
                    <div class=""row justify-content-center"">
                        <div class=""col-xl-8 col-lg-9"">
                            <!-- Hero Caption -->
                            <div class=""hero__caption"">
                                <h1>fashion<br>changing<br>always</h1>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c84d68727081af9dad7bae841cf0f8df907c88949689", async() => {
                WriteLiteral("Shop Now");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Single -->
            <div class=""single-slider slider-bg3 hero-overly slider-height d-flex align-items-center"">
                <div class=""container"">
                    <div class=""row justify-content-center"">
                        <div class=""col-xl-8 col-lg-9"">
                            <!-- Hero Caption -->
                            <div class=""hero__caption"">
                                <h1>fashion<br>changing<br>always</h1>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c84d68727081af9dad7bae841cf0f8df907c889411789", async() => {
                WriteLiteral("Shop Now");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- End Hero -->
    <!--? Popular Items Start -->
    <div class=""popular-items pt-50"">
        <div class=""container-fluid"">
            <div class=""row"">
");
#nullable restore
#line 106 "C:\Users\jerry\Documents\OnlineJewelry\Views\Home\Index.cshtml"
                 foreach (var jewelry in Model.Jewelries)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-lg-3 col-md-6 col-sm-6"">
                        <div class=""single-popular-items mb-50 text-center wow fadeInUp"" data-wow-duration=""1s"" data-wow-delay="".1s"">
                            <div class=""popular-img"">
                                <img");
            BeginWriteAttribute("src", " src=\"", 5612, "\"", 5635, 1);
#nullable restore
#line 111 "C:\Users\jerry\Documents\OnlineJewelry\Views\Home\Index.cshtml"
WriteAttributeValue("", 5618, jewelry.ImageUrl, 5618, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 5636, "\"", 5642, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"300\" height=\"300\">\r\n                                <div class=\"img-cap\">\r\n                                   <h5><span");
            BeginWriteAttribute("asp-route-idJewelry", " asp-route-idJewelry=\"", 5770, "\"", 5810, 1);
#nullable restore
#line 113 "C:\Users\jerry\Documents\OnlineJewelry\Views\Home\Index.cshtml"
WriteAttributeValue("", 5792, jewelry.JewelryId, 5792, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 113 "C:\Users\jerry\Documents\OnlineJewelry\Views\Home\Index.cshtml"
                                                                                 Write(jewelry.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h5>\r\n                                   ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c84d68727081af9dad7bae841cf0f8df907c889415437", async() => {
                WriteLiteral("Shop Now");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                                   
                                    <div class=""favorit-items"">
                                        <!--<a asp-controller=""Jewelry"" asp-action=""List"" class=""btn"">jewelry.Price.ToString(""c"")</a>-->
                                    </div>

                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 124 "C:\Users\jerry\Documents\OnlineJewelry\Views\Home\Index.cshtml"
                }                       

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
</main>

<!-- <div class=""row"">
                        foreach (var jewelry in Model.Jewelries)
                        {
                            <div class=""col-sm-4 col-lg-4 col-md-4"">
                                <div class=""thumbnail"">
                                    <h4>
                                        <a asp-controller=""Jewelry"" asp-action=""Details"" asp-route-idJewelry=""jewelry.JewelryId"">jewelry.Name</a>
                                    </h4>
                                    <img src=""jewelry.ImageUrl"" alt="""" width=""300"" height=""300"" />
                                    <div class=""caption"">
                                        <h3 class=""pull-right"">jewelry.Price.ToString(""c"")</h3>
                                        <p>jewelry.ShortDescription</p>

                                    </div>
                                </div>
                            </div>

                        }-->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JewelryListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
