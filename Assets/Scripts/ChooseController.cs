using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseController : MonoBehaviour
{
    void record(int turn, int num, int order){
        if(order == 0){
            if(turn == 0){
                GameObject.Find("Database").GetComponent<Database>().player1_record1 = num;
            }
            else if(turn == 1){
                GameObject.Find("Database").GetComponent<Database>().player1_record2 = num;
            }
            else if(turn == 2){
                GameObject.Find("Database").GetComponent<Database>().player1_record3 = num;
            }
            else if(turn == 3){
                GameObject.Find("Database").GetComponent<Database>().player1_record4 = num;
            }
            else if(turn == 4){
                GameObject.Find("Database").GetComponent<Database>().player1_record5 = num;
            }
        }
        else if(order == 1){
            if(turn == 0){
                GameObject.Find("Database").GetComponent<Database>().player2_record1 = num;
            }
            else if(turn == 1){
                GameObject.Find("Database").GetComponent<Database>().player2_record2 = num;
            }
            else if(turn == 2){
                GameObject.Find("Database").GetComponent<Database>().player2_record3 = num;
            }
            else if(turn == 3){
                GameObject.Find("Database").GetComponent<Database>().player2_record4 = num;
            }
            else if(turn == 4){
                GameObject.Find("Database").GetComponent<Database>().player2_record5 = num;
            }
        }
        else if(order == 2){
            if(turn == 0){
                GameObject.Find("Database").GetComponent<Database>().player3_record1 = num;
            }
            else if(turn == 1){
                GameObject.Find("Database").GetComponent<Database>().player3_record2 = num;
            }
            else if(turn == 2){
                GameObject.Find("Database").GetComponent<Database>().player3_record3 = num;
            }
            else if(turn == 3){
                GameObject.Find("Database").GetComponent<Database>().player3_record4 = num;
            }
            else if(turn == 4){
                GameObject.Find("Database").GetComponent<Database>().player3_record5 = num;
            }
        }
        else if(order == 3){
            if(turn == 0){
                GameObject.Find("Database").GetComponent<Database>().player4_record1 = num;
            }
            else if(turn == 1){
                GameObject.Find("Database").GetComponent<Database>().player4_record2 = num;
            }
            else if(turn == 2){
                GameObject.Find("Database").GetComponent<Database>().player4_record3 = num;
            }
            else if(turn == 3){
                GameObject.Find("Database").GetComponent<Database>().player4_record4 = num;
            }
            else if(turn == 4){
                GameObject.Find("Database").GetComponent<Database>().player4_record5 = num;
            }
        }
    }

    public void OnClickStartButton()
    {
        var order = GameObject.Find("Database").GetComponent<Database>().order;
        if(this.name == "CatButton"){
            record(GameObject.Find("Database").GetComponent<Database>().turn, 1, order);
        }
        else if(this.name == "PenguinButton"){
            record(GameObject.Find("Database").GetComponent<Database>().turn, 2, order);
        }
        else if(this.name == "SheepButton1"){
           record(GameObject.Find("Database").GetComponent<Database>().turn, 3, order);
        }
        else if(this.name == "SheepButton2"){
           record(GameObject.Find("Database").GetComponent<Database>().turn, 4, order);
        }
        else if(this.name == "SheepButton3"){
           record(GameObject.Find("Database").GetComponent<Database>().turn, 5, order);
        }
        // 1人モード
        if(GameObject.Find("Database").GetComponent<Database>().play_mode == 1){
            GameObject.Find("Database").GetComponent<Database>().turn += 1;
            SceneManager.LoadScene("Scenes/FieldScene");
        }
        // 複数人モード
        else SceneManager.LoadScene("Scenes/ChangeScene");
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
