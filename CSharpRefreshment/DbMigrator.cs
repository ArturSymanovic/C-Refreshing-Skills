using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRefreshment
{

    public class DbMigrator
    {
        private readonly ILogger _logger;
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("Migration Started On: " + DateTime.Now);

            //Details of migration

            _logger.LogInfo("Migration Completed On: " + DateTime.Now);
        }
    }
}
