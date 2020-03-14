using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Whizzo;
using SMWaterLevel.Entities;
namespace SMWaterLevel.DataAccess
{

	public class ProjectSaleInvoiceTableAdapter : BaseDataAdapter
	{
		
		
		#region Constructers

			public ProjectSaleInvoiceTableAdapter():base()
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
			InsertCommand.CommandText = @"INSERT INTO ProjectSaleInvoice(ReferenceNo,ProjectID,ProjectName,CustomerName,Total,Discount,NetTotal,CreatedDate,Username,Status) VALUES (@ReferenceNo,@ProjectID,@ProjectName,@CustomerName,@Total,@Discount,@NetTotal,@CreatedDate,@Username,@Status);SELECT ID FROM ProjectSaleInvoice WHERE (ID = SCOPE_IDENTITY())";
						InsertCommand.Parameters.Add(new SqlParameter("@ReferenceNo", SqlDbType.VarChar, 50,"ReferenceNo"));
			InsertCommand.Parameters.Add(new SqlParameter("@ProjectID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"ProjectID", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@ProjectName", SqlDbType.NVarChar, 255,"ProjectName"));
			InsertCommand.Parameters.Add(new SqlParameter("@CustomerName", SqlDbType.VarChar, 50,"CustomerName"));
			InsertCommand.Parameters.Add(new SqlParameter("@Total", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "Total", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@Discount", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "Discount", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@NetTotal", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "NetTotal", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@CreatedDate", SqlDbType.DateTime, 8,"CreatedDate"));
			InsertCommand.Parameters.Add(new SqlParameter("@Username", SqlDbType.VarChar, 50,"Username"));
			InsertCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitUpdateCommand()
		{
			UpdateCommand.CommandType = CommandType.Text;
            UpdateCommand.Connection = Connection;
			UpdateCommand.CommandText = @"UPDATE ProjectSaleInvoice SET ReferenceNo = @ReferenceNo, ProjectID = @ProjectID, ProjectName = @ProjectName, CustomerName = @CustomerName, Total = @Total, Discount = @Discount, NetTotal = @NetTotal, CreatedDate = @CreatedDate, Username = @Username, Status = @Status WHERE (ID = @ID)";
						UpdateCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@ReferenceNo", SqlDbType.VarChar, 50,"ReferenceNo"));
			UpdateCommand.Parameters.Add(new SqlParameter("@ProjectID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"ProjectID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@ProjectName", SqlDbType.NVarChar, 255,"ProjectName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@CustomerName", SqlDbType.VarChar, 50,"CustomerName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Total", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "Total", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@Discount", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "Discount", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@NetTotal", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "NetTotal", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@CreatedDate", SqlDbType.DateTime, 8,"CreatedDate"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Username", SqlDbType.VarChar, 50,"Username"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitDeleteCommand()
		{
            DeleteCommand.CommandType = CommandType.Text;
			DeleteCommand.Connection = Connection;
			DeleteCommand.CommandText = "DELETE FROM ProjectSaleInvoice WHERE (ID = @ID)";
			DeleteCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
		}

		

		protected  void InitCommandCollection()
		{
			CommandCollection = new IDbCommand[3];

			CommandCollection[0] = new SqlCommand();
			((SqlCommand) (CommandCollection[0])).Connection = Connection;
			((SqlCommand) (CommandCollection[0])).CommandText = "SELECT ID,ReferenceNo,ProjectID,ProjectName,CustomerName,Total,Discount,NetTotal,CreatedDate,Username,Status FROM ProjectSaleInvoice";
			((SqlCommand) (CommandCollection[0])).CommandType = CommandType.Text;
			
			//Fill/GetByID
            CommandCollection[1] = new SqlCommand();
            ((SqlCommand)(CommandCollection[1])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[1])).CommandText = "SELECT ID,ReferenceNo,ProjectID,ProjectName,CustomerName,Total,Discount,NetTotal,CreatedDate,Username,Status FROM ProjectSaleInvoice WHERE ID =  @ID";
            ((SqlCommand)(CommandCollection[1])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[1])).Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, "ID"));
			
			//Fill/GetByStatus
            CommandCollection[2] = new SqlCommand();
            ((SqlCommand)(CommandCollection[2])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[2])).CommandText = "SELECT ID,ReferenceNo,ProjectID,ProjectName,CustomerName,Total,Discount,NetTotal,CreatedDate,Username,Status FROM ProjectSaleInvoice WHERE Status =  @Status";
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

		public ProjectSaleInvoice GetProjectSaleInvoiceByID(int ID)
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
		
		public DataSet GetProjectSaleInvoiceByStatus(string status)
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
		
		
		
		
		
		#endregion CustomGetTable
	    
		public int Insert(ProjectSaleInvoice projectSaleInvoice)
		{
	InsertCommand.Parameters["@ReferenceNo"].Value = projectSaleInvoice.ReferenceNo;
	InsertCommand.Parameters["@ProjectID"].Value = projectSaleInvoice.ProjectID;
	InsertCommand.Parameters["@ProjectName"].Value = projectSaleInvoice.ProjectName;
	InsertCommand.Parameters["@CustomerName"].Value = projectSaleInvoice.CustomerName;
	InsertCommand.Parameters["@Total"].Value = projectSaleInvoice.Total;
	InsertCommand.Parameters["@Discount"].Value = projectSaleInvoice.Discount;
	InsertCommand.Parameters["@NetTotal"].Value = projectSaleInvoice.NetTotal;
	InsertCommand.Parameters["@CreatedDate"].Value = projectSaleInvoice.CreatedDate;
	InsertCommand.Parameters["@Username"].Value = projectSaleInvoice.Username;
	InsertCommand.Parameters["@Status"].Value = projectSaleInvoice.Status;
		
			
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
        
		public int Update(ProjectSaleInvoice projectSaleInvoice)
		{
	UpdateCommand.Parameters["@ID"].Value = projectSaleInvoice.ID;
	UpdateCommand.Parameters["@ReferenceNo"].Value = projectSaleInvoice.ReferenceNo;
	UpdateCommand.Parameters["@ProjectID"].Value = projectSaleInvoice.ProjectID;
	UpdateCommand.Parameters["@ProjectName"].Value = projectSaleInvoice.ProjectName;
	UpdateCommand.Parameters["@CustomerName"].Value = projectSaleInvoice.CustomerName;
	UpdateCommand.Parameters["@Total"].Value = projectSaleInvoice.Total;
	UpdateCommand.Parameters["@Discount"].Value = projectSaleInvoice.Discount;
	UpdateCommand.Parameters["@NetTotal"].Value = projectSaleInvoice.NetTotal;
	UpdateCommand.Parameters["@CreatedDate"].Value = projectSaleInvoice.CreatedDate;
	UpdateCommand.Parameters["@Username"].Value = projectSaleInvoice.Username;
	UpdateCommand.Parameters["@Status"].Value = projectSaleInvoice.Status;

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
        
        private ProjectSaleInvoice DataTableToEntity(DataTable dt)
        {
           
            ProjectSaleInvoice projectSaleInvoice = new ProjectSaleInvoice();
            if(Null.IsNotNull(dt)==true && dt.Rows.Count > 0)
            {
                
                if (Null.IsNotNull(dt.Rows[0]))
                {
                    DataRow dr = dt.Rows[0];
                      					if (Null.IsNotNull(dr["ID"]))
					{
						projectSaleInvoice.ID=Convert.ToInt32(dr["ID"]);
					}
					else
					{
						projectSaleInvoice.ID=0;
					}
					if (Null.IsNotNull(dr["ReferenceNo"]))
					{
						projectSaleInvoice.ReferenceNo= Convert.ToString(dr["ReferenceNo"]);
					}
					else
					{
						projectSaleInvoice.ReferenceNo=string.Empty;
					}
					if (Null.IsNotNull(dr["ProjectID"]))
					{
						projectSaleInvoice.ProjectID=Convert.ToInt32(dr["ProjectID"]);
					}
					else
					{
						projectSaleInvoice.ProjectID=0;
					}
					if (Null.IsNotNull(dr["ProjectName"]))
					{
						projectSaleInvoice.ProjectName= Convert.ToString(dr["ProjectName"]);
					}
					else
					{
						projectSaleInvoice.ProjectName=string.Empty;
					}
					if (Null.IsNotNull(dr["CustomerName"]))
					{
						projectSaleInvoice.CustomerName= Convert.ToString(dr["CustomerName"]);
					}
					else
					{
						projectSaleInvoice.CustomerName=string.Empty;
					}
					if (Null.IsNotNull(dr["Total"]))
					{
						projectSaleInvoice.Total= Convert.ToDecimal(dr["Total"]);
					}
					else
					{
						projectSaleInvoice.Total=0.00m;
					}
					if (Null.IsNotNull(dr["Discount"]))
					{
						projectSaleInvoice.Discount= Convert.ToDecimal(dr["Discount"]);
					}
					else
					{
						projectSaleInvoice.Discount=0.00m;
					}
					if (Null.IsNotNull(dr["NetTotal"]))
					{
						projectSaleInvoice.NetTotal= Convert.ToDecimal(dr["NetTotal"]);
					}
					else
					{
						projectSaleInvoice.NetTotal=0.00m;
					}
					if (Null.IsNotNull(dr["CreatedDate"]))
					{
						projectSaleInvoice.CreatedDate= Convert.ToDateTime(dr["CreatedDate"]);
					}
					else
					{
						projectSaleInvoice.CreatedDate=DateTime.Now;
					}
					if (Null.IsNotNull(dr["Username"]))
					{
						projectSaleInvoice.Username= Convert.ToString(dr["Username"]);
					}
					else
					{
						projectSaleInvoice.Username=string.Empty;
					}
					if (Null.IsNotNull(dr["Status"]))
					{
						projectSaleInvoice.Status= Convert.ToString(dr["Status"]);
					}
					else
					{
						projectSaleInvoice.Status=string.Empty;
					}
 
                }
            }
            return projectSaleInvoice ;
        }
		#endregion		
	}
}