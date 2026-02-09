using UnityEngine;

public class BallController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    //初期速度
    [SerializeField] private float StartSpeed = 5f;
    //衝突のたびに増加する速度
    [SerializeField] private float speedIncreaseRate = 0.2f;

    private Rigidbody2D rb;
    //現在の速度
    private float NowSpeed;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //速度初期化
        NowSpeed = StartSpeed;

        //ランダムな方向で上向きにボールを発射
        Vector2 startDir = new Vector2(Random.Range(-0.5f, 0.5f), 1f).normalized;
        rb.velocity = startDir * NowSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ////衝突するたびに速度を増加
        //NowSpeed += speedIncreaseRate;

        ////ラケットに当たった場合
        //if (collision.gameObject.CompareTag("Racket"))
        //{
        //    ReflectFromRacket(collision);
        //}
        //else
        //{
        //    rb.velocity = rb.velocity.normalized * NowSpeed;
        //}

        //ブロックに当たった場合
        if (collision.gameObject.CompareTag("Block"))
        {
            //得点加算
            //GameManager.Instance.AddScore(10);
            //ブロック削除
            Destroy(collision.gameObject);
        }
    }

    //private void ReflectFromRacket(Collision2D collision)
    //{
    //    Transform racket = collision.transform;

    //    //衝突位置とラケットの中心の差
    //    float hitPoint = transform.position.x - racket.position.x;
    //    //ラケットの幅
    //    float racketWidth = collision.collider.bounds.size.x;

    //    float normalized = hitPoint / (racketWidth / 2f);

    //    Vector2 newDir = new Vector2(normalized, 1f).normalized;

    //    rb.velocity = newDir * NowSpeed;
    //}
}
