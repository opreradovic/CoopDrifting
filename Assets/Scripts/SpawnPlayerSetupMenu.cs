using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.UI;
using UnityEngine;

public class SpawnPlayerSetupMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject playerSetupMenuPrefab = null;
    public PlayerInput input;
    private void Awake() {
        var rootMenu = GameObject.Find("MainLayout");
        if(rootMenu != null) {
            var menu = Instantiate(playerSetupMenuPrefab, rootMenu.transform);
            input.uiInputModule = menu.GetComponentInChildren<InputSystemUIInputModule>();
            menu.GetComponent<PlayerSetupMenuController>().SetPlayerIndex(input.playerIndex);
        }
    }
}
