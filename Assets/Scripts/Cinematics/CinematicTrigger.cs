﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;


namespace RPG.Cinematics
{
    public class CinematicTrigger : MonoBehaviour
    {
        private bool isCinematicTriggered = false;

        private void OnTriggerEnter(Collider other)
        {
            if (!isCinematicTriggered && other.tag == "Player")
            {
                GetComponent<PlayableDirector>().Play();
                isCinematicTriggered = true;
            }
        }
    }
}

