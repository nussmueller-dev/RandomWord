using RandomWord.Logic;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<Logic>();

builder.Services.AddCors(options => {
  options.AddDefaultPolicy(builder => builder
  .SetIsOriginAllowed(_ => true)
  .AllowAnyMethod()
  .AllowAnyHeader()
  .AllowCredentials());
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseAuthorization();
app.UseCors();

app.MapControllers();

app.Run();
