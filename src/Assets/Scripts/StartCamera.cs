using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCamera : MonoBehaviour
{
    public Transform player;
    float MovingDistanceSec = 4;
    float MovingAngleSec = 30;
    private StartTimer timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = GameObject.Find("Timer").GetComponent<StartTimer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.CountDownTime > 0)
        {
            transform.position -= Vector3.right * Time.deltaTime * MovingDistanceSec;
            transform.position += Vector3.up * Time.deltaTime * MovingDistanceSec;
            transform.Rotate(Vector3.right * Time.deltaTime * MovingAngleSec);
            //transform.Rotate(Vector3.forward * Time.deltaTime * MovingAngleSec*2);
        }

    }
}
