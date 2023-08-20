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
