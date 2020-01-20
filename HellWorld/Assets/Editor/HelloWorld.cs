using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class HelloWorld : Editor
{
    [MenuItem("Build/Build Android")]
    public static void CmdBuild()
    {
        EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.Android);
        
        List<string> sceneList = new List<string>();
        EditorBuildSettingsScene[] temp = EditorBuildSettings.scenes;
        for (int i = 0; i < temp.Length; i++)
        {
            sceneList.Add(temp[i].path);
        }

        BuildPipeline.BuildPlayer(sceneList.ToArray(), "./HelloWorld.apk", BuildTarget.Android, BuildOptions.None);
        
    }
}
