using Demo.GenericPopultor.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CM = System.Configuration.ConfigurationManager;

namespace Demo.GenericPopultor
{
    class Program
    {
        static void Main(string[] args)
        {

            List<EmployeeDTO> myEmployees = null;

            myEmployees = GetEmployeeList();

            Console.ReadLine();
        }

        private static List<EmployeeDTO> GetEmployeeList()
        { 

            List<EmployeeDTO> myEmployees = new List<EmployeeDTO>();



            string myConnectionString = CM.ConnectionStrings["Dev_UserBL"].ToString();

            SqlConnection con = new SqlConnection(myConnectionString);

            SqlCommand cmd = new SqlCommand
            {
                Connection = con,
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "BonusSummary2019_Select"
            };

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                EmployeeDTO myEmployee = new EmployeeDTO();

                myEmployee.Actual_Bonus = (decimal)reader["Actual_Bonus"];
                myEmployee.MI_Bonus = (decimal)reader["MI_Bonus"];
                myEmployee.CLFirstName = reader["FirstName"].ToString();
                myEmployee.Community = reader["Community"].ToString();
                myEmployee.JobTitle = reader["JobTitle"].ToString();
                myEmployee.EmployeeType = reader["EmployeeType"].ToString();

                myEmployees.Add(myEmployee);
            }
         
                //,BS.MI_Bonus
                //var employeeList = new Classes.GenericPopulator<employee>().CreateList(reader);
                //rptEmployees.DataSource = employeeList;
                //rptEmployees.DataBind();

                reader.Close();
                con.Close();
            return myEmployees;

        }

    }
}
