using DSBooking.Infrastructure.Factory;
using DSBooking.Infrastructure.Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Infrastructure.Repository
{
    public abstract class Repository<T>
    {
        protected IMapper<T> Mapper { get; private set; }

        public Repository(IMapper<T> mapper)
        {
            Mapper = mapper;
        }

        private IDbCommand CreateCommand(string sql)
        {
            var cmd = DbConnection.Instance.Connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            return cmd;
        }

        protected List<T> ExecuteQuery(string sql, Action<IDbCommand>? parameterize = null)
        {
            bool didOpen = DbConnection.Instance.Connection.State == ConnectionState.Closed;

            try
            {
                if (didOpen)
                    DbConnection.Instance.Connection.Open();

                using var cmd = CreateCommand(sql);
                parameterize?.Invoke(cmd);

                using var reader = cmd.ExecuteReader();
                var list = new List<T>();
                while (reader.Read())
                    list.Add(Mapper.Map(reader));

                return list;
            }
            finally
            {
                if (didOpen && DbConnection.Instance.Connection.State != ConnectionState.Closed)
                    DbConnection.Instance.Connection.Close();
            }
        }

        protected int ExecuteNonQuery(string sql, Action<IDbCommand>? parameterize = null)
        {
            var didOpen = DbConnection.Instance.Connection.State == ConnectionState.Closed;
            try
            {
                if (didOpen) DbConnection.Instance.Connection.Open();

                using var cmd = CreateCommand(sql);
                parameterize?.Invoke(cmd);
                int affectedRows = cmd.ExecuteNonQuery();
                return affectedRows;
            }
            finally
            {
                if (didOpen && DbConnection.Instance.Connection.State != ConnectionState.Closed)
                    DbConnection.Instance.Connection.Close();
            }
        }
    }
}
