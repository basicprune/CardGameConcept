using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceCard : MonoBehaviour
{

    private Card _card;
    [SerializeField] private BoardPlayer _boardPlayer;   

   

    // Start is called before the first frame update
    void Start()
    {
        _card = gameObject.GetComponent<Card>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "PlaceCard") 
        {
            if (_boardPlayer._mana >= _card._manaCost)
            {
                _boardPlayer._mana -= _card._manaCost;
                Debug.Log("card was placed");

            } else {
                Debug.Log("Not enough mana");

            }
        }
    }

   
}
