using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Whizzo;
using SMWaterLevel.Entities;
namespace SMWaterLevel.DataAccess
{

	public class ProjectSaleQuotationTableAdapter : BaseDataAdapter
	{
		
		
		#region Constructers

			public ProjectSaleQuotationTableAdapter():base()
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
			InsertCommand.CommandText = @"INSERT INTO ProjectSaleQuotation(ReferenceNo,ProjectID,ProjectName,CustomerName,Total,Discount,NetTotal,CreatedDate,Username,Status) VALUES (@ReferenceNo,@ProjectID,@ProjectName,@CustomerName,@Total,@Discount,@NetTotal,@CreatedDate,@Username,@Status);SELECT ID FROM ProjectSaleQuotation WHERE (ID = SCOPE_IDENTITY())";
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
			UpdateCommand.CommandText = @"UPDATE ProjectSaleQuotation SET ReferenceNo = @ReferenceNo, ProjectID = @ProjectID, ProjectName = @ProjectName, CustomerName = @CustomerName, Total = @Total, Discount = @Discount, NetTotal = @NetTotal, CreatedDate = @CreatedDate, Username = @Username, Status = @Status WHERE (ID = @ID)";
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
			DeleteCommand.CommandText = "DELETE FROM ProjectSaleQuotation WHERE (ID = @ID)";
			DeleteCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
		}

		

		protected  void InitCommandCollection()
		{
			CommandCollection = new IDbCommand[3];

			CommandCollection[0] = new SqlCommand();
			((SqlCommand) (CommandCollection[0])).Connection = Connection;
			((SqlCommand) (CommandCollection[0])).CommandText = "SELECT ID,ReferenceNo,ProjectID,ProjectName,CustomerName,Total,Discount,NetTotal,CreatedDate,Username,Status FROM ProjectSaleQuotation";
			((SqlCommand) (CommandCollection[0])).CommandType = CommandType.Text;
			
			//Fill/GetByID
            CommandCollection[1] = new SqlCommand();
            ((SqlCommand)(CommandCollection[1])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[1])).CommandText = "SELECT ID,ReferenceNo,ProjectID,ProjectName,CustomerName,Total,Discount,NetTotal,CreatedDate,Username,Status FROM ProjectSaleQuotation WHERE ID =  @ID";
            ((SqlCommand)(CommandCollection[1])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[1])).Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, "ID"));
			
			//Fill/GetByStatus
            CommandCollection[2] = new SqlCommand();
            ((SqlCommand)(CommandCollection[2])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[2])).CommandText = "SELECT ID,ReferenceNo,ProjectID,ProjectName,CustomerName,Total,Discount,NetTotal,CreatedDate,Username,Status FROM ProjectSaleQuotation WHERE Status =  @Status";
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

		public ProjectSaleQuotation GetProjectSaleQuotationByID(int ID)
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
		
		public DataSet GetProjectSaleQuotationByStatus(string status)
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
	    
		public int Insert(ProjectSaleQuotation projectSaleQuotation)
		{
	InsertCommand.Parameters["@ReferenceNo"].Value = projectSaleQuotation.ReferenceNo;
	InsertCommand.Parameters["@ProjectID"].Value = projectSaleQuotation.ProjectID;
	InsertCommand.Parameters["@ProjectName"].Value = projectSaleQuotation.ProjectName;
	InsertCommand.Parameters["@CustomerName"].Value = projectSaleQuotation.CustomerName;
	InsertCommand.Parameters["@Total"].Value = projectSaleQuotation.Total;
	InsertCommand.Parameters["@Discount"].Value = projectSaleQuotation.Discount;
	InsertCommand.Parameters["@NetTotal"].Value = projectSaleQuotation.NetTotal;
	InsertCommand.Parameters["@CreatedDate"].Value = projectSaleQuotation.CreatedDate;
	InsertCommand.Parameters["@Username"].Value = projectSaleQuotation.Username;
	InsertCommand.Parameters["@Status"].Value = projectSaleQuotation.Status;
		
			
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
        
		public int Update(ProjectSaleQuotation projectSaleQuotation)
		{
	UpdateCommand.Parameters["@ID"].Value = projectSaleQuotation.ID;
	UpdateCommand.Parameters["@ReferenceNo"].Value = projectSaleQuotation.ReferenceNo;
	UpdateCommand.Parameters["@ProjectID"].Value = projectSaleQuotation.ProjectID;
	UpdateCommand.Parameters["@ProjectName"].Value = projectSaleQuotation.ProjectName;
	UpdateCommand.Parameters["@CustomerName"].Value = projectSaleQuotation.CustomerName;
	UpdateCommand.Parameters["@Total"].Value = projectSaleQuotation.Total;
	UpdateCommand.Parameters["@Discount"].Value = projectSaleQuotation.Discount;
	UpdateCommand.Parameters["@NetTotal"].Value = projectSaleQuotation.NetTotal;
	UpdateCommand.Parameters["@CreatedDate"].Value = projectSaleQuotation.CreatedDate;
	UpdateCommand.Parameters["@Username"].Value = projectSaleQuotation.Username;
	UpdateCommand.Parameters["@Status"].Value = projectSaleQuotation.Status;

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
        
        private ProjectSaleQuotation DataTableToEntity(DataTable dt)
        {
           
            ProjectSaleQuotation projectSaleQuotation = new ProjectSaleQuotation();
            if(Null.IsNotNull(dt)==true && dt.Rows.Count > 0)
            {
                
                if (Null.IsNotNull(dt.Rows[0]))
                {
                    DataRow dr = dt.Rows[0];
                      					if (Null.IsNotNull(dr["ID"]))
					{
						projectSaleQuotation.ID=Convert.ToInt32(dr["ID"]);
					}
					else
					{
						projectSaleQuotation.ID=0;
					}
					if (Null.IsNotNull(dr["ReferenceNo"]))
					{
						projectSaleQuotation.ReferenceNo= Convert.ToString(dr["ReferenceNo"]);
					}
					else
					{
						projectSaleQuotation.ReferenceNo=string.Empty;
					}
					if (Null.IsNotNull(dr["ProjectID"]))
					{
						projectSaleQuotation.ProjectID=Convert.ToInt32(dr["ProjectID"]);
					}
					else
					{
						projectSaleQuotation.ProjectID=0;
					}
					if (Null.IsNotNull(dr["ProjectName"]))
					{
						projectSaleQuotation.ProjectName= Convert.ToString(dr["ProjectName"]);
					}
					else
					{
						projectSaleQuotation.ProjectName=string.Empty;
					}
					if (Null.IsNotNull(dr["CustomerName"]))
					{
						projectSaleQuotation.CustomerName= Convert.ToString(dr["CustomerName"]);
					}
					else
					{
						projectSaleQuotation.CustomerName=string.Empty;
					}
					if (Null.IsNotNull(dr["Total"]))
					{
						projectSaleQuotation.Total= Convert.ToDecimal(dr["Total"]);
					}
					else
					{
						projectSaleQuotation.Total=0.00m;
					}
					if (Null.IsNotNull(dr["Discount"]))
					{
						projectSaleQuotation.Discount= Convert.ToDecimal(dr["Discount"]);
					}
					else
					{
						projectSaleQuotation.Discount=0.00m;
					}
					if (Null.IsNotNull(dr["NetTotal"]))
					{
						projectSaleQuotation.NetTotal= Convert.ToDecimal(dr["NetTotal"]);
					}
					else
					{
						projectSaleQuotation.NetTotal=0.00m;
					}
					if (Null.IsNotNull(dr["CreatedDate"]))
					{
						projectSaleQuotation.CreatedDate= Convert.ToDateTime(dr["CreatedDate"]);
					}
					else
					{
						projectSaleQuotation.CreatedDate=DateTime.Now;
					}
					if (Null.IsNotNull(dr["Username"]))
					{
						projectSaleQuotation.Username= Convert.ToString(dr["Username"]);
					}
					else
					{
						projectSaleQuotation.Username=string.Empty;
					}
					if (Null.IsNotNull(dr["Status"]))
					{
						projectSaleQuotation.Status= Convert.ToString(dr["Status"]);
					}
					else
					{
						projectSaleQuotation.Status=string.Empty;
					}
 
                }
            }
            return projectSaleQuotation ;
        }
		#endregion		
	}
}