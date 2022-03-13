namespace UltimateTicTacToe.App.Models
{
    public enum NatureOfPlayer
    {
        Human,
        Bot
    }

    public enum BotStrengthLevel
    {
        Easy,
        Medium,
        Hard
    }
    internal class Player
    {
        public Player()
        {
            PlayerNature = NatureOfPlayer.Human;
            StrengthLevel = BotStrengthLevel.Easy;
        }

        public NatureOfPlayer PlayerNature { get; set; }
        public BotStrengthLevel StrengthLevel { get; set; }

    }
}
