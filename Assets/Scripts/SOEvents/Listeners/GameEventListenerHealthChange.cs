using SOEvents.Events;
using SOEvents.UnityEvents;
using UnityEngine;

namespace SOEvents.Listeners {
    public class GameEventListenerHealthChange : BaseGameEventListener<HealthChangeData, GameEventHealthChange, UnityEventHealthChange> {
    }
}