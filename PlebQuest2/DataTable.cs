using System.Data;
using System.Runtime.Serialization;

internal class DataTable<T> : DataTable
{
    public DataTable()
    {
    }

    public DataTable(string? tableName) : base(tableName)
    {
    }

    public DataTable(string? tableName, string? tableNamespace) : base(tableName, tableNamespace)
    {
    }

    protected DataTable(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

    public void AddRow(T model, params object?[] values)
    {
        if (Rows.Add(values) is DataRow<T> row)
        {
            row.Value = model;
        }
    }

    protected override Type GetRowType()
    {
        return typeof(DataRow<T>);
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
        return new DataRow<T>(builder);
    }
}