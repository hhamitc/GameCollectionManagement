using GameCollectionManagement.Models;
using GameCollectionManagement.Models.Mappers;
using GameCollectionManagement.Utilities.Database;
using System.Data;
using System.Data.SqlClient;

namespace GameCollectionManagement.Repositories
{
    public class GameRepository : BaseRepository<Game>
    {
        public override List<Game> GetAll()
        {
            string query = "select * from Games";

            DataTable dataTable = ExecuteQuery(query);

            List<Game> games = new List<Game>();

            foreach (DataRow row in dataTable.Rows)
            {
                games.Add(DataMappers.MapToGame(row));
            }

            return games;
        }

        public List<Game> GetList()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select * from Games", connection);

                SqlDataReader dataReader = command.ExecuteReader();

                List<Game> games = new List<Game>();

                while (dataReader.Read())
                {
                    Game game = new Game();
                    game.Id = Convert.ToInt32(dataReader["Id"]);
                    game.Name = dataReader["Name"].ToString();
                    game.Genre = dataReader["Genre"].ToString();
                    game.Platform = dataReader["Platform"].ToString();
                    game.ReleaseDate = Convert.ToDateTime(dataReader["ReleaseDate"]);
                    game.PlayTime = Convert.ToInt32(dataReader["PlayTime"]);
                    game.CoverImage = dataReader["CoverImage"] as byte[];

                    games.Add(game);
                }

                dataReader.Close();

                return games;
            }

        }


        public override Game GetById(int id)
        {
            string query = "Select * from Games where Id = @Id";

            var parameters = new SqlParameterBuilder()
                                .AddParameter("@Id", id)
                                .Build();

            DataTable dataTable = ExecuteQuery(query, parameters);

            DataRow row = dataTable.Rows[0];


            return DataMappers.MapToGame(row);
        }

        public override void Add(Game entity)
        {
            string query = "INSERT INTO Games (Name, Genre, Platform, ReleaseDate, PlayTime, CoverImage) VALUES (@Name, @Genre, @Platform, @ReleaseDate, @PlayTime, @CoverImage)";

            //SqlParameter[] parameters = new SqlParameter[]
            //{
            // new SqlParameter("@Name", entity.Name),
            // new SqlParameter("@Genre", entity.Genre),
            // new SqlParameter("@Platform", entity.Platform),
            // new SqlParameter("@ReleaseDate", entity.ReleaseDate),
            // new SqlParameter("@PlayTime", entity.PlayTime),
            // new SqlParameter("@CoverImage", entity.CoverImage)
            //};
            var parameters = new SqlParameterBuilder()
                                .AddParameter("@Name", entity.Name)
                                .AddParameter("@Genre", entity.Genre)
                                .AddParameter("@Platform", entity.Platform)
                                .AddParameter("@ReleaseDate", entity.ReleaseDate)
                                .AddParameter("@PlayTime", entity.PlayTime)
                                .AddParameterWithValue("@CoverImage", entity.CoverImage, SqlDbType.VarBinary)

                                .Build();

            ExecuteNonQuery(query, parameters);
        }

        public override void Update(Game entity)
        {
            string query = "UPDATE Games SET Name=@Name, Genre=@Genre, Platform=@Platform, ReleaseDate=@ReleaseDate, PlayTime=@PlayTime, CoverImage=@CoverImage WHERE Id=@Id";

            //SqlParameter[] parameters = new SqlParameter[]
            //{
            //new SqlParameter("@Id", entity.Id),
            //new SqlParameter("@Name", entity.Name),
            //new SqlParameter("@Genre", entity.Genre),
            //new SqlParameter("@Platform", entity.Platform),
            //new SqlParameter("@ReleaseDate", entity.ReleaseDate),
            //new SqlParameter("@PlayTime", entity.PlayTime),
            //new SqlParameter("@CoverImage", entity.CoverImage),
            //};

            var parameters = new SqlParameterBuilder()
                                .AddParameter("@Id", entity.Id)
                                .AddParameter("@Name", entity.Name)
                                .AddParameter("@Genre", entity.Genre)
                                .AddParameter("@Platform", entity.Platform)
                                .AddParameter("@ReleaseDate", entity.ReleaseDate)
                                .AddParameter("@PlayTime", entity.PlayTime)
                                .AddParameterWithValue("@CoverImage", entity.CoverImage, SqlDbType.VarBinary)
                                .Build();

            ExecuteNonQuery(query, parameters);
        }

        public override void Delete(int id)
        {
            string query = "DELETE FROM Games WHERE Id=@Id";
            //SqlParameter[] parameters = new SqlParameter[]
            //{
            // new SqlParameter("@Id", id)
            //};
            var parameters = new SqlParameterBuilder()
                                .AddParameter("@Id", id)
                                .Build();

            ExecuteNonQuery(query, parameters);
        }


        public override void Delete(Game entity)
        {
            Delete(entity.Id);
        }

    }
}
