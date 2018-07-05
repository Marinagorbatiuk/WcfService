[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(WcfService.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(WcfService.App_Start.NinjectWebCommon), "Stop")]

namespace WcfService.App_Start
{
    using System;
    using System.Data.Entity;
    using System.Web;
    using BLL;
    using Dal;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Ninject.Web.Common.WebHost;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<DbContext>().To<ModelBeauty>();
            kernel.Bind<IDalAdd>().To<AddFunctionDal>();
            kernel.Bind<IBllAdd>().To<AddFunctions>();
            kernel.Bind<IWCFAdd>().To<AddFunctionWCF>();
            kernel.Bind<IDalDelete>().To<DeleteFunctionDal>();
            kernel.Bind<IBllDelete>().To<DeleteFunctions>();
            kernel.Bind<IWCFDelete>().To<DeleteFunctionWCF>();
            kernel.Bind<IDalGet>().To<GetFunctionDal>();
            kernel.Bind<IBllGet>().To<GetFunctions>();
            kernel.Bind<IWCFGet>().To<GetFunctionWCF>();
            kernel.Bind<IDalUpdate>().To<UpdateFunctionDal>();
            kernel.Bind<IBllUpdate>().To<UpdateFunctions>();
            kernel.Bind<IWCFUpdate>().To<UpdateFunctionWCF>();
            kernel.Bind<IConvertationBll>().To<ConvertationsBLL>();
        }        
    }
}