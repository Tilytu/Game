using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTime : MonoBehaviour
{
    private float timer = 120f;
    LevelManager manager;
    private void Start()
    {
        
        manager = GameObject.Find("GameControl").GetComponent<LevelManager>();
    }
    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            manager.lose();
            Destroy(this.gameObject);

        }
    }
}
