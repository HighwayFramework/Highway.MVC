using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Templates.App_Architecture.Configs
{
    public enum InitializerTypes
    {
        DropCreateDatabaseAlways,
        DropCreateDatabaseIfModelChanges,
        CreateDatabaseIfNotExists,
        NullDatabaseInitializer
    }
}
