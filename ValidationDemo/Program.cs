using Microsoft.AspNetCore.Mvc;
using ValidationDemo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//�ر�Ĭ��ģ����֤
builder.Services.Configure<ApiBehaviorOptions>(opt => opt.SuppressModelStateInvalidFilter = true);
builder.Services.AddControllers(opt =>
{
    //��ӹ�����
    opt.Filters.Add<ModelValidateActionFilterAttribute>();
});


builder.Services.AddControllers();
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
