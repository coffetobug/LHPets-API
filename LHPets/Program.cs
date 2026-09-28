var builder = WebApplication.CreateBuilder(args);

// Adicionar os controladores
builder.Services.AddControllers();

// ADICIONE ESTAS DUAS LINHAS (se não estiverem lá):
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// ADICIONE ESTAS DUAS LINHAS (dentro do bloco de desenvolvimento, se não estiverem lá):
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();