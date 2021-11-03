using UnityEngine;

namespace TankBattle
{
    public class TankPlayer : TankBase
    {
        [SerializeField] private GameObject _bulletPrefab;

        [SerializeField] private Transform _bulletStartPosition;       

        private void Update()
        {
            Fire();
        }

        public override void Fire()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                var bullet = Instantiate(_bulletPrefab, _bulletStartPosition.position, _bulletStartPosition.rotation);
                //var b = bullet.GetComponent<Bullet>();
                //b.Init();                
            }
        }

        public override void Move()
        {
            throw new System.NotImplementedException();
        }
    }
}
