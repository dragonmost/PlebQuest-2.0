using System.Data;

internal class DataRow<T> : DataRow
{
    public DataRow(DataRowBuilder builder)
        : base(builder)
    {
    }

    public T? Value { get; set; }
}
