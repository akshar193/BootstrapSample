using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    class Constants
    {
        #region Employee
        public const string Employee_Add = @"insert into Employee(
                                                            Name,
                                                            Mobile,
                                                            DOJ,
                                                            DOB,
                                                            CreatedOnUtc,
                                                            CreatedBy,
                                                            UpdatedOnUtc,
                                                            UpdatedBy,
                                                            IpAddress
                                                            )
                        Values(@name,@mobile,@doj,@dob,@createdonutc,@createdby,@updatedonutc,@updatedby,@IpAddress);";

        public const string Employee_Update = @"UPDATE Employee
                                                    SET Name = @name,
                                                    Mobile = @mobile,
                                                    DOJ = @doj,
                                                    DOB = @dob,
                                                    UpdatedOnUtc = @updatedonutc,
                                                    UpdatedBy = @updatedby,
                                                    IpAddress = @ipAddress
                                                    where Id = @id
                                                    ;";


        public const string Employee_GetAll = @"Select * from Employee;";
        #endregion
    }
}
