using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace _40
{
    class data
    {

        public List<data> list = new List<data>();
        public string fname { get; set; }
        public string lname { get; set; }
        public string position { get; set; }
        public string dt { get; set; }

        public void getdata(string input)
        {
            string connStringTrusted = "Server=.; Database=Sorting; Trusted_Connection=true; MultipleActiveResultSets=true;";
            SqlConnection cnn = new SqlConnection(connStringTrusted);

            try
            {


                cnn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                string sql = "SELECT * FROM sorting1 WHERE lname LIKE @Lname";

                using (SqlCommand command = new SqlCommand(sql, cnn))
                {

                    command.Parameters.Add(CreateParam("@Lname", input + "%", SqlDbType.NVarChar));
                    var dataReader = command.ExecuteReader();
                    // While it's reading the data we add it to a new object for each row of the Municipalities table
                    while (dataReader.Read())
                    {
                        list.Add(new data() { fname = Convert.ToString(dataReader.GetValue(0)), lname = Convert.ToString(dataReader.GetValue(1)), position = Convert.ToString(dataReader.GetValue(2)), dt = Convert.ToString(dataReader.GetValue(3)) });
                    }

                    IEnumerable<data> query = list.OrderBy(data => data.lname);

                    foreach (data person in query)
                    {
                        Console.WriteLine("{0} - {1}", person.fname, person.lname);
                    }

                    command.Dispose();
                    cnn.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open) cnn.Close();
            }


        }
        private SqlParameter CreateParam(string name, object value, SqlDbType type)
        {
            SqlParameter param = new SqlParameter(name, type);
            param.Value = value;
            return param;
        }

    }
}
