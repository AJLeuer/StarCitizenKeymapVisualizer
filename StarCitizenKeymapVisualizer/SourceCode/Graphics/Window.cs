using SFML.Window;
using StarCitizenKeymapVisualizer.Resources;
using static StarCitizenKeymapVisualizer.Resources.Configuration;

namespace StarCitizenKeymapVisualizer.SourceCode.Graphics;

public class Window : SFML.Window.Window
{
    public Window() : base(new VideoMode(DefaultResolutionWidth, DefaultResolutionHeight, DefaultBitsPerPixel), Properties.ApplicationName)
    {
        
    }
}