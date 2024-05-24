using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BoardPlayer : MonoBehaviour
{

    // this will hold the player, their cards, Mana, Health, and maybe booster if added
    [SerializeField] TMP_Text _manaText;
    [SerializeField] TMP_Text _healthText;
    public int _mana;
    public int _health;
    [SerializeField] private int _manaTotal;
    [SerializeField] private int _healthTotal;
    public PlayerDetails _playerDetails;

    // Start is called before the first frame update
    void Start()
    {
        _mana = _manaTotal;
        _health = _healthTotal;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateUI();
    }

    void UpdateUI()
    {
        _manaText.text = "Mana: " + _mana.ToString() + " / " +  _manaTotal.ToString(); 
        _healthText.text = "Health: " + _health.ToString() + " / " +  _healthTotal.ToString(); 
    }
}
