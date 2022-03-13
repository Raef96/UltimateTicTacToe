using MahApps.Metro.Controls;
using System;
using System.Linq;
using UltimateTicTacToe.App.Models;
using UltimateTicTacToe.App.ViewModels;

namespace UltimateTicTacToe.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            MainVM = new MainViewModel();

            var plyersNatures = Enum.GetValues(typeof(NatureOfPlayer)).Cast<NatureOfPlayer>();
            var plyersStrengths = Enum.GetValues(typeof(BotStrengthLevel)).Cast<BotStrengthLevel>();
            cbPlayerX.ItemsSource = plyersNatures;
            cbPlayerXLevel.ItemsSource =  plyersStrengths;
            cbPlayerO.ItemsSource = plyersNatures;
            cbPlayerOLevel.ItemsSource =  plyersStrengths;

            DataContext = MainVM;
        }

        private MainViewModel MainVM { get; set; }
    }
}
