using API_SistemaDeTarefas.Data;
using API_SistemaDeTarefas.Integracao;
using API_SistemaDeTarefas.Integracao.Refit;
using API_SistemaDeTarefas.Repositorios;
using API_SistemaDeTarefas.Repositorios.Interfaces;
using API_SistemaDeTarefas.Integracao.Interfaces;
using Microsoft.EntityFrameworkCore;
using Refit;

namespace API_SistemaDeTarefas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddEntityFrameworkSqlServer().AddDbContext<SistemaDeTarefasDBContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"))
                );

            builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>(); // injecao de dependencia
            builder.Services.AddScoped<ITarefaRepositorio, TarefaRepositorio>(); // injecao de dependencia
            builder.Services.AddScoped<IViaCepIntegracao, ViaCepIntegracao>();

            builder.Services.AddRefitClient<IViaCepIntegracaoRefit>().ConfigureHttpClient(c =>
            {
                c.BaseAddress = new Uri("https://viacep.com.br"); // endereco base da API
            });

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
        }
    }
}
