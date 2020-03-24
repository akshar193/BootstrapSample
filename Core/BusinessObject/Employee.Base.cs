
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Core.BusinessObject
{
    public partial class Employee : BaseObject
    {
        #region Member Variables
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string Mobile { get; set; }
        #endregion

        #region Methods

        public Employee() { }
        public Employee(IDataReader reader) : base(reader)
        {
            Name = DBNull.Value != reader["Name"] ? reader["Name"].ToString() : string.Empty;
            DOB = DBNull.Value != reader["DOB"] ? (DateTime)reader["DOB"] : default(DateTime);
            DOJ = DBNull.Value != reader["DOJ"] ? (DateTime)reader["DOJ"] : default(DateTime);
            Mobile = DBNull.Value != reader["Mobile"] ? reader["Mobile"].ToString() : string.Empty;
        }

        #endregion
    }

}
