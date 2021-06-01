// Jenni
// Modification of RoboRyanTron's Unite 2017's
// game architecture with scriptable objects
using UnityEngine;

namespace Variables {
    [CreateAssetMenu(menuName = "Scriptable Objects/Scriptable Object(Int)")]
    public class IntSO : ScriptableObject {
        [SerializeField] private int intValue;

        public int IntValue {
            get { return this.intValue; }
            set { this.intValue = value; }
        }

        public IntSO(int intValue) {
            this.intValue = intValue;
        }

        public static implicit operator int(IntSO v) {
            return v.IntValue;
        }
    }
}