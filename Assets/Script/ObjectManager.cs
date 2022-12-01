using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public GameObejcts[] objects;

    public walls w;
    public sanity s;
    public static ObjectManager instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            s.value = 1;
        }

        if (s.value > 0) 
        {
            if (s.value < 5) 
            {
                MakeChaos();
            }
        }
    }

    void MakeChaos()
    {
        if (w)
        {
            Destroy(w.gameObject);
        }

        foreach (GameObejcts i in objects)
        {
            i.transform.Rotate(-1, 0, 0);
            i.transform.Translate(0, 0, 1, Space.World);
        }
    }
}
