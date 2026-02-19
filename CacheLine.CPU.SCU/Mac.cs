namespace CacheLine.CPU.SCU
{
    using System.Runtime.InteropServices;
    internal static class Mac
    {
        [DllImport("libc")]
        private static extern int sysctlbyname(string name, out IntPtr oldp, ref IntPtr oldlenp, IntPtr newp, IntPtr newlen);

        public static int GetSize()
        {
            IntPtr lineSize;
            IntPtr sizeOfLineSize = IntPtr.Size;
            sysctlbyname("hw.cachelinesize", out lineSize, ref sizeOfLineSize, IntPtr.Zero, IntPtr.Zero);
            return lineSize.ToInt32();
        }
    }
}