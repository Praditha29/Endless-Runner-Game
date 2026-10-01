using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mobileControls : MonoBehaviour
{
    private MobileScript mobileScript;
    
    private void Awake(){
        mobileScript = new MobileScript();
    }

    private void OnEnable(){
        mobileScript.Enable();
    }

    private void OnDisable(){
        mobileScript.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
