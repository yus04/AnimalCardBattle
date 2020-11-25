using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleController : MonoBehaviour
{
    public void OnClickStartButton()
    {
        if(this.name == "Button1"){
            GameObject.Find("Database").GetComponent<Database>().play_mode = 1;
            SceneManager.LoadScene("Scenes/SettingScene");
        }
        else if(this.name == "Button2"){
            GameObject.Find("Database").GetComponent<Database>().play_mode = 2;
            SceneManager.LoadScene("Scenes/SettingScene");
        }
        else if(this.name == "Button3"){
            SceneManager.LoadScene("Scenes/DescriptionScene");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
