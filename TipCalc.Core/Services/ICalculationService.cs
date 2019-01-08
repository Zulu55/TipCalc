namespace TipCalc.Core.Services
{
    public interface ICalculationService
    {
        decimal TipAmount(decimal subTotal, int generosity);
    }
}