using Autofac;
using EstoqueNaoFiscal.Application.Application;
using EstoqueNaoFiscal.Application.Interfaces;
using EstoqueNaoFiscal.Domain.IRepositorys;
using EstoqueNaoFiscal.Infra.Data.Repositorys;
using EstoqueNaoFiscal.Services.Interfaces;
using EstoqueNaoFiscal.Services.Services;

namespace EstoqueNaoFiscal.Infra.IOC.IOC.Base
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region Registra IOC

            #region IOC Application
            builder.RegisterType<ApplicationUsers>().As<IApplicationUsers>();

            #endregion

            #region IOC Repositorys SQL
            builder.RegisterType<RepositoryUsers>().As<IRepositoryUsers>();
            #endregion

            #endregion

            #region IOC Services
            builder.RegisterType<ServiceUsers>().As<IServiceUsers>();

            #endregion

        }
    }
}
