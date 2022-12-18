using System;
using System.Runtime.InteropServices;

namespace Vulkan
{
    internal static class Libdl
    {
#if IOS || MACCATALYST
        //change according to:
        //https://github.com/xamarin/xamarin-macios/blob/main/src/ObjCRuntime/Dlfcn.cs
        //https://github.com/xamarin/xamarin-macios/blob/main/src/ObjCRuntime/Constants.cs
        const string DllName = "/usr/lib/libSystem.dylib";
#else
        const string DllName = "libdl";
#endif
        [DllImport(DllName)]
        public static extern IntPtr dlopen(string fileName, int flags);

        [DllImport(DllName)]
        public static extern IntPtr dlsym(IntPtr handle, string name);

        [DllImport(DllName)]
        public static extern int dlclose(IntPtr handle);

        [DllImport(DllName)]
        public static extern string dlerror();

        public const int RTLD_NOW = 0x002;
    }
}
