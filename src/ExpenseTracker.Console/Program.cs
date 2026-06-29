using ExpenseTracker.Console.Repositories;
using ExpenseTracker.Console.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ExpenseTracker.Console.UI;
using System;
using System.IO;


IConfiguration configuration = new ConfigurationBuilder().
    SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json" , optional : false , reloadOnChange : true)
    .Build();

IServiceCollection services = new ServiceCollection();
services.AddSingleton<IConfiguration>(configuration);
services.AddSingleton<IExpenseRepository, JsonExpenseRepository>();
services.AddSingleton<IExpenseService, ExpenseService>();
services.AddLogging(builder => builder.AddConsole());
services.AddTransient<ConsoleMenu>();

IServiceProvider serviceProvider = services.BuildServiceProvider();
var myService =  serviceProvider.GetRequiredService<ConsoleMenu>();
myService.Run();