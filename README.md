# Pumkinfish-Ships-Mod
Mod example for my game
# Warnings
The Script.json and Icon.png/jpg/jpeg name can NOT be changed
# How to use
Take the example mod and use your own stuff. for the prefab or into a new Unity project and use the provided scripts as an example. Once you have your assetbundle put it in the mod folder and change the stuff you want in the Json.
# How to make a mod
Make a folder in the mods folder, name it your mod name. Inside place your Icon.png/jpg/jpeg and your Script.json. Download the example unity project, and create your stuff. Remember to add your textures, prefab(s), and any new scripts into the asset bundle. Copy the name of the enemy prefab(s) and put it in the Script.json
## How to right the Script.json
For single enemies:
{
    "Name": "Evil Bastard",
    "Description": "Test",
    "Prefab": "EnemyPrefabName (CHANGE THIS)",
    "SpawnInWaves": true,
    "SpawnInProtect": false,
    "SpawnInHoldout": false,
    "SpawnInObjective": true,
    "WavesItAppears": [
        1,
        3,
        5
    ],
    "Enabled": true
}
For more than 1 enemy use
[
 {
    "Name": "Evil Bastard",
    "Description": "Test",
    "Prefab": "EnemyPrefabName (CHANGE THIS)",
    "SpawnInWaves": true,
    "SpawnInProtect": false,
    "SpawnInHoldout": false,
    "SpawnInObjective": true,
    "WavesItAppears": [
        1,
        3,
        5
    ],
    "Enabled": true
},
{
    "Name": "Evil Bastard",
    "Description": "Test",
    "Prefab": "EnemyPrefabName (CHANGE THIS)",
    "SpawnInWaves": true,
    "SpawnInProtect": false,
    "SpawnInHoldout": false,
    "SpawnInObjective": true,
    "WavesItAppears": [
        1,
        3,
        5
    ],
    "Enabled": true
}
]
