using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroMusicController : MonoBehaviour
{
    void Awake () {
        DontDestroyOnLoad(gameObject);
    }
}
