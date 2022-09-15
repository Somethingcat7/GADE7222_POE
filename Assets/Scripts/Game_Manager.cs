using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{
    public float Timer = 60;
    public Text text;
    public Button button;
    public int Checkpoints = 0;

    private void Start()
    {
        Time.timeScale = 1;
        button.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        Debug.Log(Timer.ToString());
        text.text = "Time Left = " + Timer.ToString("0");

        if (Timer <= 0)
        {
            text.text = "You Lose";
            button.gameObject.SetActive(true);
            Time.timeScale = 0;
        }

        if (Checkpoints == 6)
        {
            Time.timeScale = 0;
            text.text = "You Won!";
            button.gameObject.SetActive(true);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("Checkpoint Race");
    }
}
