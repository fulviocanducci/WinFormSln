using DAO.Base;
using DAO.Extensions;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace DAO
{
    public class DaoPeople : IDao<People>
    {
        public SqlConnection Connection { get; }
        public DaoPeople(SqlConnection connection)
        {
            Connection = connection;
        }

        public IEnumerable<People> All()
        {
            Connection.OpenIsClose();
            using (SqlCommand command = new SqlCommand("SELECT Id, Name, Salary, CreatedAt, Active FROM Peoples ORDER BY Name", Connection))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    yield return TransformReaderToPeople(reader);
                }
                Connection.CloseIsOpen();
            }
        }

        public IEnumerable<People> All(params NameAndValue[] nameAndValues)
        {
            Connection.OpenIsClose();
            using (SqlCommand command = new SqlCommand("SELECT Id, Name, Salary, CreatedAt, Active FROM Peoples WHERE Name Like @Name ORDER BY Name", Connection))
            {
                command.Parameters.Clear();
                foreach (var item in nameAndValues)
                {
                    command.Parameters.Add(item.Name);
                    command.Parameters[item.Name].Value = item.Value;
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        yield return TransformReaderToPeople(reader);
                    }
                    Connection.CloseIsOpen();
                }
            }
        }

        public bool Delete(People model)
        {
            bool result = false;
            Connection.OpenIsClose();
            using (SqlCommand command = new SqlCommand("DELETE FROM Peoples WHERE Id = @Id", Connection))
            {
                command.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = model.Id;
                result = command.ExecuteNonQuery() > 0;
                Connection.CloseIsOpen();
            }
            return result;
        }

        public People Find(params object[] keys)
        {
            People people = null;
            Connection.OpenIsClose();
            using (SqlCommand command = new SqlCommand("SELECT Id, Name, Salary, CreatedAt, Active FROM Peoples WHERE Id = @Id", Connection))
            {
                command.Parameters.Add("@Id", System.Data.SqlDbType.Int);
                command.Parameters["@Id"].Value = keys[0];
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        people = TransformReaderToPeople(reader);
                    }
                    Connection.CloseIsOpen();
                }
            }
            return people;
        }

        public People Insert(People model)
        {
            Connection.OpenIsClose();
            using (SqlCommand command = new SqlCommand("INSERT INTO Peoples(Name, Salary, CreatedAt, Active) VALUES(@Name, @Salary, @CreatedAt, @Active); SELECT SCOPE_IDENTITY()", Connection))
            {
                command.Parameters.Add("@Name", System.Data.SqlDbType.VarChar).Value = model.Name;
                command.Parameters.Add("@Salary", System.Data.SqlDbType.Decimal).Value = model.Salary;
                command.Parameters.Add("@CreatedAt", System.Data.SqlDbType.DateTime).Value = (object)model.CreatedAt ?? DBNull.Value;
                command.Parameters.Add("@Active", System.Data.SqlDbType.Bit).Value = model.Active;
                if (int.TryParse(command?.ExecuteScalar()?.ToString(), out int id))
                {
                    model.Id = id;
                }
                Connection.CloseIsOpen();
            }
            return model;
        }

        public bool Update(People model)
        {
            bool result = false;
            Connection.OpenIsClose();
            using (SqlCommand command = new SqlCommand("UPDATE Peoples SET Name=@Name, Salary=@Salary, CreatedAt=@CreatedAt, Active=@Active WHERE Id=@Id", Connection))
            {
                command.Parameters.Add("@Name", System.Data.SqlDbType.VarChar).Value = model.Name;
                command.Parameters.Add("@Salary", System.Data.SqlDbType.Decimal).Value = model.Salary;
                command.Parameters.Add("@CreatedAt", System.Data.SqlDbType.DateTime).Value = (object)model.CreatedAt ?? DBNull.Value;
                command.Parameters.Add("@Active", System.Data.SqlDbType.Bit).Value = model.Active;
                command.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = model.Id;
                result = command.ExecuteNonQuery() > 0;
                Connection.CloseIsOpen();
            }
            return result;
        }

        protected People TransformReaderToPeople(SqlDataReader reader)
        {
            return new People
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                Salary = reader.GetDecimal(2),
                CreatedAt = reader.IsDBNull(3) ? null : (DateTime?)reader.GetDateTime(3),
                Active = reader.GetBoolean(4)
            };
        }
    }
}
