using Microsoft.Data.SqlClient;

namespace _02.DatabaseModel.DbContext
{
    public static class MyDbContext
    {
        public static SqlConnection connection = new SqlConnection(@"Data Source=ALFA-420C\SQLEXPRESS;Initial Catalog=KutuphaneApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public static SqlConnection Context { get=> connection; }
    }
}
