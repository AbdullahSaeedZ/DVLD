using System;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class clsDataTransaction : IDisposable
    {
        internal SqlConnection Connection { get; set; }        
        internal SqlTransaction Transaction { get; set; }
        
        public void BeginTransaction()
        {
            Connection = new SqlConnection(clsDataAccessSettings.connectionString);
            Connection.Open();
            Transaction = Connection.BeginTransaction();
        }
        
        public void CommitTransaction()
        {
            if (Transaction?.Connection != null)
                Transaction.Commit();
        }
        
        public void RollbackTransaction()
        {
            // when db rolls back, then this connection property will be set to null
            if (Transaction?.Connection != null)
                Transaction.Rollback();
        }
        
        public void Dispose()
        {
            if (Transaction != null)
            {
                Transaction?.Dispose();
                Transaction = null;
            }
            
            if (Connection != null)
            {
                if (Connection.State != System.Data.ConnectionState.Closed)
                    Connection.Close();
                
                Connection.Dispose();
                Connection = null;
            }
        }
    }
}