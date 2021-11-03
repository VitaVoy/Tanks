using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace TankBattle
{
    public class ActiveCell : MonoBehaviour
    {
        [System.Serializable]

        private struct ColorByState
        {
            public CellStateType CellStateType;

            public Color Color;
        }

        [SerializeField]
        private List<ColorByState> colorsByState;

        private Dictionary<CellStateType, ColorByState> colorsByStateDict = new Dictionary<CellStateType, ColorByState>();

        private MeshRenderer _meshRenderer;


        private void Awake()
        {
            InitColorsByStateDict();
            _meshRenderer = GetComponent<MeshRenderer>();
        }

        private void InitColorsByStateDict()
        {
            foreach (var colorByState in colorsByState)
            {
                colorsByStateDict.Add(colorByState.CellStateType, colorByState);
            }
        }

        public void SetColorByState(CellStateType state)
        {
            var material = _meshRenderer.materials.First();
            material.SetColor("_Color", colorsByStateDict[state].Color);
        }
    }
}