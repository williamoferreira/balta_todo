var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddDbContext<MeuTodo.Data.AppDbContext>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.MapControllerRoute(
    "default",
    "{controller=Home}/{action=Index}/{id?}"
);

// app.MapGet("/", () => "Hello World!");

app.Run();
