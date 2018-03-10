using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move99 : MonoBehaviour
{
    // 位置座標
    private Vector3 MousePosition;
    private Vector3 SmoothPosition;
    // Use this for initialization
    void Start()
    {
        MousePosition = SmoothPosition = Input.mousePosition;
    }

    void Update()
    {
        Camera gameCamera = Camera.main;

        // Vector3でマウス位置座標を取得する
        MousePosition = Input.mousePosition;

        MousePosition.x = Mathf.Clamp(MousePosition.x, 0.0f, Screen.width);
        MousePosition.y = Mathf.Clamp(MousePosition.y, 0.0f, Screen.height);
        MousePosition.z = 10.0f;

        SmoothPosition = (SmoothPosition * 2 + MousePosition) / 3;

        Vector3 WorldPosition = gameCamera.ScreenToWorldPoint(SmoothPosition);

        // オブジェクトにマウス座標を代入
        gameObject.transform.position = WorldPosition;

        //Converting Mouse Pos to 2D (vector2) World Pos
        Vector2 RayPosition = new Vector2(WorldPosition.x, WorldPosition.y);
        RaycastHit2D hit = Physics2D.Raycast(RayPosition, Vector2.zero, 0f);

        if (hit.collider != null)
        {


            Vector3 ObjectPosition = hit.transform.position;
            ObjectPosition.z -= 0.05f;
            gameObject.transform.position = ObjectPosition;

            if (Input.GetMouseButton(0))
            {
                //左ボタンが押されている
                hit.transform.gameObject.transform.position = WorldPosition;
                if(hit.rigidbody != null)
                    hit.rigidbody.velocity = Vector2.zero;
            }
        }
    }
}
