using System;
using System.Collections.Generic;
using GalaxyShooterDSL.Models;

namespace GalaxyShooterDSL;

public class GameInterpreter
{
    public void ExecuteLevel(Level level, List<Ship> ships, List<Wave> waves, List<PowerUp> powerUps)
    {
        Console.WriteLine($"Starting Level {level.LevelNumber}");

        foreach (var shipName in level.Ships)
        {
            var ship = ships.Find(s => s.Name == shipName);
            Console.WriteLine($"Player Ship: {ship.Name}, Health: {ship.Health}, Speed: {ship.Speed}");
        }

        foreach (var waveName in level.Waves)
        {
            var wave = waves.Find(w => $"Wave {w.WaveNumber}" == waveName);
            Console.WriteLine($"Wave {wave.WaveNumber} Spawning: {string.Join(", ", wave.Enemies)} in {wave.SpawnTime} seconds");
        }

        foreach (var powerUpName in level.PowerUps)
        {
            var powerUp = powerUps.Find(p => p.Name == powerUpName);
            Console.WriteLine($"Power-Up: {powerUp.Name}, Effect: {powerUp.Effect}, Duration: {powerUp.Duration}s");
        }
    }
}
