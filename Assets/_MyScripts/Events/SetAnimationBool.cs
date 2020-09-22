using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyEngine
{
    // устанавливает булевскую переменную в аниматоре
    public class SetAnimationBool : MonoBehaviour
    {
        public string VariableName;
        public bool Value;
        public Animator Anim;

        private void Start()
        {
            if (Anim == null)
                Anim = GetComponentInChildren<Animator>();
            if (Anim == null)
                Debug.LogError("Не найден Animator", this);
        }

        public void SetBool()
        {
            if (Anim == null)
                return;

            Anim.SetBool(VariableName, Value);
        }

        public void SetBoolTrue()
        {
            if (Anim == null)
                return;

            Anim.SetBool(VariableName, true);
        }

        public void SetBoolFalse()
        {
            if (Anim == null)
                return;

            Anim.SetBool(VariableName, false);
        }
    }
}
