using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;
using UnityEngine.UI;

public class FieldController : MonoBehaviour
{
    int turn;
    int order;
    int play_member;
    int player1;
    int player2;
    int player3;
    int player4;
    bool result1;
    bool result2;
    bool result3;
    bool result4;

    async void winAnimal(){
        await Task.Delay(2000);
        if((player1 == 1 || player2 == 1 || player3 == 1 || player4 == 1) && victory(1)){
            // 皇帝ネコ表示
            transform.Find("CatController").gameObject.SetActive(true);
            await Task.Delay(3000);
            transform.Find("CatController").gameObject.SetActive(false);
        }
        else if((player1 == 2 || player2 == 2 || player3 == 2 || player4 == 2) && victory(2)){
            // 奴隷ペンギン表示
            transform.Find("PenguinController").gameObject.SetActive(true);
            await Task.Delay(3000);
            transform.Find("PenguinController").gameObject.SetActive(false);
        }
        else if((player1 == 3 || player2 == 3 || player3 == 3 || player4 == 3) && victory(3)){
            // 平民ひつじ表示
            transform.Find("SheepController").gameObject.SetActive(true);
            await Task.Delay(3000);
            transform.Find("SheepController").gameObject.SetActive(false);
        }
        else if((player1 == 4 || player2 == 4 || player3 == 4 || player4 == 4) && victory(4)){
            // 平民ひつじ表示
            transform.Find("SheepController").gameObject.SetActive(true);
            await Task.Delay(3000);
            transform.Find("SheepController").gameObject.SetActive(false);
        }
        else if((player1 == 5 || player2 == 5 || player3 == 5 || player4 == 5) && victory(5)){
            // 平民ひつじ表示
            transform.Find("SheepController").gameObject.SetActive(true);
            await Task.Delay(3000);
            transform.Find("SheepController").gameObject.SetActive(false);
        }
        else{
            // 引き分け
            transform.Find("DrawController").gameObject.SetActive(true);
            await Task.Delay(3000);
            transform.Find("DrawController").gameObject.SetActive(false);
        }
    }

    async void scoreDisplay(){
        await Task.Delay(5000);
        transform.Find("ScoreField").gameObject.SetActive(true);
        if(victory(player1))GameObject.Find("ScoreField/Player1/Point").GetComponent<Text>().text = "+1";
        else GameObject.Find("ScoreField/Player1/Point").GetComponent<Text>().text = "+0";
        if(victory(player2))GameObject.Find("ScoreField/Player2/Point").GetComponent<Text>().text = "+1";
        else GameObject.Find("ScoreField/Player2/Point").GetComponent<Text>().text = "+0";
        if(victory(player3))GameObject.Find("ScoreField/Player3/Point").GetComponent<Text>().text = "+1";
        else GameObject.Find("ScoreField/Player3/Point").GetComponent<Text>().text = "+0";
        if(victory(player4))GameObject.Find("ScoreField/Player4/Point").GetComponent<Text>().text = "+1";
        else GameObject.Find("ScoreField/Player4/Point").GetComponent<Text>().text = "+0";
    }

    async void backScene()
    {
        await Task.Delay(7000);
        if(turn == 5){
            // Destroy(GameObject.Find("MainMusic"));
            AudioSource audioSource = GameObject.Find("MainMusic").GetComponent<AudioSource>();
            audioSource.Stop();
            SceneManager.LoadScene("Scenes/EndScene");
        }
        else{
            SceneManager.LoadScene("Scenes/HomeScene");
        }
    }

    void getRecord(){
        turn = GameObject.Find("Database").GetComponent<Database>().turn;
        order = GameObject.Find("Database").GetComponent<Database>().order;
        play_member = GameObject.Find("Database").GetComponent<Database>().play_member;
        if(turn == 1){
            player1 = GameObject.Find("Database").GetComponent<Database>().player1_record1;
            player2 = GameObject.Find("Database").GetComponent<Database>().player2_record1;
            if(play_member > 0)player3 = GameObject.Find("Database").GetComponent<Database>().player3_record1;
            if(play_member > 1)player4 = GameObject.Find("Database").GetComponent<Database>().player4_record1;
        }
        else if(turn == 2){
            player1 = GameObject.Find("Database").GetComponent<Database>().player1_record2;
            player2 = GameObject.Find("Database").GetComponent<Database>().player2_record2;
            if(play_member > 0)player3 = GameObject.Find("Database").GetComponent<Database>().player3_record2;
            if(play_member > 1)player4 = GameObject.Find("Database").GetComponent<Database>().player4_record2;
        }
        else if(turn == 3){
            player1 = GameObject.Find("Database").GetComponent<Database>().player1_record3;
            player2 = GameObject.Find("Database").GetComponent<Database>().player2_record3;
            if(play_member > 0)player3 = GameObject.Find("Database").GetComponent<Database>().player3_record3;
            if(play_member > 1)player4 = GameObject.Find("Database").GetComponent<Database>().player4_record3;
        }
        else if(turn == 4){
            player1 = GameObject.Find("Database").GetComponent<Database>().player1_record4;
            player2 = GameObject.Find("Database").GetComponent<Database>().player2_record4;
            if(play_member > 0)player3 = GameObject.Find("Database").GetComponent<Database>().player3_record4;
            if(play_member > 1)player4 = GameObject.Find("Database").GetComponent<Database>().player4_record4;
        }
        else if(turn == 5){
            player1 = GameObject.Find("Database").GetComponent<Database>().player1_record5;
            player2 = GameObject.Find("Database").GetComponent<Database>().player2_record5;
            if(play_member > 0)player3 = GameObject.Find("Database").GetComponent<Database>().player3_record5;
            if(play_member > 1)player4 = GameObject.Find("Database").GetComponent<Database>().player4_record5;
        }
        GameObject.Find("Database").GetComponent<Database>().player1 = player1;
        GameObject.Find("Database").GetComponent<Database>().player2 = player2;
        if(play_member > 0)GameObject.Find("Database").GetComponent<Database>().player3 = player3;
        if(play_member > 1)GameObject.Find("Database").GetComponent<Database>().player4 = player4;
    }

    void getRandomRecord(){
        // 1人プレイ用
        if(GameObject.Find("Database").GetComponent<Database>().play_mode == 1){
            player2 = Random.Range(1, 5);
            if(GameObject.Find("Database").GetComponent<Database>().play_member > 0)player3 = Random.Range(1, 5);
            if(GameObject.Find("Database").GetComponent<Database>().play_member > 1)player4 = Random.Range(1, 5);
            GameObject.Find("Database").GetComponent<Database>().player2 = player2;
            if(GameObject.Find("Database").GetComponent<Database>().play_member > 0)GameObject.Find("Database").GetComponent<Database>().player3 = player3;
            if(GameObject.Find("Database").GetComponent<Database>().play_member > 1)GameObject.Find("Database").GetComponent<Database>().player4 = player4;
        }
    }

    bool victory(int num){
        // 2人プレイ
        if(GameObject.Find("Database").GetComponent<Database>().play_member == 0){
            // 皇帝ネコを出した場合
            if(num == 1){
                if(player1 == 2 || player2 == 2){
                    return false;
                }
            }
            // 奴隷ペンギンを出した場合
            if(num == 2){
                if(player1 == 3 || player2 == 3 || player1 == 4 || player2 == 4 || player1 == 5 || player2 == 5){
                    return false;
                }
            }
            // 平民ひつじを出した場合
            if(num == 3 || num == 4 || num == 5){
                if(player1 == 1 || player2 == 1){
                    return false;
                }
            }
        }
        // 3人プレイ
        else if(GameObject.Find("Database").GetComponent<Database>().play_member == 1){
            // 皇帝ネコを出した場合
            if(num == 1){
                if(player1 == 2 || player2 == 2 || player3 == 2){
                    return false;
                }
            }
            // 奴隷ペンギンを出した場合
            if(num == 2){
                if(player1 == 3 || player2 == 3 || player3 == 3 || player1 == 4 || player2 == 4 || player3 == 4 || player1 == 5 || player2 == 5 || player3 == 5){
                    return false;
                }
            }
            // 平民ひつじを出した場合
            if(num == 3 || num == 4 || num == 5){
                if(player1 == 1 || player2 == 1 || player3 == 1){
                    return false;
                }
            }
        }
        // 4人プレイ
        else if(GameObject.Find("Database").GetComponent<Database>().play_member == 2){
            // 皇帝ネコを出した場合
            if(num == 1){
                if(player1 == 2 || player2 == 2 || player3 == 2 || player4 == 2){
                    return false;
                }
            }
            // 奴隷ペンギンを出した場合
            if(num == 2){
                if(player1 == 3 || player2 == 3 || player3 == 3 || player4 == 3 || player1 == 4 || player2 == 4 || player3 == 4 || player4 == 4 || player1 == 5 || player2 == 5 || player3 == 5 || player4 == 5){
                    return false;
                }
            }
            // 平民ひつじを出した場合
            if(num == 3 || num == 4 || num == 5){
                if(player1 == 1 || player2 == 1 || player3 == 1 || player4 == 1){
                    return false;
                }
            }
        }
        return true;
    }

    void fight(){
        result1 = victory(player1);
        result2 = victory(player2);
        if(GameObject.Find("Database").GetComponent<Database>().play_member >= 1)result3 = victory(player3);
        else result3 = false;
        if(GameObject.Find("Database").GetComponent<Database>().play_member >= 2)result4 = victory(player4);
        else result4 = false;
        if(result1 == false && result2 == false && result3 == false && result4 == false){
            // 何もしない
        }
        else{
            if(result1 == true)GameObject.Find("Database").GetComponent<Database>().score1 += 1;
            if(result2 == true)GameObject.Find("Database").GetComponent<Database>().score2 += 1;
            if(result3 == true)GameObject.Find("Database").GetComponent<Database>().score3 += 1;
            if(result4 == true)GameObject.Find("Database").GetComponent<Database>().score4 += 1;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        getRecord();
        getRandomRecord();
        fight();
        winAnimal();
        scoreDisplay();
        backScene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
