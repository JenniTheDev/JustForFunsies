// Jenni
// Modification of RoboRyanTron's Unite 2017's
// game architecture with scriptable objects
using UnityEngine;

namespace Variables {
    [CreateAssetMenu(fileName = "New Scriptable Object (Int)", menuName = "Scriptable Object (Int)")]
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