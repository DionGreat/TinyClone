using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Map : MonoBehaviour
{
    public int gridWidth = 4;
    public int gridHeight = 4; 

    public GameObject prefab;

    public List<GameObject> objects = new List<GameObject>();
    public void Generate()
    {
        for (int i = 0; i < gridWidth; i++)
        {
            for (int j = 0; j < gridHeight; j++)
            {
                var newTile = Instantiate(prefab, transform);
                newTile.transform.position = new Vector3(transform.position.x + (j * 11), transform.position.y, transform.position.z + (i * 11));
                newTile.GetComponent<Tile>().index = j * gridWidth + i;
                newTile.name = "Tile " + (1 + j).ToString("0#") + "x" + (1 + i).ToString("0#");
                objects.Add(newTile);
            }
        }
    }

    public void Delete()
    {
        for (int i = 0; i < transform.childCount;)
        {
            DestroyImmediate(transform.GetChild(i).gameObject);
        }
        objects.Clear();
    }

}
