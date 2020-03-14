using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Whizzo;
using SMWaterLevel.Entities;
namespace SMWaterLevel.DataAccess
{

	public class RiverTableAdapter : BaseDataAdapter
	{
		
		
		#region Constructers

			public RiverTableAdapter():base()
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
			InsertCommand.CommandText = @"INSERT INTO River(RiverID,RiverName,Latitude,Longitude,Description,Status) VALUES (@RiverID,@RiverName,@Latitude,@Longitude,@Description,@Status);SELECT ID FROM River WHERE (ID = SCOPE_IDENTITY())";
						InsertCommand.Parameters.Add(new SqlParameter("@RiverID", SqlDbType.VarChar, 50,"RiverID"));
			InsertCommand.Parameters.Add(new SqlParameter("@RiverName", SqlDbType.NVarChar, 50,"RiverName"));
			InsertCommand.Parameters.Add(new SqlParameter("@Latitude", SqlDbType.VarChar, 50,"Latitude"));
			InsertCommand.Parameters.Add(new SqlParameter("@Longitude", SqlDbType.VarChar, 50,"Longitude"));
			InsertCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 200,"Description"));
			InsertCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitUpdateCommand()
		{
			UpdateCommand.CommandType = CommandType.Text;
            UpdateCommand.Connection = Connection;
			UpdateCommand.CommandText = @"UPDATE River SET RiverID = @RiverID, RiverName = @RiverName, Latitude = @Latitude, Longitude = @Longitude, Description = @Description, Status = @Status WHERE (ID = @ID)";
						UpdateCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@RiverID", SqlDbType.VarChar, 50,"RiverID"));
			UpdateCommand.Parameters.Add(new SqlParameter("@RiverName", SqlDbType.NVarChar, 50,"RiverName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Latitude", SqlDbType.VarChar, 50,"Latitude"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Longitude", SqlDbType.VarChar, 50,"Longitude"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 200,"Description"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitDeleteCommand()
		{
            DeleteCommand.CommandType = CommandType.Text;
			DeleteCommand.Connection = Connection;
			DeleteCommand.CommandText = "DELETE FROM River WHERE (ID = @ID)";
			DeleteCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
		}

		

		protected  void InitCommandCollection()
		{
			CommandCollection = new IDbCommand[4];

			CommandCollection[0] = new SqlCommand();
			((SqlCommand) (CommandCollection[0])).Connection = Connection;
			((SqlCommand) (CommandCollection[0])).CommandText = "SELECT ID,RiverID,RiverName,Latitude,Longitude,Description,Status FROM River";
			((SqlCommand) (CommandCollection[0])).CommandType = CommandType.Text;
			
			//Fill/GetByID
            CommandCollection[1] = new SqlCommand();
            ((SqlCommand)(CommandCollection[1])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[1])).CommandText = "SELECT ID,RiverID,RiverName,Latitude,Longitude,Description,Status FROM River WHERE ID =  @ID";
            ((SqlCommand)(CommandCollection[1])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[1])).Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, "ID"));
			
			//Fill/GetByStatus
            CommandCollection[2] = new SqlCommand();
            ((SqlCommand)(CommandCollection[2])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[2])).CommandText = "SELECT ID,RiverID,RiverName,Latitude,Longitude,Description,Status FROM River WHERE Status =  @Status";
            ((SqlCommand)(CommandCollection[2])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[2])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));
			
			#region CustomCommand
			
			//GetSearchByRiver
            CommandCollection[3] = new SqlCommand();
            ((SqlCommand)(CommandCollection[3])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[3])).CommandText = "SELECT ID,RiverID,RiverName,Latitude,Longitude,Description,Status FROM River WHERE RiverName LIKE '%'+ @RiverName + '%' AND Status =  @Status";
            ((SqlCommand)(CommandCollection[3])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@RiverName", SqlDbType.NVarChar, 50, "RiverName"));
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));

			
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
               // Logger.Write(ex);
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
                //Logger.Write(ex);
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
                // Logger.Write(ex);
            }
            finally
            {
                Adapter.SelectCommand.Connection.Close();
            }

            return dt;
        }

		public River GetRiverByID(int ID)
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
               // Logger.Write(ex);
            }
            finally
			{
                 Adapter.SelectCommand.Connection.Close();
            }
		
			return DataTableToEntity(dt);
		}
		
		public DataSet GetRiverByStatus(string status)
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
                // Logger.Write(ex);
            }
            finally
            {
                Adapter.SelectCommand.Connection.Close();
            }

            return ds;
		}

		#region CustomGetTable
		
        public DataSet GetSearchByRiver(string riverName,string status)
        {
            DataSet ds = new DataSet();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[3]));
            Adapter.SelectCommand.Parameters[0].Value = riverName;
            Adapter.SelectCommand.Parameters[1].Value = status;

            try
            {
                Adapter.SelectCommand.Connection.Open();
                Adapter.Fill(ds);
            }
            catch (SqlException ex)
            {
                // Logger.Write(ex);
            }
            finally
            {
                Adapter.SelectCommand.Connection.Close();
            }

            return ds;
        }
		
		#endregion CustomGetTable
	    
		public int Insert(River river)
		{
	InsertCommand.Parameters["@RiverID"].Value = river.RiverID;
	InsertCommand.Parameters["@RiverName"].Value = river.RiverName;
	InsertCommand.Parameters["@Latitude"].Value = river.Latitude;
	InsertCommand.Parameters["@Longitude"].Value = river.Longitude;
	InsertCommand.Parameters["@Description"].Value = river.Description;
	InsertCommand.Parameters["@Status"].Value = river.Status;
		
			
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
        
		public int Update(River river)
		{
	UpdateCommand.Parameters["@ID"].Value = river.ID;
	UpdateCommand.Parameters["@RiverID"].Value = river.RiverID;
	UpdateCommand.Parameters["@RiverName"].Value = river.RiverName;
	UpdateCommand.Parameters["@Latitude"].Value = river.Latitude;
	UpdateCommand.Parameters["@Longitude"].Value = river.Longitude;
	UpdateCommand.Parameters["@Description"].Value = river.Description;
	UpdateCommand.Parameters["@Status"].Value = river.Status;

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
        
        private River DataTableToEntity(DataTable dt)
        {
           
            River river = new River();
            if(Null.IsNotNull(dt)==true && dt.Rows.Count > 0)
            {
                
                if (Null.IsNotNull(dt.Rows[0]))
                {
                    DataRow dr = dt.Rows[0];
                      					if (Null.IsNotNull(dr["ID"]))
					{
						river.ID=Convert.ToInt32(dr["ID"]);
					}
					else
					{
						river.ID=0;
					}
					if (Null.IsNotNull(dr["RiverID"]))
					{
						river.RiverID= Convert.ToString(dr["RiverID"]);
					}
					else
					{
						river.RiverID=string.Empty;
					}
					if (Null.IsNotNull(dr["RiverName"]))
					{
						river.RiverName= Convert.ToString(dr["RiverName"]);
					}
					else
					{
						river.RiverName=string.Empty;
					}
					if (Null.IsNotNull(dr["Latitude"]))
					{
						river.Latitude= Convert.ToString(dr["Latitude"]);
					}
					else
					{
						river.Latitude=string.Empty;
					}
					if (Null.IsNotNull(dr["Longitude"]))
					{
						river.Longitude= Convert.ToString(dr["Longitude"]);
					}
					else
					{
						river.Longitude=string.Empty;
					}
					if (Null.IsNotNull(dr["Description"]))
					{
						river.Description= Convert.ToString(dr["Description"]);
					}
					else
					{
						river.Description=string.Empty;
					}
					if (Null.IsNotNull(dr["Status"]))
					{
						river.Status= Convert.ToString(dr["Status"]);
					}
					else
					{
						river.Status=string.Empty;
					}
 
                }
            }
            return river ;
        }
		#endregion		
	}
}