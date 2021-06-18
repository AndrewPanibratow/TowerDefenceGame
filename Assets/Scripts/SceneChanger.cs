using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void Change_Scene(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }
}
