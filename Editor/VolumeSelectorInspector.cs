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


            showFadeBtSet.target = EditorGUILayout.ToggleLeft("버튼셋팅", showFadeBtSet.target, EditorStyles.boldLabel);
            if (EditorGUILayout.BeginFadeGroup(showFadeBtSet.faded))
            {
                EditorGUI.indentLevel++;
                GUILayout.Space(10f);
                buttonWidth = EditorGUILayout.Slider("버튼길이", buttonWidth, 50f, 180f);
                selector.buttonWidth = buttonWidth;
                buttonHeight = EditorGUILayout.Slider("버튼길이", buttonHeight, 40f, 80f);
                selector.buttonHeight = buttonHeight;
                GUILayout.Space(10f);
                GUILayout.BeginHorizontal();
                GUILayout.FlexibleSpace();
                if (GUILayout.Button("버튼 크기 리셋", GUILayout.ExpandWidth(false), GUILayout.Width(100f), GUILayout.Height(40))) resetBT();
                GUILayout.FlexibleSpace();
                GUILayout.EndHorizontal();
                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndFadeGroup();

            GUILayout.Space(50f);

            GUILayout.Label("[기본라이팅]", EditorStyles.boldLabel);
            GUILayout.Space(10f);


            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            if (GUILayout.Button("아침", GUILayout.ExpandWidth(false), GUILayout.Width(buttonWidth), GUILayout.Height(buttonHeight))) selector.m_CurrentVolume = VolumeType.Morning;
            if (GUILayout.Button("낮", GUILayout.ExpandWidth(false), GUILayout.Width(buttonWidth), GUILayout.Height(buttonHeight))) selector.m_CurrentVolume = VolumeType.Day;
            if (GUILayout.Button("밤", GUILayout.ExpandWidth(false), GUILayout.Width(buttonWidth), GUILayout.Height(buttonHeight))) selector.m_CurrentVolume = VolumeType.MoonlessNight;
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            if (GUILayout.Button("밤(달빛)", GUILayout.ExpandWidth(false), GUILayout.Width(buttonWidth), GUILayout.Height(buttonHeight))) selector.m_CurrentVolume = VolumeType.MoonNight;
            if (GUILayout.Button("실내(스튜디오)", GUILayout.ExpandWidth(false), GUILayout.Width(buttonWidth), GUILayout.Height(buttonHeight))) selector.m_CurrentVolume = VolumeType.Interior;
            if (GUILayout.Button("실내(집)", GUILayout.ExpandWidth(false), GUILayout.Width(buttonWidth), GUILayout.Height(buttonHeight))) selector.m_CurrentVolume = VolumeType.Interior2;
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUILayout.Space(10f);

            showFadeBasicLight.target = EditorGUILayout.ToggleLeft("기본라이팅 슬롯", showFadeBasicLight.target, EditorStyles.boldLabel);
            if (EditorGUILayout.BeginFadeGroup(showFadeBasicLight.faded))
            {
                EditorGUI.indentLevel++;
                slotMorning = (GameObject)EditorGUILayout.ObjectField("아침", slotMorning, typeof(GameObject), true);
                selector.m_MorningVolume = slotMorning;
                slotDay = (GameObject)EditorGUILayout.ObjectField("낮", slotDay, typeof(GameObject), true);
                selector.m_DayVolume = slotDay;
                slotMoonless = (GameObject)EditorGUILayout.ObjectField("밤", slotMoonless, typeof(GameObject), true);
                selector.m_MoonlessVolume = slotMoonless;
                slotMoon = (GameObject)EditorGUILayout.ObjectField("밤(달빛)", slotMoon, typeof(GameObject), true);
                selector.m_MoonNightVolume = slotMoon;
                slotInterior = (GameObject)EditorGUILayout.ObjectField("실내(스튜디오)", slotInterior, typeof(GameObject), true);
                selector.m_InteriorVolume = slotInterior;
                slotInterior2 = (GameObject)EditorGUILayout.ObjectField("실내(집)", slotInterior2, typeof(GameObject), true);
                selector.m_Interior2Volume = slotInterior2;
                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndFadeGroup();


            GUILayout.Space(50f);

            GUILayout.Label("[커스텀라이팅]", EditorStyles.boldLabel);
            GUILayout.Space(10f);
            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            if (GUILayout.Button("커스텀1", GUILayout.ExpandWidth(false), GUILayout.Width(buttonWidth), GUILayout.Height(buttonHeight))) selector.m_CurrentVolume = VolumeType.CustomLight1;
            if (GUILayout.Button("커스텀2", GUILayout.ExpandWidth(false), GUILayout.Width(buttonWidth), GUILayout.Height(buttonHeight))) selector.m_CurrentVolume = VolumeType.CustomLight2;
            if (GUILayout.Button("커스텀3", GUILayout.ExpandWidth(false), GUILayout.Width(buttonWidth), GUILayout.Height(buttonHeight))) selector.m_CurrentVolume = VolumeType.CustomLight3;
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            if (GUILayout.Button("커스텀4", GUILayout.ExpandWidth(false), GUILayout.Width(buttonWidth), GUILayout.Height(buttonHeight))) selector.m_CurrentVolume = VolumeType.CustomLight4;
            if (GUILayout.Button("커스텀5", GUILayout.ExpandWidth(false), GUILayout.Width(buttonWidth), GUILayout.Height(buttonHeight))) selector.m_CurrentVolume = VolumeType.CustomLight5;
            if (GUILayout.Button("커스텀6", GUILayout.ExpandWidth(false), GUILayout.Width(buttonWidth), GUILayout.Height(buttonHeight))) selector.m_CurrentVolume = VolumeType.CustomLight6;
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUILayout.Space(10f);


            showFadeCustomLight.target = EditorGUILayout.ToggleLeft("커스텀라이팅 슬롯", showFadeCustomLight.target, EditorStyles.boldLabel);
            if (EditorGUILayout.BeginFadeGroup(showFadeCustomLight.faded))
            {
                EditorGUI.indentLevel++;
                slotCustom1 = (GameObject)EditorGUILayout.ObjectField("커스텀 라이트 1", slotCustom1, typeof(GameObject), true);
                selector.m_CustomLight1Volume = slotCustom1;
                slotCustom2 = (GameObject)EditorGUILayout.ObjectField("커스텀 라이트 2", slotCustom2, typeof(GameObject), true);
                selector.m_CustomLight2Volume = slotCustom2;
                slotCustom3 = (GameObject)EditorGUILayout.ObjectField("커스텀 라이트 3", slotCustom3, typeof(GameObject), true);
                selector.m_CustomLight3Volume = slotCustom3;
                slotCustom4 = (GameObject)EditorGUILayout.ObjectField("커스텀 라이트 4", slotCustom4, typeof(GameObject), true);
                selector.m_CustomLight4Volume = slotCustom4;
                slotCustom5 = (GameObject)EditorGUILayout.ObjectField("커스텀 라이트 5", slotCustom5, typeof(GameObject), true);
                selector.m_CustomLight5Volume = slotCustom5;
                slotCustom6 = (GameObject)EditorGUILayout.ObjectField("커스텀 라이트 6", slotCustom6, typeof(GameObject), true);
                selector.m_CustomLight6Volume = slotCustom6;
                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndFadeGroup();


            selector.Apply(selector.m_CurrentVolume);

        }




    }
}

