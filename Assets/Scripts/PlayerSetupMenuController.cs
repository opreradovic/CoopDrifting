using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class PlayerSetupMenuController : MonoBehaviour
{
    private int PlayerIndex;

    [SerializeField]
    private TextMeshProUGUI colorTitleText = null, carTitleText = null;
    [SerializeField]
    private GameObject readyPanel = null, colorMenu = null, CarMenu = null;
    [SerializeField]
    private Button readyButton = null;
    [SerializeField]
    private Button colorButton = null;

    private float ignoreInputTime = 1.5f;
    private bool inputEnabled;

    public void SetPlayerIndex(int pi) {
        PlayerIndex = pi;
        colorTitleText.SetText("Player " + (pi + 1).ToString());
        carTitleText.SetText("Player " + (pi + 1).ToString());
        ignoreInputTime = Time.time + ignoreInputTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > ignoreInputTime) {
            inputEnabled = true;
        }
    }
    public void SetCar(GameObject car) {
        if (!inputEnabled) { return; }
        PlayerConfigurationManager.Instance.SetPlayerCar(PlayerIndex, car);
        colorMenu.SetActive(true);
        colorButton.Select();
        CarMenu.SetActive(false);
    }
    public void SetColor(Material color) {
        if (!inputEnabled) { return; }
        PlayerConfigurationManager.Instance.SetPlayerColor(PlayerIndex, color);       
        readyPanel.SetActive(true);
        readyButton.Select();
        colorMenu.SetActive(false);
    }
    

    public void ReadyPlayer() {
        if (!inputEnabled) { return; }

        PlayerConfigurationManager.Instance.ReadyPlayer(PlayerIndex);
        readyButton.gameObject.SetActive(false);
    }
}
