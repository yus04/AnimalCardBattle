using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreFieldController : MonoBehaviour
{
    int score1;
    int score2;
    int score3;
    int score4;
    int rank;

    public void handleActivate(int player, int rank){
        if(player == 1){
            if(rank == 1){
                transform.Find("Player1/first").gameObject.SetActive(true);
            }
            else if(rank == 2){
                transform.Find("Player1/second").gameObject.SetActive(true);
            }
            else if(rank == 3){
                transform.Find("Player1/third").gameObject.SetActive(true);
            }
        }
        if(player == 2){
            if(rank == 1){
                transform.Find("Player2/first").gameObject.SetActive(true);
            }
            else if(rank == 2){
                transform.Find("Player2/second").gameObject.SetActive(true);
            }
            else if(rank == 3){
                transform.Find("Player2/third").gameObject.SetActive(true);
            }
        }
        if(player == 3){
            if(rank == 1){
                transform.Find("Player3/first").gameObject.SetActive(true);
            }
            else if(rank == 2){
                transform.Find("Player3/second").gameObject.SetActive(true);
            }
            else if(rank == 3){
                transform.Find("Player3/third").gameObject.SetActive(true);
            }
        }
        if(player == 4){
            if(rank == 1){
                transform.Find("Player4/first").gameObject.SetActive(true);
            }
            else if(rank == 2){
                transform.Find("Player4/second").gameObject.SetActive(true);
            }
            else if(rank == 3){
                transform.Find("Player4/third").gameObject.SetActive(true);
            }
        }
    }

    public void getRanking(){
        score1 = GameObject.Find("Database").GetComponent<Database>().score1;
        score2 = GameObject.Find("Database").GetComponent<Database>().score2;
        score3 = GameObject.Find("Database").GetComponent<Database>().score3;
        score4 = GameObject.Find("Database").GetComponent<Database>().score4;
        rank = 1;
        for(int score = 5; score >= 0; score--){
            int cnt = 0;
            if(score1 == score){
                handleActivate(1, rank);
                cnt++;
            }
            if(score2 == score){
                handleActivate(2, rank);
                cnt++;
            }
            if(score3 == score){
                handleActivate(3, rank);
                cnt++;
            }
            if(score4 == score){
                handleActivate(4, rank);
                cnt++;
            }
            rank += cnt;
        }
    }

    public void getCharacterName(){
        GameObject.Find("Player1/Name").GetComponent<Text>().text = GameObject.Find("Database").GetComponent<Database>().player1_name;
        GameObject.Find("Player2/Name").GetComponent<Text>().text = GameObject.Find("Database").GetComponent<Database>().player2_name;
        GameObject.Find("Player3/Name").GetComponent<Text>().text = GameObject.Find("Database").GetComponent<Database>().player3_name;
        GameObject.Find("Player4/Name").GetComponent<Text>().text = GameObject.Find("Database").GetComponent<Database>().player4_name;
        if(GameObject.Find("Database").GetComponent<Database>().play_member < 1)transform.Find("Player3").gameObject.SetActive(false);
        if(GameObject.Find("Database").GetComponent<Database>().play_member < 2)transform.Find("Player4").gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        getRanking();
        getCharacterName();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
