using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Diagnostics;
using System.Windows.Forms;

namespace ThreeDPrinter
{
    class SysHook
    {
        public delegate int HookProc(int nCode, int wParam, IntPtr lParam);
        static int hHook = 0;
        public const int WH_KEYBOARD_LL = 13;

        //LowLevel鍵盤截獲，如果是WH_KEYBOARD＝2，並不能對系統鍵盤截取，Acrobat Reader會在你截取之前獲得鍵盤。
        HookProc KeyBoardHookProcedure;

        //鍵盤Hook結構函數
        [StructLayout(LayoutKind.Sequential)]
        public class KeyBoardHookStruct
        {
            public int vkCode;
            public int scanCode;
            public int flags;
            public int time;
            public int dwExtraInfo;
        }

        #region DllImport
        //設置鉤子
        [DllImport("user32.dll")]
        public static extern int SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hInstance, int threadId);
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        //抽掉鉤子
        public static extern bool UnhookWindowsHookEx(int idHook);
        [DllImport("user32.dll")]
        //調用下一個鉤子
        public static extern int CallNextHookEx(int idHook, int nCode, int wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        public static extern int GetCurrentThreadId();

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetModuleHandle(string name);

        public void Hook_Start()
        {
            // 安裝鍵盤鉤子
            if (hHook == 0)
            {
                KeyBoardHookProcedure = new HookProc(KeyBoardHookProc);

                //hHook = SetWindowsHookEx(2,
                // KeyBoardHookProcedure,
                // GetModuleHandle(Process.GetCurrentProcess().MainModule.ModuleName), GetCurrentThreadId());

                hHook = SetWindowsHookEx(WH_KEYBOARD_LL,
                KeyBoardHookProcedure,
                GetModuleHandle(Process.GetCurrentProcess().MainModule.ModuleName), 0);

                //如果設置鉤子失敗.
                if (hHook == 0)
                {
                    Hook_Clear();

                    //throw new Exception("設置Hook失敗!");
                }
            }
        }

        //取消鉤子事件
        public void Hook_Clear()
        {
            bool retKeyboard = true;
            if (hHook != 0)
            {
                retKeyboard = UnhookWindowsHookEx(hHook);
                hHook = 0;
            }
            //如果去掉鉤子失敗.
            if (!retKeyboard) throw new Exception("UnhookWindowsHookEx failed.");

        }

        //這裡可以添加自己想要的資訊處理
        public static int KeyBoardHookProc(int nCode, int wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                KeyBoardHookStruct kbh = (KeyBoardHookStruct)Marshal.PtrToStructure(lParam, typeof(KeyBoardHookStruct));
                //MessageBox.Show(kbh.vkCode.ToString());
                Console.WriteLine(kbh.vkCode.ToString());

                if (kbh.vkCode == 27)
                {
                    ShareMemory.isPrintProcessInterrupt = true;
                    UnhookWindowsHookEx(hHook);
                    hHook = 0;
                }

                //if ((kbh.vkCode != 32) && (kbh.vkCode != 27))
                //{
                //    return 1;
                //}
            }
            return CallNextHookEx(hHook, nCode, wParam, lParam);
        }

        #endregion

    }
}
