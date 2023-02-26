using MagicVilla_VillaApi.Logging;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

////����������� logger, MinimumLevel.Debug() - ����������� ������� �����������,
////.WriteTo.File("log/villaLogs.txt", rollingInterval: RollingInterval.Day) - ����������� ���� � ����� �����������,
////RollingInterval.Day - �������� ������ � ����
//Log.Logger = new LoggerConfiguration().MinimumLevel.Debug()
//    .WriteTo.File("log/villaLogs.txt", rollingInterval: RollingInterval.Day).CreateLogger();

////��� ������� ���������� ��������� UseSerilog()
//builder.Host.UseSerilog();  

builder.Services.AddMvc();
builder.Services.AddControllers(options=>
{
    //options.ReturnHttpNotAcceptable = true;
}).AddNewtonsoftJson().AddXmlDataContractSerializerFormatters();

builder.Services.AddScoped<ILogging, LoggingV2>();

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
