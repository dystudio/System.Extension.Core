// Copyright (c) zhenlei520 All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.IO;
using EInfrastructure.Core.Tools.Systems;

namespace EInfrastructure.Core.Tools
{
    /// <summary>
    /// 地址帮助类
    /// </summary>
    public class PathCommon
    {
        #region 得到扩展名

        /// <summary>
        /// 得到扩展名
        /// </summary>
        /// <param name="path">地址参数</param>
        /// <returns></returns>
        public static string GetExtension(string path)
        {
            string res = Path.GetExtension(path);
            return res?.Split('?')[0].SafeString() ?? string.Empty;
        }

        #endregion
    }
}
