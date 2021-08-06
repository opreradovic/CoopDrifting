using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using System.Linq;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    private void Awake() {
        Instance = this;
    }

    public bool ShouldStartGame { get; set; }
    public bool GameStarted { get; set; }

    [SerializeField]
    private TextMeshProUGUI[] player1Names;
    [SerializeField]
    private TextMeshProUGUI[] player2Names;

    [SerializeField]
    private TextMeshProUGUI[] player1Scores;
    [SerializeField]
    private TextMeshProUGUI[] player2Scores;

    [SerializeField]
    private TextMeshProUGUI[] countdowns;
    [SerializeField]
    private TextMeshProUGUI[] raceTimers;

    [SerializeField]
    private List<DriftScore> driftScores;
    
    [SerializeField]
    private TextMeshProUGUI[] winners;

    [SerializeField]
    private Canvas guiCanvas, winnerCanvas;


    private GameObject[] players;
    private float countdownTimer = 3;
    [SerializeField]
    private float raceTimer = 60;

    
    private List<float> driftPoints = new List<float>();

    private GameObject winner;
    private void Start() {
        winnerCanvas.enabled = false;

        players = GameObject.FindGameObjectsWithTag("Player");
        for (int i = 0; i < players.Length; i++) {
            driftScores.Add(players[i].GetComponent<DriftScore>());
            player1Names[i].text = "Player " + (players[i].GetComponentInParent<PlayerInput>().playerIndex + 1).ToString();
            player2Names[i].text = "Player " + (players[i].GetComponentInParent<PlayerInput>().playerIndex + 1).ToString();
        }
    }
    private void Update() {
        UpdateDriftScores();

        if (ShouldStartGame && !GameStarted) {
            countdownTimer -= Time.deltaTime;
            foreach(TextMeshProUGUI c in countdowns) {
                c.text = countdownTimer.ToString("F0");
            }
            if(countdownTimer <= 0) {
                GameStarted = true;
                countdownTimer = 3;
                foreach(TextMeshProUGUI c in countdowns) {
                    c.enabled = false;
                }
            }
        }
        if (GameStarted) {
            RaceLoop();
        }
    }
    public void StartGame() {
        ShouldStartGame = true;
    }
    void UpdateDriftScores() {
        for (int i = 0; i < driftScores.Count; i++) {
            player1Scores[i].text = driftScores[i].DriftPoints.ToString("F0");
            player2Scores[i].text = driftScores[i].DriftPoints.ToString("F0");
        }
    }
    void RaceLoop() {
        raceTimer -= Time.deltaTime;
        foreach (TextMeshProUGUI t in raceTimers) {
            t.text = raceTimer.ToString("F0");
        }
        if (raceTimer <= 0) {
            DecideWinner();
        }
    }
    void DecideWinner() {
        winnerCanvas.enabled = true;
        guiCanvas.enabled = false;
        float winnerPoints;
        for (int i = 0; i < players.Length; i++) {
            driftPoints.Add(players[i].GetComponent<DriftScore>().DriftPoints);
        }
        winnerPoints = driftPoints.Max();

        for (int i = 0; i < players.Length; i++) {
            if(players[i].GetComponent<DriftScore>().DriftPoints == winnerPoints) {
                winner = players[i].gameObject;
            }
        }
        foreach (TextMeshProUGUI w in winners) {
            w.text ="Player " + (winner.GetComponentInParent<PlayerInput>().playerIndex + 1).ToString() + " WON";
        }
    }
}
