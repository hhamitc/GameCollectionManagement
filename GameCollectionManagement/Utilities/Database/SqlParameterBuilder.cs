using System.Data;
using System.Data.SqlClient;

namespace GameCollectionManagement.Utilities.Database
{
    public class SqlParameterBuilder
    {

        private List<SqlParameter> _parameters = new List<SqlParameter>();

        public SqlParameterBuilder AddParameter(string
        name, object value)
        {
            _parameters.Add(new SqlParameter(name, value ?? DBNull.Value));
            return this;
        }

        public SqlParameterBuilder AddParameterWithValue(string
        name, object value, SqlDbType sqlDbType)
        {
            _parameters.Add(new SqlParameter(name, sqlDbType) { Value = value ?? DBNull.Value });
            return this;
        }

        public SqlParameter[] Build()
        {
            return _parameters.ToArray();
        }


    }
}
