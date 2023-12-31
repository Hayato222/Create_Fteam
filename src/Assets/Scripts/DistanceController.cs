using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DistanceController : MonoBehaviour
{

    [SerializeField] private GameObject target;
    [SerializeField] private GameObject player;
    [SerializeField] private TMPro.TMP_Text counter;

    void Start()
    {
    }

    void Update()
    {
        // ターゲットのポジションを取得
        Vector3 targetPos = target.transform.position;

        // プレイヤーのポジションを取得
        Vector3 playerPos = player.transform.position;

        // ターゲットとプレイヤーの距離を取得
        float dis = Vector3.Distance(targetPos, playerPos);

        dis = float.Parse(dis.ToString("f2"));

        // カウンター
        counter.text = Convert.ToString(dis);
    }
}