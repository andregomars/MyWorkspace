﻿using System.Collections.Generic;
using System;
using NetCoreDemo.DesignPattern;
//using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using NLog;

namespace NetCoreDemo
{
    public class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        
        public static void Main(string[] args)
        {
            /*
            //TestFactory();
            ILoggerFactory loggerFactory = new LoggerFactory()
                .AddConsole()
                .AddDebug()
                .AddNLog();
            //ILogger logger = loggerFactory.CreateLogger<Program>();
            logger.LogInformation("start to run main!");
            HttpClientSample.Run();

            */
            Console.WriteLine("runned");
            //Console.ReadLine();
            logger.Info("nlog works");
        }

        public static void TestFactory()
        {
            List<EDI> ediDocs = new List<EDI>();
            ediDocs.Add(new EDI832());
            ediDocs.Add(new EDI850());
            ediDocs.Add(new EDI810());

            foreach(EDI doc in ediDocs)
            {
                Console.WriteLine(doc.GetType().Name);
                foreach(Segment seg in doc.Segments)
                {
                    Console.WriteLine(seg.GetType().Name);
                }
            } 
        }
    }
 


}