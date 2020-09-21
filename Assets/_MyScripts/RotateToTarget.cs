using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyEngine
{
    // Поворот к цели по оси
    public class RotateToTarget : MonoBehaviour
    {
        public Transform target = null;
        public float speed = 5f;

        private Vector3 direction;
        private Quaternion lookRotation;

        private void Update()
        {
            direction = (target.position - transform.position).normalized;
            lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0f, direction.z));
            transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, Time.deltaTime * speed);
        }
    }
}
