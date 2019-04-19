using System;
using System.Collections.Generic;
using System.Text;
using CSharpRefreshment.Math;
using System.IO;
using System.Threading;

namespace CSharpRefreshment
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);


            dbMigrator.Migrate();
            installer.Install();
        }
    }
}