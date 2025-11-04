using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductivityUnit : Unit
{
    ResourcePile currentPile;
    public float ProductivityMultiplier = 2;
    protected override void BuildingInRange()
    {
        if (currentPile == null)
        {
            ResourcePile pile = m_Target as ResourcePile;
            if (pile != null)
            {
                currentPile = pile;
                currentPile.ProductionSpeed 
                    *= ProductivityMultiplier; 
            }
        }
    }
}
