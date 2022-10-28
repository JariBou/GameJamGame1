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
                GameObject prefab = Instantiate(block, new Vector3(i, j, 0), Quaternion.identity);
                Color colorValue = perlinValue > 0.5f ? Color.white : Color.black;
                Debug.Log(perlinValue);
                prefab.GetComponent<SpriteRenderer>().color = colorValue;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
