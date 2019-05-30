namespace AngelHack.Repository.Configuration
{
    public static class DbConnection
    {
        private static string url = "angelhack.database.windows.net,1433";
        public static string SQLConnectionString => $"Data Source={url};Persist Security Info=False;User ID=angel;Password=123Aa321; Initial Catalog=AngelHack;";
    }
}
