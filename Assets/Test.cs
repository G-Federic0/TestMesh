using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private EmulatorOnControllerColliderHit daBoss;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update() {
        daBoss = Object.FindObjectOfType<EmulatorOnControllerColliderHit>();
        
        // if for some reason you want that GameObject
        GameObject holder = daBoss.gameObject;
        Debug.Log(holder);
        Debug.Log("ciao");
    }
}
