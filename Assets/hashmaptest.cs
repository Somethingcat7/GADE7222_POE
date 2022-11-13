using MyHashMap;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class hashmaptest : MonoBehaviour
{
    [SerializeField] private List<AudioClip> myclips;
    // Start is called before the first frame update
        AudioSource audioSource;
        
    void Start()
    {
        var hashmap = new Hashmap<string, AudioClip>(10);
        foreach (var clip in myclips)
        {
            hashmap.Add(clip.name, clip);
        }
        
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(hashmap["bad-to-the-bone"]);          
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
