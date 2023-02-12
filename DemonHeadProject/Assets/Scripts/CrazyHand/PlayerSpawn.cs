using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DemonHead.Player;

namespace DemonHead.Infrastructure
{
    public class PlayerSpawn : MonoBehaviour
    {
        //Awake, spawn player and call initialiser component to setup player
        private void Awake()
        {
            PlayerInit player = new GameObject("Player").AddComponent<PlayerInit>();
            player.Init(transform.position);
        }
    }
}