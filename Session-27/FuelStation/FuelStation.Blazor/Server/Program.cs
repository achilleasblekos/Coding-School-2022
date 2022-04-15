using FuelStation.EF.Context;
using FuelStation.EF.MockRepositories;
using FuelStation.EF.Repositories;
using FuelStation.Model.Entities;
using FuelStation.Model.Handlers;
using Microsoft.AspNetCore.ResponseCompression;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddDbContext<FuelStationContext>();
//builder.Services.AddScoped<IEntityRepo<Customer>, CustomerRepo>();
var useMocks = Boolean.Parse(builder.Configuration["UseMocks"]);
if (!useMocks)
{
    builder.Services.AddScoped<IEntityRepo<Customer>, CustomerRepo>();
    builder.Services.AddScoped<IEntityRepo<Employee>, EmployeeRepo>();
    builder.Services.AddScoped<IEntityRepo<Item>, ItemRepo>();
    builder.Services.AddScoped<IEntityRepo<Transaction>, TransactionRepo>();
    builder.Services.AddScoped<CustomerHandler>();
    builder.Services.AddScoped<EmployeeHandler>();
    builder.Services.AddScoped<enumsHandler>();
    builder.Services.AddScoped<LedgerHandler>();
    builder.Services.AddScoped<TransactionHandler>();
}
else
{
    builder.Services.AddSingleton<IEntityRepo<Customer>, MockCustomerRepo>();
    builder.Services.AddSingleton<IEntityRepo<Employee>, MockEmployeeRepo>();
    builder.Services.AddSingleton<IEntityRepo<Item>, MockItemRepo>();
    builder.Services.AddSingleton<IEntityRepo<Transaction>, MockTransactionRepo>();
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
