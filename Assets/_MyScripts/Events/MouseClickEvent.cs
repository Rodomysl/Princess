using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace MyEngine
{
    // создаёт событие по клику на объекте
    [RequireComponent(typeof(Collider))]
    public class MouseClickEvent : MonoBehaviour
    {
        public float DelayClick = 1f;
        public UnityEvent OnMouseClick;

        private bool isClick = false;

        private void OnMouseDown()
        {
            if (isClick == false)
            {
                StartCoroutine(MouseClick());
            }
        }

        private IEnumerator MouseClick()
        {
            OnMouseClick?.Invoke();

            isClick = true;

            yield return new WaitForSeconds(DelayClick);

            isClick = false;
        }
    }
}
