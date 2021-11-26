using UnityEngine;
using UnityEngine.AI;

namespace Settlers
{
    /// <summary>
    /// The base class for all type of units. Can't do anything on its own, but can be transformed into any other type of unit.
    /// </summary>
    public class Settler : MonoBehaviour
    {
        /// <summary>
        /// An enum to save all the different types of settlers in.
        /// </summary>
        public enum SettlerType
        {
            Settler,
            Carrier
        }

        /// <summary>
        /// The type/name of this settler.
        /// </summary>
        public SettlerType settlerName = SettlerType.Settler;
        
        /// <summary>
        /// Reference to the NavMeshAgent that is attached to every unit.
        /// </summary>
        internal NavMeshAgent Nav;
        
        /// <summary>
        /// Initialises the NavMeshAgent.
        /// </summary>
        private void Start()
        {
            Nav = gameObject.GetComponent<NavMeshAgent>();
        }

        /// <summary>
        /// Move the unit to a specific location.
        /// </summary>
        /// <param name="destination">The destination of the movement.</param>
        protected void MoveToPosition(Vector3 destination)
        {
            Nav.destination = destination;
        }
    }
}