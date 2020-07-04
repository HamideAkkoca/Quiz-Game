using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrueFalse : MonoBehaviour
{
    public GameObject dogruCevapPaneli;
    public GameObject yanliscevapPaneli;
    // Start is called before the first frame update
    public void YanlisCevap()
    {
        dogruCevapPaneli.SetActive(false);
        yanliscevapPaneli.SetActive(true);
    }

    // Update is called once per frame
    public void DogruCevap()
    {
        dogruCevapPaneli.SetActive(true);
        yanliscevapPaneli.SetActive(false);
    }
    public void Anasayfayadon()
    {
        dogruCevapPaneli.transform.parent.gameObject.SetActive(false);
    }
}
