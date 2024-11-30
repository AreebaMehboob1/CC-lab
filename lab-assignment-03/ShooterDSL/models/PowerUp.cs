public class PowerUp
{
    public string Name { get; set; }
    public string Effect { get; set; }
    private int _duration;

    public int Duration
    {
        get => _duration;
        set
        {
            if (value < 0)
                throw new ArgumentException("Duration must be a positive value.");
            _duration = value;
        }
    }
}
