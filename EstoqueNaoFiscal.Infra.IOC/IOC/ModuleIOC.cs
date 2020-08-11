using Autofac;
using EstoqueNaoFiscal.Infra.IOC.IOC.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstoqueNaoFiscal.Infra.IOC.IOC
{
   public class ModuleIOC : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            #region Carrega IOC
            ConfigurationIOC.Load(builder);
            #endregion
        }
    }
}
