using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class CardEntity : MonoBehaviour
{

    [SerializeField] private TMP_Text _healthText;
    [SerializeField] private TMP_Text _attackDamageText;
    [SerializeField] private int _attackDamage;
    [SerializeField] private int _health;

    public void Attack(CardEntity enemy){
        if (enemy._attackDamage >= _health){
            PlayDeathAnimation();
        }else if (enemy._attackDamage < _health){
            _health -= enemy._attackDamage;
        }
    }
    void PlayDeathAnimation(){
        // death animtion
        Debug.Log("You Died");

    }

    private IEnumerator WaitBeforeKilling(){
        while (true)
        {
            yield return new WaitForSeconds(1f);
            Debug.Log("Entity has died");
            Destroy(gameObject);
        }
    }
}
