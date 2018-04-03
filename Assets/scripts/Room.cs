using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TextRPG
{
    public class Room : MonoBehaviour
    {
        public Chest Chest { get; set; }
        public Enemy Enemy { get; set; }
        public bool Exit { get; set; }
        public bool Empty { get; set; }
        public Vector2 RoomIndex { get; set; }

        public Room()
        {
            int roll = Random.Range(0, 30);
            if (roll > 0 && roll < 6)
            {
                Enemy = EnemyDatabase.Instance.GetRandomEnemy();
                Enemy.RoomIndex = RoomIndex;
            }
            else if (roll > 10 && roll < 15)
            {
                Chest = new Chest();
            }
            else
            {
                Empty = true;
            }
        }
    }
}