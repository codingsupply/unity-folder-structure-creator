using UnityEngine;
using UnityEditor;
using System.IO;
using System.Diagnostics;

public class CreateGAMENAMEFolders
{
    [MenuItem("GAMENAME/Setup/Create Project Folder Structure")]
    public static void CreateFolders()
    {
        string[] folders = new string[]
        {
            "Assets/GAMENAME/_Game/Core/Architecture",
            "Assets/GAMENAME/_Game/Core/Interfaces",
            "Assets/GAMENAME/_Game/Core/Events",
            "Assets/GAMENAME/_Game/Core/Extensions",
            "Assets/GAMENAME/_Game/Core/Constants",
            "Assets/GAMENAME/_Game/Services/Timer",
            "Assets/GAMENAME/_Game/Services/Reward",
            "Assets/GAMENAME/_Game/Services/Save",
            "Assets/GAMENAME/_Game/Services/World",
            "Assets/GAMENAME/_Game/Services/NPC",
            "Assets/GAMENAME/_Game/Services/Audio",
            "Assets/GAMENAME/_Game/Services/Weather",
            "Assets/GAMENAME/_Game/Services/Analytics",
            "Assets/GAMENAME/_Game/Services/Social",
            "Assets/GAMENAME/_Game/Services/Notification",
            "Assets/GAMENAME/_Game/Services/Tutorial",
            "Assets/GAMENAME/_Game/Gameplay/MiniGames/Fishing",
            "Assets/GAMENAME/_Game/Gameplay/MiniGames/Gardening",
            "Assets/GAMENAME/_Game/Gameplay/MiniGames/Crafting",
            "Assets/GAMENAME/_Game/Gameplay/MiniGames/_Shared",
            "Assets/GAMENAME/_Game/Gameplay/World/Furniture",
            "Assets/GAMENAME/_Game/Gameplay/World/Rooms",
            "Assets/GAMENAME/_Game/Gameplay/World/Island",
            "Assets/GAMENAME/_Game/Gameplay/World/Interaction",
            "Assets/GAMENAME/_Game/Gameplay/NPCs/AI",
            "Assets/GAMENAME/_Game/Gameplay/NPCs/Dialogue",
            "Assets/GAMENAME/_Game/Gameplay/NPCs/Characters",
            "Assets/GAMENAME/_Game/Gameplay/NPCs/Quests",
            "Assets/GAMENAME/_Game/Gameplay/Player/Input",
            "Assets/GAMENAME/_Game/Gameplay/Player/Camera",
            "Assets/GAMENAME/_Game/Gameplay/Player/Progression",
            "Assets/GAMENAME/_Game/UI/Core",
            "Assets/GAMENAME/_Game/UI/Screens/MainMenu",
            "Assets/GAMENAME/_Game/UI/Screens/Timer",
            "Assets/GAMENAME/_Game/UI/Screens/Home",
            "Assets/GAMENAME/_Game/UI/Screens/Shop",
            "Assets/GAMENAME/_Game/UI/Screens/Inventory",
            "Assets/GAMENAME/_Game/UI/Screens/Statistics",
            "Assets/GAMENAME/_Game/UI/Screens/Settings",
            "Assets/GAMENAME/_Game/UI/Widgets",
            "Assets/GAMENAME/_Game/UI/Animations",
            "Assets/GAMENAME/_Game/UI/Mobile",
            "Assets/GAMENAME/_Game/UI/Notifications",
            "Assets/GAMENAME/_Game/Data/Settings",
            "Assets/GAMENAME/_Game/Data/Localization",
            "Assets/GAMENAME/_Game/Data/Balance",
            "Assets/GAMENAME/_Game/Data/Analytics",
            "Assets/GAMENAME/Art/3D/Characters/NPCs",
            "Assets/GAMENAME/Art/3D/Characters/Player",
            "Assets/GAMENAME/Art/3D/Characters/Animations",
            "Assets/GAMENAME/Art/3D/Environment/Furniture",
            "Assets/GAMENAME/Art/3D/Environment/Props",
            "Assets/GAMENAME/Art/3D/Environment/Nature",
            "Assets/GAMENAME/Art/3D/Environment/Seasonal",
            "Assets/GAMENAME/Art/3D/Environment/Architecture",
            "Assets/GAMENAME/Art/3D/MiniGames/Fishing",
            "Assets/GAMENAME/Art/3D/MiniGames/Gardening",
            "Assets/GAMENAME/Art/3D/MiniGames/Crafting",
            "Assets/GAMENAME/Art/2D/UI/Icons",
            "Assets/GAMENAME/Art/2D/UI/Buttons",
            "Assets/GAMENAME/Art/2D/UI/Backgrounds",
            "Assets/GAMENAME/Art/2D/UI/Mobile",
            "Assets/GAMENAME/Art/2D/Portraits",
            "Assets/GAMENAME/Art/2D/Items",
            "Assets/GAMENAME/Art/2D/HUD",
            "Assets/GAMENAME/Art/Materials/Characters",
            "Assets/GAMENAME/Art/Materials/Environment",
            "Assets/GAMENAME/Art/Materials/UI",
            "Assets/GAMENAME/Art/Materials/Effects",
            "Assets/GAMENAME/Art/Materials/Stylized",
            "Assets/GAMENAME/Art/Textures/Characters",
            "Assets/GAMENAME/Art/Textures/Environment",
            "Assets/GAMENAME/Art/Textures/UI",
            "Assets/GAMENAME/Art/Textures/Effects",
            "Assets/GAMENAME/Art/Shaders/Environment",
            "Assets/GAMENAME/Art/Shaders/Characters",
            "Assets/GAMENAME/Art/Shaders/UI",
            "Assets/GAMENAME/Art/Shaders/Effects",
            "Assets/GAMENAME/Art/VFX/Particles",
            "Assets/GAMENAME/Art/VFX/Atmosphere",
            "Assets/GAMENAME/Art/VFX/Weather",
            "Assets/GAMENAME/Art/VFX/Rewards",
            "Assets/GAMENAME/Audio/Music/Ambient",
            "Assets/GAMENAME/Audio/Music/Focus",
            "Assets/GAMENAME/Audio/Music/Seasonal",
            "Assets/GAMENAME/Audio/Music/Dynamic",
            "Assets/GAMENAME/Audio/SFX/UI",
            "Assets/GAMENAME/Audio/SFX/Environment",
            "Assets/GAMENAME/Audio/SFX/MiniGames",
            "Assets/GAMENAME/Audio/SFX/NPCs",
            "Assets/GAMENAME/Audio/SFX/Notifications",
            "Assets/GAMENAME/Audio/Voice/NPCs",
            "Assets/GAMENAME/Audio/Voice/Tutorial",
            "Assets/GAMENAME/Audio/Ambient/Nature",
            "Assets/GAMENAME/Audio/Ambient/Indoor",
            "Assets/GAMENAME/Audio/Ambient/Weather",
            "Assets/GAMENAME/Prefabs/Core",
            "Assets/GAMENAME/Prefabs/UI",
            "Assets/GAMENAME/Prefabs/Characters",
            "Assets/GAMENAME/Prefabs/Environment",
            "Assets/GAMENAME/Prefabs/MiniGames",
            "Assets/GAMENAME/Prefabs/Effects",
            "Assets/GAMENAME/Prefabs/Mobile",
            "Assets/GAMENAME/Scenes/Core",
            "Assets/GAMENAME/Scenes/Gameplay",
            "Assets/GAMENAME/Scenes/MiniGames",
            "Assets/GAMENAME/Scenes/Testing",
            "Assets/GAMENAME/Scenes/Mobile",
            "Assets/GAMENAME/StreamingAssets/Localization",
            "Assets/GAMENAME/StreamingAssets/Configuration",
            "Assets/GAMENAME/StreamingAssets/Analytics",
            "Assets/GAMENAME/Plugins/AStarPathfinding",
            "Assets/GAMENAME/Plugins/DialogueSystem",
            "Assets/GAMENAME/Plugins/DOTween",
            "Assets/GAMENAME/Plugins/EasySave",
            "Assets/GAMENAME/Plugins/Animancer",
            "Assets/GAMENAME/Plugins/AmplifyShader",
            "Assets/GAMENAME/Plugins/AtmosphericFog",
            "Assets/GAMENAME/Plugins/StylizedGrass",
            "Assets/GAMENAME/Plugins/OdinInspector",
            "Assets/GAMENAME/Plugins/Mobile",
            "Assets/GAMENAME/Editor/Core",
            "Assets/GAMENAME/Editor/Tools",
            "Assets/GAMENAME/Editor/Inspectors",
            "Assets/GAMENAME/Editor/Windows",
            "Assets/GAMENAME/Editor/Build",
            "Assets/GAMENAME/Editor/Testing",
            "Assets/GAMENAME/Documentation/Architecture",
            "Assets/GAMENAME/Documentation/API",
            "Assets/GAMENAME/Documentation/GameDesign",
            "Assets/GAMENAME/Documentation/Art",
            "Assets/GAMENAME/Documentation/Mobile",
            // Additions
            "Assets/GAMENAME/Gizmos",                       // Gizmos for debugging
            "Assets/GAMENAME/Resources",                    // Unity Resources (use sparingly!)
            "Assets/GAMENAME/Addressables",                 // For Addressables System (future-proof)
            "Assets/GAMENAME/Tests/Editor",                 // Editor Unit Tests
            "Assets/GAMENAME/Tests/Runtime"                 // Runtime Unit Tests
        };

        foreach (var folder in folders)
        {
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
                // Optional: Readme for Orientierung
                string readme = folder + "/_README.md";
                File.WriteAllText(readme, $"# {folder.Replace("Assets/GAMENAME/", "")}\n\nBeschreibung und Team-Notizen für diesen Ordner.");
            }
        }

        AssetDatabase.Refresh();
        UnityEngine.Debug.Log("📁 DONE!");
    }
}
