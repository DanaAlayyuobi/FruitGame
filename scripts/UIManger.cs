using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UIManger : MonoBehaviour
{
    public static int clickedOnCounter;
    public Text textCounter;
    public static int MissedCounter;
    public Text MissedtextCounter;
    public GameObject gameOverUI;
    // Start is called before the first frame update
    void Start()
    {
        clickedOnCounter = 0;
        MissedCounter = 0;
        Time.timeScale = 1;

    }
 


    // Update is called once per frame
    void Update()
    {
        textCounter.text = "x:" + clickedOnCounter;
        MissedtextCounter.text = "x: " + MissedCounter;

        if (MissedCounter > 10)
        {
            gameOverUI.SetActive(true);
            Time.timeScale=0;
        }

    }
    public void replayButton() {
        SceneManager.LoadScene("SampleScene");
       
        
    }
}
