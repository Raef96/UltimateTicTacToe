namespace UltimateTicTacToe.App.ViewModels
{
    internal class SmallBoardViewModel : BaseViewModel
    {
        private const string PlayerX = "X";
        private const string PlayerO = "O";
        private const int BoardSize = 3;

        private int[] _bord;

        private string _currentPlayer;
        public SmallBoardViewModel()
        {
            _currentPlayer = PlayerX;
            _bord = new int[9];
        }

        public string CurrentPlayer
        {
            get { return _currentPlayer; }
            set
            {
                if(_currentPlayer != value)
                {
                    _currentPlayer = value;
                    OnPropertyChanged(nameof(CurrentPlayer));
                }
            }
        }
        public string PreviousPlayer => CurrentPlayer == PlayerX ? PlayerO : PlayerX;
        
        public (int Row, int Column) MakeMove(int rowIdx, int columnIdx)
        {
            var index = BoardSize * rowIdx + columnIdx;
            _bord[index] = CurrentPlayer == PlayerX ? 1 : 2;


            //Search for a possible move for currentplyer
            for (int i = 0; i < _bord.Length; i++)
            {
                if(_bord[i] == 0)
                {
                    var column = i % BoardSize; 
                    var row = i / BoardSize;

                    // play the move
                    _bord[i] = CurrentPlayer == PlayerX ? 2 : 1;

                    return (row, column);
                }
            }

            // game must be over
            return (-1, -1);
        }
    }
}
