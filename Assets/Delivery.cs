using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{

    [SerializeField] Color32 hasPackageColor = new Color32(1,1,1,1);
    [SerializeField] Color32 noPackageColor = new Color32(1,1,1,1);
    [SerializeField] float destroyDelay = 0.5f;
    bool pickedUp = false;

    SpriteRenderer spriteRenderer;

    void Start(){

        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("we crashed");
    }

    void OnTriggerEnter2D(Collider2D other) {

     
     if(other.tag == "Package" && !pickedUp){
        Debug.Log("package picked up");
        pickedUp = true;
        spriteRenderer.color = hasPackageColor;
        Destroy(other.gameObject, destroyDelay);
        
     }

     if(other.tag == "Customer" && pickedUp == true){
         Debug.Log("delivered package");
         spriteRenderer.color = noPackageColor;
         pickedUp = false;
     }
     
 }
}
