using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class UIPosition : MonoBehaviour
{
    public GameObject target;
    private TextMeshProUGUI textPosition;

    void Start()
    {
        textPosition = gameObject.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        textPosition.text = "position(x,y,z): " + (target.transform.position.x).ToString("0.00") + "," + (target.transform.position.y).ToString("0.00") + "," + (target.transform.position.z).ToString("0.00");
    }
}