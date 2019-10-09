namespace Task1
{
    public static class Tax
    {
        const int Income = 500;

        public static double Calculate(int companyCount, double taxPercentage)
        {
            return companyCount * Income * (taxPercentage / 100);
        }
    }
}
