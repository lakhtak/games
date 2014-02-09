using System;
using System.Runtime.InteropServices;
using System.Security;
using Logic;

namespace WalrusSeaFight
{
    class Mouse
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct NativeMessage
        {
            public IntPtr handle;
            public uint msg;
            public IntPtr wParam;
            public IntPtr lParam;
            public uint time;
            public System.Drawing.Point p;
        }

        [SuppressUnmanagedCodeSecurity]
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool PeekMessage(out NativeMessage message,
            IntPtr handle, uint filterMin, uint filterMax, uint flags);
        private const UInt32 WM_MOUSEFIRST = 0x0200;
        private const UInt32 WM_MOUSELAST = 0x020D;
        public const int PM_REMOVE = 0x0001;

        public static void OnGameStateChanged(object sender, StateEventArgs e)
        {
            if (e.NewState == State.PlayerTurn || e.NewState == State.GameOver)
                FlushAllEvents();
        }

        private static void FlushAllEvents()
        {
            NativeMessage msg;
            while (PeekMessage(out msg, IntPtr.Zero,
                WM_MOUSEFIRST, WM_MOUSELAST, PM_REMOVE))
            {
            }
        }
    }
}
