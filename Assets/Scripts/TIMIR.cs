using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TIMIR : MonoBehaviour
{
    public Text timer;
    public float lifeTime = 60f;
    private float gameTime;
    private void Update()
    {
        timer.text = "Осталось:" + lifeTime;
        gameTime += 1 * Time.deltaTime;
        if (gameTime >= 1)
        {
            lifeTime -= 1;
            gameTime = 0;
            if (lifeTime == 0)
            {
                SceneManager.LoadScene(0);
            }

        }
      
    }
}     
