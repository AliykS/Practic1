using Avalonia.Controls;
using Avalonia.Interactivity;
using Practic1;
using System.Collections.ObjectModel;

namespace Practic1;

public partial class MainWindow : Window
{
    private ObservableCollection<Museum> museums = new();

    public MainWindow()
    {
        InitializeComponent();

        MuseumsListBox.ItemsSource = museums;
    }

    private void AddButton_Click(object? sender, RoutedEventArgs e)
    {
        string museumName = MuseumNameTextBox.Text?.Trim() ?? "";
        string city = CityTextBox.Text?.Trim() ?? "";

        if (string.IsNullOrWhiteSpace(museumName) ||
            string.IsNullOrWhiteSpace(city))
        {
            ErrorTextBlock.Text = "Ошибка: заполните название музея и город.";
            return;
        }

        ErrorTextBlock.Text = "";

        Museum museum = new Museum
        {
            Name = museumName,
            City = city
        };

        museums.Add(museum);

        MuseumNameTextBox.Text = "";
        CityTextBox.Text = "";
    }
}