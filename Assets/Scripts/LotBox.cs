using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LotBox : MonoBehaviour
{

    public Num numGood;
    public Num numBad;

    // Start is called before the first frame update
    void Start()
    {
        numGood = GameObject.Find("numGood").GetComponent<Num>();
        numBad = GameObject.Find("numBad").GetComponent<Num>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Lot")
        {
            Debug.Log("lot enter");
            Lot lot = other.GetComponent<Lot>();
            if(lot.isGood == true)
            {
                Debug.Log("Good lot");
                numGood.num += 1;
            }
            else
            {
                Debug.Log("Bad lot");
                numBad.num += 1;
            }
        }
    }
    
    private void OnTriggerExit2D(Collider2D other) 
    {
        if(other.tag == "Lot")
        {
            Debug.Log("lot out");
            Lot lot = other.GetComponent<Lot>();
            if(lot.isGood == true)
            {
                Debug.Log("Good lot");
                numGood.num -= 1;
            }
            else
            {
                Debug.Log("Bad lot");
                numBad.num -= 1;
            }
        }
    }
}
