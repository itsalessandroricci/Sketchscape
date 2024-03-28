using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReapitinBackground : MonoBehaviour
{
    public GameObject camera1;
    public float parallaxEffect;
    private float width, positionX;

    // Start is called before the first frame update
    void Start()
    {
        width = GetComponent<SpriteRenderer>().bounds.size.x;
        positionX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        float parallaxDistance = camera1.transform.position.x * parallaxEffect;
        float reaminingDistance = camera1.transform.position.x * (1 - parallaxEffect);

        transform.position = new Vector3(positionX + parallaxDistance, transform.position.y, transform.position.z);

        if (reaminingDistance > positionX + width)
        {
            positionX += width;
        }
    }
}
