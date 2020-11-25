using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingController : MonoBehaviour
{
    InputField inputField;

    public void GetPlayerName(){
        GameObject.Find("Database").GetComponent<Database>().player1_name = GameObject.Find("Canvas/Dropdown/InputField1").GetComponent<InputField>().text;
        GameObject.Find("Database").GetComponent<Database>().player2_name = GameObject.Find("Canvas/Dropdown/InputField2").GetComponent<InputField>().text;
        GameObject.Find("Database").GetComponent<Database>().player3_name = GameObject.Find("Canvas/Dropdown/InputField3").GetComponent<InputField>().text;
        GameObject.Find("Database").GetComponent<Database>().player4_name = GameObject.Find("Canvas/Dropdown/InputField4").GetComponent<InputField>().text;
        GameObject.Find("Database").GetComponent<Database>().play_member = GameObject.Find("Canvas/Dropdown").GetComponent<Dropdown>().value;
        if(GameObject.Find("Canvas/Dropdown/InputField1").GetComponent<InputField>().text == "") GameObject.Find("Database").GetComponent<Database>().player1_name = "プレイヤー1";
        if(GameObject.Find("Canvas/Dropdown/InputField2").GetComponent<InputField>().text == "") GameObject.Find("Database").GetComponent<Database>().player2_name = "プレイヤー2";
        if(GameObject.Find("Canvas/Dropdown/InputField3").GetComponent<InputField>().text == "") GameObject.Find("Database").GetComponent<Database>().player3_name = "プレイヤー3";
        if(GameObject.Find("Canvas/Dropdown/InputField4").GetComponent<InputField>().text == "") GameObject.Find("Database").GetComponent<Database>().player4_name = "プレイヤー4";
    }

    public void OnClickButton()
    {
        if(this.name == "StartButton"){
            GetPlayerName();
            Destroy(GameObject.Find("IntroMusic"));
            SceneManager.LoadScene("Scenes/HomeScene");
            AudioSource audioSource = GameObject.Find("MainMusic").GetComponent<AudioSource>();
            audioSource.Play();
        }
        else if(this.name == "BackButton"){
            Destroy(GameObject.Find("IntroMusic"));
            SceneManager.LoadScene("Scenes/TitleScene");
        }
    }

    public void handleActive(bool b1, bool b2, bool b3, bool b4){
        transform.Find("InputField1").gameObject.SetActive(b1);
        transform.Find("InputField2").gameObject.SetActive(b2);
        transform.Find("InputField3").gameObject.SetActive(b3);
        transform.Find("InputField4").gameObject.SetActive(b4);
    }

    public void CheckPlayerNumber(){
        if(this.name == "Dropdown"){
            if(this.gameObject.GetComponent<Dropdown>().value == 0)
            {
                handleActive(true, true, false, false);
            }
            else if(this.gameObject.GetComponent<Dropdown>().value == 1)
            {
                handleActive(true, true, true, false);
            }
            else if (this.gameObject.GetComponent<Dropdown>().value == 2)
            {
                handleActive(true, true, true, true);
            }
        }

    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckPlayerNumber();
    }
}
