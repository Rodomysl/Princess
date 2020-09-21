using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyEngine
{
    // Гиперсылка
    public class Hyperlinks : MonoBehaviour
    {
        public void OpenHyperlinks(string hyperlinks)
        {
            Application.OpenURL(hyperlinks);
        }
    }
}