using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 10f;

    public float jumpSpeed = 20;

    [SerializeField]
    private Stat health;

    [SerializeField]
    private Stat armor;

    private void Awake()
    {
        health.Initialize();
        armor.Initialize();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (armor.CurrentVal <= 0)
            {
                health.CurrentVal -= 10;
            }
            else
            {
                armor.CurrentVal -= 20;
            }
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (health.CurrentVal >= 100)
            {
                armor.CurrentVal += 20;
            }
            else
            {
                health.CurrentVal += 10;
            }

        }
    }
}

