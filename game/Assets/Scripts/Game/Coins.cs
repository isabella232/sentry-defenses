using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Manager;

public class Coins : MonoBehaviour
{
    public Text coinDisplay;
    private GameData _data;
    private EventManager _eventManager;

    private void Awake()
    {
        _data = GameData.Instance;
        _eventManager = EventManager.Instance;
        coinDisplay.text = "Coins: " + _data.Coins;
        _eventManager.CoinsUpdated += CoinsUpdate;
    }

    private void CoinsUpdate() {
        coinDisplay.text = "Coins: " + _data.Coins;
    }

    void Update()
    {
        
    }
}