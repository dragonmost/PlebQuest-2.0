using PlebQuest2.Windows;
using Terminal.Gui;

namespace PlebQuest2;

internal class PlebQuestTopLevel : Toplevel
{
    public PlebQuestTopLevel()
    {
        Add(new SplashScreenWindow());
    }
}
