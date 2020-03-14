using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Whizzo;
using SMWaterLevel.Entities;
namespace SMWaterLevel.DataAccess
{

	public class WaterLevelTableAdapter : BaseDataAdapter
	{
		
		
		#region Constructers

			public WaterLevelTableAdapter():base()
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
			InsertCommand.CommandText = @"INSERT INTO WaterLevel(RiverID,RiverName,LevelFeet,Remark,CreatedDate,CreatedTime,Status) VALUES (@RiverID,@RiverName,@LevelFeet,@Remark,@CreatedDate,@CreatedTime,@Status);SELECT ID FROM WaterLevel WHERE (ID = SCOPE_IDENTITY())";
						InsertCommand.Parameters.Add(new SqlParameter("@RiverID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"RiverID", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@RiverName", SqlDbType.NVarChar, 50,"RiverName"));
			InsertCommand.Parameters.Add(new SqlParameter("@LevelFeet", SqlDbType.NVarChar, 50,"LevelFeet"));
			InsertCommand.Parameters.Add(new SqlParameter("@Remark", SqlDbType.NVarChar, 200,"Remark"));
			InsertCommand.Parameters.Add(new SqlParameter("@CreatedDate", SqlDbType.DateTime, 8,"CreatedDate"));
			InsertCommand.Parameters.Add(new SqlParameter("@CreatedTime", SqlDbType.NVarChar, 50,"CreatedTime"));
			InsertCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitUpdateCommand()
		{
			UpdateCommand.CommandType = CommandType.Text;
            UpdateCommand.Connection = Connection;
			UpdateCommand.CommandText = @"UPDATE WaterLevel SET RiverID = @RiverID, RiverName = @RiverName, LevelFeet = @LevelFeet, Remark = @Remark, CreatedDate = @CreatedDate, CreatedTime = @CreatedTime, Status = @Status WHERE (ID = @ID)";
						UpdateCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@RiverID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"RiverID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@RiverName", SqlDbType.NVarChar, 50,"RiverName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@LevelFeet", SqlDbType.NVarChar, 50,"LevelFeet"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Remark", SqlDbType.NVarChar, 200,"Remark"));
			UpdateCommand.Parameters.Add(new SqlParameter("@CreatedDate", SqlDbType.DateTime, 8,"CreatedDate"));
			UpdateCommand.Parameters.Add(new SqlParameter("@CreatedTime", SqlDbType.NVarChar, 50,"CreatedTime"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitDeleteCommand()
		{
            DeleteCommand.CommandType = CommandType.Text;
			DeleteCommand.Connection = Connection;
			DeleteCommand.CommandText = "DELETE FROM WaterLevel WHERE (ID = @ID)";
			DeleteCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
		}

		

		protected  void InitCommandCollection()
		{
			CommandCollection = new IDbCommand[4];

			CommandCollection[0] = new SqlCommand();
			((SqlCommand) (CommandCollection[0])).Connection = Connection;
			((SqlCommand) (CommandCollection[0])).CommandText = "SELECT ID,RiverID,RiverName,LevelFeet,Remark,CreatedDate,CreatedTime,Status FROM WaterLevel";
			((SqlCommand) (CommandCollection[0])).CommandType = CommandType.Text;
			
			//Fill/GetByID
            CommandCollection[1] = new SqlCommand();
            ((SqlCommand)(CommandCollection[1])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[1])).CommandText = "SELECT ID,RiverID,RiverName,LevelFeet,Remark,CreatedDate,CreatedTime,Status FROM WaterLevel WHERE ID =  @ID";
            ((SqlCommand)(CommandCollection[1])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[1])).Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, "ID"));
			
			//Fill/GetByStatus
            CommandCollection[2] = new SqlCommand();
            ((SqlCommand)(CommandCollection[2])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[2])).CommandText = "SELECT ID,RiverID,RiverName,LevelFeet,Remark,CreatedDate,CreatedTime,Status FROM WaterLevel WHERE Status =  @Status ORDER BY ID DESC";
            ((SqlCommand)(CommandCollection[2])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[2])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));
			
			#region CustomCommand

            //GetSearchByWaterLevel
            CommandCollection[3] = new SqlCommand();
            ((SqlCommand)(CommandCollection[3])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[3])).CommandText = "SELECT ID,RiverID,RiverName,LevelFeet,Remark,CreatedDate,CreatedTime,Status FROM WaterLevel WHERE RiverName LIKE '%' + @RiverName + '%' AND Status =  @Status OR LevelFeet LIKE '%' + @LevelFeet + '%' AND Status =  @Status OR Remark LIKE '%' + @Remark + '%' AND Status =  @Status ORDER BY ID DESC";
            ((SqlCommand)(CommandCollection[3])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@RiverName", SqlDbType.NVarChar, 50, "RiverName"));
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@LevelFeet", SqlDbType.NVarChar, 50, "LevelFeet"));
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@Remark", SqlDbType.NVarChar, 200, "Remark"));
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

		public WaterLevel GetWaterLevelByID(int ID)
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
		
		public DataSet GetWaterLevelByStatus(string status)
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
		
		
		
		
        public DataSet GetSearchByWaterLevel(string riverName, string waterLevel, string remark, string status)
        {
            DataSet ds = new DataSet();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[3]));
            Adapter.SelectCommand.Parameters[0].Value = riverName;
            Adapter.SelectCommand.Parameters[1].Value = waterLevel;
            Adapter.SelectCommand.Parameters[2].Value = remark;
            Adapter.SelectCommand.Parameters[3].Value = status;


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
		
		
		
		
		
		
		
		
		#endregion CustomGetTable
	    
		public int Insert(WaterLevel waterLevel)
		{
	InsertCommand.Parameters["@RiverID"].Value = waterLevel.RiverID;
	InsertCommand.Parameters["@RiverName"].Value = waterLevel.RiverName;
	InsertCommand.Parameters["@LevelFeet"].Value = waterLevel.LevelFeet;
	InsertCommand.Parameters["@Remark"].Value = waterLevel.Remark;
	InsertCommand.Parameters["@CreatedDate"].Value = waterLevel.CreatedDate;
	InsertCommand.Parameters["@CreatedTime"].Value = waterLevel.CreatedTime;
	InsertCommand.Parameters["@Status"].Value = waterLevel.Status;
		
			
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
        
		public int Update(WaterLevel waterLevel)
		{
	UpdateCommand.Parameters["@ID"].Value = waterLevel.ID;
	UpdateCommand.Parameters["@RiverID"].Value = waterLevel.RiverID;
	UpdateCommand.Parameters["@RiverName"].Value = waterLevel.RiverName;
	UpdateCommand.Parameters["@LevelFeet"].Value = waterLevel.LevelFeet;
	UpdateCommand.Parameters["@Remark"].Value = waterLevel.Remark;
	UpdateCommand.Parameters["@CreatedDate"].Value = waterLevel.CreatedDate;
	UpdateCommand.Parameters["@CreatedTime"].Value = waterLevel.CreatedTime;
	UpdateCommand.Parameters["@Status"].Value = waterLevel.Status;

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
        
        private WaterLevel DataTableToEntity(DataTable dt)
        {
           
            WaterLevel waterLevel = new WaterLevel();
            if(Null.IsNotNull(dt)==true && dt.Rows.Count > 0)
            {
                
                if (Null.IsNotNull(dt.Rows[0]))
                {
                    DataRow dr = dt.Rows[0];
                      					if (Null.IsNotNull(dr["ID"]))
					{
						waterLevel.ID=Convert.ToInt32(dr["ID"]);
					}
					else
					{
						waterLevel.ID=0;
					}
					if (Null.IsNotNull(dr["RiverID"]))
					{
						waterLevel.RiverID=Convert.ToInt32(dr["RiverID"]);
					}
					else
					{
						waterLevel.RiverID=0;
					}
					if (Null.IsNotNull(dr["RiverName"]))
					{
						waterLevel.RiverName= Convert.ToString(dr["RiverName"]);
					}
					else
					{
						waterLevel.RiverName=string.Empty;
					}
					if (Null.IsNotNull(dr["LevelFeet"]))
					{
						waterLevel.LevelFeet= Convert.ToString(dr["LevelFeet"]);
					}
					else
					{
						waterLevel.LevelFeet=string.Empty;
					}
					if (Null.IsNotNull(dr["Remark"]))
					{
						waterLevel.Remark= Convert.ToString(dr["Remark"]);
					}
					else
					{
						waterLevel.Remark=string.Empty;
					}
					if (Null.IsNotNull(dr["CreatedDate"]))
					{
						waterLevel.CreatedDate= Convert.ToDateTime(dr["CreatedDate"]);
					}
					else
					{
						waterLevel.CreatedDate=DateTime.Now;
					}
					if (Null.IsNotNull(dr["CreatedTime"]))
					{
						waterLevel.CreatedTime= Convert.ToString(dr["CreatedTime"]);
					}
					else
					{
						waterLevel.CreatedTime=string.Empty;
					}
					if (Null.IsNotNull(dr["Status"]))
					{
						waterLevel.Status= Convert.ToString(dr["Status"]);
					}
					else
					{
						waterLevel.Status=string.Empty;
					}
 
                }
            }
            return waterLevel ;
        }
		#endregion		
	}
}