using System.Collections;

namespace Buildings
{
    /// <summary>
    /// A small utility class that is used for testing purposes to store items without the need for a building.
    /// </summary>
    public class Container : Building
    {
        /// <summary>
        /// This method is not needed in this special case of a "building".
        /// </summary>
        /// <returns>IEnumerator: - </returns>
        protected override IEnumerator Production()
        {
            yield return null;
        }
    }
}