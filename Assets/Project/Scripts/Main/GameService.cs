using System;
using UnityEngine;

/// <summary>
///  Game Service 
/// </summary>

public class GameService : MonoBehaviour
{
    // Services
    private UiService uiService;
    private ShopService shopService;

    private PlayerService playerService;

    // ScriptableObject 
    [SerializeField] private ItemConfigurationSO itemConfigurationSO;


    // Views
    [SerializeField] private UiView uiView;

    //Scene Reference 
    [SerializeField] private AudioSource audioSource;
    private void Start()
    {
        InitializeService();
        InjectDependency();
    }
    private void InitializeService()
    {
        uiService = new UiService();
        shopService = new ShopService(itemConfigurationSO);
        playerService = new PlayerService();
    }
    private void InjectDependency()
    {
        uiService.Init(uiView);
        shopService.Init(playerService, uiService);
    }


}


