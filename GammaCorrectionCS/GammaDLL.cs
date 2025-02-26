using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GammaCorrectionCsDLL
{
    public static class GammaDLL
    {
        public static float gamma;
        public static byte[] CalculateGammaParallel(byte[] pixels, int numberOfThreads)
        {
            Parallel.For(0, pixels.Length, new ParallelOptions { MaxDegreeOfParallelism = numberOfThreads }, i =>
            {
                //wartosc pixela / 255 -> wartosc znormalizowana
                double normalized = Math.Pow((pixels[i] / 255.0), (1.0 / gamma));
                int correctedValue = System.Convert.ToInt32(System.Math.Floor(normalized * 255.0));
                pixels[i] = (byte)correctedValue;
            });

            return pixels;
        }

        public static float[] ConvertByteToFloat(byte[] byteArray)
        {
            float[] floatArray = new float[byteArray.Length];
            for (int i = 0; i < byteArray.Length; i++)
            {
                floatArray[i] = byteArray[i] / 255.0f;
            }
            return floatArray;
        }
    }
}
