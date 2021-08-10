using System;
using Data;

namespace Manager
{
    public class EventManager : MonoSingleton<EventManager>
    {
        public event Action Resetting;
        public event Action SentryPlacing;
        public event Action SentryUpgrading;
        public event Action SentryUpgraded;

        
        public void Reset()
        {
            Resetting?.Invoke();
        }
        
        public void SentryPlaced()
        {
            SentryPlacing?.Invoke();
        }

        public void Updating()
        {
            SentryUpgrading?.Invoke();
        }

        public void Upgraded()
        {
            SentryUpgraded?.Invoke();
        }
    }
}
