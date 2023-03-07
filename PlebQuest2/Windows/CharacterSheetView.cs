using PlebQuest2.Entities;
using PlebQuest2.Views;
using Terminal.Gui;

namespace PlebQuest2.Windows;

internal class CharacterSheetView : ViewModelView<Character>
{
    public CharacterSheetView(Character character)
         : base(character, "Character Sheet")
    {
        var traitsTableView = new TableView(TableUtils.CreateModelTable(new { character.FirstName, character.LastName, character.Level }))
        {
            Width = Dim.Fill(),
            Height = 6,
            FullRowSelect = true,
            SelectedRow = -1,
            CanFocus = false,
            Style = new()
            {
                ShowVerticalCellLines = false,
            }
        };

        var statsTableView = new TableView(TableUtils.CreateModelTable(character.Stats, "Stat"))
        {
            Y = Pos.Bottom(traitsTableView),
            Width = Dim.Fill(),
            Height = 9,
            FullRowSelect = true,
            CanFocus = false,
            Style = new()
            {
                ShowVerticalCellLines = false,
            }
        };

        var progressBarview = new FrameView("Experience")
        {
            Y = Pos.Bottom(statsTableView),
            Width = Dim.Fill(),
            Height = 3
        };

        var experienceProgressBar = new ProgressBar()
        {
            Fraction = character.Experience / 100f,
            ProgressBarStyle = ProgressBarStyle.MarqueeBlocks,
            Width = Dim.Fill(),
            ColorScheme = new ColorScheme
            {
                Normal = new(Color.Magenta, Color.Gray)
            }
        };

        progressBarview.Add(experienceProgressBar);

        Add(traitsTableView, statsTableView, progressBarview);
    }
}
