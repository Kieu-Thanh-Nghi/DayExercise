using System;
using UnityEngine;

public class Beam : MonoBehaviour
{
    [SerializeField] GameObject BeamExplorePrefab;
    [SerializeField] Transform head;   
    [SerializeField] SpriteRenderer Body;
    [SerializeField] float defaultBeamSpeed;
    [SerializeField] float destroyTime;
    public Action DoWhenDestroy;
    float beamSpeed;
    bool isDestroy;
    bool isExplore;

    private void Start()
    {
        beamSpeed = defaultBeamSpeed;
        isDestroy = false;
        isExplore = false;
        Invoke(nameof(DestroyThis), destroyTime);
    }
    private void FixedUpdate()
    {
        head.Translate(transform.right * beamSpeed);
        Body.size += Vector2.right * beamSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        BodyCollide enemyBody = collision.GetComponent<BodyCollide>();
        if(enemyBody != null)
        {
            beamSpeed = beamSpeed / 10;
            CancelInvoke(nameof(DestroyThis));
            Invoke(nameof(DestroyThis), destroyTime/5);
        }
    }
    private void Update()
    {
        if (isDestroy)
        {
            DoToDestroy();
        }
    }

    void DestroyThis()
    {
        isDestroy = true;
    }
    void DoToDestroy()
    {
        Body.size -= Vector2.up * beamSpeed;
        head.gameObject.SetActive(false);
        if (!isExplore)
        {
            Instantiate(BeamExplorePrefab, head.position, head.rotation);
            isExplore = true;
        }
        if(Body.size.y < 1f)
        {
            DoWhenDestroy?.Invoke();
            Destroy(this.gameObject);
            isDestroy = false;
        }
    }
}
