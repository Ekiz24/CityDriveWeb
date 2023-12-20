using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class back : MonoBehaviour
{

    public void infoBack()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);

    }
}