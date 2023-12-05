using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShopPlayer : MonoBehaviour
{
    public ShopPlayerStats stats;
    
    private BasePowerUp selectedPowerUp;
    
    public event Action<ShopPlayerStats> OnPlayerStatsModified; 
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && selectedPowerUp != null)
        {
            ApplyPowerUp();
            OnPlayerStatsModified.Invoke(stats);
        }
    }
    private void ApplyPowerUp()
    {
        selectedPowerUp.ModifyStats(ref stats);
        selectedPowerUp.gameObject.SetActive(false);
        selectedPowerUp = null;
    }

    // OnTriggerEnter is called when the object collides with a trigger Area
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<BasePowerUp>())
        {
            selectedPowerUp = other.GetComponent<BasePowerUp>();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<BasePowerUp>())
        {
            selectedPowerUp = null;
        }
    }
}
