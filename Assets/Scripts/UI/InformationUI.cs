using Buildings;
using Settlers;
using TMPro;
using UnityEngine;

namespace UI
{
    /// <summary>
    /// This script controls an UI that displays some information about a settler or a building.
    /// </summary>
    public class InformationUI : MonoBehaviour
    {
        /// <summary>
        /// There are two types of possible information.
        /// </summary>
        private enum InformationType
        {
            None,
            Settler,
            Building
        }

        /// <summary>
        /// The type of the information.
        /// </summary>
        private InformationType _informationType;
        /// <summary>
        /// Reference to the Settler whose information is displayed if the InformationType aligns.
        /// </summary>
        public Settler DisplaySettler { get; set; }
        /// <summary>
        /// Reference to the Building whose information is displayed if the InformationType aligns.
        /// </summary>
        public Building DisplayBuilding { get; set; }
        
        /// <summary>
        /// Reference to the GameObject that has all the information texts about a settler as children.
        /// </summary>
        public GameObject settlerInformation;
        /// <summary>
        /// Reference to the caption that shows the type of settler.
        /// </summary>
        public TMP_Text settlerType;

        /// <summary>
        /// Reference to the GameObject that has all the information texts about a building as children.
        /// </summary>
        public GameObject buildingInformation;
        /// <summary>
        /// Reference to the caption that shows the type of building.
        /// </summary>
        public TMP_Text buildingType;
        /// <summary>
        /// Reference to the text that shows all the types of input resources of this building and their current amount.
        /// </summary>
        public TMP_Text inputInformation;
        /// <summary>
        /// Reference to the text that shows all the types of input resources of this building and their current amount.
        /// </summary>
        public TMP_Text outputInformation;

        /// <summary>
        /// If this GameObject gets enabled, the script will look if there was a reference to a settler or building and will display the specific information.
        /// </summary>
        private void OnEnable()
        {
            if (_informationType == InformationType.Settler)
            {
                settlerType.text = DisplaySettler.settlerName.ToString();
                settlerInformation.SetActive(true);
            }
            else if (_informationType == InformationType.Building)
            {
                buildingType.text = DisplayBuilding.BuildingName.ToString();
                inputInformation.text =
                    DisplayBuilding.Input[0].ResourceType + ": " +
                    DisplayBuilding.Input[0]
                        .ResourceCount; // TODO: Change is into a for loop that includes all the ResourcePackets in the Input list
                outputInformation.text =
                    DisplayBuilding.Output[0].ResourceType + ": " +
                    DisplayBuilding.Output[0]
                        .ResourceCount; // TODO: Change is into a for loop that includes all the ResourcePackets in the Output list
                buildingInformation.SetActive(true);
            }
        }

        /// <summary>
        /// If this GameObject gets disabled, all GameObjects that might have been set active have to be set inactive again.
        /// </summary>
        private void OnDisable()
        {
            settlerInformation.SetActive(false);
            buildingInformation.SetActive(false);
        }
    }
}
