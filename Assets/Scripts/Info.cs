using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Info : MonoBehaviour
{

    public void infoScene()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);

    }
}
