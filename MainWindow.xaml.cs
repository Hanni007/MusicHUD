using System.Windows;
using System.Windows.Threading;


namespace MusicHUD;


public partial class MainWindow : Window
{


MediaController controller =
new MediaController();



public MainWindow()
{

InitializeComponent();


DispatcherTimer timer =
new DispatcherTimer();


timer.Interval =
TimeSpan.FromSeconds(1);



timer.Tick += async (s,e)=>
{


var data =
await controller.GetMusic();



SongText.Text =
data.title;



ArtistText.Text =
data.artist;



};



timer.Start();



}



}
