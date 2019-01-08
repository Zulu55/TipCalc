namespace TipCalc.Core
{
    using MvvmCross;
    using MvvmCross.ViewModels;
    using Services;
    using ViewModels;

    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.RegisterType<ICalculationService, CalculationService>();

            RegisterAppStart<TipViewModel>();
        }
    }
}