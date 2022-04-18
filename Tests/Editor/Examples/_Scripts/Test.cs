using UnityEngine;

namespace Mirrusdev { 
    public class Test : MonoBehaviour {
        [Header("Debbuging")]
        [Tooltip("Add de GameObject with the Logging Script")]
        public GameObject SystemLogger;
        private Logger Logger;
        void Start() {
            Logger = SystemLogger.GetComponent<Logger>();
            Logger.Log("This is a System Log", this.gameObject);
        }
    }
}
