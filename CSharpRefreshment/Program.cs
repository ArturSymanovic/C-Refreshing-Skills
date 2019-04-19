using System;
using System.Collections.Generic;
using System.Text;
using CSharpRefreshment.Math;
using System.IO;
using System.Threading;
using Amazon;
using System.Collections;

namespace CSharpRefreshment
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection("abc");
            sqlConnection.Open();

            var oracleConnection = new OracleConnection("def");
            oracleConnection.Open();

            sqlConnection.Close();
            oracleConnection.Close();
        }

    }
}