using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UIElements;


public class Crops
{

}

public class CropsManager : MonoBehaviour
{
    [SerializeField] TileBase plowed;
    [SerializeField] TileBase seeded;
    [SerializeField] Tilemap targetTilemap;

    Dictionary<Vector2Int, Crops> crops;

    private void Start()
    {
        crops = new Dictionary<Vector2Int, Crops>();
    }

    public bool Check(Vector3Int position)
    {
        return crops.ContainsKey((Vector2Int)position);
    }

    public void Plow(Vector3Int position)
    {
        if (crops.ContainsKey((Vector2Int)position))
        {
            return;
        }

        CreatePlowedTile(position);
    }

    public void Seed(Vector3Int position)
    {
        targetTilemap.SetTile(position, seeded);
    }

    private void CreatePlowedTile(Vector3Int position)
    {
        Crops crop = new Crops();
        crops.Add((Vector2Int)position, crop);

        targetTilemap.SetTile(position, plowed);
    }
}
