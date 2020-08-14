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
            builder.RegisterType<ApplicationEnderecos>().As<IApplicationEnderecos>();

            #endregion

            #region IOC Repositorys SQL
            builder.RegisterType<RepositoryUsers>().As<IRepositoryUsers>();
            builder.RegisterType<RepositoryEnderecos>().As<IRepositoryEnderecos>();
            #endregion

            #endregion

            #region IOC Services
            builder.RegisterType<ServiceUsers>().As<IServiceUsers>();
            builder.RegisterType<ServiceEnderecos>().As<IServiceEnderecos>();

            #endregion

        }
    }
}
