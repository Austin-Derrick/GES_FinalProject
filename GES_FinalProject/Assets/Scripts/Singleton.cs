using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Generic that inherits from Monobehavir ensures that we can use the Unity API
// Where T is MonoBehaviour (or inherits from MonoBehavior) ensures T to Singleton<T> 
public class Singleton<T> : MonoBehaviour
    where T : MonoBehaviour
{
    static public T  Instance01 { get; private set; }
    static public T Instance02 { get; private set; }

    private void Awake()
    {

        if (Instance01 == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance01 = this as T;
        }
        else if (Instance01 != null && Instance02 == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance02 = this as T;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
