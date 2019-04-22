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
            var encoder = new VideoEncoder();
            encoder.RegisterNotificationChannel(new MailNotificationChannel());
            encoder.RegisterNotificationChannel(new SmsNotificationChannel());
            encoder.Encode(new Video());
        }

    }
}