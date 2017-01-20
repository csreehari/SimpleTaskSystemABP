using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;
using SimpleTaskSystem.Services;

namespace SimpleTaskSystem
{
    [DependsOn(typeof(AbpWebApiModule), typeof(SimpleTaskSystemApplicationModule))]
    public class SimpleTaskSystemWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(SimpleTaskSystemApplicationModule).Assembly, "smps")
                .Build();
        }
    }
}
