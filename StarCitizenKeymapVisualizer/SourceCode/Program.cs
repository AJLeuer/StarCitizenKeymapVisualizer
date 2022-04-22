using StarCitizenKeymapVisualizer;
using StarCitizenKeymapVisualizer.SourceCode.Graphics;

var window = new Window();

byte[] keyVectorImageFile = Assets.BlankKeyVectorImage;

while (true)
{
    window.DispatchEvents();
    window.Display();
    Thread.Sleep(TimeSpan.FromMilliseconds(8));
}
