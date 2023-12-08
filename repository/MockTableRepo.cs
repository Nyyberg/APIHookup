using apihookup.interfaces;

namespace apihookup.repository
{
    public class MockTableRepo : ISqlTableRepo
    {
        public List<string> GetAllTables()
        {
            //create a mock table with 10 entries
            List<string> mockTables = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                mockTables.Add("table" + i);
            }
            return mockTables;
        }

        public List<string> GetColumnsOfTable(string tableName)
        {
            //create a mock list of 10 columns with the table name + "coumn" + i
            List<string> mockColumns = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                mockColumns.Add(tableName + " column" + i);
            }
            return mockColumns;
        }
    }
}
