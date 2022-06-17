using System.ComponentModel;
using System.Linq.Expressions;
using Terminal.Gui;

namespace PlebQuest2;

internal static class MVVMExtensions
{
    public static void Bind<TModel>(this TextField textField, TModel model, Expression<Func<TModel, string>> expression)
        where TModel : INotifyPropertyChanged
    {
        if (expression.Body is MemberExpression memberExpression)
        {
            string memberName = memberExpression.Member.Name;
            var @delegate = expression.Compile();

            void Update()
            {
                textField.Text = @delegate(model);
            }

            model.PropertyChanged += (e, args) =>
            {
                if (args.PropertyName == memberName)
                {
                    Update();
                }
            };

            Update();
        }
    }
}
