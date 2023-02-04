using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRetry : MonoBehaviour
{
    public AudioClip retry;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void  gameRetry()
    {
        //SE        
        audioSource.PlayOneShot(retry);
        Invoke("scene", 0.2f);
    }

    void scene()
    {
        SceneManager.LoadScene("Nakata_Scene");
    }
}
