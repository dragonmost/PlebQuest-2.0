using System.Data;

namespace PlebQuest2.Utils;

internal class TableUtils
{
    public static DataTable CreateModelTable<TModel>(TModel model, string propertyName = "Name", string valueName = "Value") where TModel : notnull
    {
        var table = new DataTable<TModel>();
        table.Columns.Add(propertyName);
        table.Columns.Add(valueName);

        foreach (var property in typeof(TModel).GetProperties())
        {
            table.AddRow(model, property.Name, property.GetValue(model));
        }

        return table;
    }

    public static DataTable CreateModelTable<TModel>(IEnumerable<TModel> models, Func<TModel, string> keySelector, Func<TModel, object> valueSelector, string propertyName = "Name", string valueName = "Value")
    {
        var table = new DataTable<TModel>();
        table.Columns.Add(propertyName);
        table.Columns.Add(valueName);

        foreach (var model in models)
        {
            table.AddRow(model, keySelector(model), valueSelector(model));
        }

        return table;
    }
}
