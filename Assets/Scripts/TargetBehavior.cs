using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBehavior : MonoBehaviour
{
    public GameObject npc;
    private float y;
    
    // Start is called before the first frame update
    void Start()
    {
        y = 1.25f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == npc.name)
        {
            float x, z;
            x = Random.Range(-26, -57);
            z = Random.Range(-21, 64);
            if (y == 1.25f)
                y = 17.18f;
            else
                y = 1.25f;
            
            //y = Terrain.activeTerrain.SampleHeight(new Vector3(x, 0, z));
            this.transform.position = new Vector3(x,y,z);
        }
    }
}
