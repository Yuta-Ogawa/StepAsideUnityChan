using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    
public class ItemDestroy : MonoBehaviour {
    GameObject unitychan;
    GameObject mainCamera;


    private void Start() {
        this.unitychan = GameObject.Find("unitychan");
        this.mainCamera = GameObject.Find("Main Camera");
    }
    
    void Update() {
        if (this.transform.position.z < mainCamera.transform.position.z) {
            Destroy(this.gameObject);
        }
    }
}