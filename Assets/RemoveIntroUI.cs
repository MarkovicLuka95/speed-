using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;


public class RemoveIntroUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var sanityManager = GameObject.FindGameObjectsWithTag("SanityManager")[0];
        sanityManager.GetComponent<sanity>().value = 1;
        if (GetComponent<PlayableDirector>().state != PlayState.Playing)
		{
			Destroy(transform.parent.gameObject);
		}


	}
}
