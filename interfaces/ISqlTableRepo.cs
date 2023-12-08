namespace apihookup.interfaces
{
    public interface ISqlTableRepo
    {
        List<string> GetAllTables();
        List<string> GetColumnsOfTable(string tableName);
    }
}
