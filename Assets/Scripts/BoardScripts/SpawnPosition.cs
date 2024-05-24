using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPosition : MonoBehaviour
{

    [SerializeField] private Transform spawnTransform;

  

    public void SpawnEntity(GameObject cardPrefab)
    {
        if (spawnTransform != null){
            GameObject newCardPrefab = Instantiate(cardPrefab);
            newCardPrefab.transform.position = spawnTransform.position;
        }
    }
}
