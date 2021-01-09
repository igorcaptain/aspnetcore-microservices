using System;

namespace Catalog.API.Settings
{
    public interface ICatalogDatabaseSettings
    {
        string CollectionName { get; set; }
        string DatabaseName { get; set; }
        string ConnectionString { get; set; }
    }
}
