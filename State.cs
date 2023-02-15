namespace SebastianRicketts.dev;

public class State
{
    public Component Current = Component.Startup;
    
    public enum Component
    {
        Startup,
        Transition,
        Name
    }

    public event Action? OnChange;

    public void Set(Component Component)
    {
        Current = Component;
        StateChanged();
    }

    private void StateChanged()
    {
        OnChange?.Invoke();
    }
}