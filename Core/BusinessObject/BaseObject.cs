using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Core.BusinessObject
{
    public class BaseObject
    {
        #region Member Variables
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime UpdatedOnUtc { get; set; }
        public string IpAddress { get; set; }
        public int Id { get; set; }
        #endregion

        public BaseObject() 
        {
        }

        public BaseObject(IDataReader reader) 
        {
            Id = DBNull.Value != reader["Id"] ? (int)reader["Id"] : default(int);
            CreatedBy = DBNull.Value != reader["CreatedBy"] ? reader["CreatedBy"].ToString() : string.Empty;
            UpdatedBy = DBNull.Value != reader["UpdatedBy"] ? reader["UpdatedBy"].ToString() : string.Empty;
            IpAddress = DBNull.Value != reader["IpAddress"] ? reader["IpAddress"].ToString() : string.Empty;
            CreatedOnUtc = DBNull.Value != reader["CreatedOnUtc"] ? (DateTime)reader["CreatedOnUtc"] : default(DateTime);
            UpdatedOnUtc = DBNull.Value != reader["UpdatedOnUtc"] ? (DateTime)reader["UpdatedOnUtc"] : default(DateTime);
        }
    }
}
