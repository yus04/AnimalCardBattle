using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class MainCameraController : MonoBehaviour
{
    void rotate(){
        Transform myTransform = this.transform;
        Vector3 worldAngle = myTransform.eulerAngles;
        worldAngle.y += 0.15f;
        myTransform.eulerAngles = worldAngle;
    }

    void forward(){
        Transform myTransform = this.transform;
        Vector3 pos = myTransform.position;
        pos.z += 0.1f;
        myTransform.position = pos;
        
    }

    // Start is called before the first frame update
    void Start()
    {
        var turn = GameObject.Find("Database").GetComponent<Database>().turn;
        transform.rotation = Quaternion.Euler(0.0f, 180f + turn * 90, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        // forward();
        rotate();
    }
}