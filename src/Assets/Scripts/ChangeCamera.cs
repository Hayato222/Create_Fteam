using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera
    : MonoBehaviour
{
    private StartTimer timer;
    public GameObject mainCamera;
    public GameObject subCamera;
    void Start()
    {
        timer = GameObject.Find("Timer").GetComponent<StartTimer>();
        // �e�J�����I�u�W�F�N�g���擾
        mainCamera = GameObject.Find("Main Camera");
        subCamera = GameObject.Find("Sub Camera");

        // �T�u�J�����̓f�t�H���g�Ŗ����ɂ��Ă���
        subCamera.SetActive(true);
    }

    void Update()
    {
        // ����Space�L�[�������ꂽ�Ȃ�΁A
        if (timer.CountDownTime <= 0)
        {
            // �e�J�����I�u�W�F�N�g�̗L���t���O���t�](true��false,false��true)������
            subCamera.SetActive(false);
            mainCamera.SetActive(true);
            
        }
    }
}