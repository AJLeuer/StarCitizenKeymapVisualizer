using StarCitizenKeymapVisualizer.SourceCode.Graphics;
using StarCitizenKeymapVisualizer.Resources;

var window = new Window();

byte[] keyVectorImageFile = Assets.BlankKeyVectorImage;

while (true)
{
    window.DispatchEvents();
    window.Display();
    Thread.Sleep(TimeSpan.FromMilliseconds(8));
}
