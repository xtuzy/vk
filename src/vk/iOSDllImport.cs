// 警告: 某些程序集引用无法自动解析。这可能会导致某些部分反编译错误,
// 比如属性getter/setter 访问。要获得最佳反编译结果, 请手动将缺少的引用添加到加载的程序集列表中。
// Vulkan.iOSDllImport
using System.Runtime.InteropServices;
using Vulkan;
#if IOS || MACCATALYST
/// <summary>
/// It will generate __Internal in dll, if not, like can't load static library.
/// </summary>
public static class iOSDllImport
{
	[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
	public unsafe static extern VkResult vkCreateInstance(VkInstanceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkInstance* pInstance);
}
#endif
