using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Dbug
{
    /// <summary>
    /// Custom Debug.Log extension to add console colours
    /// </summary>
    public static class Log
    {
        public static void Good(string message)
        {
            Debug.Log($"<color=green>{message}</color>");
        }

        public static void Warning(string message)
        {
            Debug.LogWarning($"<color=orange>{message}</color>");
        }

        public static void Error(string message)
        {
            Debug.LogError($"<color=red>{message}</color>");
        }
    }
}

