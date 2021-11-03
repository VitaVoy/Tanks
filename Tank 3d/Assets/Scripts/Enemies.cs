using System.Collections.Generic;
using UnityEngine;

namespace TankBattle
{
    public class Enemies : MonoBehaviour
    {
        public List<TankEnemy> enemies = new List<TankEnemy>(3);

        void Start()
        {
            var enemiesOnScene = FindObjectsOfType<TankEnemy>();
            for (int i = 0; i < enemiesOnScene.Length; i++)
            {
                enemies.Add(enemiesOnScene[i]);               
            }            
        }
    }
}
