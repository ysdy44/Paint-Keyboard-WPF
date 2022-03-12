using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;

namespace Paint_Keyboard
{
    public static partial class NativeMethod
    {

        public static void Unfocus(Window window)
        {
            IntPtr handle = new WindowInteropHelper(window).Handle;
            IntPtr exstyle = NativeMethod.GetWindowLong(handle, NativeMethod.GWL_EXSTYLE);
            NativeMethod.SetWindowLong(handle, NativeMethod.GWL_EXSTYLE, new IntPtr(exstyle.ToInt32() | NativeMethod.WS_EX_NOACTIVATE));
        }

        #region Native Methods


        private const int WS_EX_NOACTIVATE = 0x08000000;
        private const int GWL_EXSTYLE = -20;

        public static IntPtr GetWindowLong(IntPtr hWnd, int nIndex)
        {
            return Environment.Is64BitProcess
                ? NativeMethod.GetWindowLong64(hWnd, nIndex)
                : NativeMethod.GetWindowLong32(hWnd, nIndex);
        }

        public static IntPtr SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong)
        {
            return Environment.Is64BitProcess
                ? NativeMethod.SetWindowLong64(hWnd, nIndex, dwNewLong)
                : NativeMethod.SetWindowLong32(hWnd, nIndex, dwNewLong);
        }

        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        private static extern IntPtr GetWindowLong32(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", EntryPoint = "GetWindowLongPtr")]
        private static extern IntPtr GetWindowLong64(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        private static extern IntPtr SetWindowLong32(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        [DllImport("user32.dll", EntryPoint = "SetWindowLongPtr")]
        private static extern IntPtr SetWindowLong64(IntPtr hWnd, int nIndex, IntPtr dwNewLong);


        #endregion

    }
}