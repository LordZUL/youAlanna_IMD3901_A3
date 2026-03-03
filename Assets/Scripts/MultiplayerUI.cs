using UnityEngine;
using Unity.Netcode;
using UnityEngine.UI;

public class MultiplayerUI : MonoBehaviour
{
    [SerializeField] private Button hostButton;
    [SerializeField] private Button clientButton;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
        hostButton.onClick.AddListener(HostButtonOnClick);
        clientButton.onClick.AddListener(ClientButtonOnClick);

    }

    private void HostButtonOnClick()
    {
        NetworkManager.Singleton.StartHost();
    }
    private void ClientButtonOnClick()
    {
        NetworkManager.Singleton.StartClient();
    }
}
