using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
    //notify when player collider touvhes the moving platform collider
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            //put player as a child of moving platform
            collision.gameObject.transform.SetParent(transform);
        }
    }
    //overriding previous method so that after falling of the platform ,platform remove player from its ch
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            //put player as a child of moving platform
            collision.gameObject.transform.SetParent(null);
        }
    }

}
