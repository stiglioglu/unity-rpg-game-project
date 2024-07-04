using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Core
{
    public class FollowCamera : MonoBehaviour
    {

        [SerializeField] private Transform target;

        private void Update()
        {
            transform.position = target.position;
        }
    }
}
