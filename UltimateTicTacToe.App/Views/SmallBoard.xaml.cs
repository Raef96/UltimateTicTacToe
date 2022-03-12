using System.Windows;
using System.Windows.Controls;
using UltimateTicTacToe.App.ViewModels;

namespace UltimateTicTacToe.App.Views
{
    /// <summary>
    /// Interaction logic for SmallBoard.xaml
    /// </summary>
    public partial class SmallBoard : UserControl
    {
        private SmallBoardViewModel _smallBoardVM;
        public SmallBoard()
        {
            InitializeComponent();
            _smallBoardVM = new SmallBoardViewModel();

            DataContext = _smallBoardVM;
        }
        
        private void MakeMove(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            // drow the badge for the currentPlayer
            button.Content = _smallBoardVM.CurrentPlayer;
            //make the move for the player

            // get move coordinates .. name of button : Button{int}_{int}
            var coords = button.Name.Split("Button")[1].Split('_');
            var row = int.Parse(coords[0]);
            var col = int.Parse(coords[1]);
            // send them to _smallBoardVM to make move
            // if the AI is activated get the move 
            var moveCoordinates = _smallBoardVM.MakeMove(row,col);

            // make move for AI by drowing its badge
            var targetName = $"Button{moveCoordinates.Row}_{moveCoordinates.Column}";
            var targetButton = (Button)boardCells.FindName(targetName);
            targetButton.Content = _smallBoardVM.PreviousPlayer;
        }
    }
}
