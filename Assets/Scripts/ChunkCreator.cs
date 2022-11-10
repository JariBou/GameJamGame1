using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkCreator : MonoBehaviour
{
    public GameObject block;

    public int size;
    
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                float perlinValue = PerlinCreator.perlin[i, j];
                bool isWall = perlinValue < 0.2f;
                Color colorValue = isWall ? Color.black : Color.white;
                GameObject prefab = Instantiate(block, new Vector3(i*4, j*4, 0), Quaternion.identity);
                if (isWall)
                {
                    BoxCollider2D box = prefab.AddComponent<BoxCollider2D>() as BoxCollider2D;
                    box.isTrigger = true;
                    BoxCollider2D box2 = prefab.AddComponent<BoxCollider2D>() as BoxCollider2D;
                    prefab.tag = "Void";
                    prefab.layer = 8;
                }
                prefab.GetComponent<SpriteRenderer>().color = colorValue;

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
