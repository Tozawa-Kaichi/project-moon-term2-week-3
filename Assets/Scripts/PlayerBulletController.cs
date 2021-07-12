using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// シューティングゲームで自機から発射される弾を制御するコンポーネント
/// 弾はインスタンス化されたら自ら飛んでいく
/// </summary>
[RequireComponent(typeof(Rigidbody2D))] // Rigidbody コンポーネントのアタッチを強制する
public class PlayerBulletController : MonoBehaviour
{
    /// <summary>弾の発射方向</summary>
    [SerializeField] Vector2 m_direction = Vector2.up;
    /// <summary>弾の飛ぶ速度</summary>
    [SerializeField] float m_bulletSpeed = 10f;
    Rigidbody2D m_rb;
    [SerializeField] float m_offset=1;

    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
        Vector3 v = m_direction.normalized * m_bulletSpeed; // 弾が飛ぶ速度ベクトルを計算する
        m_rb.velocity = v;                                  // 速度ベクトルを弾にセットする
    }
    private void Update()
    {
        //var cols =Physics2D.OverlapCircleAll(this.transform.position + Vector2.up * m_offset);
        //Collider2D closestEnemy = default;

    }
}
