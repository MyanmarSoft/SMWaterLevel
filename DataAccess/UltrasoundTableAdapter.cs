using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Whizzo;
using SMWaterLevel.Entities;
namespace SMWaterLevel.DataAccess
{

	public class UltrasoundTableAdapter : BaseDataAdapter
	{
		
		
		#region Constructers

			public UltrasoundTableAdapter():base()
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
			InsertCommand.CommandText = @"INSERT INTO Ultrasound(ItemName,ServiceFee,ReferFee,ReaderFee,TechFee,Total,CreateDate,Status) VALUES (@ItemName,@ServiceFee,@ReferFee,@ReaderFee,@TechFee,@Total,@CreateDate,@Status);SELECT ID FROM Ultrasound WHERE (ID = SCOPE_IDENTITY())";
						InsertCommand.Parameters.Add(new SqlParameter("@ItemName", SqlDbType.VarChar, 50,"ItemName"));
			InsertCommand.Parameters.Add(new SqlParameter("@ServiceFee", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "ServiceFee", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@ReferFee", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "ReferFee", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@ReaderFee", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "ReaderFee", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@TechFee", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "TechFee", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@Total", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "Total", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@CreateDate", SqlDbType.DateTime, 8,"CreateDate"));
			InsertCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitUpdateCommand()
		{
			UpdateCommand.CommandType = CommandType.Text;
            UpdateCommand.Connection = Connection;
			UpdateCommand.CommandText = @"UPDATE Ultrasound SET ItemName = @ItemName, ServiceFee = @ServiceFee, ReferFee = @ReferFee, ReaderFee = @ReaderFee, TechFee = @TechFee, Total = @Total, CreateDate = @CreateDate, Status = @Status WHERE (ID = @ID)";
						UpdateCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@ItemName", SqlDbType.VarChar, 50,"ItemName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@ServiceFee", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "ServiceFee", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@ReferFee", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "ReferFee", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@ReaderFee", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "ReaderFee", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@TechFee", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "TechFee", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@Total", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "Total", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@CreateDate", SqlDbType.DateTime, 8,"CreateDate"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitDeleteCommand()
		{
            DeleteCommand.CommandType = CommandType.Text;
			DeleteCommand.Connection = Connection;
			DeleteCommand.CommandText = "DELETE FROM Ultrasound WHERE (ID = @ID)";
			DeleteCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
		}

		

		protected  void InitCommandCollection()
		{
			CommandCollection = new IDbCommand[3];

			CommandCollection[0] = new SqlCommand();
			((SqlCommand) (CommandCollection[0])).Connection = Connection;
			((SqlCommand) (CommandCollection[0])).CommandText = "SELECT ID,ItemName,ServiceFee,ReferFee,ReaderFee,TechFee,Total,CreateDate,Status FROM Ultrasound";
			((SqlCommand) (CommandCollection[0])).CommandType = CommandType.Text;
			
			//Fill/GetByID
            CommandCollection[1] = new SqlCommand();
            ((SqlCommand)(CommandCollection[1])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[1])).CommandText = "SELECT ID,ItemName,ServiceFee,ReferFee,ReaderFee,TechFee,Total,CreateDate,Status FROM Ultrasound WHERE ID =  @ID";
            ((SqlCommand)(CommandCollection[1])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[1])).Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, "ID"));
			
			//Fill/GetByStatus
            CommandCollection[2] = new SqlCommand();
            ((SqlCommand)(CommandCollection[2])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[2])).CommandText = "SELECT ID,ItemName,ServiceFee,ReferFee,ReaderFee,TechFee,Total,CreateDate,Status FROM Ultrasound WHERE Status =  @Status";
            ((SqlCommand)(CommandCollection[2])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[2])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));
			
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

		public Ultrasound GetUltrasoundByID(int ID)
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
		
		public DataSet GetUltrasoundByStatus(string status)
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
		
		#endregion CustomGetTable
	    
		public int Insert(Ultrasound ultrasound)
		{
	InsertCommand.Parameters["@ItemName"].Value = ultrasound.ItemName;
	InsertCommand.Parameters["@ServiceFee"].Value = ultrasound.ServiceFee;
	InsertCommand.Parameters["@ReferFee"].Value = ultrasound.ReferFee;
	InsertCommand.Parameters["@ReaderFee"].Value = ultrasound.ReaderFee;
	InsertCommand.Parameters["@TechFee"].Value = ultrasound.TechFee;
	InsertCommand.Parameters["@Total"].Value = ultrasound.Total;
	InsertCommand.Parameters["@CreateDate"].Value = ultrasound.CreateDate;
	InsertCommand.Parameters["@Status"].Value = ultrasound.Status;
		
			
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
        
		public int Update(Ultrasound ultrasound)
		{
	UpdateCommand.Parameters["@ID"].Value = ultrasound.ID;
	UpdateCommand.Parameters["@ItemName"].Value = ultrasound.ItemName;
	UpdateCommand.Parameters["@ServiceFee"].Value = ultrasound.ServiceFee;
	UpdateCommand.Parameters["@ReferFee"].Value = ultrasound.ReferFee;
	UpdateCommand.Parameters["@ReaderFee"].Value = ultrasound.ReaderFee;
	UpdateCommand.Parameters["@TechFee"].Value = ultrasound.TechFee;
	UpdateCommand.Parameters["@Total"].Value = ultrasound.Total;
	UpdateCommand.Parameters["@CreateDate"].Value = ultrasound.CreateDate;
	UpdateCommand.Parameters["@Status"].Value = ultrasound.Status;

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
        
        private Ultrasound DataTableToEntity(DataTable dt)
        {
           
            Ultrasound ultrasound = new Ultrasound();
            if(Null.IsNotNull(dt)==true && dt.Rows.Count > 0)
            {
                
                if (Null.IsNotNull(dt.Rows[0]))
                {
                    DataRow dr = dt.Rows[0];
                      					if (Null.IsNotNull(dr["ID"]))
					{
						ultrasound.ID=Convert.ToInt32(dr["ID"]);
					}
					else
					{
						ultrasound.ID=0;
					}
					if (Null.IsNotNull(dr["ItemName"]))
					{
						ultrasound.ItemName= Convert.ToString(dr["ItemName"]);
					}
					else
					{
						ultrasound.ItemName=string.Empty;
					}
					if (Null.IsNotNull(dr["ServiceFee"]))
					{
						ultrasound.ServiceFee= Convert.ToDecimal(dr["ServiceFee"]);
					}
					else
					{
						ultrasound.ServiceFee=0.00m;
					}
					if (Null.IsNotNull(dr["ReferFee"]))
					{
						ultrasound.ReferFee= Convert.ToDecimal(dr["ReferFee"]);
					}
					else
					{
						ultrasound.ReferFee=0.00m;
					}
					if (Null.IsNotNull(dr["ReaderFee"]))
					{
						ultrasound.ReaderFee= Convert.ToDecimal(dr["ReaderFee"]);
					}
					else
					{
						ultrasound.ReaderFee=0.00m;
					}
					if (Null.IsNotNull(dr["TechFee"]))
					{
						ultrasound.TechFee= Convert.ToDecimal(dr["TechFee"]);
					}
					else
					{
						ultrasound.TechFee=0.00m;
					}
					if (Null.IsNotNull(dr["Total"]))
					{
						ultrasound.Total= Convert.ToDecimal(dr["Total"]);
					}
					else
					{
						ultrasound.Total=0.00m;
					}
					if (Null.IsNotNull(dr["CreateDate"]))
					{
						ultrasound.CreateDate= Convert.ToDateTime(dr["CreateDate"]);
					}
					else
					{
						ultrasound.CreateDate=DateTime.Now;
					}
					if (Null.IsNotNull(dr["Status"]))
					{
						ultrasound.Status= Convert.ToString(dr["Status"]);
					}
					else
					{
						ultrasound.Status=string.Empty;
					}
 
                }
            }
            return ultrasound ;
        }
		#endregion		
	}
}