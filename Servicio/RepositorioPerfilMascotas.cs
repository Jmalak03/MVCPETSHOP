using Dapper;
using MVCPETSHOP.Models;
using Microsoft.Data.SqlClient;

namespace MVCPETSHOP.Servicios
{
    public interface IRepositorioPerfilMascotas
    {
        Task Crear(PerfilMascotas perfilMascotas);
        Task Obtener(Task<PerfilMascotas> IdMascotas);
        Task Obtener(object idMascotas);
        Task<PerfilMascotas> ObtenerPorId(int IdMascotas, int Nombre);
        object ObtenerPorId();
    }
    public class RepositorioPerfilMascotas
    {
        private readonly string connetionString;

        public RepositorioPerfilMascotas(IConfiguration configuration)
        {
            connetionString = configuration.GetConnectionString("DefaultConection");
        }

        public async Task Crear(PerfilMascotas perfilMascotas)
        {
            using var connetion = new SqlConnection(connetionString);

            var IdMascotas = await connetion.QuerySingleAsync<int>(
                @"INSERT INTO PerfilMascotas (IdMascota, Nombre, Edad, TipoMascota, Raza)
                VALUES (@IdMascota, @Nombre, @Edad, @TipoMascota, @Raza)
                SELECT SCOPE_IDENTITY();", perfilMascotas);
            perfilMascotas.IdMascotas = IdMascotas;
        }

        public async Task<PerfilMascotas> ObtenerPorId(int IdMascotas, int Nombre)
        {
            using var connection = new SqlConnection(connetionString);
            return await connection.QueryFirstOrDefaultAsync<PerfilMascotas>(@"SELECT Id, Nombre, Orden
                                                                            FROM TiposCuentas
                                                                            WHERE Id = @Id AND UsuarioId = @UsuarioId;",
                                                                            new { IdMascotas, Nombre });
        }

        public async Task<IEnumerable<PerfilMascotas>> Obtener(int IdMascotas)
        {
            using var connection = new SqlConnection(connetionString);

            return await connection.QueryAsync<PerfilMascotas>(@"SELECT IdMascota, Nombre, Edad, TipoMascota, Raza
                                                             FROM PerfilMascotas
                                                             WHERE IdMascotas = @idMascotas
                                                             ORDER BY Orden", new { IdMascotas });
        }
    }
}
