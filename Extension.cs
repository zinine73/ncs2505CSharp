using System;
using System.Text;

namespace MyExtension
{
    public static class ExClass
    {
        /// <summary>
        /// 대문자 => 소문자, 소문자 => 대문자
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToChangeCase(this String str)
        {
            var sb = new StringBuilder();
            foreach (var ch in str)
            {
                if (ch >= 'A' && ch <= 'Z')
                    sb.Append((char)('a' + ch - 'A'));
                else if (ch >= 'a' && ch <= 'z')
                    sb.Append((char)('A' + ch - 'a'));
                else
                    sb.Append(ch);
            }
            return sb.ToString();
        }
        /// <summary>
        /// str안에 char가 있는지 판단
        /// </summary>
        /// <param name="str"></param>
        /// <param name="ch"></param>
        /// <returns></returns>
        public static bool Found(this String str, char ch)
        {
            int position = str.IndexOf(ch);
            return position >= 0;
        }

        /// <summary>
        /// char -> string : Replace의 확장메서드
        /// </summary>
        /// <param name="str"></param>
        /// <param name="ch"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static string Replace(this String str, char ch, string val)
        {
            return str.Replace(ch.ToString(), val);
        }
    }
}