using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Tile : MonoBehaviour
{
    public int index;
    public int level;
    public GameObject prefab;

    public void GenerateBuilding()
    {
        Instantiate(prefab);
    }
}
