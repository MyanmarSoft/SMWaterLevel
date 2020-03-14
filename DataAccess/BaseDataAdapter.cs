using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Configuration;
using Whizzo;
namespace SMWaterLevel.DataAccess
{
    public class BaseDataAdapter
    {
        #region Members
        protected SqlCommand _SelectCommand;
        protected SqlCommand _DeleteCommand;
        protected SqlCommand _InsertCommand;
        protected SqlCommand _UpdateCommand;

        protected SqlConnection _Connection;
        private SqlDataAdapter _Adapter;
        #endregion

        #region Constructors

        public BaseDataAdapter()
        {

        }

        #endregion

        #region Properties

        protected IDbCommand[] CommandCollection;


        protected SqlDataAdapter Adapter
        {
            get
            {
                if ((this._Adapter == null))
                {
                    _Adapter = new SqlDataAdapter();
                }
                return _Adapter;
            }
            set { _Adapter = value; }
        }

        protected SqlCommand SelectCommand
        {
            get
            {
                if ((this._SelectCommand == null))
                {
                    this._SelectCommand = new SqlCommand();
                    this._SelectCommand.Connection = this.Connection;

                }
                return this._SelectCommand;
            }
        }

        protected SqlCommand DeleteCommand
        {
            get
            {
                if ((this._DeleteCommand == null))
                {
                    this._DeleteCommand = new SqlCommand();
                    this._DeleteCommand.Connection = this.Connection;

                }
                return this._DeleteCommand;
            }
        }

        protected SqlCommand InsertCommand
        {
            get
            {
                if ((this._InsertCommand == null))
                {
                    this._InsertCommand = new SqlCommand();
                    this._InsertCommand.Connection = this.Connection;
                }
                return this._InsertCommand;
            }
        }

        protected SqlCommand UpdateCommand
        {
            get
            {
                if ((this._UpdateCommand == null))
                {
                    this._UpdateCommand = new SqlCommand();
                    this._UpdateCommand.Connection = this.Connection;
                }
                return this._UpdateCommand;
            }
        }

        internal SqlConnection Connection
        {
            get
            {
                if ((this._Connection == null))
                {
                    this._Connection = new SqlConnection();
                    this._Connection.ConnectionString = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;

                }
                return this._Connection;
            }
        }
        #endregion
		
		#region CustomCommand
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		#endregion CustomCommand
    }
}
