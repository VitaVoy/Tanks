using UnityEngine;

namespace TankBattle
{
    public abstract class TankBase : MonoBehaviour
    {
        public float speed;        

        public abstract void Move();

        public abstract void Fire();
    }
}
