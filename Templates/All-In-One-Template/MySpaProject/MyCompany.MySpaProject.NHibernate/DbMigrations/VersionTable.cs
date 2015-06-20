using FluentMigrator.VersionTableInfo;

namespace MyCompany.MySpaProject.DbMigrations
{
    [VersionTableMetaData]
    public class VersionTable : DefaultVersionTableMetaData
    {
        public override string TableName
        {
            get
            {
                return "MyAppVersionInfo";
            }
        }
    }
}
