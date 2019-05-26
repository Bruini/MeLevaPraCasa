namespace AngelHack.Repository.Configuration
{
    public static class DbConnection
    {
        private static string url = "angelhack.clken9dsuswo.us-east-1.rds.amazonaws.com,1433";
        public static string SQLConnectionString => $"Data Source={url};Persist Security Info=False;User ID=admin;Password=123Aa321; Initial Catalog=AngelHack;";
    }
}
