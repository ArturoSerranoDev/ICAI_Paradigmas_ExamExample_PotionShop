using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthAndSpeedPowerUp : BasePowerUp
{
    public BasePowerUp wrappedPowerUp;
    
    public override void ModifyStats(ref ShopPlayerStats stats)
    {
        wrappedPowerUp.ModifyStats(ref stats);
        stats.speed += 3f;
    }
}
