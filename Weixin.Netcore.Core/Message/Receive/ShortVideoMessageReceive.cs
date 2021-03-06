﻿using System.Collections.Generic;
using Weixin.Netcore.Model.WeixinMessage;
using Weixin.Netcore.Utility;

namespace Weixin.Netcore.Core.Message.Receive
{
    /// <summary>
    /// 小视频消息接收
    /// </summary>
    public class ShortVideoMessageReceive : IMessageReceive//<ShortVideoMessage>
    {
        public IMessage GetEntity(string xml)
        {
            var dic = UtilityHelper.Xml2Dictionary(xml);
            return new ShortVideoMessage()
            {
                ToUserName = dic["ToUserName"],
                FromUserName = dic["FromUserName"],
                CreateTime = long.Parse(dic["CreateTime"]),
                MsgId = long.Parse(dic["MsgId"]),
                MediaId = dic["MediaId"],
                ThumbMediaId = dic["ThumbMediaId"]
            };
        }

        public IMessage GetEntity(Dictionary<string, string> dic)
        {
            return new ShortVideoMessage()
            {
                ToUserName = dic["ToUserName"],
                FromUserName = dic["FromUserName"],
                CreateTime = long.Parse(dic["CreateTime"]),
                MsgId = long.Parse(dic["MsgId"]),
                MediaId = dic["MediaId"],
                ThumbMediaId = dic["ThumbMediaId"]
            };
        }
    }
}
