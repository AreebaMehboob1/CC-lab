using System;
using GalaxyShooterDSL;
using GalaxyShooterDSL.Models;

class Program
{
    static void Main(string[] args)
    {
       string dslScript = @"
Ship Hero {
    Health: 100;
    Speed: 10;
    Weapon: Laser;
}

Ship EnemySmall {
    Health: 50;
    Speed: 6;
    Weapon: Plasma;
}

Wave 1 {
    Enemies: [EnemySmall, EnemySmall];
    SpawnTime: 5s;
}

Wave 2 {
    Enemies: [EnemySmall];
    SpawnTime: 3s;
}

PowerUp Shield {
    Effect: IncreaseDefense;
    Duration: 10s;
}

PowerUp SpeedBoost {
    Effect: IncreaseSpeed;
    Duration: 5s;
}

Level 1 {
    Ships: [Hero];
    Waves: [Wave 1, Wave 2];
    PowerUps: [Shield, SpeedBoost];
}";


        var parser = new DSLParser();
        var ships = parser.ParseShips(dslScript);
        var waves = parser.ParseWaves(dslScript);
        var powerUps = parser.ParsePowerUps(dslScript);
        var levels = parser.ParseLevels(dslScript);

        var interpreter = new GameInterpreter();
        foreach (var level in levels)
        {
            interpreter.ExecuteLevel(level, ships, waves, powerUps);
        }
    }
}
