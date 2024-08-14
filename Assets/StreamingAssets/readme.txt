StreamingAssets Folder Structure

The StreamingAssets folder is for assets that should be included in the game’s build but are accessed at runtime, usually from disk.
Folder Descriptions

    /Videos: Stores video files that are played within the game, such as cutscenes or background animations.
    /ExternalConfigs: Contains configuration files that might need to be modified outside of Unity, allowing for updates without rebuilding the game.

Examples

    /ExternalConfigs: A JSON file here could be used to store settings that are read by the game at startup, such as server addresses or user preferences.