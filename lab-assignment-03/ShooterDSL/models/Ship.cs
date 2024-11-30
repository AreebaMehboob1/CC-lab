public class Ship
{
    public string Name { get; set; }
    
    private int _health;
    public int Health
    {
        get => _health;
        set
        {
            if (value < 0)
                throw new ArgumentException("Health must be a positive value.");
            _health = value;
        }
    }

    private int _speed;
    public int Speed
    {
        get => _speed;
        set
        {
            if (value < 0)
                throw new ArgumentException("Speed must be a positive value.");
            _speed = value;
        }
    }

    public string Weapon { get; set; }
}
