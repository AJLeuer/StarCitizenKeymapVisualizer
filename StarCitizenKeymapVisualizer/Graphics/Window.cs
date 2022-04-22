using SFML.Window;
using static StarCitizenKeymapVisualizer.Configuration;
namespace StarCitizenKeymapVisualizer.Graphics;

public class Window : SFML.Window.Window
{
    public Window() : base(new VideoMode(DefaultResolutionWidth, DefaultResolutionHeight, DefaultBitsPerPixel), Properties.ApplicationName)
    {
        
    }
}