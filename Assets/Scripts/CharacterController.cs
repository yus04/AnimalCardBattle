using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterController : MonoBehaviour
{
    public void getCharacterName(){
        GameObject.Find("Rin/Canvas/Panel/Text").GetComponent<Text>().text = GameObject.Find("Database").GetComponent<Database>().player1_name;
        GameObject.Find("Satomi/Canvas/Panel/Text").GetComponent<Text>().text = GameObject.Find("Database").GetComponent<Database>().player2_name;
        GameObject.Find("Arisa/Canvas/Panel/Text").GetComponent<Text>().text = GameObject.Find("Database").GetComponent<Database>().player3_name;
        GameObject.Find("Tatsumi/Canvas/Panel/Text").GetComponent<Text>().text = GameObject.Find("Database").GetComponent<Database>().player4_name;
    }

    public void handleCharacterActive(){
        transform.Find("Rin").gameObject.SetActive(true);
        transform.Find("Satomi").gameObject.SetActive(true);
        if(GameObject.Find("Database").GetComponent<Database>().play_member < 1)transform.Find("Arisa").gameObject.SetActive(false);
        if(GameObject.Find("Database").GetComponent<Database>().play_member < 2)transform.Find("Tatsumi").gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        getCharacterName();
        handleCharacterActive();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
