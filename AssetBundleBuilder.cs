using UnityEngine;
using UnityEditor;

public class AssetBundleBuilder
{
    [MenuItem("Assets/Build AssetBundles")]
    static void BuildAllAssetBundles()
    {
        string outputPath = "Assets/AssetBundles";
        if (!System.IO.Directory.Exists(outputPath))
        {
            System.IO.Directory.CreateDirectory(outputPath);
        }
        BuildPipeline.BuildAssetBundles(outputPath, 
            BuildAssetBundleOptions.None, 
            BuildTarget.StandaloneWindows64);
        Debug.Log("AssetBundles built to " + outputPath);
    }
}