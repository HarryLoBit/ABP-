using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;
using Abp.Application;
namespace MyProject
{
    [DependsOn(typeof(AbpWebApiModule), typeof(MyProjectApplicationModule))]
    public class MyProjectWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(Assembly.GetAssembly(null),"app")
                .Build();

            //DynamicApiControllerBuilder.For<IBookRepository>("getone/book").ForMethod("GetOneItem").WithVerb(HttpVerb.Get).Build();

        }
    }
}
