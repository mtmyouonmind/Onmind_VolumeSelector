using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OnmindVolumeSelector

{
    
    public enum VolumeType
    {
        Morning,
        Day,
        MoonlessNight,
        MoonNight,
        Interior,
        Interior2,
        CustomLight1,
        CustomLight2,
        CustomLight3,
        CustomLight4,
        CustomLight5,
        CustomLight6,

    }

    
    public class VolumeSelector : MonoBehaviour
    {
        public float buttonWidth = 150f;
        public float buttonHeight = 60f;

        public VolumeType m_CurrentVolume = VolumeType.Day;
        public GameObject m_MorningVolume;
        public GameObject m_DayVolume;
        public GameObject m_MoonlessVolume;
        public GameObject m_MoonNightVolume;
        public GameObject m_InteriorVolume;
        public GameObject m_Interior2Volume;
        public GameObject m_CustomLight1Volume;
        public GameObject m_CustomLight2Volume;
        public GameObject m_CustomLight3Volume;
        public GameObject m_CustomLight4Volume;
        public GameObject m_CustomLight5Volume;
        public GameObject m_CustomLight6Volume;

        
        public void Apply(VolumeType type)
        {
            switch (type)
            {
                case VolumeType.Morning:
                    if (m_MorningVolume != null)
                    {
                        m_MorningVolume.SetActive(true);
                    }
                    if (m_DayVolume != null)
                    {
                        m_DayVolume.SetActive(false);
                    }
                    if (m_MoonlessVolume != null)
                    {
                        m_MoonlessVolume.SetActive(false);
                    }
                    if (m_MoonNightVolume != null)
                    {
                        m_MoonNightVolume.SetActive(false);
                    }
                    if (m_InteriorVolume != null)
                    {
                        m_InteriorVolume.SetActive(false);
                    }
                    if (m_Interior2Volume != null)
                    {
                        m_Interior2Volume.SetActive(false);
                    }
                    if (m_CustomLight1Volume != null)
                    {
                        m_CustomLight1Volume.SetActive(false);
                    }
                    if (m_CustomLight2Volume != null)
                    {
                        m_CustomLight2Volume.SetActive(false);
                    }
                    if (m_CustomLight3Volume != null)
                    {
                        m_CustomLight3Volume.SetActive(false);
                    }
                    if (m_CustomLight4Volume != null)
                    {
                        m_CustomLight4Volume.SetActive(false);
                    }
                    if (m_CustomLight5Volume != null)
                    {
                        m_CustomLight5Volume.SetActive(false);
                    }
                    if (m_CustomLight6Volume != null)
                    {
                        m_CustomLight6Volume.SetActive(false);
                    }
                    break;
                case VolumeType.Day:
                    if (m_MorningVolume != null)
                    {
                        m_MorningVolume.SetActive(false);
                    }
                    if (m_DayVolume != null)
                    {
                        m_DayVolume.SetActive(true);
                    }
                    if (m_MoonlessVolume != null)
                    {
                        m_MoonlessVolume.SetActive(false);
                    }
                    if (m_MoonNightVolume != null)
                    {
                        m_MoonNightVolume.SetActive(false);
                    }
                    if (m_InteriorVolume != null)
                    {
                        m_InteriorVolume.SetActive(false);
                    }
                    if (m_Interior2Volume != null)
                    {
                        m_Interior2Volume.SetActive(false);
                    }
                    if (m_CustomLight1Volume != null)
                    {
                        m_CustomLight1Volume.SetActive(false);
                    }
                    if (m_CustomLight2Volume != null)
                    {
                        m_CustomLight2Volume.SetActive(false);
                    }
                    if (m_CustomLight3Volume != null)
                    {
                        m_CustomLight3Volume.SetActive(false);
                    }
                    if (m_CustomLight4Volume != null)
                    {
                        m_CustomLight4Volume.SetActive(false);
                    }
                    if (m_CustomLight5Volume != null)
                    {
                        m_CustomLight5Volume.SetActive(false);
                    }
                    if (m_CustomLight6Volume != null)
                    {
                        m_CustomLight6Volume.SetActive(false);
                    }
                    break;
                case VolumeType.MoonlessNight:
                    if (m_MorningVolume != null)
                    {
                        m_MorningVolume.SetActive(false);
                    }
                    if (m_DayVolume != null)
                    {
                        m_DayVolume.SetActive(false);
                    }
                    if (m_MoonlessVolume != null)
                    {
                        m_MoonlessVolume.SetActive(true);
                    }
                    if (m_MoonNightVolume != null)
                    {
                        m_MoonNightVolume.SetActive(false);
                    }
                    if (m_InteriorVolume != null)
                    {
                        m_InteriorVolume.SetActive(false);
                    }
                    if (m_Interior2Volume != null)
                    {
                        m_Interior2Volume.SetActive(false);
                    }
                    if (m_CustomLight1Volume != null)
                    {
                        m_CustomLight1Volume.SetActive(false);
                    }
                    if (m_CustomLight2Volume != null)
                    {
                        m_CustomLight2Volume.SetActive(false);
                    }
                    if (m_CustomLight3Volume != null)
                    {
                        m_CustomLight3Volume.SetActive(false);
                    }
                    if (m_CustomLight4Volume != null)
                    {
                        m_CustomLight4Volume.SetActive(false);
                    }
                    if (m_CustomLight5Volume != null)
                    {
                        m_CustomLight5Volume.SetActive(false);
                    }
                    if (m_CustomLight6Volume != null)
                    {
                        m_CustomLight6Volume.SetActive(false);
                    }
                    break;
                case VolumeType.MoonNight:
                    if (m_MorningVolume != null)
                    {
                        m_MorningVolume.SetActive(false);
                    }
                    if (m_DayVolume != null)
                    {
                        m_DayVolume.SetActive(false);
                    }
                    if (m_MoonlessVolume != null)
                    {
                        m_MoonlessVolume.SetActive(false);
                    }
                    if (m_MoonNightVolume != null)
                    {
                        m_MoonNightVolume.SetActive(true);
                    }
                    if (m_InteriorVolume != null)
                    {
                        m_InteriorVolume.SetActive(false);
                    }
                    if (m_Interior2Volume != null)
                    {
                        m_Interior2Volume.SetActive(false);
                    }
                    if (m_CustomLight1Volume != null)
                    {
                        m_CustomLight1Volume.SetActive(false);
                    }
                    if (m_CustomLight2Volume != null)
                    {
                        m_CustomLight2Volume.SetActive(false);
                    }
                    if (m_CustomLight3Volume != null)
                    {
                        m_CustomLight3Volume.SetActive(false);
                    }
                    if (m_CustomLight4Volume != null)
                    {
                        m_CustomLight4Volume.SetActive(false);
                    }
                    if (m_CustomLight5Volume != null)
                    {
                        m_CustomLight5Volume.SetActive(false);
                    }
                    if (m_CustomLight6Volume != null)
                    {
                        m_CustomLight6Volume.SetActive(false);
                    }
                    break;
                case VolumeType.Interior:
                    if (m_MorningVolume != null)
                    {
                        m_MorningVolume.SetActive(false);
                    }
                    if (m_DayVolume != null)
                    {
                        m_DayVolume.SetActive(false);
                    }
                    if (m_MoonlessVolume != null)
                    {
                        m_MoonlessVolume.SetActive(false);
                    }
                    if (m_MoonNightVolume != null)
                    {
                        m_MoonNightVolume.SetActive(false);
                    }
                    if (m_InteriorVolume != null)
                    {
                        m_InteriorVolume.SetActive(true);
                    }
                    if (m_Interior2Volume != null)
                    {
                        m_Interior2Volume.SetActive(false);
                    }
                    if (m_CustomLight1Volume != null)
                    {
                        m_CustomLight1Volume.SetActive(false);
                    }
                    if (m_CustomLight2Volume != null)
                    {
                        m_CustomLight2Volume.SetActive(false);
                    }
                    if (m_CustomLight3Volume != null)
                    {
                        m_CustomLight3Volume.SetActive(false);
                    }
                    if (m_CustomLight4Volume != null)
                    {
                        m_CustomLight4Volume.SetActive(false);
                    }
                    if (m_CustomLight5Volume != null)
                    {
                        m_CustomLight5Volume.SetActive(false);
                    }
                    if (m_CustomLight6Volume != null)
                    {
                        m_CustomLight6Volume.SetActive(false);
                    }
                    break;
                case VolumeType.Interior2:
                    if (m_MorningVolume != null)
                    {
                        m_MorningVolume.SetActive(false);
                    }
                    if (m_DayVolume != null)
                    {
                        m_DayVolume.SetActive(false);
                    }
                    if (m_MoonlessVolume != null)
                    {
                        m_MoonlessVolume.SetActive(false);
                    }
                    if (m_MoonNightVolume != null)
                    {
                        m_MoonNightVolume.SetActive(false);
                    }
                    if (m_InteriorVolume != null)
                    {
                        m_InteriorVolume.SetActive(false);
                    }
                    if (m_Interior2Volume != null)
                    {
                        m_Interior2Volume.SetActive(true);
                    }
                    if (m_CustomLight1Volume != null)
                    {
                        m_CustomLight1Volume.SetActive(false);
                    }
                    if (m_CustomLight2Volume != null)
                    {
                        m_CustomLight2Volume.SetActive(false);
                    }
                    if (m_CustomLight3Volume != null)
                    {
                        m_CustomLight3Volume.SetActive(false);
                    }
                    if (m_CustomLight4Volume != null)
                    {
                        m_CustomLight4Volume.SetActive(false);
                    }
                    if (m_CustomLight5Volume != null)
                    {
                        m_CustomLight5Volume.SetActive(false);
                    }
                    if (m_CustomLight6Volume != null)
                    {
                        m_CustomLight6Volume.SetActive(false);
                    }
                    break;
                case VolumeType.CustomLight1:
                    if (m_MorningVolume != null)
                    {
                        m_MorningVolume.SetActive(false);
                    }
                    if (m_DayVolume != null)
                    {
                        m_DayVolume.SetActive(false);
                    }
                    if (m_MoonlessVolume != null)
                    {
                        m_MoonlessVolume.SetActive(false);
                    }
                    if (m_MoonNightVolume != null)
                    {
                        m_MoonNightVolume.SetActive(false);
                    }
                    if (m_InteriorVolume != null)
                    {
                        m_InteriorVolume.SetActive(false);
                    }
                    if (m_Interior2Volume != null)
                    {
                        m_Interior2Volume.SetActive(false);
                    }
                    if (m_CustomLight1Volume != null)
                    {
                        m_CustomLight1Volume.SetActive(true);
                    }
                    if (m_CustomLight2Volume != null)
                    {
                        m_CustomLight2Volume.SetActive(false);
                    }
                    if (m_CustomLight3Volume != null)
                    {
                        m_CustomLight3Volume.SetActive(false);
                    }
                    if (m_CustomLight4Volume != null)
                    {
                        m_CustomLight4Volume.SetActive(false);
                    }
                    if (m_CustomLight5Volume != null)
                    {
                        m_CustomLight5Volume.SetActive(false);
                    }
                    if (m_CustomLight6Volume != null)
                    {
                        m_CustomLight6Volume.SetActive(false);
                    }
                    break;
                case VolumeType.CustomLight2:
                    if (m_MorningVolume != null)
                    {
                        m_MorningVolume.SetActive(false);
                    }
                    if (m_DayVolume != null)
                    {
                        m_DayVolume.SetActive(false);
                    }
                    if (m_MoonlessVolume != null)
                    {
                        m_MoonlessVolume.SetActive(false);
                    }
                    if (m_MoonNightVolume != null)
                    {
                        m_MoonNightVolume.SetActive(false);
                    }
                    if (m_InteriorVolume != null)
                    {
                        m_InteriorVolume.SetActive(false);
                    }
                    if (m_Interior2Volume != null)
                    {
                        m_Interior2Volume.SetActive(false);
                    }
                    if (m_CustomLight1Volume != null)
                    {
                        m_CustomLight1Volume.SetActive(false);
                    }
                    if (m_CustomLight2Volume != null)
                    {
                        m_CustomLight2Volume.SetActive(true);
                    }
                    if (m_CustomLight3Volume != null)
                    {
                        m_CustomLight3Volume.SetActive(false);
                    }
                    if (m_CustomLight4Volume != null)
                    {
                        m_CustomLight4Volume.SetActive(false);
                    }
                    if (m_CustomLight5Volume != null)
                    {
                        m_CustomLight5Volume.SetActive(false);
                    }
                    if (m_CustomLight6Volume != null)
                    {
                        m_CustomLight6Volume.SetActive(false);
                    }
                    break;
                case VolumeType.CustomLight3:
                    if (m_MorningVolume != null)
                    {
                        m_MorningVolume.SetActive(false);
                    }
                    if (m_DayVolume != null)
                    {
                        m_DayVolume.SetActive(false);
                    }
                    if (m_MoonlessVolume != null)
                    {
                        m_MoonlessVolume.SetActive(false);
                    }
                    if (m_MoonNightVolume != null)
                    {
                        m_MoonNightVolume.SetActive(false);
                    }
                    if (m_InteriorVolume != null)
                    {
                        m_InteriorVolume.SetActive(false);
                    }
                    if (m_Interior2Volume != null)
                    {
                        m_Interior2Volume.SetActive(false);
                    }
                    if (m_CustomLight1Volume != null)
                    {
                        m_CustomLight1Volume.SetActive(false);
                    }
                    if (m_CustomLight2Volume != null)
                    {
                        m_CustomLight2Volume.SetActive(false);
                    }
                    if (m_CustomLight3Volume != null)
                    {
                        m_CustomLight3Volume.SetActive(true);
                    }
                    if (m_CustomLight4Volume != null)
                    {
                        m_CustomLight4Volume.SetActive(false);
                    }
                    if (m_CustomLight5Volume != null)
                    {
                        m_CustomLight5Volume.SetActive(false);
                    }
                    if (m_CustomLight6Volume != null)
                    {
                        m_CustomLight6Volume.SetActive(false);
                    }
                    break;
                case VolumeType.CustomLight4:
                    if (m_MorningVolume != null)
                    {
                        m_MorningVolume.SetActive(false);
                    }
                    if (m_DayVolume != null)
                    {
                        m_DayVolume.SetActive(false);
                    }
                    if (m_MoonlessVolume != null)
                    {
                        m_MoonlessVolume.SetActive(false);
                    }
                    if (m_MoonNightVolume != null)
                    {
                        m_MoonNightVolume.SetActive(false);
                    }
                    if (m_InteriorVolume != null)
                    {
                        m_InteriorVolume.SetActive(false);
                    }
                    if (m_Interior2Volume != null)
                    {
                        m_Interior2Volume.SetActive(false);
                    }
                    if (m_CustomLight1Volume != null)
                    {
                        m_CustomLight1Volume.SetActive(false);
                    }
                    if (m_CustomLight2Volume != null)
                    {
                        m_CustomLight2Volume.SetActive(false);
                    }
                    if (m_CustomLight3Volume != null)
                    {
                        m_CustomLight3Volume.SetActive(false);
                    }
                    if (m_CustomLight4Volume != null)
                    {
                        m_CustomLight4Volume.SetActive(true);
                    }
                    if (m_CustomLight5Volume != null)
                    {
                        m_CustomLight5Volume.SetActive(false);
                    }
                    if (m_CustomLight6Volume != null)
                    {
                        m_CustomLight6Volume.SetActive(false);
                    }
                    break;
                case VolumeType.CustomLight5:
                    if (m_MorningVolume != null)
                    {
                        m_MorningVolume.SetActive(false);
                    }
                    if (m_DayVolume != null)
                    {
                        m_DayVolume.SetActive(false);
                    }
                    if (m_MoonlessVolume != null)
                    {
                        m_MoonlessVolume.SetActive(false);
                    }
                    if (m_MoonNightVolume != null)
                    {
                        m_MoonNightVolume.SetActive(false);
                    }
                    if (m_InteriorVolume != null)
                    {
                        m_InteriorVolume.SetActive(false);
                    }
                    if (m_Interior2Volume != null)
                    {
                        m_Interior2Volume.SetActive(false);
                    }
                    if (m_CustomLight1Volume != null)
                    {
                        m_CustomLight1Volume.SetActive(false);
                    }
                    if (m_CustomLight2Volume != null)
                    {
                        m_CustomLight2Volume.SetActive(false);
                    }
                    if (m_CustomLight3Volume != null)
                    {
                        m_CustomLight3Volume.SetActive(false);
                    }
                    if (m_CustomLight4Volume != null)
                    {
                        m_CustomLight4Volume.SetActive(false);
                    }
                    if (m_CustomLight5Volume != null)
                    {
                        m_CustomLight5Volume.SetActive(true);
                    }
                    if (m_CustomLight6Volume != null)
                    {
                        m_CustomLight6Volume.SetActive(false);
                    }
                    break;
                case VolumeType.CustomLight6:
                    if (m_MorningVolume != null)
                    {
                        m_MorningVolume.SetActive(false);
                    }
                    if (m_DayVolume != null)
                    {
                        m_DayVolume.SetActive(false);
                    }
                    if (m_MoonlessVolume != null)
                    {
                        m_MoonlessVolume.SetActive(false);
                    }
                    if (m_MoonNightVolume != null)
                    {
                        m_MoonNightVolume.SetActive(false);
                    }
                    if (m_InteriorVolume != null)
                    {
                        m_InteriorVolume.SetActive(false);
                    }
                    if (m_Interior2Volume != null)
                    {
                        m_Interior2Volume.SetActive(false);
                    }
                    if (m_CustomLight1Volume != null)
                    {
                        m_CustomLight1Volume.SetActive(false);
                    }
                    if (m_CustomLight2Volume != null)
                    {
                        m_CustomLight2Volume.SetActive(false);
                    }
                    if (m_CustomLight3Volume != null)
                    {
                        m_CustomLight3Volume.SetActive(false);
                    }
                    if (m_CustomLight4Volume != null)
                    {
                        m_CustomLight4Volume.SetActive(false);
                    }
                    if (m_CustomLight5Volume != null)
                    {
                        m_CustomLight5Volume.SetActive(false);
                    }
                    if (m_CustomLight6Volume != null)
                    {
                        m_CustomLight6Volume.SetActive(true);
                    }
                    break;

            }
            
            




        }
    }



}


