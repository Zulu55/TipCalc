namespace TipCalc.Core.Services
{
    public class CalculationService : ICalculationService
    {
        public decimal TipAmount(decimal subTotal, int generosity)
        {
            return subTotal * (decimal)(generosity / 100.0);
        }
    }
}