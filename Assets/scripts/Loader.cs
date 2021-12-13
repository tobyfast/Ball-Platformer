using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Loader
{
    public enum scene
    {
        level1,
    }
    public static void LoadGame(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }

}