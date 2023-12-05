using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShopPlayerUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private TextMeshProUGUI speedText;
    [SerializeField] private TextMeshProUGUI manaText;
    
    [SerializeField] private ShopPlayerStats playerStats;
    
    private void UpdateUI(ShopPlayerStats playerStats)
    {
        healthText.text = "Health: " + playerStats.health.ToString();
        speedText.text = "Speed: "  + playerStats.speed.ToString();
        manaText.text = "Speed: "  + playerStats.speed.ToString();
        
    }

}
