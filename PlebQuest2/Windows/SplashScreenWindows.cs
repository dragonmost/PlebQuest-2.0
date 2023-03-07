using PlebQuest2.Resources;
using PlebQuest2.UI;
using Terminal.Gui;

namespace PlebQuest2.Windows;

internal class SplashScreenWindow : Window
{
    public SplashScreenWindow()
    {
        Width = Dim.Fill();
        Height = Dim.Fill();

        Add(new ImageView(EmbeddedResources.LoadImage("PlebQuest2.Resources.PQ2.jpg")));

        AddCommand(Command.Accept, () =>
        {
            SuperView.Add(new GameWindow(new Game()));
            SuperView.Remove(this);
            return true;
        });

        AddKeyBinding(Key.Enter, Command.Accept);
    }
}
