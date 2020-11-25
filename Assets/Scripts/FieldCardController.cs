using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class FieldCardController : MonoBehaviour
{
    async void handleActive()
    {
        if(this.name == "CardController1"){
            int player1 = GameObject.Find("Database").GetComponent<Database>().player1;
            if(player1 == 1)transform.Find("CatCard").gameObject.SetActive(true);
            if(player1 == 2)transform.Find("PenguinCard").gameObject.SetActive(true);
            if(player1 == 3 || player1 == 4 || player1 == 5)transform.Find("SheepCard").gameObject.SetActive(true);
        }
        else if(this.name == "CardController2"){
            int player2 = GameObject.Find("Database").GetComponent<Database>().player2;
            if(player2 == 1)transform.Find("CatCard").gameObject.SetActive(true);
            if(player2 == 2)transform.Find("PenguinCard").gameObject.SetActive(true);
            if(player2 == 3 || player2 == 4 || player2 == 5)transform.Find("SheepCard").gameObject.SetActive(true);
        }
        else if(this.name == "CardController3" && GameObject.Find("Database").GetComponent<Database>().play_member >= 1){
            int player3 = GameObject.Find("Database").GetComponent<Database>().player3;
            if(player3 == 1)transform.Find("CatCard").gameObject.SetActive(true);
            if(player3 == 2)transform.Find("PenguinCard").gameObject.SetActive(true);
            if(player3 == 3 || player3 == 4 || player3 == 5)transform.Find("SheepCard").gameObject.SetActive(true);
        }
        else if(this.name == "CardController4" && GameObject.Find("Database").GetComponent<Database>().play_member >= 2){
            int player4 = GameObject.Find("Database").GetComponent<Database>().player4;
            if(player4 == 1)transform.Find("CatCard").gameObject.SetActive(true);
            if(player4 == 2)transform.Find("PenguinCard").gameObject.SetActive(true);
            if(player4 == 3 || player4 == 4 || player4 == 5)transform.Find("SheepCard").gameObject.SetActive(true);
        }
        await Task.Delay(5000);
        transform.Find("CatCard").gameObject.SetActive(false);
        transform.Find("PenguinCard").gameObject.SetActive(false);
        transform.Find("SheepCard").gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        handleActive();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
