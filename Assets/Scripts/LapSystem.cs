using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapSystem : MonoBehaviour
{
    [SerializeField] Text Text1;
    [SerializeField] Text Text2;
    [SerializeField] GameObject panel;
    [SerializeField] Button button;
    private int Lap = 0;

    private void Start()
    {
        Time.timeScale = 1;

        Text1.text = Text1.text = "Lap: " + Lap.ToString() + "/3";
        Text2.text = Text2.text = "Lap: " + Lap.ToString() + "/3";
        panel.SetActive(false);
        
        button.gameObject.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (Lap < 3)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                Lap += 1;
                Text1.text = "Lap: " + Lap.ToString() + "/3";
                Text2.text = Text1.text = "Lap: " + Lap.ToString() + "/3";

            }
        }
        else
        {
            Time.timeScale = 0;
            button.gameObject.SetActive(true);
            panel.SetActive(true);
        }
    }
}
