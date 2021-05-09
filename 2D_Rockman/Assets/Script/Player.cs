using UnityEngine;

public class Player : MonoBehaviour
{
    #region 事件
    [Header("移動速度"), Range(0, 1000)]
    public float speed = 10.5f;
    [Header("跳要高度"), Range(0, 3000)]
    public int jump = 100;
    [Range(0, 200)]
    public float hp = 100;
    [Header("是否在地板上"), Tooltip("儲存角色是否在地板上")]
    public bool isGrounded;
    [Header("子彈"), Tooltip("角色要發射的子彈物件")]
    public GameObject bullet;
    [Header("子彈生成點"), Tooltip("生成子彈的位置")]
    public Transform bulletPoint;
    [Range(0, 5000)]
    [Header("開槍音效"), Tooltip("開槍的聲音")]
    public AudioClip bulletSound;

    private AudioSource aud;
    private Rigidbody2D rig;
    private Animator ani;
    #endregion

    #region 事件
    private void Start()
    {
        // 利用程式取得原件
        // 傳回原件 取得原件<元件名稱>() - <泛型>
        // 取得跟此腳本同一層的元件
        rig = GetComponent<Rigidbody2D>();
    }

    //一秒約執行 60 次
    private void Update()
    {
        Move();
        Jump();
    }

    [Header("判斷地板碰撞的位移與半徑")]
    public Vector3 groundoffset;
    public float groundRadius = 0.2f;

    //繪製圖示 - 輔助編輯時的圖形線條
    private void OnDrawGizmos()
    {
        //1.指定顏色
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        //2.繪製圖形
        //transform 可以抓到此腳本同一層的變形元件
        Gizmos.DrawSphere(transform.position + groundoffset, groundRadius);
    }
    #endregion

    #region 方法
    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {
        //1.要抓到玩家按下左右鍵的資訊 Input
        float h = Input.GetAxis("Horizontal");
        print("水平的值：" + h);
        //2.使用左右鍵的資訊控制角色移動
        //剛體.加速度 = 二維向量(水平 * 速度 *一幀的時間，指定回原本的 Y軸加速度)
        //一幀的時間解決不同效能的裝置速度差問題
        rig.velocity = new Vector2(h * speed * Time.deltaTime, rig.velocity.y);
    }

    /// <summary>
    /// 跳躍
    /// </summary>
    private void Jump()
    {
        //如果 玩家 按下 空白鍵 就 往上跳躍
        //判斷式 C#
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //剛體.添加推力(二維向量)
            rig.AddForce(new Vector2(0,jump));
        }

        
    }

    /// <summary>
    /// 開槍
    /// </summary>
    private void Fire()
    {
       
    }

    /// <summary>
    /// 受傷
    /// <summary>
    /// <param name="damage">造成的傷害</param>
    private void hit(float damage)
    {

    }

    /// <summary>
    /// 死亡
    /// <summary>
    /// <return>是否死亡</return>
    private bool Dead()
    {
        return false;
    }

    /// <summary>
    /// 吃道具
    /// <summary>
    /// <param name="prop">道具的名稱</param>
    private bool Eatprop(string prop)
    {
        return false;
    }

}



    #endregion

