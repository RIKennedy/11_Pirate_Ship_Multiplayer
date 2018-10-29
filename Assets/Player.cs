using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityStandardAssets.CrossPlatformInput;

public class Player : NetworkBehaviour {


    private Vector3 inputValue;
    [SerializeField] float horizScale = 20f;
    [SerializeField] float vertScale = 20f;



    void Update ()
    {
        if (!isLocalPlayer)
        {
            return;
        }
        inputValue.x = CrossPlatformInputManager.GetAxis("Horizontal") * horizScale * Time.deltaTime;
        inputValue.y = 0f * Time.deltaTime;
        inputValue.z = CrossPlatformInputManager.GetAxis("Vertical") * vertScale * Time.deltaTime;

        transform.Translate(inputValue);
    }

    public override void OnStartLocalPlayer()
    {
        GetComponentInChildren<Camera>().enabled = true;
    }



}
