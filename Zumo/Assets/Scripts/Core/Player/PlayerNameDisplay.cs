using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Collections;
using UnityEngine;

public class PlayerNameDisplay : MonoBehaviour
{

    [SerializeField] private TankPlayer player;
    [SerializeField] private TMP_Text PlayerNameText;

    private void Start()
    {
        HandlePlayerNameChanged(string.Empty, player.PlayerName.Value);

        player.PlayerName.OnValueChanged += HandlePlayerNameChanged;
    }

    private void HandlePlayerNameChanged(FixedString32Bytes oldName, FixedString32Bytes newName)
    {
        PlayerNameText.text = newName.ToString();   
    }

    private void OnDestroy()
    {
        player.PlayerName.OnValueChanged -= HandlePlayerNameChanged;
    }

}
