using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour {


    public Sprite Floor;

    public static int Size =5;

    Tile[,] tiles;

	void Start () {

        tiles = new Tile[Size, Size];

        Generate();
	}

    private void Generate()
    {
        
        for (int x = 0; x < Size; x++)
        {
            for (int y = 0; y < Size; y++)
            {
                tiles[x, y] = new Tile(x + (int) transform.position.x ,y + (int)transform.position.y ,0);

                GameObject tempTile = new GameObject("Tile(" + tiles[x, y].X + "," + tiles[x, y].Y + "," + tiles[x, y].Z + ")");

                tempTile.transform.position = new Vector3(tiles[x, y].X, tiles[x, y].Y, tiles[x, y].Z);
                tempTile.transform.SetParent(this.transform);

                SpriteRenderer spriteRenderer = tempTile.AddComponent<SpriteRenderer>();
                spriteRenderer.sprite = Floor;

            }
        }
    }
}
