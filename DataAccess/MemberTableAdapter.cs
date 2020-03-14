using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Whizzo;
using SMWaterLevel.Entities;
namespace SMWaterLevel.DataAccess
{

	public class MemberTableAdapter : BaseDataAdapter
	{
		
		
		#region Constructers

			public MemberTableAdapter():base()
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
			InsertCommand.CommandText = @"INSERT INTO Member(MemberName,PhoneNo,Address,Remark,Status) VALUES (@MemberName,@PhoneNo,@Address,@Remark,@Status);SELECT ID FROM Member WHERE (ID = SCOPE_IDENTITY())";
			InsertCommand.Parameters.Add(new SqlParameter("@MemberName", SqlDbType.VarChar, 50,"MemberName"));
			InsertCommand.Parameters.Add(new SqlParameter("@PhoneNo", SqlDbType.VarChar, 50,"PhoneNo"));
			InsertCommand.Parameters.Add(new SqlParameter("@Address", SqlDbType.VarChar, 50,"Address"));
			InsertCommand.Parameters.Add(new SqlParameter("@Remark", SqlDbType.VarChar, 50,"Remark"));
			InsertCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 50,"Status"));

			
		}

		protected  void InitUpdateCommand()
		{
			UpdateCommand.CommandType = CommandType.Text;
            UpdateCommand.Connection = Connection;
			UpdateCommand.CommandText = @"UPDATE Member SET MemberName = @MemberName, PhoneNo = @PhoneNo, Address = @Address, Remark = @Remark, Status = @Status WHERE (ID = @ID)";
						UpdateCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@MemberName", SqlDbType.VarChar, 50,"MemberName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@PhoneNo", SqlDbType.VarChar, 50,"PhoneNo"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Address", SqlDbType.VarChar, 50,"Address"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Remark", SqlDbType.VarChar, 50,"Remark"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 50,"Status"));

			
		}

		protected  void InitDeleteCommand()
		{
            DeleteCommand.CommandType = CommandType.Text;
			DeleteCommand.Connection = Connection;
			DeleteCommand.CommandText = "DELETE FROM Member WHERE (ID = @ID)";
			DeleteCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
		}

		

		protected  void InitCommandCollection()
		{
			CommandCollection = new IDbCommand[4];

			CommandCollection[0] = new SqlCommand();
			((SqlCommand) (CommandCollection[0])).Connection = Connection;
			((SqlCommand) (CommandCollection[0])).CommandText = "SELECT ID,MemberName,PhoneNo,Address,Remark,Status FROM Member";
			((SqlCommand) (CommandCollection[0])).CommandType = CommandType.Text;
			
			//Fill/GetByID
            CommandCollection[1] = new SqlCommand();
            ((SqlCommand)(CommandCollection[1])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[1])).CommandText = "SELECT ID,MemberName,PhoneNo,Address,Remark,Status FROM Member WHERE ID =  @ID";
            ((SqlCommand)(CommandCollection[1])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[1])).Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, "ID"));
			
			//Fill/GetByStatus
            CommandCollection[2] = new SqlCommand();
            ((SqlCommand)(CommandCollection[2])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[2])).CommandText = "SELECT ID,MemberName,PhoneNo,Address,Remark,Status FROM Member WHERE Status =  @Status ORDER BY ID DESC";
            ((SqlCommand)(CommandCollection[2])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[2])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));
			
			#region CustomCommand
            //GetSearchByMember
            CommandCollection[3] = new SqlCommand();
            ((SqlCommand)(CommandCollection[3])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[3])).CommandText = "SELECT ID,MemberName,PhoneNo,Address,Remark,Status FROM Member WHERE MemberName LIKE '%'+ @MemberName +'%' AND PhoneNo LIKE '%'+ @PhoneNo +'%' AND Address LIKE '%'+ @Address +'%' AND Remark LIKE '%'+ @Remark +'%' AND Status =  @Status  ORDER BY ID DESC ";
            ((SqlCommand)(CommandCollection[3])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@MemberName", SqlDbType.VarChar, 50, "MemberName"));
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@PhoneNo", SqlDbType.VarChar, 50, "PhoneNo"));
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@Address", SqlDbType.VarChar, 50, "Address"));
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@Remark", SqlDbType.VarChar, 50, "Remark"));
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

		public Member GetMemberByID(int ID)
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
		
		public DataSet GetMemberByStatus(string status)
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
        public DataSet GetSearchByMember(string memberName,string phoneNo,string address,string remark,string status)
        {
            DataSet ds = new DataSet();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[3]));
            Adapter.SelectCommand.Parameters[0].Value = memberName;
            Adapter.SelectCommand.Parameters[1].Value = phoneNo;
            Adapter.SelectCommand.Parameters[2].Value = address;
            Adapter.SelectCommand.Parameters[3].Value = remark;
            Adapter.SelectCommand.Parameters[4].Value = status;


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
	    
		public int Insert(Member member)
		{
	InsertCommand.Parameters["@MemberName"].Value = member.MemberName;
	InsertCommand.Parameters["@PhoneNo"].Value = member.PhoneNo;
	InsertCommand.Parameters["@Address"].Value = member.Address;
	InsertCommand.Parameters["@Remark"].Value = member.Remark;
	InsertCommand.Parameters["@Status"].Value = member.Status;
		
			
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
        
		public int Update(Member member)
		{
	UpdateCommand.Parameters["@ID"].Value = member.ID;
	UpdateCommand.Parameters["@MemberName"].Value = member.MemberName;
	UpdateCommand.Parameters["@PhoneNo"].Value = member.PhoneNo;
	UpdateCommand.Parameters["@Address"].Value = member.Address;
	UpdateCommand.Parameters["@Remark"].Value = member.Remark;
	UpdateCommand.Parameters["@Status"].Value = member.Status;

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
        
        private Member DataTableToEntity(DataTable dt)
        {
           
            Member member = new Member();
            if(Null.IsNotNull(dt)==true && dt.Rows.Count > 0)
            {
                
                if (Null.IsNotNull(dt.Rows[0]))
                {
                    DataRow dr = dt.Rows[0];
                      					if (Null.IsNotNull(dr["ID"]))
					{
						member.ID=Convert.ToInt32(dr["ID"]);
					}
					else
					{
						member.ID=0;
					}
					if (Null.IsNotNull(dr["MemberName"]))
					{
						member.MemberName= Convert.ToString(dr["MemberName"]);
					}
					else
					{
						member.MemberName=string.Empty;
					}
					if (Null.IsNotNull(dr["PhoneNo"]))
					{
						member.PhoneNo= Convert.ToString(dr["PhoneNo"]);
					}
					else
					{
						member.PhoneNo=string.Empty;
					}
					if (Null.IsNotNull(dr["Address"]))
					{
						member.Address= Convert.ToString(dr["Address"]);
					}
					else
					{
						member.Address=string.Empty;
					}
					if (Null.IsNotNull(dr["Remark"]))
					{
						member.Remark= Convert.ToString(dr["Remark"]);
					}
					else
					{
						member.Remark=string.Empty;
					}
					if (Null.IsNotNull(dr["Status"]))
					{
						member.Status= Convert.ToString(dr["Status"]);
					}
					else
					{
						member.Status=string.Empty;
					}
 
                }
            }
            return member ;
        }
		#endregion		
	}
}