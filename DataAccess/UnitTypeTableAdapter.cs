using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Whizzo;
using SMWaterLevel.Entities;
namespace SMWaterLevel.DataAccess
{

	public class UnitTypeTableAdapter : BaseDataAdapter
	{
		
		
		#region Constructers

			public UnitTypeTableAdapter():base()
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
			InsertCommand.CommandText = @"INSERT INTO UnitType(UnitTypeName,ShortUnitTypeName,Status) VALUES (@UnitTypeName,@ShortUnitTypeName,@Status);SELECT ID FROM UnitType WHERE (ID = SCOPE_IDENTITY())";
						InsertCommand.Parameters.Add(new SqlParameter("@UnitTypeName", SqlDbType.VarChar, 50,"UnitTypeName"));
			InsertCommand.Parameters.Add(new SqlParameter("@ShortUnitTypeName", SqlDbType.VarChar, 50,"ShortUnitTypeName"));
			InsertCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitUpdateCommand()
		{
			UpdateCommand.CommandType = CommandType.Text;
            UpdateCommand.Connection = Connection;
			UpdateCommand.CommandText = @"UPDATE UnitType SET UnitTypeName = @UnitTypeName, ShortUnitTypeName = @ShortUnitTypeName, Status = @Status WHERE (ID = @ID)";
						UpdateCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@UnitTypeName", SqlDbType.VarChar, 50,"UnitTypeName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@ShortUnitTypeName", SqlDbType.VarChar, 50,"ShortUnitTypeName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitDeleteCommand()
		{
            DeleteCommand.CommandType = CommandType.Text;
			DeleteCommand.Connection = Connection;
			DeleteCommand.CommandText = "DELETE FROM UnitType WHERE (ID = @ID)";
			DeleteCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
		}

		

		protected  void InitCommandCollection()
		{
			CommandCollection = new IDbCommand[5];

			CommandCollection[0] = new SqlCommand();
			((SqlCommand) (CommandCollection[0])).Connection = Connection;
			((SqlCommand) (CommandCollection[0])).CommandText = "SELECT ID,UnitTypeName,ShortUnitTypeName,Status FROM UnitType";
			((SqlCommand) (CommandCollection[0])).CommandType = CommandType.Text;
			
			//Fill/GetByID
            CommandCollection[1] = new SqlCommand();
            ((SqlCommand)(CommandCollection[1])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[1])).CommandText = "SELECT ID,UnitTypeName,ShortUnitTypeName,Status FROM UnitType WHERE ID =  @ID";
            ((SqlCommand)(CommandCollection[1])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[1])).Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, "ID"));
			
			//Fill/GetByStatus
            CommandCollection[2] = new SqlCommand();
            ((SqlCommand)(CommandCollection[2])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[2])).CommandText = "SELECT ID,UnitTypeName,ShortUnitTypeName,Status FROM UnitType WHERE Status =  @Status";
            ((SqlCommand)(CommandCollection[2])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[2])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));
			
			#region CustomCommand
            //GetDataByInventoryItemUnitTypeID
            CommandCollection[3] = new SqlCommand();
            ((SqlCommand)(CommandCollection[3])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[3])).CommandText = "SELECT * FROM UnitType WHERE ID = @BaseUnitTypeID OR ID = @MediumUnitTypeID OR ID = @SmallestUnitTypeID";
            ((SqlCommand)(CommandCollection[3])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@BaseUnitTypeID", SqlDbType.Int, 4, "ID"));
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@MediumUnitTypeID", SqlDbType.Int, 4, "ID"));
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@SmallestUnitTypeID", SqlDbType.Int, 4, "ID"));


            //GetUnitTypeByShortUnitTypeName
            CommandCollection[4] = new SqlCommand();
            ((SqlCommand)(CommandCollection[4])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[4])).CommandText = "SELECT ID,UnitTypeName,ShortUnitTypeName,Status FROM UnitType WHERE ShortUnitTypeName =  @ShortUnitTypeName";
            ((SqlCommand)(CommandCollection[4])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[4])).Parameters.Add(new SqlParameter("@ShortUnitTypeName", SqlDbType.VarChar, 50, "ShortUnitTypeName"));
			
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

		public UnitType_ GetUnitTypeByID(int ID)
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
		
		public DataSet GetUnitTypeByStatus(string status)
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
        public DataTable GetDataByInventoryItemUnitTypeID(int baseunitTypeID, int mediumUnitTypeID, int smallestUnitTypeID)
        {

            DataTable dt = new DataTable();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[3]));
            Adapter.SelectCommand.Parameters["@BaseUnitTypeID"].Value = baseunitTypeID;
            Adapter.SelectCommand.Parameters["@MediumUnitTypeID"].Value = mediumUnitTypeID;
            Adapter.SelectCommand.Parameters["@SmallestUnitTypeID"].Value = smallestUnitTypeID;

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

        public UnitType_ GetUnitTypeByShortUnitTypeName(string shortunitTypeName)
        {

            DataTable dt = new DataTable();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[4]));
            Adapter.SelectCommand.Parameters[0].Value = shortunitTypeName;

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
	    
		public int Insert(UnitType_ unitType)
		{
	InsertCommand.Parameters["@UnitTypeName"].Value = unitType.UnitTypeName;
	InsertCommand.Parameters["@ShortUnitTypeName"].Value = unitType.ShortUnitTypeName;
	InsertCommand.Parameters["@Status"].Value = unitType.Status;
		
			
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
        
		public int Update(UnitType_ unitType)
		{
	UpdateCommand.Parameters["@ID"].Value = unitType.ID;
	UpdateCommand.Parameters["@UnitTypeName"].Value = unitType.UnitTypeName;
	UpdateCommand.Parameters["@ShortUnitTypeName"].Value = unitType.ShortUnitTypeName;
	UpdateCommand.Parameters["@Status"].Value = unitType.Status;

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
        
        private UnitType_ DataTableToEntity(DataTable dt)
        {
           
            UnitType_ unitType = new UnitType_();
            if(Null.IsNotNull(dt)==true && dt.Rows.Count > 0)
            {
                
                if (Null.IsNotNull(dt.Rows[0]))
                {
                    DataRow dr = dt.Rows[0];
                      					if (Null.IsNotNull(dr["ID"]))
					{
						unitType.ID=Convert.ToInt32(dr["ID"]);
					}
					else
					{
						unitType.ID=0;
					}
					if (Null.IsNotNull(dr["UnitTypeName"]))
					{
						unitType.UnitTypeName= Convert.ToString(dr["UnitTypeName"]);
					}
					else
					{
						unitType.UnitTypeName=string.Empty;
					}
					if (Null.IsNotNull(dr["ShortUnitTypeName"]))
					{
						unitType.ShortUnitTypeName= Convert.ToString(dr["ShortUnitTypeName"]);
					}
					else
					{
						unitType.ShortUnitTypeName=string.Empty;
					}
					if (Null.IsNotNull(dr["Status"]))
					{
						unitType.Status= Convert.ToString(dr["Status"]);
					}
					else
					{
						unitType.Status=string.Empty;
					}
 
                }
            }
            return unitType ;
        }
		#endregion		
	}
}