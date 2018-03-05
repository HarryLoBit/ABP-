using System.Reflection;
using Abp.Modules;
using Abp.MongoDb;
using Abp.Configuration.Startup;

namespace MyProject
{
    [DependsOn(typeof(AbpMongoDbModule), typeof(MyProjectCoreModule))]
    public class MyProjectDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
            //MongoDB数据库地址
            Configuration.Modules.AbpMongoDb().ConnectionString = "mongodb://59.53.67.84:27017";
            //MongoDB数据库名称
            Configuration.Modules.AbpMongoDb().DatatabaseName = "wcommunity";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
