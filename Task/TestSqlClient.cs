using Microsoft.Build.Framework;
using System.Data.SqlClient;

namespace TestTasks
{
    public class TestSqlClient : Microsoft.Build.Utilities.Task
    {
        public override bool Execute()
        {
            var client = new SqlConnection();
            Log.LogMessage(MessageImportance.High, "Done!");
            return true;
        }
    }
}