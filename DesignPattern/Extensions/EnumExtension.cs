﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Extensions
{
    /// <summary>
    /// Enum 的擴充方法
    /// </summary>
    public static class EnumExtension
    {
        /// <summary>
        /// 取得顯示名稱
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetDisplayName(this Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());

            // 取 DisplayAttribute 標記
            DisplayAttribute pDisplay = fieldInfo.GetCustomAttributes(typeof(DisplayAttribute), false).FirstOrDefault() as DisplayAttribute;
            // 取 DisplayName 標記
            DisplayNameAttribute pDisplayName = fieldInfo.GetCustomAttributes(typeof(DisplayNameAttribute), false).FirstOrDefault() as DisplayNameAttribute;

            if (pDisplay != null)
            {
                return pDisplay.Name ?? value.ToString();
            }
            else if (pDisplayName != null)
            {
                return pDisplayName.DisplayName ?? value.ToString();
            }
            else
            {
                return value.ToString();
            }
        }
        /// <summary>
        /// 取得說明
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetDescription(this Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());

            // 取 DisplayAttribute 標記
            DisplayAttribute pDisplay = fieldInfo.GetCustomAttributes(typeof(DisplayAttribute), false).FirstOrDefault() as DisplayAttribute;

            if (pDisplay != null)
            {
                return pDisplay.Description ?? value.ToString();
            }
            else
            {
                return value.ToString();
            }
        }
        /// <summary>
        /// 取得說明
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetShortName(this Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());

            // 取 DisplayAttribute 標記
            DisplayAttribute pDisplay = fieldInfo.GetCustomAttributes(typeof(DisplayAttribute), false).FirstOrDefault() as DisplayAttribute;

            if (pDisplay != null)
            {
                return pDisplay.ShortName ?? value.ToString();
            }
            else
            {
                return value.ToString();
            }
        }
        /// <summary>
        /// 取得群組名稱
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetGroupName(this Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());

            // 取 DisplayAttribute 標記
            DisplayAttribute pDisplay = fieldInfo.GetCustomAttributes(typeof(DisplayAttribute), false).FirstOrDefault() as DisplayAttribute;

            if (pDisplay != null)
            {
                return pDisplay.GroupName ?? value.ToString();
            }
            else
            {
                return value.ToString();
            }
        }
        /// <summary>
        /// 取得數字的字串
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetValueIntString(this Enum value)
        {
            return Convert.ToInt32(value).ToString();
        }
        /// <summary>
        /// 轉換成 Enum
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">要轉換的字串</param>
        /// <returns></returns>
        public static T ToEnum<T>(this int value) where T : Enum
        {
            return (T)Enum.Parse(typeof(T), value.ToString(), true);
        }
        /// <summary>
        /// 轉換成 Enum
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">要轉換的字串</param>
        /// <returns></returns>
        public static T ToEnum<T>(this string value) where T : Enum
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
        /// <summary>
        /// 取得 EnumName
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <param name="defalueWord">預設文字</param>
        /// <returns></returns>
        public static string GetEnumDisplayName<T>(this string value, string defalueWord = "--") where T : Enum
        {
            try
            {
                return value.ToEnum<T>().GetDisplayName();
            }
            catch
            {
                return defalueWord;
            }
        }
        /// <summary>
        /// 從名稱取得 Enum
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="description">描述</param>
        /// <param name="defaultEnum">預設值</param>
        /// <returns></returns>
        public static T GetValueFromName<T>(string name, T defaultEnum) where T : Enum
        {
            foreach (var field in typeof(T).GetFields())
            {
                if (Attribute.GetCustomAttribute(field,
                typeof(DisplayAttribute)) is DisplayAttribute attribute)
                {
                    if (attribute.Name == name)
                        return (T)field.GetValue(null);
                }
                else
                {
                    if (field.Name == name)
                        return (T)field.GetValue(null);
                }
            }

            return defaultEnum;
        }
        /// <summary>
        /// 從描述取得 Enum
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="description">描述</param>
        /// <param name="defaultEnum">預設值</param>
        /// <returns></returns>
        public static T GetValueFromDescription<T>(string description, T defaultEnum) where T : Enum
        {
            foreach (var field in typeof(T).GetFields())
            {
                if (Attribute.GetCustomAttribute(field,
                typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
                {
                    if (attribute.Description == description)
                        return (T)field.GetValue(null);
                }
                else
                {
                    if (field.Name == description)
                        return (T)field.GetValue(null);
                }
            }

            return defaultEnum;
        }
    }
}
