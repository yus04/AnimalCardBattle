using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CardController : MonoBehaviour {

    int width;
    int height;
    int turn;
    int order;
    int record1;
    int record2;
    int record3;
    int record4;
    int record5;

    void initialize(){
        width = Screen.width;
        height = Screen.height;
        turn = GameObject.Find("Database").GetComponent<Database>().turn;
        order = GameObject.Find("Database").GetComponent<Database>().order;
        // プレイヤー1
        if(order == 0){
            record1 = GameObject.Find("Database").GetComponent<Database>().player1_record1;
            record2 = GameObject.Find("Database").GetComponent<Database>().player1_record2;
            record3 = GameObject.Find("Database").GetComponent<Database>().player1_record3;
            record4 = GameObject.Find("Database").GetComponent<Database>().player1_record4;
            record5 = GameObject.Find("Database").GetComponent<Database>().player1_record5;
        }
        // プレイヤー2
        if(order == 1){
            record1 = GameObject.Find("Database").GetComponent<Database>().player2_record1;
            record2 = GameObject.Find("Database").GetComponent<Database>().player2_record2;
            record3 = GameObject.Find("Database").GetComponent<Database>().player2_record3;
            record4 = GameObject.Find("Database").GetComponent<Database>().player2_record4;
            record5 = GameObject.Find("Database").GetComponent<Database>().player2_record5;
        }
        // プレイヤー3
        if(order == 2){
            record1 = GameObject.Find("Database").GetComponent<Database>().player3_record1;
            record2 = GameObject.Find("Database").GetComponent<Database>().player3_record2;
            record3 = GameObject.Find("Database").GetComponent<Database>().player3_record3;
            record4 = GameObject.Find("Database").GetComponent<Database>().player3_record4;
            record5 = GameObject.Find("Database").GetComponent<Database>().player3_record5;
        }
        // プレイヤー4
        if(order == 3){
            record1 = GameObject.Find("Database").GetComponent<Database>().player4_record1;
            record2 = GameObject.Find("Database").GetComponent<Database>().player4_record2;
            record3 = GameObject.Find("Database").GetComponent<Database>().player4_record3;
            record4 = GameObject.Find("Database").GetComponent<Database>().player4_record4;
            record5 = GameObject.Find("Database").GetComponent<Database>().player4_record5;
        }
    }

    void handleCard(int record_num){
        if(record_num == 1)transform.Find("CatCard").gameObject.SetActive(false);
        else if(record_num == 2)transform.Find("PenguinCard").gameObject.SetActive(false);
        else if(record_num == 3)transform.Find("SheepCard1").gameObject.SetActive(false);
        else if(record_num == 4)transform.Find("SheepCard2").gameObject.SetActive(false);
        else if(record_num == 5)transform.Find("SheepCard3").gameObject.SetActive(false);
    }

    void handleActive(){
        if(turn > 0)handleCard(record1);
        if(turn > 1)handleCard(record2);
        if(turn > 2)handleCard(record3);
        if(turn > 3)handleCard(record4);
    }

    void handleDisplay(string s){
        // 初期化
        transform.Find("Display/Cat").gameObject.SetActive(false);
        transform.Find("Display/Penguin").gameObject.SetActive(false);
        transform.Find("Display/Sheep1").gameObject.SetActive(false);
        transform.Find("Display/Sheep2").gameObject.SetActive(false);
        transform.Find("Display/Sheep3").gameObject.SetActive(false);

        if(s == "CatCard"){
            transform.Find("Display/Cat").gameObject.SetActive(true);
        }
        else if(s == "PenguinCard"){
            transform.Find("Display/Penguin").gameObject.SetActive(true);
        }
        else if(s == "SheepCard1"){
            transform.Find("Display/Sheep1").gameObject.SetActive(true);
        }
        else if(s == "SheepCard2"){
            transform.Find("Display/Sheep2").gameObject.SetActive(true);
        }
        else if(s == "SheepCard3"){
            transform.Find("Display/Sheep3").gameObject.SetActive(true);
        }
    }

    void click(){
        if (Input.GetMouseButtonUp(0))
        {
            Vector3 mousePosition = Input.mousePosition;
            var x_rate = mousePosition.x / width;
            var y_rate = mousePosition.y / height;
            if(y_rate >= 0.02 && y_rate <= 0.3){
                // 1番目のカード
                if(x_rate >= 0.14 && x_rate <= 0.24){
                    handleDisplay(transform.GetChild(0).gameObject.name);
                }
                // 2番目のカード
                else if(x_rate >= 0.29 && x_rate <= 0.39){
                    handleDisplay(transform.GetChild(1).gameObject.name);
                }
                // 3番目のカード
                else if(x_rate >= 0.45 && x_rate <= 0.55){
                    handleDisplay(transform.GetChild(2).gameObject.name);
                }
                // 4番目のカード
                else if(x_rate >= 0.60 && x_rate <= 0.70){
                    handleDisplay(transform.GetChild(3).gameObject.name);
                }
                // 5番目のカード
                else if(x_rate >= 0.75 && x_rate <= 0.85){
                    handleDisplay(transform.GetChild(4).gameObject.name);
                }
            }   
        }
    }

    // Use this for initialization
    void Start () {
        initialize();
        handleActive();
    }

    // Update is called once per frame
    void Update()
    {
        click();
    }
}