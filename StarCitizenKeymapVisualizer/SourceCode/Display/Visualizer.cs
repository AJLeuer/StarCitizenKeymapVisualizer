using StarCitizenKeymapVisualizer.Resources;
using StarCitizenKeymapVisualizer.SourceCode.Models;

namespace StarCitizenKeymapVisualizer.SourceCode.Display;

public static class Visualizer
{
    public static  State   State { get; private set; }
    private static Window  Window = new ();
    private static Thread? UpdateThread;

    public static Key Key { get; set; } = new ();
    
    public static void Start()
    {
        State = State.Running;
        
        UpdateThread = new Thread(Update);
        UpdateThread.Start();
        
        Display();
    }

    private static void Update()
    {
        while (State == State.Running)
        {
            Thread.Sleep(TimeSpan.FromMilliseconds(Configuration.DisplayRefreshIntervalMilliseconds));
        }
    }

    private static void Display()
    {
        while (State == State.Running)
        {
            Window.DispatchEvents();
            
            Window.Clear();
            Window.Draw(Key);
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