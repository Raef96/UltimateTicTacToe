using System.Windows.Input;
using UltimateTicTacToe.App.Models;

namespace UltimateTicTacToe.App.ViewModels
{
    internal class MainViewModel : BaseViewModel
    {

        private NatureOfPlayer _nPlayerX;
        private NatureOfPlayer _nPlayerO;

        private string _tttName = "Tic Tac Toe";
        private string _utttName = "Ultimate Tic Tac Toe";

        private bool _isTicTacToe;
        private bool _isUltimateTicTacToe;

        public MainViewModel()
        {
            Start = new RelayCommand(StartNewGame, () => true);
        }

        public string TTT => _tttName;
        public string UTTT => _utttName;

        public NatureOfPlayer NplayerX
        {
            get { return _nPlayerX; }
            set
            {
                if (_nPlayerX == value) return;
                _nPlayerX = value;
                OnPropertyChanged(nameof(PlayerXIsBot));
            }
        }
        public NatureOfPlayer NplayerO
        {
            get { return _nPlayerO; }
            set
            {
                if (_nPlayerO == value) return;
                _nPlayerO = value;
                OnPropertyChanged(nameof(PlayerOIsBot));
            }
        }
        public BotStrengthLevel PalyerXStrength { get; set; }
        public BotStrengthLevel PalyerOStrength { get; set; }


        public bool PlayerXIsBot => NplayerX == NatureOfPlayer.Bot;
        public bool PlayerOIsBot => NplayerO == NatureOfPlayer.Bot;

        public ICommand Start { get; set; }

        public bool IsTicTacToe
        {
            get => _isTicTacToe;
            set
            {
                if (_isTicTacToe == value) return;
                _isTicTacToe = value;
                OnPropertyChanged(nameof(CanStartGame));
            }
        }
        public bool IsUltimateTicTacToe
        {
            get => _isUltimateTicTacToe;
            set
            {
                if (_isUltimateTicTacToe == value) return;
                _isUltimateTicTacToe = value;
                OnPropertyChanged(nameof(CanStartGame));
            }
        }
        public bool CanStartGame => IsTicTacToe || IsUltimateTicTacToe;

        public void StartNewGame()
        {
            // TODO
        }

    }
}
