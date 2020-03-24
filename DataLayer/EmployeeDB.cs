using Core.BusinessObject;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataLayer
{
    public class EmployeeDB
    {
        public string connStr { get; set; }
        public MySqlConnection conn { get; set; }
        public EmployeeDB()
        {
            connStr = "server=localhost;user=root;database=bootstrapsample;port=3306;password=akshar193";
            conn = new MySqlConnection(connStr);
        }

        public void Add(Employee emp)
        {
            MySqlCommand cmd = new MySqlCommand(Constants.Employee_Add, conn);
            conn.Open();
            cmd.Parameters.AddWithValue("name", emp.Name);
            cmd.Parameters.AddWithValue("dob", emp.DOB);
            cmd.Parameters.AddWithValue("doj", emp.DOJ);
            cmd.Parameters.AddWithValue("mobile", emp.Mobile);
            cmd.Parameters.AddWithValue("createdby", emp.CreatedBy);
            cmd.Parameters.AddWithValue("createdonutc", emp.CreatedOnUtc);
            cmd.Parameters.AddWithValue("updatedby", emp.UpdatedBy);
            cmd.Parameters.AddWithValue("updatedonutc", emp.UpdatedOnUtc);
            cmd.Parameters.AddWithValue("ipaddress", emp.IpAddress);
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public void Update(Employee emp)
        {
            MySqlCommand cmd = new MySqlCommand(Constants.Employee_Update, conn);
            conn.Open();
            cmd.Parameters.AddWithValue("id", emp.Id);
            cmd.Parameters.AddWithValue("name", emp.Name);
            cmd.Parameters.AddWithValue("dob", emp.DOB);
            cmd.Parameters.AddWithValue("doj", emp.DOJ);
            cmd.Parameters.AddWithValue("mobile", emp.Mobile);
            cmd.Parameters.AddWithValue("updatedby", emp.UpdatedBy);
            cmd.Parameters.AddWithValue("updatedonutc", emp.UpdatedOnUtc);
            cmd.Parameters.AddWithValue("ipaddress", emp.IpAddress);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        public List<Employee> GetAll()
        {
            MySqlCommand cmd = new MySqlCommand(Constants.Employee_GetAll, conn);
            conn.Open();
            IDataReader reader = cmd.ExecuteReader();
            List<Employee> EmployeeList = new List<Employee>();
            while (reader.Read())
            {
                Employee emp = new Employee(reader);
                if (emp != null)
                {
                    EmployeeList.Add(emp);
                }
            }

            if (EmployeeList == null)
            {
                EmployeeList = new List<Employee>();
            }
            conn.Close();
            return EmployeeList;
        }
    }
}
