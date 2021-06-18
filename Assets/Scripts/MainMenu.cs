using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{

    private const float cameraRotationSpeed = 3.0f;
    public GameObject levelButtonPrefab;
    public GameObject levelButtonContainer;

    private Transform cameraTransform;
    private Transform cameraDesiredLookAt;
    private void Start()
    {
        Sprite[] thumbnails = Resources.LoadAll<Sprite>("Levels");
        foreach(Sprite thumbnail in thumbnails)
        {
            cameraTransform = Camera.main.transform;
        }
    }

    private void Update()
    {
        if (cameraDesiredLookAt != null)
        {
            cameraTransform.rotation = Quaternion.Slerp(cameraTransform.rotation, cameraDesiredLookAt.rotation, cameraRotationSpeed * Time.deltaTime);
        }
    }
    private void LoadLevel(string sceneName)
    {
        Debug.Log(sceneName);
        SceneManager.LoadScene(sceneName);
    }

    public void LookAtMenu(Transform menuTransform)
    {
        cameraDesiredLookAt = menuTransform;
    }
}
