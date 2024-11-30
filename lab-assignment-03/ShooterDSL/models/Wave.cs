public class Wave
{
    public int WaveNumber { get; set; }
    public string[] Enemies { get; set; }
    public int SpawnTime { get; set; }

    public void PrintWaveInfo()
    {
        Console.WriteLine($"Wave {WaveNumber}:");
        Console.WriteLine($"Enemies: {string.Join(", ", Enemies)}");
        Console.WriteLine($"Spawn Time: {SpawnTime} seconds");
    }
}
