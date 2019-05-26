using System;
using System.Collections.Generic;
using System.Text;

namespace AngelHack.Repository.Configuration
{
    public static class DbConnection
    {
        public static string SQLConnectionString => "Data Source=http://angelhack.clken9dsuswo.us-east-1.rds.amazonaws.com/; Persist Security Info=False;User ID=admin;Password=123Aa321; Database=AngelHack;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True";
    }
}
