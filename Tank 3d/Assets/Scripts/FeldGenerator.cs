using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankBattle
{
    public class FeldGenerator : MonoBehaviour
    {
        [System.Serializable]

        private struct FieldSize
        {
            public int X;
            public int Y;
        }

        [SerializeField]
        private GameObject _cellPrefab;

        [SerializeField]
        private FieldSize _fieldSize;

        [ContextMenu("Generate Field")]
        public void GenerateField()
        {
            var parent = new GameObject("GameField");

            for (int i = 0; i < _fieldSize.X; i++)
            {
                for (int j = 0; j < _fieldSize.Y; j++)
                {
                    var position = new Vector3(i, 0, j);
                    var cellClone = Instantiate(_cellPrefab, position, Quaternion.identity);
                    cellClone.transform.SetParent(parent.transform);

                    var name = $"Cell X:{i}, Y:{j}";
                    cellClone.name = name;
                }
            }
        }
    }
}
