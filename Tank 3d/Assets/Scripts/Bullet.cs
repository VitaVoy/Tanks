using UnityEngine;

namespace TankBattle
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] 
        private float _speed;

        private Enemies _enemyTanks;

        private void Start()
        {
            _enemyTanks.enemies.AddRange(FindObjectsOfType<TankEnemy>());
        }
        private void Update()
        {
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        }

        private void OnCollisionEnter(Collision collision)
        {
            TankEnemy tankEnemy = collision.gameObject.GetComponent<TankEnemy>();
            if (tankEnemy != null)
            {
                _enemyTanks.enemies[0].Fire();
                Destroy(this.gameObject);
            }
            else if (tankEnemy != null)
            {
                _enemyTanks.enemies[1].Fire();
                Destroy(this.gameObject);
            }
            else if (tankEnemy != null)
            {
                _enemyTanks.enemies[2].Fire();
                Destroy(this.gameObject);
            }
        }
    }
}