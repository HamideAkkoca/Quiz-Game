using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public float timeleft;
    public Text zaman;

    // Update is called once per frame
    void Update()
    {
        timeleft -= Time.deltaTime;
        zaman.text = timeleft.ToString("100.01");
    }
}
