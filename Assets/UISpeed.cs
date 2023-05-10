using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class UISpeed : MonoBehaviour
{
    public GameObject target;
    private TextMeshProUGUI textSpeed; 
    private float speed;

    void Start()
    {
        textSpeed = gameObject.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        StartCoroutine(CalculateSpeed());
        textSpeed.text = "speed: " + (speed).ToString("F2");
    }

    IEnumerator CalculateSpeed()
    {
        Vector3 lastPosition = target.transform.position;
        yield return new WaitForFixedUpdate();
        speed = (lastPosition - target.transform.position).magnitude / Time.deltaTime;
    }
    
}