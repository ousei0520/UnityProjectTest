using UnityEngine;

public class RacketController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    //移動速度
    [SerializeField] private float moveSpeed = 8f;
    //移動可能範囲
    [SerializeField] private float limitX = 3f;

    private void Update()
    {
        //左右入力
        float input = Input.GetAxisRaw("Horizontal");

        //現在位置取得
        Vector3 pos = transform.position;
        //水平方向に移動
        pos.x += input * moveSpeed * Time.deltaTime;
        //壁外に出ないように制限
        pos.x = Mathf.Clamp(pos.x, -limitX, limitX);

        //位置の更新
        transform.position = pos;
    }
}
