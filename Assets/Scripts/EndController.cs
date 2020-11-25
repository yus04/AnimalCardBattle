using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndController : MonoBehaviour
{
    int score1;
    int score2;
    int score3;
    int score4;
    bool win1;
    bool win2;
    bool win3;
    bool win4;

    void initialize(){
        score1 = GameObject.Find("Database").GetComponent<Database>().score1;
        score2 = GameObject.Find("Database").GetComponent<Database>().score2;
        score3 = GameObject.Find("Database").GetComponent<Database>().score3;
        score4 = GameObject.Find("Database").GetComponent<Database>().score4;
        win1 = false;
        win2 = false;
        win3 = false;
        win4 = false;
    }

    void handleActive(){
        if(score1 >= score2 && score1 >= score3 && score1 >= score4)win1 = true;
        if(score2 >= score1 && score2 >= score3 && score2 >= score4)win2 = true;
        if(score3 >= score1 && score3 >= score2 && score3 >= score4)win3 = true;
        if(score4 >= score1 && score4 >= score2 && score4 >= score3)win4 = true;
        if(this.name == "Characters"){
            transform.Find("Rin").gameObject.SetActive(win1);
            transform.Find("Satomi").gameObject.SetActive(win2);
            transform.Find("Arisa").gameObject.SetActive(win3);
            transform.Find("Tatsumi").gameObject.SetActive(win4);
            if(win1)GameObject.Find("Rin/Canvas/Panel/Text").GetComponent<Text>().text = GameObject.Find("Database").GetComponent<Database>().player1_name;
            if(win2)GameObject.Find("Satomi/Canvas/Panel/Text").GetComponent<Text>().text = GameObject.Find("Database").GetComponent<Database>().player2_name;
            if(win3)GameObject.Find("Arisa/Canvas/Panel/Text").GetComponent<Text>().text = GameObject.Find("Database").GetComponent<Database>().player3_name;
            if(win4)GameObject.Find("Tatsumi/Canvas/Panel/Text").GetComponent<Text>().text = GameObject.Find("Database").GetComponent<Database>().player4_name;
        }
        else{
            string name = "";
            if(win1)name = name + GameObject.Find("Database").GetComponent<Database>().player1_name;
            if(win2)name = name + " " + GameObject.Find("Database").GetComponent<Database>().player2_name;
            if(win3)name = name + " " + GameObject.Find("Database").GetComponent<Database>().player3_name;
            if(win4)name = name + " " + GameObject.Find("Database").GetComponent<Database>().player4_name;
            if(this.name == "Name1"){
                this.GetComponent<Text>().text = name;
            }
            else if(this.name == "Name2"){
                this.GetComponent<Text>().text = name;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        initialize();
        handleActive();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
