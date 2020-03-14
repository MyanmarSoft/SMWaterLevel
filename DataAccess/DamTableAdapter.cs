using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Whizzo;
using SMWaterLevel.Entities;
namespace SMWaterLevel.DataAccess
{

	public class DamTableAdapter : BaseDataAdapter
	{
		
		
		#region Constructers

			public DamTableAdapter():base()
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
			InsertCommand.CommandText = @"INSERT INTO Dam(DamID,DamName,Latitude,Longitude,Description,Status) VALUES (@DamID,@DamName,@Latitude,@Longitude,@Description,@Status);SELECT ID FROM Dam WHERE (ID = SCOPE_IDENTITY())";
						InsertCommand.Parameters.Add(new SqlParameter("@DamID", SqlDbType.VarChar, 50,"DamID"));
			InsertCommand.Parameters.Add(new SqlParameter("@DamName", SqlDbType.NVarChar, 50,"DamName"));
			InsertCommand.Parameters.Add(new SqlParameter("@Latitude", SqlDbType.VarChar, 50,"Latitude"));
			InsertCommand.Parameters.Add(new SqlParameter("@Longitude", SqlDbType.VarChar, 50,"Longitude"));
			InsertCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 200,"Description"));
			InsertCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitUpdateCommand()
		{
			UpdateCommand.CommandType = CommandType.Text;
            UpdateCommand.Connection = Connection;
			UpdateCommand.CommandText = @"UPDATE Dam SET DamID = @DamID, DamName = @DamName, Latitude = @Latitude, Longitude = @Longitude, Description = @Description, Status = @Status WHERE (ID = @ID)";
						UpdateCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@DamID", SqlDbType.VarChar, 50,"DamID"));
			UpdateCommand.Parameters.Add(new SqlParameter("@DamName", SqlDbType.NVarChar, 50,"DamName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Latitude", SqlDbType.VarChar, 50,"Latitude"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Longitude", SqlDbType.VarChar, 50,"Longitude"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 200,"Description"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitDeleteCommand()
		{
            DeleteCommand.CommandType = CommandType.Text;
			DeleteCommand.Connection = Connection;
			DeleteCommand.CommandText = "DELETE FROM Dam WHERE (ID = @ID)";
			DeleteCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
		}

		

		protected  void InitCommandCollection()
		{
			CommandCollection = new IDbCommand[4];

			CommandCollection[0] = new SqlCommand();
			((SqlCommand) (CommandCollection[0])).Connection = Connection;
			((SqlCommand) (CommandCollection[0])).CommandText = "SELECT ID,DamID,DamName,Latitude,Longitude,Description,Status FROM Dam";
			((SqlCommand) (CommandCollection[0])).CommandType = CommandType.Text;
			
			//Fill/GetByID
            CommandCollection[1] = new SqlCommand();
            ((SqlCommand)(CommandCollection[1])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[1])).CommandText = "SELECT ID,DamID,DamName,Latitude,Longitude,Description,Status FROM Dam WHERE ID =  @ID";
            ((SqlCommand)(CommandCollection[1])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[1])).Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, "ID"));
			
			//Fill/GetByStatus
            CommandCollection[2] = new SqlCommand();
            ((SqlCommand)(CommandCollection[2])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[2])).CommandText = "SELECT ID,DamID,DamName,Latitude,Longitude,Description,Status FROM Dam WHERE Status =  @Status";
            ((SqlCommand)(CommandCollection[2])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[2])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));

            //GetSearchByDam
            CommandCollection[3] = new SqlCommand();
            ((SqlCommand)(CommandCollection[3])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[3])).CommandText = "SELECT ID,DamID,DamName,Latitude,Longitude,Description,Status FROM Dam WHERE DamName LIKE '%'+ @DamName + '%' AND Status =  @Status";
            ((SqlCommand)(CommandCollection[3])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@DamName", SqlDbType.NVarChar, 50, "DamName"));
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));
			#region CustomCommand
			
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

		public Dam GetDamByID(int ID)
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
		
		public DataSet GetDamByStatus(string status)
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

        public DataSet GetSearchByDam(string damName, string status)
        {
            DataSet ds = new DataSet();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[3]));
            Adapter.SelectCommand.Parameters[0].Value = damName;
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
		#region CustomGetTable
		
		#endregion CustomGetTable
	    
		public int Insert(Dam dam)
		{
	InsertCommand.Parameters["@DamID"].Value = dam.DamID;
	InsertCommand.Parameters["@DamName"].Value = dam.DamName;
	InsertCommand.Parameters["@Latitude"].Value = dam.Latitude;
	InsertCommand.Parameters["@Longitude"].Value = dam.Longitude;
	InsertCommand.Parameters["@Description"].Value = dam.Description;
	InsertCommand.Parameters["@Status"].Value = dam.Status;
		
			
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
        
		public int Update(Dam dam)
		{
	UpdateCommand.Parameters["@ID"].Value = dam.ID;
	UpdateCommand.Parameters["@DamID"].Value = dam.DamID;
	UpdateCommand.Parameters["@DamName"].Value = dam.DamName;
	UpdateCommand.Parameters["@Latitude"].Value = dam.Latitude;
	UpdateCommand.Parameters["@Longitude"].Value = dam.Longitude;
	UpdateCommand.Parameters["@Description"].Value = dam.Description;
	UpdateCommand.Parameters["@Status"].Value = dam.Status;

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
        
        private Dam DataTableToEntity(DataTable dt)
        {
           
            Dam dam = new Dam();
            if(Null.IsNotNull(dt)==true && dt.Rows.Count > 0)
            {
                
                if (Null.IsNotNull(dt.Rows[0]))
                {
                    DataRow dr = dt.Rows[0];
                      					if (Null.IsNotNull(dr["ID"]))
					{
						dam.ID=Convert.ToInt32(dr["ID"]);
					}
					else
					{
						dam.ID=0;
					}
					if (Null.IsNotNull(dr["DamID"]))
					{
						dam.DamID= Convert.ToString(dr["DamID"]);
					}
					else
					{
						dam.DamID=string.Empty;
					}
					if (Null.IsNotNull(dr["DamName"]))
					{
						dam.DamName= Convert.ToString(dr["DamName"]);
					}
					else
					{
						dam.DamName=string.Empty;
					}
					if (Null.IsNotNull(dr["Latitude"]))
					{
						dam.Latitude= Convert.ToString(dr["Latitude"]);
					}
					else
					{
						dam.Latitude=string.Empty;
					}
					if (Null.IsNotNull(dr["Longitude"]))
					{
						dam.Longitude= Convert.ToString(dr["Longitude"]);
					}
					else
					{
						dam.Longitude=string.Empty;
					}
					if (Null.IsNotNull(dr["Description"]))
					{
						dam.Description= Convert.ToString(dr["Description"]);
					}
					else
					{
						dam.Description=string.Empty;
					}
					if (Null.IsNotNull(dr["Status"]))
					{
						dam.Status= Convert.ToString(dr["Status"]);
					}
					else
					{
						dam.Status=string.Empty;
					}
 
                }
            }
            return dam ;
        }
		#endregion		
	}
}