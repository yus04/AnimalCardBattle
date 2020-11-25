using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Database : MonoBehaviour
{
    public int play_mode;
    public int play_member;
    public string player1_name;
    public string player2_name;
    public string player3_name;
    public string player4_name;
    public int turn;
    public int order;
    public int player1_record1;
    public int player1_record2;
    public int player1_record3;
    public int player1_record4;
    public int player1_record5;
    public int player2_record1;
    public int player2_record2;
    public int player2_record3;
    public int player2_record4;
    public int player2_record5;
    public int player3_record1;
    public int player3_record2;
    public int player3_record3;
    public int player3_record4;
    public int player3_record5;
    public int player4_record1;
    public int player4_record2;
    public int player4_record3;
    public int player4_record4;
    public int player4_record5;
    public int player1;
    public int player2;
    public int player3;
    public int player4;
    public int score1;
    public int score2;
    public int score3;
    public int score4;

    void Awake () {
        DontDestroyOnLoad(gameObject);
    }
}
