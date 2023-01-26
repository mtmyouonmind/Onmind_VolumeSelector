using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace OnmindVolumeSelector 
{

    public class VolumeSelectorMenu : Editor
    {


        [MenuItem("GameObject/Onmind/VolumeSelector")]
        public static void AddConfig()
        {
            GameObject createVS;
            Vector3 pos = new Vector3(0, 0, 0);
            Debug.Log("add");

            createVS = Resources.Load("Prefabs/VolumeSelector") as GameObject;
            if (createVS != null)
            {
                createVS.name = "VolumeSelector";
                Instantiate(createVS, pos, Quaternion.identity);
            }

        }

    }
}
