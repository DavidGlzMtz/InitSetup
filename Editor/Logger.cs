//e-Xpectrum

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mirrusdev {
    [AddComponentMenu("_Mirrus/Services/Logging")] 
    public class Logger : MonoBehaviour {
        [Header("Settings")]
        [SerializeField] bool _showLogs;
        [SerializeField] string _prefix;
        [SerializeField] Color _prefixColor;
        public void Log(object message, Object sender){
            if (_showLogs)
            Debug.Log($"<b><color=#{ColorUtility.ToHtmlStringRGB(_prefixColor)}>" + _prefix + ": </color></b>" + message, sender);
        }
    }
}
