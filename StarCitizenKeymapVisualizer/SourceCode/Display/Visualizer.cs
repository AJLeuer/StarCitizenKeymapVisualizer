using StarCitizenKeymapVisualizer.Resources;

namespace StarCitizenKeymapVisualizer.SourceCode.Display;

public static class Visualizer
{
    public static  State  State { get; private set; }
    private static Window Window = new Window();
    
    public static void Start()
    {
        State = State.Running;
        while (State == State.Running)
        {
            Window.DispatchEvents();
            Window.Display();
            Thread.Sleep(TimeSpan.FromMilliseconds(Configuration.DisplayRefreshIntervalMilliseconds));
        }
    }
}

public enum State
{
    Running,
    Stopped
}