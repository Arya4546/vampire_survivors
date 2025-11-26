using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.Collections;
using TMPro;
using System.Collections.Generic;

public class LeaderboardManager : MonoBehaviour
{
    [Header("UI")]
    public GameObject rowPrefab;
    public Transform leaderboardContainer;

    private string apiUrl = "https://somnia-data-streams-manager.vercel.app/api/data";

    void Start()
    {
        FetchLeaderboard();
    }

    public void FetchLeaderboard()
    {
        StartCoroutine(GetLeaderboardData());
    }

    IEnumerator GetLeaderboardData()
    {
        UnityWebRequest request = UnityWebRequest.Get(apiUrl);

        yield return request.SendWebRequest();

        if (request.result == UnityWebRequest.Result.Success)
        {
            Debug.Log("LEADERBOARD JSON: " + request.downloadHandler.text);

            LeaderboardResponse data = JsonUtility.FromJson<LeaderboardResponse>(request.downloadHandler.text);
            DisplayLeaderboard(data.leaderboard);
        }
        else
        {
            Debug.LogError("Failed to fetch leaderboard: " + request.error);
        }
    }

    void DisplayLeaderboard(List<PlayerEntry> leaderboard)
    {
        // Clear old UI first
        foreach (Transform child in leaderboardContainer)
            Destroy(child.gameObject);

        // Max 10 entries only
        int count = Mathf.Min(10, leaderboard.Count);

        for (int i = 0; i < count; i++)
        {
            var p = leaderboard[i];

            GameObject row = Instantiate(rowPrefab, leaderboardContainer);

            // Access Rank / Wallet / Score
            TextMeshProUGUI rankText = row.transform.Find("RankText").GetComponent<TextMeshProUGUI>();
            TextMeshProUGUI walletText = row.transform.Find("WalletText").GetComponent<TextMeshProUGUI>();
            TextMeshProUGUI scoreText = row.transform.Find("ScoreText").GetComponent<TextMeshProUGUI>();

            // Parent Image (iske color change honge)
            Image rowBg = row.GetComponent<Image>();

            // Set Text
            rankText.text = p.rank.ToString();
            walletText.text = p.player;
            scoreText.text = p.score;

            // TIME HATA DIYA — UI se bhi remove kar do
            Transform timeObj = row.transform.Find("TimeText");
            if (timeObj != null) timeObj.gameObject.SetActive(false);

            // First 3 rows = green, others = red
            Color targetColor = (i < 3) ? Color.green : Color.red;

            // Parent image ko green/red karo
            if (rowBg != null)
                rowBg.color = targetColor;
        }
    }



    
}

[System.Serializable]
public class LeaderboardResponse
{
    public int totalPlayers;
    public List<PlayerEntry> leaderboard;
}

[System.Serializable]
public class PlayerEntry
{
    public int rank;
    public string player;
    public string score;
    public string playTime;
}
