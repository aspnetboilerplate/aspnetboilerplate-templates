using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using MyCompany.MySpaProject.EntityFramework;

namespace MyCompany.MySpaProject
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(MySpaProjectCoreModule))]
    public class MySpaProjectDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<MySpaProjectDbContext>(null);
        }
    }
}
