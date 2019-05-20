﻿#region License
/***
 * Copyright © 2018-2019, 张强 (943620963@qq.com).
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * without warranties or conditions of any kind, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
#endregion

using System.Web;

namespace ZqUtils.WeChat.Interfaces
{
    /// <summary>
    /// 微信公众平台后台服务器接口
    /// </summary>
    public interface IWeChatServerUrl
    {
        /// <summary>
        /// 处理微信请求，被动回复消息
        /// </summary>
        /// <param name="context">HttpContext</param>
        void WxService(HttpContext context);
    }
}
