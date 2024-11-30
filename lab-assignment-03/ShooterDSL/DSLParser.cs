using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using GalaxyShooterDSL.Models;

namespace GalaxyShooterDSL;

public class DSLParser
{
    public List<Ship> ParseShips(string script)
    {
        var ships = new List<Ship>();
        var shipRegex = new Regex(@"Ship (\w+) \{.*?Health: (\d+);.*?Speed: (\d+);.*?Weapon: (\w+);.*?\}", RegexOptions.Singleline);
        foreach (Match match in shipRegex.Matches(script))
        {
            ships.Add(new Ship
            {
                Name = match.Groups[1].Value,
                Health = int.Parse(match.Groups[2].Value),
                Speed = int.Parse(match.Groups[3].Value),
                Weapon = match.Groups[4].Value
            });
        }
        return ships;
    }

    public List<Wave> ParseWaves(string script)
    {
        var waves = new List<Wave>();
        var waveRegex = new Regex(@"Wave (\d+) \{.*?Enemies: \[(.*?)\];.*?SpawnTime: (\d+)s;.*?\}", RegexOptions.Singleline);
        foreach (Match match in waveRegex.Matches(script))
        {
            waves.Add(new Wave
            {
                WaveNumber = int.Parse(match.Groups[1].Value),
                Enemies = match.Groups[2].Value.Split(", "),
                SpawnTime = int.Parse(match.Groups[3].Value)
            });
        }
        return waves;
    }

    public List<PowerUp> ParsePowerUps(string script)
    {
        var powerUps = new List<PowerUp>();
        var powerUpRegex = new Regex(@"PowerUp (\w+) \{.*?Effect: (\w+);.*?Duration: (\d+)s;.*?\}", RegexOptions.Singleline);
        foreach (Match match in powerUpRegex.Matches(script))
        {
            powerUps.Add(new PowerUp
            {
                Name = match.Groups[1].Value,
                Effect = match.Groups[2].Value,
                Duration = int.Parse(match.Groups[3].Value)
            });
        }
        return powerUps;
    }

    public List<Level> ParseLevels(string script)
    {
        var levels = new List<Level>();
        var levelRegex = new Regex(@"Level (\d+) \{.*?Ships: \[(.*?)\];.*?Waves: \[(.*?)\];.*?PowerUps: \[(.*?)\];.*?\}", RegexOptions.Singleline);
        foreach (Match match in levelRegex.Matches(script))
        {
            levels.Add(new Level
            {
                LevelNumber = int.Parse(match.Groups[1].Value),
                Ships = match.Groups[2].Value.Split(", "),
                Waves = match.Groups[3].Value.Split(", "),
                PowerUps = match.Groups[4].Value.Split(", ")
            });
        }
        return levels;
    }
}
