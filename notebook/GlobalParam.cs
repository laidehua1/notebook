using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notebook
{
    /// <summary>
    /// 检查字符方式枚举
    /// </summary>
    public enum CheckCharType
    {
        OnlyNum,
        OnlyLetter,
        NumOrLetter
    }

    /// <summary>
    /// 文本对齐方式
    /// </summary>
    public enum AlignmentType
    {
        Center,
        left,
        right
    }
    class GlobalParam
    {
        /// <summary>
        /// 字符串加密密匙
        /// </summary>
        public const string EDKey = "xiao";
        public static string Active_User = "";
        public static string RootDirectory = @"G:\project\notebook\NoteList\";
        /// <summary>
        /// 数据库用户表表名
        /// </summary>
        public const string TableName_User = "UserList";
        public const string TableName_Note = "NoteInfo";
        public const string TableName_Music = "Music";
        public const string TableName_MusicList = "MusicList";
        public const string TableName_MusicPlay = "MusicPlay";
    }
}
