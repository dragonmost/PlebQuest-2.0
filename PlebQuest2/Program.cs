using PlebQuest2.Entities;
using PlebQuest2.Fights;
using PlebQuest2.Items;
using System.Runtime.CompilerServices;
using System.Text;
using Terminal.Gui;

Application.Init();

var top = Application.Top;
var window = new Window("Pleb Quest 2")
{
    X = 0,
    Y = 1,
    Width = Dim.Fill(),
    Height = Dim.Fill()
};

window.Add(new ImageView("Resources\\PQ2.jpg")
{
    Width = Dim.Fill(),
    Height = Dim.Fill()
});

top.Add(window);

Application.Run();
Application.Shutdown();
