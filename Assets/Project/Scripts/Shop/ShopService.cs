using UnityEngine;

/// <summary>
///  
/// </summary>

public class ShopService
{
    private ItemConfigurationSO itemConfigurationSO;

    private PlayerService playerService;
    private UiService uiService;

    public ShopService(ItemConfigurationSO _itemConfigurationSO)
    {
        this.itemConfigurationSO = _itemConfigurationSO;
    }
    public void Init(PlayerService _playerService, UiService _uiService)
    {
        this.playerService = _playerService;
        this.uiService = _uiService;
    }
}


