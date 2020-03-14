using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Whizzo;
using SMWaterLevel.Entities;
namespace SMWaterLevel.DataAccess
{

	public class WaterLevelDamTableAdapter : BaseDataAdapter
	{
		
		
		#region Constructers

			public WaterLevelDamTableAdapter():base()
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
			InsertCommand.CommandText = @"INSERT INTO WaterLevelDam(DamID,DamName,LevelFeet,Remark,CreatedDate,CreatedTime,Status) VALUES (@DamID,@DamName,@LevelFeet,@Remark,@CreatedDate,@CreatedTime,@Status);SELECT ID FROM WaterLevelDam WHERE (ID = SCOPE_IDENTITY())";
			InsertCommand.Parameters.Add(new SqlParameter("@DamID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"DamID", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@DamName", SqlDbType.NVarChar, 50,"DamName"));
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
            UpdateCommand.CommandText = @"UPDATE WaterLevelDam SET DamID = @DamID, DamName = @DamName, LevelFeet = @LevelFeet, Remark = @Remark, CreatedDate = @CreatedDate, CreatedTime = @CreatedTime, Status = @Status WHERE (ID = @ID)";
						UpdateCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@DamID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"DamID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@DamName", SqlDbType.NVarChar, 50,"DamName"));
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
			DeleteCommand.CommandText = "DELETE FROM WaterLevelDam WHERE (ID = @ID)";
			DeleteCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
		}

		

		protected  void InitCommandCollection()
		{
			CommandCollection = new IDbCommand[4];

			CommandCollection[0] = new SqlCommand();
			((SqlCommand) (CommandCollection[0])).Connection = Connection;
            ((SqlCommand)(CommandCollection[0])).CommandText = "SELECT ID,DamID,DamName,LevelFeet,Remark,CreatedDate,CreatedTime,Status FROM WaterLevelDam";
			((SqlCommand) (CommandCollection[0])).CommandType = CommandType.Text;
			
			//Fill/GetByID
            CommandCollection[1] = new SqlCommand();
            ((SqlCommand)(CommandCollection[1])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[1])).CommandText = "SELECT ID,DamID,DamName,LevelFeet,Remark,CreatedDate,CreatedTime,Status FROM WaterLevelDam WHERE ID =  @ID";
            ((SqlCommand)(CommandCollection[1])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[1])).Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, "ID"));
			
			//Fill/GetByStatus
            CommandCollection[2] = new SqlCommand();
            ((SqlCommand)(CommandCollection[2])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[2])).CommandText = "SELECT ID,DamID,DamName,LevelFeet,Remark,CreatedDate,CreatedTime,Status FROM WaterLevelDam WHERE Status =  @Status ORDER BY ID DESC";
            ((SqlCommand)(CommandCollection[2])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[2])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));
			
			#region CustomCommand

            //GetSearchByWaterLevel
            CommandCollection[3] = new SqlCommand();
            ((SqlCommand)(CommandCollection[3])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[3])).CommandText = "SELECT ID,DamID,DamName,LevelFeet,Remark,CreatedDate,CreatedTime,Status FROM WaterLevelDam WHERE DamName LIKE '%' + @DamName + '%' AND Status =  @Status OR LevelFeet LIKE '%' + @LevelFeet + '%' AND Status =  @Status OR Remark LIKE '%' + @Remark + '%' AND Status =  @Status OR CreatedDate = @CreatedDate AND Status =  @Status OR CreatedTime = @CreatedTime AND Status =  @Status  ORDER BY ID DESC";
            ((SqlCommand)(CommandCollection[3])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@DamName", SqlDbType.NVarChar, 50, "DamName"));
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@LevelFeet", SqlDbType.NVarChar, 50, "LevelFeet"));
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@Remark", SqlDbType.NVarChar, 200, "Remark"));
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@CreatedDate", SqlDbType.DateTime, 8, "CreatedDate"));
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@CreatedTime", SqlDbType.NVarChar, 50, "CreatedTime"));
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

		public WaterLevelDam GetWaterLevelByID(int ID)
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




        public DataSet GetSearchByWaterLevel(string damName, string waterLevel, string remark, DateTime createdDate, string createdTime, string status)
        {
            DataSet ds = new DataSet();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[3]));
            Adapter.SelectCommand.Parameters[0].Value = damName;
            Adapter.SelectCommand.Parameters[1].Value = waterLevel;
            Adapter.SelectCommand.Parameters[2].Value = remark;
            Adapter.SelectCommand.Parameters[3].Value = createdDate;
            Adapter.SelectCommand.Parameters[4].Value = createdTime;
            Adapter.SelectCommand.Parameters[5].Value = status;


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
	    
		public int Insert(WaterLevelDam waterLeveldam)
		{
            InsertCommand.Parameters["@DamID"].Value = waterLeveldam.DamID;
            InsertCommand.Parameters["@DamName"].Value = waterLeveldam.DamName;
            InsertCommand.Parameters["@LevelFeet"].Value = waterLeveldam.LevelFeet;
            InsertCommand.Parameters["@Remark"].Value = waterLeveldam.Remark;
            InsertCommand.Parameters["@CreatedDate"].Value = waterLeveldam.CreatedDate;
            InsertCommand.Parameters["@CreatedTime"].Value = waterLeveldam.CreatedTime;
            InsertCommand.Parameters["@Status"].Value = waterLeveldam.Status;
		
			
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
        
		public int Update(WaterLevelDam waterLeveldam)
		{
            UpdateCommand.Parameters["@ID"].Value = waterLeveldam.ID;
            UpdateCommand.Parameters["@DamID"].Value = waterLeveldam.DamID;
            UpdateCommand.Parameters["@DamName"].Value = waterLeveldam.DamName;
            UpdateCommand.Parameters["@LevelFeet"].Value = waterLeveldam.LevelFeet;
            UpdateCommand.Parameters["@Remark"].Value = waterLeveldam.Remark;
            UpdateCommand.Parameters["@CreatedDate"].Value = waterLeveldam.CreatedDate;
            UpdateCommand.Parameters["@CreatedTime"].Value = waterLeveldam.CreatedTime;
            UpdateCommand.Parameters["@Status"].Value = waterLeveldam.Status;

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
        
        private WaterLevelDam DataTableToEntity(DataTable dt)
        {
           
            WaterLevelDam waterLeveldam = new WaterLevelDam();
            if(Null.IsNotNull(dt)==true && dt.Rows.Count > 0)
            {
                
                if (Null.IsNotNull(dt.Rows[0]))
                {
                    DataRow dr = dt.Rows[0];
                      					if (Null.IsNotNull(dr["ID"]))
					{
						waterLeveldam.ID=Convert.ToInt32(dr["ID"]);
					}
					else
					{
                        waterLeveldam.ID = 0;
					}
					if (Null.IsNotNull(dr["DamID"]))
					{
                        waterLeveldam.DamID = Convert.ToInt32(dr["DamID"]);
					}
					else
					{
                        waterLeveldam.DamID = 0;
					}
					if (Null.IsNotNull(dr["DamName"]))
					{
                        waterLeveldam.DamName = Convert.ToString(dr["DamName"]);
					}
					else
					{
                        waterLeveldam.DamName = string.Empty;
					}
					if (Null.IsNotNull(dr["LevelFeet"]))
					{
                        waterLeveldam.LevelFeet = Convert.ToString(dr["LevelFeet"]);
					}
					else
					{
                        waterLeveldam.LevelFeet = string.Empty;
					}
					if (Null.IsNotNull(dr["Remark"]))
					{
                        waterLeveldam.Remark = Convert.ToString(dr["Remark"]);
					}
					else
					{
                        waterLeveldam.Remark = string.Empty;
					}
					if (Null.IsNotNull(dr["CreatedDate"]))
					{
                        waterLeveldam.CreatedDate = Convert.ToDateTime(dr["CreatedDate"]);
					}
					else
					{
                        waterLeveldam.CreatedDate = DateTime.Now;
					}
					if (Null.IsNotNull(dr["CreatedTime"]))
					{
                        waterLeveldam.CreatedTime = Convert.ToString(dr["CreatedTime"]);
					}
					else
					{
                        waterLeveldam.CreatedTime = string.Empty;
					}
					if (Null.IsNotNull(dr["Status"]))
					{
                        waterLeveldam.Status = Convert.ToString(dr["Status"]);
					}
					else
					{
                        waterLeveldam.Status = string.Empty;
					}
 
                }
            }
            return waterLeveldam;
        }
		#endregion		
	}
}