using UnityEngine;

namespace Mirrusdev { 
    public class Test1 : MonoBehaviour {
        [Header("Debbuging")]
        [Tooltip("Add de GameObject with the Logging Script")]
        public GameObject SystemLogger;
        private Logger Logger;
        void Start() {
            Logger = SystemLogger.GetComponent<Logger>();
            Logger.Log("This is an Avatar Log", this.gameObject);
        }
    }
}
