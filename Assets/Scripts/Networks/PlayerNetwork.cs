﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerNetwork : MonoBehaviour
{
    public static PlayerNetwork instance;
    public string PlayerName { get; private set; }

    private void Awake()
    {
        instance = this;

        //PlayerName = "Player#" + Random.Range(0, 9999);
    }

}
