using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace TryItOutKarliCards
{
    public partial class StartGame : Window
    {
        private GameOptions _gameOptions;
        public StartGame()
        {
            if (_gameOptions == null)
            {
                if (File.Exists("GameOptions.xml"))
                {
                    using (var stream = File.OpenRead("GameOptions.xml"))
                    {
                        var serializer = new XmlSerializer(typeof(GameOptions));
                        _gameOptions = serializer.Deserialize(stream) as GameOptions;
                    }
                }
                else
                {
                    _gameOptions = new GameOptions();
                }
            }
            DataContext = _gameOptions;
            InitializeComponent();
            if (_gameOptions.PlayAgainstComputer)
            {
                playerNameListBox.SelectionMode = SelectionMode.Single;
            }
            else
            {
                playerNameListBox.SelectionMode = SelectionMode.Extended;
            }
        }


        private void PlayerNameListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_gameOptions.PlayAgainstComputer)
            {
                okButton.IsEnabled = (playerNameListBox.SelectedItems.Count == 1);
            }
            else
            {
                okButton.IsEnabled = (playerNameListBox.SelectedItems.Count == _gameOptions.NumbersOfPlayers);
            }
        }

        private void AddNewPlayerButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(newPlayerTextBok.Text))
            {
                _gameOptions.AddPlayer(newPlayerTextBok.Text);
            }
            else
            {
                newPlayerTextBok.Text = string.Empty;
            }
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (string item in playerNameListBox.SelectedItems)
            {
                _gameOptions.SelectedPlayers.Add(item);
            }
        }
    }
}
