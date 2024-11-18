using GameCollectionManagement.Models;
using GameCollectionManagement.Models.Mappers;
using GameCollectionManagement.Utilities.Database;
using System.Data;

namespace GameCollectionManagement.Repositories
{
    public class UserRepository : BaseRepository<User>
    {

        public override List<User> GetAll()
        {
            string query = "select * from Users";

            DataTable dataTable = ExecuteQuery(query);

            List<User> users = new List<User>();

            foreach (DataRow row in dataTable.Rows)
            {
                users.Add(DataMappers.MapToUser(row));
            }
            return users;
        }

        public override User GetById(int id)
        {
            string query = "select * from Users where Id=@Id";

            //SqlParameter[] sqlParameters = new SqlParameter[] {
            //new SqlParameter("@Id", id)
            //};
            var parameters = new SqlParameterBuilder()
                                .AddParameter("@Id", id)
                                .Build();

            DataTable dataTable = ExecuteQuery(query, parameters);

            if (dataTable.Rows.Count == 0)
            {
                return null;
            }

            DataRow row = dataTable.Rows[0];

            return DataMappers.MapToUser(row);
        }

        public override void Add(User entity)
        {
            string query = "insert into Users (UserName, Email, Password, Role) Values (@UserName, @Email, @Password, @Role)";


            //SqlParameter[] parameters = new SqlParameter[] {
            //new SqlParameter("@UserName", entity.UserName),
            //new SqlParameter("@Email", entity.Email),
            //new SqlParameter("@Password", entity.Password),
            //new SqlParameter("@Role", entity.Role)
            //};
            var parameters = new SqlParameterBuilder()
                                .AddParameter("@UserName", entity.UserName)
                                .AddParameter("@Email", entity.Email)
                                .AddParameter("@Password", entity.Password)
                                .AddParameter("@Role", entity.Role)
                                .Build();


            ExecuteNonQuery(query, parameters);
        }

        public override void Update(User entity)
        {
            string query = "update Users set UserName=@UserName, Email=@Email, Password=@Password, Role=@Role where Id=@Id";
            //SqlParameter[] parameters = new SqlParameter[] {
            //new SqlParameter("@Id", entity.Id),
            //new SqlParameter("@UserName", entity.UserName),
            //new SqlParameter("@Email", entity.Email),
            //new SqlParameter("@Password", entity.Password),
            //new SqlParameter("@Role", entity.Role)
            //};
            var parameters = new SqlParameterBuilder()
                                .AddParameter("@Id", entity.Id)
                                .AddParameter("@UserName", entity.UserName)
                                .AddParameter("@Email", entity.Email)
                                .AddParameter("@Password", entity.Password)
                                .AddParameter("@Role", entity.Role)
                                .Build();
            ExecuteNonQuery(query, parameters);
        }

        public override void Delete(int id)
        {
            string query = "delete from Users where Id=@Id";


            //SqlParameter[] parameters = new SqlParameter[] {
            //new SqlParameter("@Id", id)
            //};

            var parameters = new SqlParameterBuilder()
                                .AddParameter("@Id", id)
                                .Build();


            ExecuteNonQuery(query, parameters);
        }

        public override void Delete(User entity)
        {
            Delete(entity.Id);
        }


        public (bool, int?) Login(string userName, string password)
        {
            string query = "select Id from Users where UserName=@UserName and Password=@Password";

            //SqlParameter[] parameters = new SqlParameter[] {
            //new SqlParameter("@UserName", userName),
            //new SqlParameter("@Password", password)
            //};
            var parameters = new SqlParameterBuilder()
                                .AddParameter("@UserName", userName)
                                .AddParameter("@Password", password)
                                .Build();

            var dataTable = ExecuteQuery(query, parameters);

            if (dataTable.Rows.Count == 0)
                return (false, null);

            int id = (int)dataTable.Rows[0]["Id"];
            return (true, id);
        }





    }
}
