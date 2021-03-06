using BankPaymentService.Application.Dto.PaymentInfo;
using BankPaymentService.Application.Interfaces;
using BankPaymentService.Application.Interfaces.Repositories;
using BankPaymentService.Application.Interfaces.Services;
using BankPaymentService.Application.Validators;
using BankPaymentService.Domain.Entities;
using BankPaymentService.Persistence;
using BankPaymentService.Persistence.Factory;
using BankPaymentService.Persistence.Repositories;
using BankPaymentService.Persistence.Services;
using BankPaymentService.Persistence.UnitOfWorks;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddFluentValidation(options =>
{
    options.ImplicitlyValidateChildProperties = true;
    options.ImplicitlyValidateRootCollectionElements = true;
    options.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
});
builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = "localhost:6379";
});
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options => 
options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"), 
    b => b.MigrationsAssembly("BankPaymentService.Persistence")));

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddTransient<ICcBinCodeRepository, CcBinCodeRepository>();
builder.Services.AddTransient<IPaymentInfoRepository, PaymentInfoRepository>();
builder.Services.AddTransient<IBankRepository, BankRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient<IBinCodeService, BinCodeService>();
builder.Services.AddTransient<IPaymentService, PaymentService>();
builder.Services.AddScoped<DbContext>(provider => provider.GetService<AppDbContext>());
builder.Services.AddTransient<IBankFactory, BankFactory>();
builder.Services.AddTransient<IValidator<PaymentInfoInput>, PaymentInfoValidator>();
builder.Services.AddTransient<IValidator<Bank>, BankValidator>();
builder.Services.AddSingleton<IRedisService,RedisService>();



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
