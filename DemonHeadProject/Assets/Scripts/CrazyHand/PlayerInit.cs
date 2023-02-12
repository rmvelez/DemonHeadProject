using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DemonHead.Player
{
    public class PlayerInit : MonoBehaviour
    {
        //Initialiser, adds relevant components and calls on them to initialise
        internal void Init(Vector2 position)
        {
            transform.position = position;

            gameObject.AddComponent<PlayerMovement>().Init();
            gameObject.AddComponent<PlayerAppearance>().Init();
        }
    }
}