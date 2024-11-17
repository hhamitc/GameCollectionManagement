using System.Data;
using System.Data.SqlClient;

namespace GameCollectionManagement.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        protected string _connectionString = "Server=LAPTOP-MCRDNKOK\\SQLEXPRESS;Database=GameCollectionManagement;Trusted_Connection=True";

        public abstract List<T> GetAll();
        public abstract T GetById(int Id);
        public abstract void Add(T entity);
        public abstract void Update(T entity);
        public abstract void Delete(T entity);
        public abstract void Delete(int Id);

        protected DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameters is not null)
                {
                    command.Parameters.AddRange(parameters);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                return dataTable;

            }
        }


        protected int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameters is not null)
                {
                    command.Parameters.AddRange(parameters);
                }

                return command.ExecuteNonQuery();

            }

        }
    }
}
