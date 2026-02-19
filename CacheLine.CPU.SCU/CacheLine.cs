namespace CacheLine.CPU.SCU
{
    using System.Runtime.InteropServices;
    public class CacheLine
    {
        public static readonly int DEFAULT_VALUE = 64;

        /// <summary>
        /// Get CPU Cache line size. FailSafe method. Fallback on Exception to DEFAULT_VALUE = 64 bytes
        /// </summary>
        public static readonly int Size = GetSize();

        /// <summary>
        /// Get CPU Cache line size. Fallback to DEFAULT_VALUE = 64 bytes when suppressException is True
        /// </summary>
        public static int GetSize(bool suppressException = true)
        {
            try
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) return Windows.GetSize;
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) return Linux.GetSize;
                if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) return Mac.GetSize();
            }
            catch (Exception e)
            {
                if (!suppressException) throw;
            }
            return DEFAULT_VALUE;
        }
    }
}