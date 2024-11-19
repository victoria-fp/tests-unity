using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    private Button loadSceneButton;
    private Button playSoundButton;
    private AudioSource audioSource; 
    private AudioClip audioClip;
    
    // Start is called before the first frame update
    void Start()
    {
        loadSceneButton = GameObject.Find("Load_Scene_Button").GetComponent<Button>();
        playSoundButton = GameObject.Find("Play_Sound_Button").GetComponent<Button>();

        audioSource = playSoundButton.GetComponent<AudioSource>();
        audioClip = audioSource.GetComponent<AudioClip>();
        audioSource.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene()
    {
        SceneManager.LoadScene("EmptyScene");
    }

    public void PlaySound()
    {
        audioSource.Play();
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene("MusicScene");
    }

    public void LoadMovementScene()
    {
        SceneManager.LoadScene("MovementScene");
    }

    public void LoadAttackScene()
    {
        SceneManager.LoadScene("AttackScene");
    }
}
