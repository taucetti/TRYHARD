using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{


    private const float Death_Radius = 5F;
    private const float Death_Radius_SQ = Death_Radius * Death_Radius;

    private GameObject playerGameObject;
    // Start is called before the first frame update
    void Start()
    {
        //Declaration of Player
        playerGameObject = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 distanceToPlayer = (playerGameObject.transform.position - this.transform.position);

            if(distanceToPlayer.sqrMagnitude <= Death_Radius_SQ)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
