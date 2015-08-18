using LamedhPos.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamedhPos.Infras.Data.SqlRepositories
{
    public class EmployeeSqlRepository : IDisposable
    {
        private SqlConnection connection;

        public EmployeeSqlRepository()
        {
            connection = new SqlConnection("Server=.\\SQLEXPRESS;Database=LamedhPos;Integrated Security=SSPI");
            connection.Open();
        }

        public Employee GetByCode(string code)
        {
            var command = connection.CreateCommand();
            command.CommandText = "select * from Employees where Code = @code";
            command.Parameters.AddWithValue("code", code);
            using (var reader = command.ExecuteReader())
            {
                reader.Read();
                return new Employee { Id = reader.GetInt32(0), Code = reader.GetString(1), Name = reader.GetString(2), Birthdate = reader.GetDateTime(3), };
            }
        }

        public IEnumerable<Employee> GetAll()
        {
            var command = connection.CreateCommand();
            command.CommandText = "select * from Employees";
            using (var reader = command.ExecuteReader())
            {
                //var result = new List<Employee>();
                while (reader.Read())
                {
                    var newEmployee = new Employee
                    {
                        Id = (int)reader["Id"],
                        Code = (string)reader["Code"],
                        Name = (string)reader["Name"],
                        Birthdate = (DateTime)reader["Birthdate"],
                    };
                    //result.Add(newEmployee);
                    yield return newEmployee;
                }
            }
        }

        public void Dispose()
        {
            connection.Close();
        }
    }
}
