namespace GalaxyShooterDSL.Models;

public class Level
{
    public int LevelNumber { get; set; }  // Represents the level number, e.g., "1" for Level 1.
    public string[] Ships { get; set; }  // An array of ship names used in the level (e.g., ["Hero"]).
    public string[] Waves { get; set; }  // An array of wave names associated with the level (e.g., ["Wave 1", "Wave 2"]).
    public string[] PowerUps { get; set; } // An array of power-up names available in the level (e.g., ["Shield", "SpeedBoost"]).
}
