using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMusicController : MonoBehaviour
{
    void Awake () {
        DontDestroyOnLoad(gameObject);
    }
}
