using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Whizzo;
using SMWaterLevel.Entities;
namespace SMWaterLevel.DataAccess
{

	public class ProjectTableAdapter : BaseDataAdapter
	{
		
		
		#region Constructers

			public ProjectTableAdapter():base()
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
			InsertCommand.CommandText = @"INSERT INTO Project(ProjectName,CustomerID,CustomerName,ProjectCategoryID,ProjectCategoryName,ProjectStatusID,ProjectStatus,CreatedDate,Status) VALUES (@ProjectName,@CustomerID,@CustomerName,@ProjectCategoryID,@ProjectCategoryName,@ProjectStatusID,@ProjectStatus,@CreatedDate,@Status);SELECT ID FROM Project WHERE (ID = SCOPE_IDENTITY())";
						InsertCommand.Parameters.Add(new SqlParameter("@ProjectName", SqlDbType.NVarChar, 100,"ProjectName"));
			InsertCommand.Parameters.Add(new SqlParameter("@CustomerID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"CustomerID", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@CustomerName", SqlDbType.VarChar, 50,"CustomerName"));
			InsertCommand.Parameters.Add(new SqlParameter("@ProjectCategoryID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"ProjectCategoryID", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@ProjectCategoryName", SqlDbType.VarChar, 50,"ProjectCategoryName"));
			InsertCommand.Parameters.Add(new SqlParameter("@ProjectStatusID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"ProjectStatusID", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@ProjectStatus", SqlDbType.VarChar, 50,"ProjectStatus"));
			InsertCommand.Parameters.Add(new SqlParameter("@CreatedDate", SqlDbType.DateTime, 8,"CreatedDate"));
			InsertCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitUpdateCommand()
		{
			UpdateCommand.CommandType = CommandType.Text;
            UpdateCommand.Connection = Connection;
			UpdateCommand.CommandText = @"UPDATE Project SET ProjectName = @ProjectName, CustomerID = @CustomerID, CustomerName = @CustomerName, ProjectCategoryID = @ProjectCategoryID, ProjectCategoryName = @ProjectCategoryName, ProjectStatusID = @ProjectStatusID, ProjectStatus = @ProjectStatus, CreatedDate = @CreatedDate, Status = @Status WHERE (ID = @ID)";
						UpdateCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@ProjectName", SqlDbType.NVarChar, 100,"ProjectName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@CustomerID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"CustomerID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@CustomerName", SqlDbType.VarChar, 50,"CustomerName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@ProjectCategoryID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"ProjectCategoryID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@ProjectCategoryName", SqlDbType.VarChar, 50,"ProjectCategoryName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@ProjectStatusID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"ProjectStatusID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@ProjectStatus", SqlDbType.VarChar, 50,"ProjectStatus"));
			UpdateCommand.Parameters.Add(new SqlParameter("@CreatedDate", SqlDbType.DateTime, 8,"CreatedDate"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitDeleteCommand()
		{
            DeleteCommand.CommandType = CommandType.Text;
			DeleteCommand.Connection = Connection;
			DeleteCommand.CommandText = "DELETE FROM Project WHERE (ID = @ID)";
			DeleteCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
		}

		

		protected  void InitCommandCollection()
		{
			CommandCollection = new IDbCommand[4];

			CommandCollection[0] = new SqlCommand();
			((SqlCommand) (CommandCollection[0])).Connection = Connection;
			((SqlCommand) (CommandCollection[0])).CommandText = "SELECT ID,ProjectName,CustomerID,CustomerName,ProjectCategoryID,ProjectCategoryName,ProjectStatusID,ProjectStatus,CreatedDate,Status FROM Project";
			((SqlCommand) (CommandCollection[0])).CommandType = CommandType.Text;
			
			//Fill/GetByID
            CommandCollection[1] = new SqlCommand();
            ((SqlCommand)(CommandCollection[1])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[1])).CommandText = "SELECT ID,ProjectName,CustomerID,CustomerName,ProjectCategoryID,ProjectCategoryName,ProjectStatusID,ProjectStatus,CreatedDate,Status FROM Project WHERE ID =  @ID";
            ((SqlCommand)(CommandCollection[1])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[1])).Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, "ID"));
			
			//Fill/GetByStatus
            CommandCollection[2] = new SqlCommand();
            ((SqlCommand)(CommandCollection[2])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[2])).CommandText = "SELECT ID,ProjectName,CustomerID,CustomerName,ProjectCategoryID,ProjectCategoryName,ProjectStatusID,ProjectStatus,CreatedDate,Status FROM Project WHERE Status =  @Status ORDER BY ID DESC";
            ((SqlCommand)(CommandCollection[2])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[2])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));
			
			#region CustomCommand
			//GetSearchByProject
            CommandCollection[3] = new SqlCommand();
            ((SqlCommand)(CommandCollection[3])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[3])).CommandText = "SELECT ID,ProjectName,CustomerID,CustomerName,ProjectCategoryID,ProjectCategoryName,ProjectStatusID,ProjectStatus,CreatedDate,Status FROM Project WHERE ProjectName LIKE '%' + @ProjectName + '%' AND Status =  @Status OR ProjectCategoryName LIKE '%' + @ProjectCategoryName + '%' AND Status = @Status OR CustomerName LIKE '%' + @CustomerName + '%' AND Status = @Status OR ProjectStatus LIKE '%' + @ProjectStatus + '%' AND Status = @Status";
            ((SqlCommand)(CommandCollection[3])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@ProjectName", SqlDbType.VarChar, 50, "ProjectName"));
			((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@ProjectCategoryName", SqlDbType.VarChar, 50, "ProjectCategoryName"));
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@CustomerName", SqlDbType.VarChar, 50, "CustomerName"));
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@ProjectStatus", SqlDbType.VarChar, 50, "ProjectStatus"));
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

		public Project GetProjectByID(int ID)
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
		
		public DataSet GetProjectByStatus(string status)
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

        public DataSet GetSearchByProject(string projectName,string projectCategory, string customer, string projectStatus,string status)
        {
            DataSet ds = new DataSet();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[3]));
            Adapter.SelectCommand.Parameters[0].Value = projectName;
            Adapter.SelectCommand.Parameters[1].Value = projectCategory;
            Adapter.SelectCommand.Parameters[2].Value = customer;
            Adapter.SelectCommand.Parameters[3].Value = projectStatus;
            Adapter.SelectCommand.Parameters[4].Value = status;


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
	    
		public int Insert(Project project)
		{
	InsertCommand.Parameters["@ProjectName"].Value = project.ProjectName;
	InsertCommand.Parameters["@CustomerID"].Value = project.CustomerID;
	InsertCommand.Parameters["@CustomerName"].Value = project.CustomerName;
	InsertCommand.Parameters["@ProjectCategoryID"].Value = project.ProjectCategoryID;
	InsertCommand.Parameters["@ProjectCategoryName"].Value = project.ProjectCategoryName;
	InsertCommand.Parameters["@ProjectStatusID"].Value = project.ProjectStatusID;
	InsertCommand.Parameters["@ProjectStatus"].Value = project.ProjectStatus;
	InsertCommand.Parameters["@CreatedDate"].Value = project.CreatedDate;
	InsertCommand.Parameters["@Status"].Value = project.Status;
		
			
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
        
		public int Update(Project project)
		{
	UpdateCommand.Parameters["@ID"].Value = project.ID;
	UpdateCommand.Parameters["@ProjectName"].Value = project.ProjectName;
	UpdateCommand.Parameters["@CustomerID"].Value = project.CustomerID;
	UpdateCommand.Parameters["@CustomerName"].Value = project.CustomerName;
	UpdateCommand.Parameters["@ProjectCategoryID"].Value = project.ProjectCategoryID;
	UpdateCommand.Parameters["@ProjectCategoryName"].Value = project.ProjectCategoryName;
	UpdateCommand.Parameters["@ProjectStatusID"].Value = project.ProjectStatusID;
	UpdateCommand.Parameters["@ProjectStatus"].Value = project.ProjectStatus;
	UpdateCommand.Parameters["@CreatedDate"].Value = project.CreatedDate;
	UpdateCommand.Parameters["@Status"].Value = project.Status;

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
        
        private Project DataTableToEntity(DataTable dt)
        {
           
            Project project = new Project();
            if(Null.IsNotNull(dt)==true && dt.Rows.Count > 0)
            {
                
                if (Null.IsNotNull(dt.Rows[0]))
                {
                    DataRow dr = dt.Rows[0];
                      					if (Null.IsNotNull(dr["ID"]))
					{
						project.ID=Convert.ToInt32(dr["ID"]);
					}
					else
					{
						project.ID=0;
					}
					if (Null.IsNotNull(dr["ProjectName"]))
					{
						project.ProjectName= Convert.ToString(dr["ProjectName"]);
					}
					else
					{
						project.ProjectName=string.Empty;
					}
					if (Null.IsNotNull(dr["CustomerID"]))
					{
						project.CustomerID=Convert.ToInt32(dr["CustomerID"]);
					}
					else
					{
						project.CustomerID=0;
					}
					if (Null.IsNotNull(dr["CustomerName"]))
					{
						project.CustomerName= Convert.ToString(dr["CustomerName"]);
					}
					else
					{
						project.CustomerName=string.Empty;
					}
					if (Null.IsNotNull(dr["ProjectCategoryID"]))
					{
						project.ProjectCategoryID=Convert.ToInt32(dr["ProjectCategoryID"]);
					}
					else
					{
						project.ProjectCategoryID=0;
					}
					if (Null.IsNotNull(dr["ProjectCategoryName"]))
					{
						project.ProjectCategoryName= Convert.ToString(dr["ProjectCategoryName"]);
					}
					else
					{
						project.ProjectCategoryName=string.Empty;
					}
					if (Null.IsNotNull(dr["ProjectStatusID"]))
					{
						project.ProjectStatusID=Convert.ToInt32(dr["ProjectStatusID"]);
					}
					else
					{
						project.ProjectStatusID=0;
					}
					if (Null.IsNotNull(dr["ProjectStatus"]))
					{
						project.ProjectStatus= Convert.ToString(dr["ProjectStatus"]);
					}
					else
					{
						project.ProjectStatus=string.Empty;
					}
					if (Null.IsNotNull(dr["CreatedDate"]))
					{
						project.CreatedDate= Convert.ToDateTime(dr["CreatedDate"]);
					}
					else
					{
						project.CreatedDate=DateTime.Now;
					}
					if (Null.IsNotNull(dr["Status"]))
					{
						project.Status= Convert.ToString(dr["Status"]);
					}
					else
					{
						project.Status=string.Empty;
					}
 
                }
            }
            return project ;
        }
		#endregion		
	}
}