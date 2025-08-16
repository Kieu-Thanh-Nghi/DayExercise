using UnityEngine;

public class DestroyWhenAnimEnd : MonoBehaviour
{
    public void DestroyThis()
    {
        Destroy(this.gameObject);
    }
}
