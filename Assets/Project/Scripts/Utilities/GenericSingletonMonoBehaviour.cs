using UnityEngine;

/// <summary>
///  Generic Singleton MonoBehaviour 
/// </summary>

public class GenericSingletonMonoBehaviour<T> : MonoBehaviour where T : GenericSingletonMonoBehaviour<T>
{
    private static T instance;
    public static T Instance { get { return instance; } }

    private void Awake()
    {
        if (instance == null)
        {
            instance = (T)this;
        }
        else
        {
            Destroy(gameObject);
        }

    }

}


