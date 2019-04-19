using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRefreshment
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {

        }

        public override void Close()
        {
            Console.WriteLine("Close Oracle Connection");
        }

        public override void Open()
        {
            Console.WriteLine("Open Oracle Connection");
        }
    }
}
