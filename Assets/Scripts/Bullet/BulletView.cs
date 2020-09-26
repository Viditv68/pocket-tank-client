using UnityEngine;

public class BulletView : MonoBehaviour
{
    
    private Rigidbody2D rbd;

    private void Awake()
    {
        Debug.Log("awake is called");
        rbd = gameObject.GetComponent<Rigidbody2D>();
        
    }

    

    public void FireBullet(float power)
    {
        Debug.Log("power: " + power);
        rbd.AddRelativeForce(transform.up * power, ForceMode2D.Impulse);
    }

    public void SetBulletAngle(float angle)
    {
        transform.rotation = Quaternion.Euler(0, 0, angle-90);
        
    }

}
