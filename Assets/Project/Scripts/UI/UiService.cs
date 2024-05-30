using UnityEngine;

/// <summary>
///  
/// </summary>

public class UiService
{
    private UiController uiController;
    private UiView uiView;
    public UiService()
    {

    }
    public void Init(UiView _uiView)
    {
        this.uiView = _uiView;
    }


}


