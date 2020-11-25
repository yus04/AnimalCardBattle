using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeController : MonoBehaviour
{
    int play_member;
    int order;

    public void initialize(){
        play_member = GameObject.Find("Database").GetComponent<Database>().play_member;
        order = GameObject.Find("Database").GetComponent<Database>().order;
    }

    public void OnClickButton(){
        // まだ次の順番の人がいる場合
        if(play_member + 1 > order){
            GameObject.Find("Database").GetComponent<Database>().order += 1;
            SceneManager.LoadScene("Scenes/HomeScene");
        }
        // 次の順番の人がいない場合
        else{
            GameObject.Find("Database").GetComponent<Database>().turn += 1;
            GameObject.Find("Database").GetComponent<Database>().order = 0;
            SceneManager.LoadScene("Scenes/FieldScene");
        }
    }
    
    public void MakeButtonText(){
        // まだ次の順番の人がいる場合
        if(play_member + 1 > order){
            var order = GameObject.Find("Database").GetComponent<Database>().order;
            if(order == 0){
                GameObject.Find("Canvas/Panel/Text").GetComponent<Text>().text = "次は" + GameObject.Find("Database").GetComponent<Database>().player2_name + "の順番です";
            }
            else if(order == 1){
                GameObject.Find("Canvas/Panel/Text").GetComponent<Text>().text = "次は" + GameObject.Find("Database").GetComponent<Database>().player3_name + "の順番です";
            }
            else if(order == 2){
                GameObject.Find("Canvas/Panel/Text").GetComponent<Text>().text = "次は" + GameObject.Find("Database").GetComponent<Database>().player4_name + "の順番です";
            }
        }
        // 次の順番の人がいない場合
        else{
            GameObject.Find("Canvas/Panel/Text").GetComponent<Text>().text = "勝敗の結果を確認する";
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        initialize();
        MakeButtonText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
