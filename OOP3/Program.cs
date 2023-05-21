using System;
using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            ICreditManager consumerLoanManager = new ConsumerLoanManager();
            ICreditManager vehicleLoanManager = new VehicleLoanManager();            
            ICreditManager mortgageManager = new MortgageManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>() { fileLoggerService, new DatabaseLoggerService(), new SmsLoggerService()};

            ApplicantManager applicantManager = new ApplicantManager();
            applicantManager.Apply(vehicleLoanManager, new List<ILoggerService>() { databaseLoggerService, new SmsLoggerService()});


            List<ICreditManager> credits = new List<ICreditManager>() {mortgageManager, vehicleLoanManager };
            //applicantManager.CreditPreliminaryInformation(credits);
            
        }
    }
}