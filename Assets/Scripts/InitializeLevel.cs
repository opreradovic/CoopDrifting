using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class InitializeLevel : MonoBehaviour
{
    [SerializeField]
    private Transform[] playerSpawns = null;

    [SerializeField]
    private RenderTexture[] renderTextures = null;

    private Camera[] cameras;

    private GameObject playerPrefab;


    private GameObject[] playerCfg = null;
    // Start is called before the first frame update
    void Start()
    {
        var playerConfigs = PlayerConfigurationManager.Instance.GetPlayConfigs().ToArray();
        playerCfg = GameObject.FindGameObjectsWithTag("playercfg");
        for (int i = 0; i < playerConfigs.Length; i++) {
            playerPrefab = playerConfigs[i].Car;
            var player = Instantiate(playerPrefab, playerSpawns[i].position, playerSpawns[i].rotation, gameObject.transform);
            cameras = player.GetComponentsInChildren<Camera>();
            player.GetComponent<PlayerInputHandler>().InitializePlayer(playerConfigs[i]);
            player.GetComponent<Car>().SpawnPosition = playerSpawns[i];
            player.transform.SetParent(playerCfg[i].transform);
            //Camera camera = player.GetComponentInChildren<Camera>();
            Camera camera = cameras[0];
            playerCfg[i].GetComponent<PlayerInput>().camera = camera;
            camera.transform.parent.gameObject.transform.SetParent(playerCfg[i].transform);
            //Camera miniCamera = cameras[1];
            //miniCamera.targetTexture = renderTextures[i];
            //texImage = player.GetComponentInChildren<RawImage>();
            //texImage.texture = renderTextures[i];
        }
        PlayerConfigurationManager.Instance.GetComponent<PlayerInputManager>().splitScreen = true;
        GameManager.Instance.ShouldStartGame = true;
    }
}
