#if !NETFX_CORE
//using System.Data.Common;
//using System.Data.Entity;
//using System.Data.Entity.Infrastructure;
//
//namespace TestProfilerWithCore3.ModelEF
//{
//    public class EntitiesConfiguration : DbConfiguration
//    {
//        public EntitiesConfiguration()
//        {
//            SetDatabaseInitializer<Entities>(null);
//            SetManifestTokenResolver(new MyManifestTokenResolver());
//        }
//
//        public class MyManifestTokenResolver : IManifestTokenResolver
//        {
//            public string ResolveManifestToken(DbConnection connection)
//            {
//                return "2012";
//            }
//        }
//    }
//}
#endif