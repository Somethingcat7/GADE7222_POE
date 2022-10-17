using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{

    Animator anime;
    private float timer = 5f;
    private int choose;
    
    // Start is called before the first frame update
    void Start()
    {
        anime = GetComponent<Animator>();
        choose = Random.Range(1, 4);
            AnimationSwitch(choose);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            choose = Random.Range(1, 4);
            AnimationSwitch(choose);
             timer = 5f;
        }
    }

    void AnimationSwitch(int switching)
    {
        if (switching == 1)
        {
            anime.SetBool("isHappyWave", true);
            anime.SetBool("isNormalWave", false);
            anime.SetBool("isRally", false);
        }

        if (switching == 2)
        {
            anime.SetBool("isHappyWave", false);
            anime.SetBool("isNormalWave", true);
            anime.SetBool("isRally", false);
        }
        if (switching == 3)
        {
            anime.SetBool("isHappyWave", false);
            anime.SetBool("isNormalWave", false);
            anime.SetBool("isRally", true);
        }
    }
    
    
    
}
