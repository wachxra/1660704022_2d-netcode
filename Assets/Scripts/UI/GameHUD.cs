using TMPro;
using Unity.Netcode;
using UnityEngine;
public class GameHUD : NetworkBehaviour
{
    [SerializeField] private TMP_Text lobbyCodeText;
    public void LeaveGame()
    {
        if (NetworkManager.Singleton.IsHost)
        {
            HostSingleton.Instance.GameManager.Shutdown();
        }

        ClientSingleton.Instance.GameManager.Disconnect();
    }
}