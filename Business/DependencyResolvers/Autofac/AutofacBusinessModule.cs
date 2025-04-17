using System.Reflection;
using Autofac;
using Business.Abstracts.Services;
using Business.Concretes.Managers;
using DataAccess.Abstracts.Dals;
using DataAccess.Concretes.EFDals;


namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            #region Car 
            builder.RegisterType<CarManager>().As<ICarService>().SingleInstance();
            builder.RegisterType<EFCarDal>().As<ICardal>().SingleInstance();
            #endregion

            #region Brand 
            builder.RegisterType<BrandManager>().As<IBrandService>().SingleInstance();
            builder.RegisterType<EFBrandDal>().As<IBrandDal>().SingleInstance();
            #endregion

            #region Car 
            builder.RegisterType<CarManager>().As<ICarService>().SingleInstance();
            builder.RegisterType<EFCarDal>().As<ICardal>().SingleInstance();
            #endregion

            #region Car 
            builder.RegisterType<CarManager>().As<ICarService>().SingleInstance();
            builder.RegisterType<EFCarDal>().As<ICardal>().SingleInstance();
            #endregion

            #region Car 
            builder.RegisterType<CarManager>().As<ICarService>().SingleInstance();
            builder.RegisterType<EFCarDal>().As<ICardal>().SingleInstance();
            #endregion

            #region Car 
            builder.RegisterType<CarManager>().As<ICarService>().SingleInstance();
            builder.RegisterType<EFCarDal>().As<ICardal>().SingleInstance();
            #endregion

        }
    }
}