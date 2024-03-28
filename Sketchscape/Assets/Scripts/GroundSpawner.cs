using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{

    public GameObject Ground1, Ground2, Ground3;
    bool hasGround = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!hasGround)
        {
            SpaceGround();
            hasGround = true;
        }
    }

    public void SpaceGround()
    {
        int randomNum = Random.Range(1, 4);

        if(randomNum == 1)
        {
            Instantiate(Ground1, new Vector3(transform.position.x + 3, -4.17f, 0), Quaternion.identity);
        }
         if(randomNum == 2)
        {
            Instantiate(Ground2, new Vector3(transform.position.x + 3, -2.05f, 0), Quaternion.identity);
        }
        if(randomNum == 3)
        {
            Instantiate(Ground3, new Vector3(transform.position.x + 3, -1.04f, 0), Quaternion.identity);
        }
    }

   private void OnTriggerEnter2D(Collider2D collision)
   {
    if(collision.gameObject.CompareTag("Ground"))
    {
        hasGround = true;
    }
   }

private void OnTriggerExit2D(Collider2D collision)
{
 if(collision.gameObject.CompareTag("Ground"))
    {
        hasGround = false;
    }
}

}
