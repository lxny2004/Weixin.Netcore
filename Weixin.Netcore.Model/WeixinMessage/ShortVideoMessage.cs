﻿using Weixin.Netcore.Utility;

namespace Weixin.Netcore.Model.WeixinMessage
{
    /// <summary>
    /// 小视频消息
    /// </summary>
    public class ShortVideoMessage : NormalMessage, IMessageReceive
    {
        public ShortVideoMessage()
        {
            MsgType = "shortvideo";
        }

        /// <summary>
        /// 视频消息素材Id
        /// </summary>
        public string MediaId { get; set; }

        /// <summary>
        /// 视频消息缩略图素材Id
        /// </summary>
        public string ThumbMediaId { get; set; }

        public void ConvertEntity(string xml)
        {
            var dic = UtilityHelper.Xml2Dictionary(xml);
            ToUserName = dic["ToUserName"];
            FromUserName = dic["FromUserName"];
            CreateTime = long.Parse(dic["CreateTime"]);
            MsgId = long.Parse(dic["MsgId"]);
            MediaId = dic["MediaId"];
            ThumbMediaId = dic["ThumbMediaId"];
        }
    }
}
