using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using TMPro;


public class joinlobby : MonoBehaviour
{
    [SerializeField] private NetworkManager networkManager = null;

    public TMP_InputField ipAddressInputField;
    public GameObject panel;

    public void JoinLobby()
    {
        string ipAddress = ipAddressInputField.text;

        networkManager.networkAddress = ipAddress;
        networkManager.StartClient();

        panel.SetActive(false);
    }
}
