using System;
using SnapObjects.Data;
using SnapObjects.Data.SqlServer;

namespace AdventureWorks
{
    public class AWDataContext : SqlServerDataContext
	{
        public AWDataContext(string connectionString)
            : this(new SqlServerDataContextOptions<AWDataContext>(connectionString))
        {
        }

        public AWDataContext(IDataContextOptions<AWDataContext> options)
            : base(options)
        {
        }
        
        public AWDataContext(IDataContextOptions options)
            : base(options)
        {
        }
    }
}
