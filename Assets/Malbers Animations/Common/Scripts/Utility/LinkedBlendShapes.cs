﻿using UnityEngine;

namespace MalbersAnimations.Utilities
{
    [ExecuteInEditMode]
    public class LinkedBlendShapes : MonoBehaviour
    {
        public SkinnedMeshRenderer master;
        public SkinnedMeshRenderer slave;

        void Update()
        {
            UpdateSlaveBlendShapes();
        }

     public virtual void UpdateSlaveBlendShapes()
        {
            if (master && slave)
            {
                for (int i = 0; i < slave.sharedMesh.blendShapeCount; i++)
                {
                    slave.SetBlendShapeWeight(i, master.GetBlendShapeWeight(i));
                }
            }
        }
    }
}