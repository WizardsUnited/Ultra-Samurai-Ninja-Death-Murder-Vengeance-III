Editor Folder Structure

This Editor folder contains custom scripts and tools to extend the Unity Editor's functionality for this project.
Folder Descriptions

    /CustomTools: Contains scripts that add new tools and utilities specific to this project within the Unity Editor.
    /EditorWindows: Includes custom editor windows that provide additional interfaces or panels within the Unity Editor.
    /Gizmos: Holds custom Gizmo scripts to visualize game objects in the Scene view with unique icons or handles.
    /Inspector: Contains scripts that modify or extend the default behavior of the Inspector window for specific components or assets.
    /MenuItems: Contains scripts that add new options or actions to the Unity Editor's menus, such as context menus or the top menu bar.

Examples

    /EditorWindows: A script here could create a custom window to manage complex game configurations via an intuitive UI rather than through the Inspector.
    /MenuItems: Scripts in this folder could add new commands under the Assets or GameObject menus, like the Create Text File example that allows for quick creation of .txt files directly within the Unity Editor.
    /Inspector: A script might allow custom handling and display of a ScriptableObject, providing tailored editor functionality such as collapsible sections or validation checks directly in the Inspector.