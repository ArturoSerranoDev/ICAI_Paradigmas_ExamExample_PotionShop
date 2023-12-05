using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerUp : BasePowerUp
{
    public override void ModifyStats( ref ShopPlayerStats stats)
    {
        stats.health += 50f;
    }
}
