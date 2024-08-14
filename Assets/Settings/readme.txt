Settings Folder Structure

The Settings folder organizes project-specific configuration files and settings that govern various aspects of the game.
Folder Descriptions

    /Graphics: Stores settings that control the graphical quality and rendering behavior of the game.
    /Input: Includes custom input configurations, such as key bindings and control schemes.
    /Physics: Holds settings that define the physical interactions within the game, including gravity and collision layers.
    /Quality: Contains settings that adjust the quality levels for different platforms or performance profiles.

Examples

    /Graphics: A ScriptableObject might be used here to store different quality presets, which are applied depending on the player's hardware or settings selection.


--GraphicsSettings ScriptableObject--

csharp

using UnityEngine;

[CreateAssetMenu(fileName = "GraphicsSettings", menuName = "Settings/GraphicsSettings", order = 1)]
public class GraphicsSettings : ScriptableObject
{
    public int resolutionWidth;
    public int resolutionHeight;
    public bool fullscreen;
    public int qualityLevel;
}

--InputSettings ScriptableObject--

csharp

using UnityEngine;

[CreateAssetMenu(fileName = "InputSettings", menuName = "Settings/InputSettings", order = 2)]
public class InputSettings : ScriptableObject
{
    public KeyCode jumpKey;
    public KeyCode crouchKey;
    public KeyCode shootKey;
}