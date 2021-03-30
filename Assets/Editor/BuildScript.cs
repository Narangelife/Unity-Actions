using System.Linq;
using UnityEditor;

public class BuildScript
{
    [MenuItem("BuildScript/Build")]
    public static void Build()
    {
        BuildPipeline.BuildPlayer(ScenePaths, "Build/Application.apk", BuildTarget.StandaloneWindows64, BuildOptions.CompressWithLz4);
    }

    static string[] ScenePaths => EditorBuildSettings.scenes.Select(scene => scene.path).ToArray();
}
