using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;

// Write the BatW6 class here.

public class BatW6 : MonoBehaviour
{
    [SerializeField] private int speed;
    [SerializeField] private bool chasing_player = false;
    [SerializeField] private GameObject target_player;
    private void Start()
    {
    }
    public void chase_player()
    {
        chasing_player = true;
    }
    public void stop_chasing_player()
    {
        chasing_player = false;
     
    }



    private void Update()
    {
       if (chasing_player==true)
       {
            transform.position = transform.position + ((target_player.transform.position-transform.position).normalized * Time.deltaTime*speed);
       }
    }

}
