using SFML.Window;

var window = new Window(new VideoMode(1920, 1080, 30), "Star Citizen Keymap Visualizer");

while (true)
{
    window.DispatchEvents();
    window.Display();
    Thread.Sleep(TimeSpan.FromMilliseconds(8));
}
