using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ToolAction : ScriptableObject
{
    public virtual bool OnApply(Vector2 worldPoint)
    {
        Debug.LogWarning("OnApply is not implemented");
        return true;
    }

    public virtual bool OnApplyToTileMap(Vector3Int tilemapPosition, TileMapReadController tileMapReadController)
    {
        Debug.LogWarning("OnApplyToTileMap is not implemented");
        return true;
    }

    public virtual void OnItemUsed(Item usedItem, ItemContainer inventory)
    {
        
    }
}
