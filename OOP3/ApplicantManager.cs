using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicantManager
    {
        //Method injection
        public void Apply(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            creditManager.Hesapla();

            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();

            }
        }

        public void CreditPreliminaryInformation(List<ICreditManager> krediler)
        {
            foreach (var credit in krediler)
            {
                credit.Hesapla();
            }
        }
    }
}
