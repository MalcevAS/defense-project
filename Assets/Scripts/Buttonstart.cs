using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Reporting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttonstart : MonoBehaviour
{

    public void LoadScene()
    {
       
        SceneManager.LoadScene(3);
    }

}
