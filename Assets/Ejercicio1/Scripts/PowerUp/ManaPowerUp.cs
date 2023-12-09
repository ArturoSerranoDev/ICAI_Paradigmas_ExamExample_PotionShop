using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaPowerUp : BasePowerUp
{
    public override void ModifyStats(ref ShopPlayerStats stats)
    {
        stats.mana += 20;
    }
}
