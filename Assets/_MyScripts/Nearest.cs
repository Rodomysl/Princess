using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyEngine
{
    // Находит ближайшего врага из всех существующих на счене с тегом "Enemy"
    public class Nearest : MonoBehaviour
    {
        private GameObject[] enemys = null;
        private GameObject closest = null;

        public string nearestEnemy;

        private void Start()
        {
            enemys = GameObject.FindGameObjectsWithTag("Enemy");
        }

        private void Update()
        {
            nearestEnemy = FindClosesEnemy().name;
        }

        private GameObject FindClosesEnemy()
        {
            float distance = Mathf.Infinity;
            Vector3 position = transform.position;
            foreach(GameObject obj in enemys)
            {
                Vector3 diff = obj.transform.position - position;
                float currentDistance = diff.sqrMagnitude;
                if (currentDistance < distance)
                {
                    closest = obj;
                    distance = currentDistance;
                }
            }
            return closest;
        }
    }
}
