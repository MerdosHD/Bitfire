using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour {

    public GameObject prefabChunk;

	void Start () {
        Generate();
	}

    private void Generate()
    {
        for (int x = 0; x < 5; x++)
        {
            for (int y = 0; y < 5; y++)
            {
                Instantiate(prefabChunk, new Vector3(x * Chunk.Size, y * Chunk.Size, 0f), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
