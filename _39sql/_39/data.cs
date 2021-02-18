using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace _39
{ 
    class data
    {

        public List<data> list = new List<data>();
        public string fname { get; set; }
        public string lname { get; set; }
        public string position { get; set; }
        public string dt { get; set; }

        public void getdata()
        {
            string connStringTrusted = "Server=.; Database=Sorting; Trusted_Connection=true; MultipleActiveResultSets=true;";
            SqlConnection cnn = new SqlConnection(connStringTrusted);

            try
            {
                cnn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                string sql = "SELECT * FROM sorting1";

                using (SqlCommand command = new SqlCommand(sql, cnn))
                {
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
        public int SortByNameAscending(string name1, string name2)
        {

            return name1.CompareTo(name2);
        }

    }
}
