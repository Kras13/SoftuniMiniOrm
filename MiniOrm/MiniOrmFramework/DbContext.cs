using System.Reflection;

namespace MiniOrmFramework
{
    public abstract class DbContext
    {
        private readonly DatabaseConnection connection;

        private readonly Dictionary<Type, PropertyInfo> dbSetProperties;

        internal static readonly Type[] AllowedSqlTypes =
        {
            typeof(string),
            typeof(int),
            typeof(uint),
            typeof(long),
            typeof(ulong),
            typeof(decimal),
            typeof(bool),
            typeof(DateTime),
        };
    }

    public ClassNamePlaceholder(string connectionString)
    {
        this.connection = new DatabaseConnection(connectionString);

        this.dbSetProperties = this.DiscoverDbSets();

        using (new ConnectionManager(connection))
        {
            this.InitializeDbSets();
        }

        this.MappAllRelations();
    }
}
