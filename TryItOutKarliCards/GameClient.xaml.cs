using System;
using System.Collections.Generic;
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

namespace TryItOutKarliCards
{
    
    public partial class GameClient : Window
    {

        public GameClient()
        {
            InitializeComponent();
        }

        private void CommandCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (e.Command == ApplicationCommands.Close)
            {
                e.CanExecute = true;
            }
            if (e.Command == ApplicationCommands.Save)
            {
                e.CanExecute = false;
            }
        }

        private void CommandExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Command == ApplicationCommands.Close)
            {
                this.Close();
            }
            e.Handled = true;
        }
    }
}
