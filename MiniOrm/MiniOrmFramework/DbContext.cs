namespace MiniOrmFramework
{
    internal class DbContext
    {
        // connection...
        //Dictionary....db set properties

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
}
