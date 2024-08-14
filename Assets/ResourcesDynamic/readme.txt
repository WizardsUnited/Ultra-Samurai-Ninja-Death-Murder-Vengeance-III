Resources Folder Structure

The Resources folder is used for assets that need to be loaded dynamically at runtime.
Folder Descriptions

    /Localization: Contains localization files and resources for supporting multiple languages.
    /Configs: Houses configuration files that might be loaded at runtime, such as game settings or character stats.
    /Prefabs: Stores prefabs that need to be instantiated at runtime using Resources.Load.
    /Audio: Contains audio files that need to be loaded dynamically, such as voice lines or situational sound effects.
    /Textures: Stores textures that are loaded on-demand to save memory during gameplay.

Examples

    /Localization: You might find JSON or CSV files here that define text strings for different languages, which are loaded at runtime to display in the UI.