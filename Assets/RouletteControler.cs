using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteControler : MonoBehaviour
{
    // Start is called before the first frame update
    float rotSpeed = 0; //회전 속도 초기화

    private void Start()
    {
        print(rotSpeed); //회전 값 확인
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //마우스를 클릭하면
        {
            this.rotSpeed = 10; //속도를 10으로 설정
        }
        transform.Rotate(0, 0, this.rotSpeed); //속도값만큼 회전
        this.rotSpeed *= 0.96f; //회전 속도 감소
        
    }
}
