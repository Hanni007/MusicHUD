using Windows.Media.Control;


namespace MusicHUD;



public class MediaController
{


public async Task<(string title,string artist)> GetMusic()
{


try
{


var manager =
await GlobalSystemMediaTransportControlsSessionManager.RequestAsync();



var session =
manager.GetCurrentSession();



if(session==null)

return ("没有播放","");



var info =
await session.TryGetMediaPropertiesAsync();



return
(
info.Title,
info.Artist
);



}

catch
{

return ("等待音乐","");

}



}



}
