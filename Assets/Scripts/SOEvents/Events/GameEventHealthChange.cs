using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOEvents.Events {
    [CreateAssetMenu(menuName = "Scriptable Objects / Game Events/ New Game Event(HealthChange)")]
    public class GameEventHealthChange : BaseGameEvent<HealthChangeData> { }
}