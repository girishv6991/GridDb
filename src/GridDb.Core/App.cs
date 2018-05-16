using MvvmCross.IoC;
using MvvmCross.ViewModels;
using GridDb.Core.ViewModels.Home;

namespace GridDb.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<HomeViewModel>();
        }
    }
}
