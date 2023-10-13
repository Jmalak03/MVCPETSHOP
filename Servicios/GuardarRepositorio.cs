using Microsoft.Data.SqlClient;
using MVCPETSHOP.Models;

namespace MVCPETSHOP.Servicios
{
    public class GuardarRepositorio
    {
        public interface IRepositorioPerfilMascotas
        {

        }
        public class RepositorioPerfilMascota : IRepositorioPerfilMascotas
        {
            private readonly string connectionString;



            public RepositorioPerfilMascota(IConfiguration configuration)
            {
                connectionString = configuration.GetConnectionString("DefaultConnection");
            }
            public async Task Guardar(PerfilMascotas perfilMascotas)
            {
                using var connection = new SqlConnection(connectionString);
            }
        }

        public interface IRepositorioPedido
        {

        }
        public class RepositorioPedido : IRepositorioPedido
        {
            private readonly string connectionString;



            public RepositorioPedido(IConfiguration configuration)
            {
                connectionString = configuration.GetConnectionString("DefaultConnection");
            }
            public async Task Guardar(PedidoModel pedidoModel)
            {
                using var connection = new SqlConnection(connectionString);
            }
        }
    }

   
}
