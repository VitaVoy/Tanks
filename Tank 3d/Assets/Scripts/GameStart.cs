using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
   
   public GameObject Enemy;
   public GameObject LevelArt;
   public GameObject Player;
   
   
   
    void Start()
    {
        Instantiate(LevelArt, new Vector3(0, 0, 0), Quaternion.identity);
        Instantiate(Enemy, new Vector3(1, 0, 3), Quaternion.identity);
        Instantiate(Player, new Vector3(1, 0, -3), Quaternion.identity);

       
        



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
