namespace Budgeteer.BTMath
{
    public static class AprCalculator
    {
        public static decimal CalculateAprAmount(decimal principal, decimal apr, DateTime dtPeriod) =>
            principal * ((apr / 365) * DateTime.DaysInMonth(dtPeriod.Year, dtPeriod.Month));

        public static List<(int pmtNo, DateTime pmtDate, decimal payment, decimal principal, decimal interest, decimal remainingBalance)>
            CalculateLoanAmortization(DateTime startDate, decimal apr, decimal loanAmount, decimal payment)
        {
            List<(int pmtNo, DateTime pmtDate, decimal payment, decimal principal, decimal interest, decimal remainingBalance)> loanAmortization = new();
            var remainingBalance = loanAmount;
            var pmtDate = startDate;
            int pmtNum = 1;

            while (remainingBalance > 0)
            {
                // 1 Calculate monthly interest
                var monthlyInterest = CalculateAprAmount(remainingBalance, apr, pmtDate);

                // 2 Calculate monthly principal
                var monthlyPrincipal = payment - monthlyInterest;

                // 3 Calculate remaining balance
                remainingBalance -= monthlyPrincipal;

                // 4 Add to loan amortization list
                loanAmortization.Add((pmtNum++, startDate, payment, monthlyPrincipal, monthlyInterest, remainingBalance));

                pmtDate = pmtDate.AddMonths(1);

                // check for end of loan
                if (remainingBalance <= payment)
                {
                    loanAmortization.Add((pmtNum++, startDate, remainingBalance, remainingBalance, 0, 0));
                    break;
                }
            }

            return loanAmortization;
        }

        public static decimal CalculateLoanPayment(decimal principal, decimal apr, int term)
        {
            var monthlyRate = (double)(apr / 12);
            var termInMonths = term * 12;
            var payment = (double)principal * (monthlyRate * Math.Pow(1 + monthlyRate, termInMonths)) / (Math.Pow(1 + monthlyRate, termInMonths) - 1);
            return (decimal)payment;
        }
    }
}