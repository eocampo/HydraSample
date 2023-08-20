using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
// using Microsoft.Extensions.WebEncoders;

string? environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

WebApplicationBuilder builder;

if ("Development".Equals(environment)) { //builder.Environment.IsDevelopment()) {
    builder = WebApplication.CreateBuilder(new WebApplicationOptions() {
        WebRootPath = "ClientApp/dist"
    });
} else {
    builder = WebApplication.CreateBuilder(args);
}

builder.Services.AddControllersWithViews();

// builder.Services.Configure<RazorViewEngineOptions>(options => {
//     options.SuppressOutputFormatter = true;
// });

// builder.Services.Configure<WebEncoderOptions>(options =>
// {
//     options.TextEncoderSettings = new System.Text.Encodings.Web.TextEncoderSettings(System.Text.Unicode.UnicodeRanges.All);
//     options.TextEncoderSettings.TrimZeroLengthWhitespace = true;
// });

// builder.Services.Configure<HtmlEncoderOptions>(options =>
// {
//     options.TrimOptions = TrimOptions.Trim;

// });

var app = builder.Build();

if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts(); // 30 days    
} else {
    // var baseDir = app.Environment.ContentRootPath;
    // AppDomain.CurrentDomain.SetData("DataDirectory", Path.Combine(baseDir, "App_Data"));
}

// app.UseRequestLocalization();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// app.UseAuthentication();
// app.UseAuthorization();

app.UseEndpoints(endpoints => {
    // endpoints.MapControllerRoute(
    //   name: "areas",
    //   pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

    endpoints.MapControllerRoute(
      name: "default",
      pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();
