using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

namespace MyEngine
{
    public static class Utils
    {

        // отключаем переход телефона в спящий режим
        public static void NoSleep()
        {
            Screen.sleepTimeout = SleepTimeout.NeverSleep;
        }

        // сохранение в PlayerPrefs даты и времени
        public static void SetDataTime(string key, DateTime value)
        {
            string convertedToString = value.ToString("u", CultureInfo.InvariantCulture);
            PlayerPrefs.SetString(key, convertedToString);
        }

        // загрузка из PlayerPrefs даты и времени
        public static DateTime GetDataTime(string key, DateTime value)
        {
            if (PlayerPrefs.HasKey(key))
            {
                string stored = PlayerPrefs.GetString(key);
                DateTime result = DateTime.ParseExact(stored, "u", CultureInfo.InvariantCulture);
                return result;
            }
            else
                return value;
        }

        // метод возвращает мировую координату UI элемента
        public static Vector3 GetUIObjectToWorldPoint(RectTransform uiObject, Camera cam, float z = 10f)
        {
            Vector3 screenPos = uiObject.position;
            screenPos.z = z;
            Vector3 worldPosition = cam.ScreenToWorldPoint(screenPos);
            return worldPosition;
        }

        // метод возвращает мировую координаты из экранной
        public static Vector3 ScreenToWorldPoint(Vector2 position, Camera cam)
        {
            Vector3 worldPosition = cam.ScreenToWorldPoint(position);
            worldPosition.z = 0f;
            return worldPosition;
        }
    }
}
