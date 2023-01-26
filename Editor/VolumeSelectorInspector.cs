using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using OnmindVolumeSelector;
using UnityEditor.AnimatedValues;

namespace OnmindVolumeSelector
{
    [CustomEditor(typeof(VolumeSelector))]
    public class VolumeSelectorEditor : Editor
    {


        VolumeSelector selector;
        Texture2D onmindLogo;

        AnimBool showFadeBtSet;
        AnimBool showFadeBasicLight;
        AnimBool showFadeCustomLight;

        GameObject slotMorning = null;
        GameObject slotDay = null;
        GameObject slotMoonless = null;
        GameObject slotMoon = null;
        GameObject slotInterior = null;
        GameObject slotInterior2 = null;
        GameObject slotCustom1 = null;
        GameObject slotCustom2 = null;
        GameObject slotCustom3 = null;
        GameObject slotCustom4 = null;
        GameObject slotCustom5 = null;
        GameObject slotCustom6 = null;

        float buttonWidth;
        float buttonHeight;

        private void OnEnable()
        {
            selector = target as VolumeSelector;
            onmindLogo = Resources.Load<Texture2D>("Images/SmallLogo");

            buttonWidth = selector.buttonWidth;
            buttonHeight = selector.buttonHeight;

            slotMorning = selector.m_MorningVolume;
            slotDay = selector.m_DayVolume;
            slotMoonless = selector.m_MoonlessVolume;
            slotMoon = selector.m_MoonNightVolume;
            slotInterior = selector.m_InteriorVolume;
            slotInterior2 = selector.m_Interior2Volume;
            slotCustom1 = selector.m_CustomLight1Volume;
            slotCustom2 = selector.m_CustomLight2Volume;
            slotCustom3 = selector.m_CustomLight3Volume;
            slotCustom4 = selector.m_CustomLight4Volume;
            slotCustom5 = selector.m_CustomLight5Volume;
            slotCustom6 = selector.m_CustomLight6Volume;

            showFadeBtSet = new AnimBool(true);
            showFadeBtSet.valueChanged.AddListener(Repaint);
            showFadeBasicLight = new AnimBool(false);
            showFadeBasicLight.valueChanged.AddListener(Repaint);
            showFadeCustomLight = new AnimBool(false);
            showFadeCustomLight.valueChanged.AddListener(Repaint);


        }

        public void resetBT()
        {
            buttonWidth = 150f;
            buttonHeight = 60f;
        }

        public override void OnInspectorGUI()
        {
            //base.OnInspectorGUI();

            GUILayout.Space(30f);
            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            GUILayout.Label(onmindLogo);
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUILayout.Space(30f);


            showFadeBtSet.target = EditorGUILayout.ToggleLeft("��ư����", showFadeBtSet.target, EditorStyles.boldLabel);
            if (EditorGUILayout.BeginFadeGroup(showFadeBtSet.faded))
            {
                EditorGUI.indentLevel++;
                GUILayout.Space(10f);
                buttonWidth = EditorGUILayout.Slider("��ư����", buttonWidth, 50f, 180f);
                selector.buttonWidth = buttonWidth;
                buttonHeight = EditorGUILayout.Slider("��ư����", buttonHeight, 40f, 80f);
                selector.buttonHeight = buttonHeight;
                GUILayout.Space(10f);
                GUILayout.BeginHorizontal();
                GUILayout.FlexibleSpace();
                if (GUILayout.Button("��ư ũ�� ����", GUILayout.ExpandWidth(false), GUILayout.Width(100f), GUILayout.Height(40))) resetBT();
                GUILayout.FlexibleSpace();
                GUILayout.EndHorizontal();
                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndFadeGroup();

            GUILayout.Space(50f);

            GUILayout.Label("[�⺻������]", EditorStyles.boldLabel);
            GUILayout.Space(10f);


            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            if (GUILayout.Button("��ħ", GUILayout.ExpandWidth(false), GUILayout.Width(buttonWidth), GUILayout.Height(buttonHeight))) selector.m_CurrentVolume = VolumeType.Morning;
            if (GUILayout.Button("��", GUILayout.ExpandWidth(false), GUILayout.Width(buttonWidth), GUILayout.Height(buttonHeight))) selector.m_CurrentVolume = VolumeType.Day;
            if (GUILayout.Button("��", GUILayout.ExpandWidth(false), GUILayout.Width(buttonWidth), GUILayout.Height(buttonHeight))) selector.m_CurrentVolume = VolumeType.MoonlessNight;
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            if (GUILayout.Button("��(�޺�)", GUILayout.ExpandWidth(false), GUILayout.Width(buttonWidth), GUILayout.Height(buttonHeight))) selector.m_CurrentVolume = VolumeType.MoonNight;
            if (GUILayout.Button("�ǳ�(��Ʃ���)", GUILayout.ExpandWidth(false), GUILayout.Width(buttonWidth), GUILayout.Height(buttonHeight))) selector.m_CurrentVolume = VolumeType.Interior;
            if (GUILayout.Button("�ǳ�(��)", GUILayout.ExpandWidth(false), GUILayout.Width(buttonWidth), GUILayout.Height(buttonHeight))) selector.m_CurrentVolume = VolumeType.Interior2;
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUILayout.Space(10f);

            showFadeBasicLight.target = EditorGUILayout.ToggleLeft("�⺻������ ����", showFadeBasicLight.target, EditorStyles.boldLabel);
            if (EditorGUILayout.BeginFadeGroup(showFadeBasicLight.faded))
            {
                EditorGUI.indentLevel++;
                slotMorning = (GameObject)EditorGUILayout.ObjectField("��ħ", slotMorning, typeof(GameObject), true);
                selector.m_MorningVolume = slotMorning;
                slotDay = (GameObject)EditorGUILayout.ObjectField("��", slotDay, typeof(GameObject), true);
                selector.m_DayVolume = slotDay;
                slotMoonless = (GameObject)EditorGUILayout.ObjectField("��", slotMoonless, typeof(GameObject), true);
                selector.m_MoonlessVolume = slotMoonless;
                slotMoon = (GameObject)EditorGUILayout.ObjectField("��(�޺�)", slotMoon, typeof(GameObject), true);
                selector.m_MoonNightVolume = slotMoon;
                slotInterior = (GameObject)EditorGUILayout.ObjectField("�ǳ�(��Ʃ���)", slotInterior, typeof(GameObject), true);
                selector.m_InteriorVolume = slotInterior;
                slotInterior2 = (GameObject)EditorGUILayout.ObjectField("�ǳ�(��)", slotInterior2, typeof(GameObject), true);
                selector.m_Interior2Volume = slotInterior2;
                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndFadeGroup();


            GUILayout.Space(50f);

            GUILayout.Label("[Ŀ���Ҷ�����]", EditorStyles.boldLabel);
            GUILayout.Space(10f);
            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            if (GUILayout.Button("Ŀ����1", GUILayout.ExpandWidth(false), GUILayout.Width(buttonWidth), GUILayout.Height(buttonHeight))) selector.m_CurrentVolume = VolumeType.CustomLight1;
            if (GUILayout.Button("Ŀ����2", GUILayout.ExpandWidth(false), GUILayout.Width(buttonWidth), GUILayout.Height(buttonHeight))) selector.m_CurrentVolume = VolumeType.CustomLight2;
            if (GUILayout.Button("Ŀ����3", GUILayout.ExpandWidth(false), GUILayout.Width(buttonWidth), GUILayout.Height(buttonHeight))) selector.m_CurrentVolume = VolumeType.CustomLight3;
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            if (GUILayout.Button("Ŀ����4", GUILayout.ExpandWidth(false), GUILayout.Width(buttonWidth), GUILayout.Height(buttonHeight))) selector.m_CurrentVolume = VolumeType.CustomLight4;
            if (GUILayout.Button("Ŀ����5", GUILayout.ExpandWidth(false), GUILayout.Width(buttonWidth), GUILayout.Height(buttonHeight))) selector.m_CurrentVolume = VolumeType.CustomLight5;
            if (GUILayout.Button("Ŀ����6", GUILayout.ExpandWidth(false), GUILayout.Width(buttonWidth), GUILayout.Height(buttonHeight))) selector.m_CurrentVolume = VolumeType.CustomLight6;
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUILayout.Space(10f);


            showFadeCustomLight.target = EditorGUILayout.ToggleLeft("Ŀ���Ҷ����� ����", showFadeCustomLight.target, EditorStyles.boldLabel);
            if (EditorGUILayout.BeginFadeGroup(showFadeCustomLight.faded))
            {
                EditorGUI.indentLevel++;
                slotCustom1 = (GameObject)EditorGUILayout.ObjectField("Ŀ���� ����Ʈ 1", slotCustom1, typeof(GameObject), true);
                selector.m_CustomLight1Volume = slotCustom1;
                slotCustom2 = (GameObject)EditorGUILayout.ObjectField("Ŀ���� ����Ʈ 2", slotCustom2, typeof(GameObject), true);
                selector.m_CustomLight2Volume = slotCustom2;
                slotCustom3 = (GameObject)EditorGUILayout.ObjectField("Ŀ���� ����Ʈ 3", slotCustom3, typeof(GameObject), true);
                selector.m_CustomLight3Volume = slotCustom3;
                slotCustom4 = (GameObject)EditorGUILayout.ObjectField("Ŀ���� ����Ʈ 4", slotCustom4, typeof(GameObject), true);
                selector.m_CustomLight4Volume = slotCustom4;
                slotCustom5 = (GameObject)EditorGUILayout.ObjectField("Ŀ���� ����Ʈ 5", slotCustom5, typeof(GameObject), true);
                selector.m_CustomLight5Volume = slotCustom5;
                slotCustom6 = (GameObject)EditorGUILayout.ObjectField("Ŀ���� ����Ʈ 6", slotCustom6, typeof(GameObject), true);
                selector.m_CustomLight6Volume = slotCustom6;
                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndFadeGroup();


            selector.Apply(selector.m_CurrentVolume);

        }




    }
}

