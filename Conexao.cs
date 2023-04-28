using System.Data;
using Microsoft.EntityFrameworkCore;

public class Conexao : DbContext
{
    public string conn = "Server=localhost;User Id=root;Database=loja2";
    protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseMySql(conn, ServerVersion.AutoDetect(conn));

    public DbSet<Model.Produto> Produtos { get; set; }
    public DbSet<Model.Produto> Almoxarifado { get; internal set; }

    internal int ExecuteNonQuery()
    {
        throw new NotImplementedException();
    }
}

