using SOEvents.Events;
using SOEvents.UnityEvents;
using UnityEngine;

namespace SOEvents.Listeners {
    public class GameEventListenerDeath : BaseGameEventListener<DeathData, GameEventDeath, UnityEventDeath> {
    }
}
