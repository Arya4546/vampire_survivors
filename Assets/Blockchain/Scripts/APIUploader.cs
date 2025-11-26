using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class APIUploader : MonoBehaviour
{
    private string apiURL = "https://somnia-data-streams-manager.vercel.app/api/publish";

  
    public void SendDataToSomnia(int coinsGained)
    {
        string wallet = PlayerPrefs.GetString("WALLET_ADDRESS",
            "0xce73c2729bc87c4e5759e28a1fad6c3d603a8169");

        int score = coinsGained;   // <-- NOW using CoinsGained

        StartCoroutine(SendData(wallet, score));
    }

    IEnumerator SendData(string wallet, int score)
    {
        string jsonBody = "{\"player\":\"" + wallet +
                          "\",\"score\":" + score + "}";

        Debug.Log("📤 JSON Body: " + jsonBody);

        UnityWebRequest request = new UnityWebRequest(apiURL, "POST");
        byte[] bodyRaw = System.Text.Encoding.UTF8.GetBytes(jsonBody);

        request.uploadHandler = new UploadHandlerRaw(bodyRaw);
        request.downloadHandler = new DownloadHandlerBuffer();
        request.SetRequestHeader("Content-Type", "application/json");

        yield return request.SendWebRequest();

        if (request.result == UnityWebRequest.Result.Success)
        {
            Debug.Log("✅ Upload Success: " + request.downloadHandler.text);
        }
        else
        {
            Debug.LogError("❌ Upload Failed: " + request.error +
                           " | Response: " + request.downloadHandler.text);
        }
    }


}
