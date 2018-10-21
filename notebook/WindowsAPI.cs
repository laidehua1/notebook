using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace notebook
{
    /// <summary>
    /// 窗体动画类
    /// </summary>
    class WindowsAPI
    {
        /// <summary>
        /// 正面_水平方向
        /// </summary>
        public const Int32 AW_HOR_POSITIVE = 0X00000001;
        /// <summary>
        /// 负面_水平方向
        /// </summary>
        public const Int32 AW_HOR_NEGATIVE = 0X00000002;
        /// <summary>
        /// 正面_垂直方向
        /// </summary>
        public const Int32 AW_VER_POSITIVE = 0X00000004;
        /// <summary>
        /// 负面_垂直方向
        /// </summary>
        public const Int32 AW_VER_NEGATIVE = 0X00000008;
        /// <summary>
        /// 由中间四周展开或由四周向中间缩小
        /// </summary>
        public const Int32 AW_CENTER = 0X00000010;
        /// <summary>
        /// 隐藏对象
        /// </summary>
        public const Int32 AW_HIDE = 0X00010000;
        /// <summary>
        /// 显示对象
        /// </summary>
        public const Int32 AW_ACTIVATE = 0X00020000;
        /// <summary>
        /// 拉幕滑动效果
        /// </summary>
        public const Int32 AW_SLIDE = 0X00040000;
        /// <summary>
        /// 淡入淡出渐变效果
        /// </summary>
        public const Int32 AW_BLEND = 0X00080000;
        /// <summary>
        /// 窗体动画
        /// </summary>
        /// <param name="hwnd"></param>
        /// <param name="dwTime"></param>
        /// <param name="dwFlags"></param>
        /// <returns></returns>
        [DllImport("user32")]
        public static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);
        /// <summary>
        /// 释放鼠标捕捉
        /// </summary>
        /// <returns></returns>
        [DllImport("user32")]
        public static extern bool ReleaseCapture();
        /// <summary>
        /// 消息传递
        /// </summary>
        /// <param name="hwnd">窗口句柄。窗口可以是任何类型的屏幕对象。</param>
        /// <param name="wMsg">用于区别其他消息的常量值</param>
        /// <param name="wParam">通常是一个与消息有关的常量值，也可能是窗口或控件的句柄</param>
        /// <param name="lParam">通常是一个指向内存中数据的指针</param>
        /// <returns></returns>
        [DllImport("user32")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
    }
}
