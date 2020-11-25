using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class AgainButtonController : MonoBehaviour
{
    public void OnClickButton(){
        GameObject.Find("Database").GetComponent<Database>().turn = 0;
        GameObject.Find("Database").GetComponent<Database>().order = 0;
        GameObject.Find("Database").GetComponent<Database>().player1_record1 = 0;
        GameObject.Find("Database").GetComponent<Database>().player1_record2 = 0;
        GameObject.Find("Database").GetComponent<Database>().player1_record3 = 0;
        GameObject.Find("Database").GetComponent<Database>().player1_record4 = 0;
        GameObject.Find("Database").GetComponent<Database>().player1_record5 = 0;
        GameObject.Find("Database").GetComponent<Database>().player2_record1 = 0;
        GameObject.Find("Database").GetComponent<Database>().player2_record2 = 0;
        GameObject.Find("Database").GetComponent<Database>().player2_record3 = 0;
        GameObject.Find("Database").GetComponent<Database>().player2_record4 = 0;
        GameObject.Find("Database").GetComponent<Database>().player2_record5 = 0;
        GameObject.Find("Database").GetComponent<Database>().player3_record1 = 0;
        GameObject.Find("Database").GetComponent<Database>().player3_record2 = 0;
        GameObject.Find("Database").GetComponent<Database>().player3_record3 = 0;
        GameObject.Find("Database").GetComponent<Database>().player3_record4 = 0;
        GameObject.Find("Database").GetComponent<Database>().player3_record5 = 0;
        GameObject.Find("Database").GetComponent<Database>().player4_record1 = 0;
        GameObject.Find("Database").GetComponent<Database>().player4_record2 = 0;
        GameObject.Find("Database").GetComponent<Database>().player4_record3 = 0;
        GameObject.Find("Database").GetComponent<Database>().player4_record4 = 0;
        GameObject.Find("Database").GetComponent<Database>().player4_record5 = 0;
        GameObject.Find("Database").GetComponent<Database>().score1 = 0;
        GameObject.Find("Database").GetComponent<Database>().score2 = 0;
        GameObject.Find("Database").GetComponent<Database>().score3 = 0;
        GameObject.Find("Database").GetComponent<Database>().score4 = 0;
        AudioSource audioSource = GameObject.Find("MainMusic").GetComponent<AudioSource>();
        audioSource.Play();
        SceneManager.LoadScene("Scenes/HomeScene");
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
