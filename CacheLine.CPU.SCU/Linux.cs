namespace CacheLine.CPU.SCU
{
    using System.Runtime.InteropServices;
    internal class Linux
    {
        [DllImport("libc")]
        private static extern long sysconf(int name);
        private const int _SC_LEVEL1_DCACHE_LINESIZE = 190;
        public static int GetSize => (int)sysconf(_SC_LEVEL1_DCACHE_LINESIZE);
    }
}