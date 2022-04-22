using StarCitizenKeymapVisualizer.Graphics;

var window = new Window();

while (true)
{
    window.DispatchEvents();
    window.Display();
    Thread.Sleep(TimeSpan.FromMilliseconds(8));
}
