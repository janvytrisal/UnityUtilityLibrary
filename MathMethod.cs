using UnityEngine;


namespace UnityUtilityLibrary
{
    public class MathMethod
    {
        /// <summary>
        /// Compare number a and b. Returns true if they are same within precision.
        /// </summary>
        /// <param name="a">Float variable a.</param>
        /// <param name="b">Float variable b.</param>
        /// <param name="precision">Number of digits considered.</param>
        public static bool Approximately(float a, float b, float precision)
        {
            float multiplier = 1;
            for (int i = 0; i < precision; i++)
            {
                multiplier *= 10;
            }

            int integerA = Mathf.RoundToInt(a * multiplier);
            int integerB = Mathf.RoundToInt(b * multiplier);

            if (integerA == integerB)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static float CircleCircumference(float radius)
        {
            return (2 * Mathf.PI * radius);
        }

        public static Vector3 LossyToLocal(Vector3 divident, Vector3 divisor)
        {
            Vector3 localScale = Vector3.zero;

            localScale.x = divident.x / divisor.x;
            localScale.y = divident.y / divisor.y;
            localScale.z = divident.z / divisor.z;

            return localScale;
        }

        public static float LossyToLocal(float divident, float divisor)
        {
            float localScale = divident / divisor;
            return localScale;
        }


        public static float VectorSign(Vector3 v)
        {
            float sum = Mathf.Round(v.x + v.y + v.z);
            return sum;
        }
    }
}

