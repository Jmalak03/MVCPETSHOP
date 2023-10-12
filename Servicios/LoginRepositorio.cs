using Dapper;
using Microsoft.Data.SqlClient;
using MVCPETSHOP.Models;

namespace MVCPETSHOP.Servicios
{
   

        public interface ILoginRepositorio
        { }

        public class LoginRepositorio : ILoginRepositorio
        {

                 private readonly string connectionString;

            public LoginRepositorio(IConfiguration configuration)
            {
            connectionString = configuration.GetConnectionString("DefaultConnection");
            }

            public async Task Iniciar(LoginViewModel login)
            {
            using var connection = new SqlConnection(connectionString);

            var id = await connection.QuerySingleAsync<int>(
          @"INSERT INTO Login (Email, Password)
                VALUES (@Email, @Password,)
                SELECT SCOPE_IDENTITY();", login
          );
            
        }


            }

    

}