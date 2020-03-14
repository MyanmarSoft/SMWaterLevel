using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Whizzo;
using SMWaterLevel.Entities;
namespace SMWaterLevel.DataAccess
{

	public class UserProfileTableAdapter : BaseDataAdapter
	{
		
		
		#region Constructers

			public UserProfileTableAdapter():base()
            {
                InitInsertCommand();
                InitUpdateCommand();
                InitDeleteCommand();
                InitCommandCollection();
            }

		#endregion

		

		#region Initializations

		protected  void InitInsertCommand()
		{
			InsertCommand.CommandType = CommandType.Text;
            InsertCommand.Connection = Connection;
			InsertCommand.CommandText = @"INSERT INTO UserProfile(Name,Username,Password,UserRoleID,DepartmentID,Status) VALUES (@Name,@Username,@Password,@UserRoleID,@DepartmentID,@Status);SELECT ID FROM UserProfile WHERE (ID = SCOPE_IDENTITY())";
						InsertCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar, 50,"Name"));
			InsertCommand.Parameters.Add(new SqlParameter("@Username", SqlDbType.VarChar, 50,"Username"));
			InsertCommand.Parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar, 50,"Password"));
			InsertCommand.Parameters.Add(new SqlParameter("@UserRoleID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"UserRoleID", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@DepartmentID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"DepartmentID", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitUpdateCommand()
		{
			UpdateCommand.CommandType = CommandType.Text;
            UpdateCommand.Connection = Connection;
			UpdateCommand.CommandText = @"UPDATE UserProfile SET Name = @Name, Username = @Username, Password = @Password, UserRoleID = @UserRoleID, DepartmentID = @DepartmentID, Status = @Status WHERE (ID = @ID)";
			UpdateCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar, 50,"Name"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Username", SqlDbType.VarChar, 50,"Username"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar, 50,"Password"));
			UpdateCommand.Parameters.Add(new SqlParameter("@UserRoleID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"UserRoleID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@DepartmentID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"DepartmentID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitDeleteCommand()
		{
            DeleteCommand.CommandType = CommandType.Text;
			DeleteCommand.Connection = Connection;
			DeleteCommand.CommandText = "DELETE FROM UserProfile WHERE (ID = @ID)";
			DeleteCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
		}

		protected  void InitCommandCollection()
		{
			CommandCollection = new IDbCommand[6];

			CommandCollection[0] = new SqlCommand();
			((SqlCommand) (CommandCollection[0])).Connection = Connection;
			((SqlCommand) (CommandCollection[0])).CommandText = "SELECT ID,Name,Username,Password,UserRoleID,DepartmentID,Status FROM UserProfile";
			((SqlCommand) (CommandCollection[0])).CommandType = CommandType.Text;
			
			//Fill/GetByID
            CommandCollection[1] = new SqlCommand();
            ((SqlCommand)(CommandCollection[1])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[1])).CommandText = "SELECT ID,Name,Username,Password,UserRoleID,DepartmentID,Status FROM UserProfile WHERE ID =  @ID";
            ((SqlCommand)(CommandCollection[1])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[1])).Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, "ID"));
			
			//Fill/GetByStatus
            CommandCollection[2] = new SqlCommand();
            ((SqlCommand)(CommandCollection[2])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[2])).CommandText = "SELECT UserProfile.ID,UserProfile.Name,UserProfile.Username,UserProfile.Password,UserProfile.UserRoleID,RoleName,UserProfile.DepartmentID,DepartmentName,UserProfile.Status FROM UserRole,Department,UserProfile WHERE UserProfile.UserRoleID = UserRole.ID AND UserProfile.DepartmentID = Department.ID AND UserProfile.Status =  @Status";
            ((SqlCommand)(CommandCollection[2])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[2])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));
			
			#region CustomCommand
			
            //Fill/GetUserProfileByUsername
            CommandCollection[3] = new SqlCommand();
            ((SqlCommand)(CommandCollection[3])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[3])).CommandText = "SELECT ID,Name,Username,Password,UserRoleID,DepartmentID,Status FROM UserProfile WHERE Username = @Username AND Status =  @Status";
            ((SqlCommand)(CommandCollection[3])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@Username", SqlDbType.VarChar, 50, "Username"));
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10, "Status"));
            

            //GetDataByDepartmentIDAndStatus
            CommandCollection[4] = new SqlCommand();
            ((SqlCommand)(CommandCollection[4])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[4])).CommandText = "SELECT UserProfile.ID,UserProfile.Name,UserProfile.Username,UserProfile.Password,UserProfile.UserRoleID,RoleName,UserProfile.DepartmentID,DepartmentName,UserProfile.Status FROM UserRole,Department,UserProfile WHERE UserProfile.UserRoleID = UserRole.ID AND UserProfile.DepartmentID = Department.ID AND UserProfile.DepartmentID = @DepartmentID AND UserProfile.Status =  @Status";
            ((SqlCommand)(CommandCollection[4])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[4])).Parameters.Add(new SqlParameter("@DepartmentID", SqlDbType.Int, 4, "DepartmentID"));
            ((SqlCommand)(this.CommandCollection[4])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10, "Status"));

            //GetUserProfileByName
            CommandCollection[5] = new SqlCommand();
            ((SqlCommand)(CommandCollection[5])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[5])).CommandText = "SELECT ID,Name,Username,Password,UserRoleID,DepartmentID,Status FROM UserProfile WHERE Name = @Name AND Status =  @Status";
            ((SqlCommand)(CommandCollection[5])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[5])).Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar, 50, "Name"));
            ((SqlCommand)(this.CommandCollection[5])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10, "Status"));
            

			#endregion CustomCommand
			
		}

		#endregion

		#region Data Functions

		
		public int Fill(DataTable dt)
		{
           
            int returnValue =-1;
			Adapter.SelectCommand = ((SqlCommand) (this.CommandCollection[0]));
            
			try
            {
                Adapter.SelectCommand.Connection.Open();
			    returnValue = Adapter.Fill(dt);
            }
            catch(SqlException ex)
            {
                Logger.Write(ex);
            }
            finally
			{
                 Adapter.SelectCommand.Connection.Close();
            }
			return returnValue;
		}

		public DataTable GetData()
		{
           
			Adapter.SelectCommand = ((SqlCommand) (CommandCollection[0]));
			DataTable dt = new DataTable();
            
            try
            {
                Adapter.SelectCommand.Connection.Open();
			    Adapter.Fill(dt);
            }
            catch(SqlException ex)
            {
                 Logger.Write(ex);
            }
            finally
			{
                 Adapter.SelectCommand.Connection.Close();
            }
			
			return dt;
		}
	    public DataTable GetDataByStatus(string status)
        {

            DataTable dt = new DataTable();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[2]));
            Adapter.SelectCommand.Parameters["@Status"].Value = status;

            try
            {
                Adapter.SelectCommand.Connection.Open();
                Adapter.Fill(dt);
            }
            catch (SqlException ex)
            {
                 Logger.Write(ex);
            }
            finally
            {
                Adapter.SelectCommand.Connection.Close();
            }

            return dt;
        }



		public UserProfile GetUserProfileByID(int ID)
		{
            
            DataTable dt = new DataTable();
			Adapter.SelectCommand = ((SqlCommand) (CommandCollection[1]));
			Adapter.SelectCommand.Parameters[0].Value = ID;
		   
            try
            {
                Adapter.SelectCommand.Connection.Open();
			    Adapter.Fill(dt);
            }
            catch(SqlException ex)
            {
                Logger.Write(ex);
            }
            finally
			{
                 Adapter.SelectCommand.Connection.Close();
            }
		
			return DataTableToEntity(dt);
		}
		
		public DataSet GetUserProfileByStatus(string status)
		{
             DataSet ds = new DataSet();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[2]));
            Adapter.SelectCommand.Parameters[0].Value = status;

            try
            {
                Adapter.SelectCommand.Connection.Open();
                Adapter.Fill(ds);
            }
            catch (SqlException ex)
            {
                 Logger.Write(ex);
            }
            finally
            {
                Adapter.SelectCommand.Connection.Close();
            }

            return ds;
		}
 
		#region CustomGetTable
		
        public UserProfile GetUserProfileByUsername(string userName, string status)
        {

            DataTable dt = new DataTable();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[3]));
            Adapter.SelectCommand.Parameters[0].Value = userName;
            Adapter.SelectCommand.Parameters[1].Value = status;

            try
            {
                Adapter.SelectCommand.Connection.Open();
                Adapter.Fill(dt);
            }
            catch (SqlException ex)
            {
                Logger.Write(ex);
            }
            finally
            {
                Adapter.SelectCommand.Connection.Close();
            }

            return DataTableToEntity(dt);
        }

        public DataTable GetDataByDepartmentIDAndStatus(int departmentID, string status)
        {

            DataTable dt = new DataTable();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[4]));
            Adapter.SelectCommand.Parameters[0].Value = departmentID;
            Adapter.SelectCommand.Parameters[1].Value = status;

            try
            {
                Adapter.SelectCommand.Connection.Open();
                Adapter.Fill(dt);
            }
            catch (SqlException ex)
            {
                 Logger.Write(ex);
            }
            finally
            {
                Adapter.SelectCommand.Connection.Close();
            }

            return dt;
        }

        public UserProfile GetDoctorByDepartmentIDAndStatus(int departmentID, string status)
        {

            DataTable dt = new DataTable();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[3]));
            Adapter.SelectCommand.Parameters[0].Value = departmentID;
            Adapter.SelectCommand.Parameters[1].Value = status;

            try
            {
                Adapter.SelectCommand.Connection.Open();
                Adapter.Fill(dt);
            }
            catch (SqlException ex)
            {
                Logger.Write(ex);
            }
            finally
            {
                Adapter.SelectCommand.Connection.Close();
            }

            return DataTableToEntity(dt);
        }

        public UserProfile GetUserProfileByName(string name,string status)
        {

            DataTable dt = new DataTable();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[5]));
            Adapter.SelectCommand.Parameters[0].Value = name;
            Adapter.SelectCommand.Parameters[1].Value = status;


            try
            {
                Adapter.SelectCommand.Connection.Open();
                Adapter.Fill(dt);
            }
            catch (SqlException ex)
            {
                Logger.Write(ex);
            }
            finally
            {
                Adapter.SelectCommand.Connection.Close();
            }

            return DataTableToEntity(dt);
        }
		
        
		#endregion CustomGetTable
	    
		public int Insert(UserProfile userProfile)
		{
	InsertCommand.Parameters["@Name"].Value = userProfile.Name;
	InsertCommand.Parameters["@Username"].Value = userProfile.Username;
	InsertCommand.Parameters["@Password"].Value = userProfile.Password;
	InsertCommand.Parameters["@UserRoleID"].Value = userProfile.UserRoleID;
	InsertCommand.Parameters["@DepartmentID"].Value = userProfile.DepartmentID;
	InsertCommand.Parameters["@Status"].Value = userProfile.Status;
		
			
            int returnValue = -1;
            try
            {
                InsertCommand.Connection.Open();
                returnValue = (int)InsertCommand.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                Logger.Write(ex);
            }
            finally
            {
                InsertCommand.Connection.Close();
            }
            return returnValue;
		}
        
		public int Update(UserProfile userProfile)
		{
	UpdateCommand.Parameters["@ID"].Value = userProfile.ID;
	UpdateCommand.Parameters["@Name"].Value = userProfile.Name;
	UpdateCommand.Parameters["@Username"].Value = userProfile.Username;
	UpdateCommand.Parameters["@Password"].Value = userProfile.Password;
	UpdateCommand.Parameters["@UserRoleID"].Value = userProfile.UserRoleID;
	UpdateCommand.Parameters["@DepartmentID"].Value = userProfile.DepartmentID;
	UpdateCommand.Parameters["@Status"].Value = userProfile.Status;

			int returnValue = -1;
            try
            {
                UpdateCommand.Connection.Open();
                returnValue = UpdateCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Logger.Write(ex);
            }
            finally
            {
                UpdateCommand.Connection.Close();
            }
            return returnValue;
		}
        
        private UserProfile DataTableToEntity(DataTable dt)
        {
           
            UserProfile userProfile = new UserProfile();
            if(Null.IsNotNull(dt)==true && dt.Rows.Count > 0)
            {
                
                if (Null.IsNotNull(dt.Rows[0]))
                {
                    DataRow dr = dt.Rows[0];
                      					if (Null.IsNotNull(dr["ID"]))
					{
						userProfile.ID=Convert.ToInt32(dr["ID"]);
					}
					else
					{
						userProfile.ID=0;
					}
					if (Null.IsNotNull(dr["Name"]))
					{
						userProfile.Name= Convert.ToString(dr["Name"]);
					}
					else
					{
						userProfile.Name=string.Empty;
					}
					if (Null.IsNotNull(dr["Username"]))
					{
						userProfile.Username= Convert.ToString(dr["Username"]);
					}
					else
					{
						userProfile.Username=string.Empty;
					}
					if (Null.IsNotNull(dr["Password"]))
					{
						userProfile.Password= Convert.ToString(dr["Password"]);
					}
					else
					{
						userProfile.Password=string.Empty;
					}
					if (Null.IsNotNull(dr["UserRoleID"]))
					{
						userProfile.UserRoleID=Convert.ToInt32(dr["UserRoleID"]);
					}
					else
					{
						userProfile.UserRoleID=0;
					}
					if (Null.IsNotNull(dr["DepartmentID"]))
					{
						userProfile.DepartmentID=Convert.ToInt32(dr["DepartmentID"]);
					}
					else
					{
						userProfile.DepartmentID=0;
					}
					if (Null.IsNotNull(dr["Status"]))
					{
						userProfile.Status= Convert.ToString(dr["Status"]);
					}
					else
					{
						userProfile.Status=string.Empty;
					}
 
                }
            }
            return userProfile ;
        }
		#endregion		
	}
}