using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{
    private Button loadMenuButton;
    private AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        loadMenuButton = GameObject.Find("Load_Menu_Button").GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
