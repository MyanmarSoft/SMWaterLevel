﻿using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Whizzo;
using SMWaterLevel.Entities;
namespace SMWaterLevel.DataAccess
{

	public class MedicalCheckupTableAdapter : BaseDataAdapter
	{
		
		
		#region Constructers

			public MedicalCheckupTableAdapter():base()
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
			InsertCommand.CommandText = @"INSERT INTO MedicalCheckup(ItemName,CompanyID,MMK,USD,CheckList,Status) VALUES (@ItemName,@CompanyID,@MMK,@USD,@CheckList,@Status);SELECT ID FROM MedicalCheckup WHERE (ID = SCOPE_IDENTITY())";
						InsertCommand.Parameters.Add(new SqlParameter("@ItemName", SqlDbType.NVarChar, 255,"ItemName"));
			InsertCommand.Parameters.Add(new SqlParameter("@CompanyID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"CompanyID", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@MMK", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "MMK", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@USD", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "USD", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@CheckList", SqlDbType.VarChar, 200,"CheckList"));
			InsertCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitUpdateCommand()
		{
			UpdateCommand.CommandType = CommandType.Text;
            UpdateCommand.Connection = Connection;
			UpdateCommand.CommandText = @"UPDATE MedicalCheckup SET ItemName = @ItemName, CompanyID = @CompanyID, MMK = @MMK, USD = @USD, CheckList = @CheckList, Status = @Status WHERE (ID = @ID)";
						UpdateCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@ItemName", SqlDbType.NVarChar, 255,"ItemName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@CompanyID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"CompanyID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@MMK", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "MMK", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@USD", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "USD", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@CheckList", SqlDbType.VarChar, 200,"CheckList"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitDeleteCommand()
		{
            DeleteCommand.CommandType = CommandType.Text;
			DeleteCommand.Connection = Connection;
			DeleteCommand.CommandText = "DELETE FROM MedicalCheckup WHERE (ID = @ID)";
			DeleteCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
		}

		

		protected  void InitCommandCollection()
		{
			CommandCollection = new IDbCommand[5];

			CommandCollection[0] = new SqlCommand();
			((SqlCommand) (CommandCollection[0])).Connection = Connection;
			((SqlCommand) (CommandCollection[0])).CommandText = "SELECT ID,ItemName,CompanyID,MMK,USD,CheckList,Status FROM MedicalCheckup";
			((SqlCommand) (CommandCollection[0])).CommandType = CommandType.Text;
			
			//Fill/GetByID
            CommandCollection[1] = new SqlCommand();
            ((SqlCommand)(CommandCollection[1])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[1])).CommandText = "SELECT ID,ItemName,CompanyID,MMK,USD,CheckList,Status FROM MedicalCheckup WHERE ID =  @ID";
            ((SqlCommand)(CommandCollection[1])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[1])).Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, "ID"));
			
			//Fill/GetByStatus
            CommandCollection[2] = new SqlCommand();
            ((SqlCommand)(CommandCollection[2])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[2])).CommandText = "SELECT ID,ItemName,CompanyID,MMK,USD,CheckList,Status FROM MedicalCheckup WHERE Status =  @Status ORDER BY ItemName ASC";
            ((SqlCommand)(CommandCollection[2])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[2])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));
			
			#region CustomCommand
			
			
            //Fill/GetItemTypeNameByStatus
            CommandCollection[3] = new SqlCommand();
            ((SqlCommand)(CommandCollection[3])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[3])).CommandText = "SELECT MedicalCheckup.ID, MedicalCheckup.ItemName,MedicalCheckup.CompanyID,CompanyName,MedicalCheckup.MMK,MedicalCheckup.USD,MedicalCheckup.CheckList,MedicalCheckup.Status FROM MedicalCheckup,Company WHERE  MedicalCheckup.CompanyID = Company.ID AND MedicalCheckup.Status =  @Status ORDER BY ItemName ASC";
            ((SqlCommand)(CommandCollection[3])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));

            //Fill/GetDataByItemName
            CommandCollection[4] = new SqlCommand();
            ((SqlCommand)(CommandCollection[4])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[4])).CommandText = "SELECT MedicalCheckup.ID,MedicalCheckup.ItemName,MedicalCheckup.CompanyID,CompanyName,MedicalCheckup.MMK,MedicalCheckup.USD,MedicalCheckup.CheckList,MedicalCheckup.Status FROM MedicalCheckup,Company WHERE MedicalCheckup.CompanyID = Company.ID AND MedicalCheckup.ItemName LIKE '%'+ @ItemName +'%' AND  MedicalCheckup.Status =  @Status ORDER BY ItemName ASC";
            ((SqlCommand)(CommandCollection[4])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[4])).Parameters.Add(new SqlParameter("@ItemName", SqlDbType.VarChar, 100, "ItemName"));
            ((SqlCommand)(this.CommandCollection[4])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));
			
			
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

		public MedicalCheckup GetMedicalCheckupByID(int ID)
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
		
		public DataSet GetMedicalCheckupByStatus(string status)
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
		
		
		
        public DataTable GetItemTypeNameByStatus(string status)
        {

            DataTable dt = new DataTable();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[3]));
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


        public DataTable GetDataByItemName(string itemName, string status)
        {

            DataTable dt = new DataTable();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[4]));
            Adapter.SelectCommand.Parameters[0].Value = itemName;
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
		
		
		#endregion CustomGetTable
	    
		public int Insert(MedicalCheckup medicalCheckup)
		{
	InsertCommand.Parameters["@ItemName"].Value = medicalCheckup.ItemName;
	InsertCommand.Parameters["@CompanyID"].Value = medicalCheckup.CompanyID;
	InsertCommand.Parameters["@MMK"].Value = medicalCheckup.MMK;
	InsertCommand.Parameters["@USD"].Value = medicalCheckup.USD;
	InsertCommand.Parameters["@CheckList"].Value = medicalCheckup.CheckList;
	InsertCommand.Parameters["@Status"].Value = medicalCheckup.Status;
		
			
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
        
		public int Update(MedicalCheckup medicalCheckup)
		{
	UpdateCommand.Parameters["@ID"].Value = medicalCheckup.ID;
	UpdateCommand.Parameters["@ItemName"].Value = medicalCheckup.ItemName;
	UpdateCommand.Parameters["@CompanyID"].Value = medicalCheckup.CompanyID;
	UpdateCommand.Parameters["@MMK"].Value = medicalCheckup.MMK;
	UpdateCommand.Parameters["@USD"].Value = medicalCheckup.USD;
	UpdateCommand.Parameters["@CheckList"].Value = medicalCheckup.CheckList;
	UpdateCommand.Parameters["@Status"].Value = medicalCheckup.Status;

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
        
        private MedicalCheckup DataTableToEntity(DataTable dt)
        {
           
            MedicalCheckup medicalCheckup = new MedicalCheckup();
            if(Null.IsNotNull(dt)==true && dt.Rows.Count > 0)
            {
                
                if (Null.IsNotNull(dt.Rows[0]))
                {
                    DataRow dr = dt.Rows[0];
                      					if (Null.IsNotNull(dr["ID"]))
					{
						medicalCheckup.ID=Convert.ToInt32(dr["ID"]);
					}
					else
					{
						medicalCheckup.ID=0;
					}
					if (Null.IsNotNull(dr["ItemName"]))
					{
						medicalCheckup.ItemName= Convert.ToString(dr["ItemName"]);
					}
					else
					{
						medicalCheckup.ItemName=string.Empty;
					}
					if (Null.IsNotNull(dr["CompanyID"]))
					{
						medicalCheckup.CompanyID=Convert.ToInt32(dr["CompanyID"]);
					}
					else
					{
						medicalCheckup.CompanyID=0;
					}
					if (Null.IsNotNull(dr["MMK"]))
					{
						medicalCheckup.MMK= Convert.ToDecimal(dr["MMK"]);
					}
					else
					{
						medicalCheckup.MMK=0.00m;
					}
					if (Null.IsNotNull(dr["USD"]))
					{
						medicalCheckup.USD= Convert.ToDecimal(dr["USD"]);
					}
					else
					{
						medicalCheckup.USD=0.00m;
					}
					if (Null.IsNotNull(dr["CheckList"]))
					{
						medicalCheckup.CheckList= Convert.ToString(dr["CheckList"]);
					}
					else
					{
						medicalCheckup.CheckList=string.Empty;
					}
					if (Null.IsNotNull(dr["Status"]))
					{
						medicalCheckup.Status= Convert.ToString(dr["Status"]);
					}
					else
					{
						medicalCheckup.Status=string.Empty;
					}
 
                }
            }
            return medicalCheckup ;
        }
		#endregion		
	}
}