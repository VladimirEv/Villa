var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

////настраиваем logger, MinimumLevel.Debug() - минимальный уровень регистрации,
////.WriteTo.File("log/villaLogs.txt", rollingInterval: RollingInterval.Day) - настраиваем путь к файлу логирования,
////RollingInterval.Day - интервал записи в файл
//Log.Logger = new LoggerConfiguration().MinimumLevel.Debug()
//    .WriteTo.File("log/villaLogs.txt", rollingInterval: RollingInterval.Day).CreateLogger();

////при запуске приложения запускаем UseSerilog()
//builder.Host.UseSerilog();  

builder.Services.AddMvc();
builder.Services.AddControllers(options=>
{
    //options.ReturnHttpNotAcceptable = true;
}).AddNewtonsoftJson().AddXmlDataContractSerializerFormatters();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
