using SFML.Window;
using SFML.Graphics;
using StarCitizenKeymapVisualizer.Resources;
using static StarCitizenKeymapVisualizer.Resources.Configuration;

namespace StarCitizenKeymapVisualizer.SourceCode.Display;

public class Window : RenderWindow
{
    public Window() : base(new VideoMode(DefaultResolutionWidth, DefaultResolutionHeight, DefaultBitsPerPixel), Properties.ApplicationName)
    {
        
    }
}