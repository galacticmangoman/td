using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTower : MonoBehaviour
{
    public GameObject towerPrefab;
    private GameObject tower;

    private bool canPlaceTower(){
        return tower==null;
    }

    void OnMouseUp(){
        if(canPlaceTower())
        {
            tower=Instantiate(towerPrefab,transform.position,Quaternion.identity);
        }
    }
}
