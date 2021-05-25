﻿using System;
using System.Web.Mvc;

namespace Helpers.Infrastructure
{
    public static class CustomHelpers
    {
        public static MvcHtmlString ListArrayStringItems(this HtmlHelper html, string[] list)
        {
            TagBuilder tag = new TagBuilder("ul");

            foreach (string str in list)
            {
                TagBuilder itemTag = new TagBuilder("li");
                itemTag.SetInnerText(str);
                tag.InnerHtml += itemTag.ToString();
            }

            return new MvcHtmlString(tag.ToString());
        }
        
        // public static MvcHtmlString DisplayMessage(this HtmlHelper html, string msg)
        // {
        //     string result = String.Format("Сообщение: <p>{0}</p>", msg);
        //     return new MvcHtmlString(result);
        // }
        
        // public static string DisplayMessage(this HtmlHelper html, string msg)
        // {
        //     return String.Format("Сообщение: <p>{0}</p>", msg);
        // }
        
        public static MvcHtmlString DisplayMessage(this HtmlHelper html, string msg)
        {
            string encodedMessage = html.Encode(msg);
            string result = String.Format("Сообщение: <p>{0}</p>", encodedMessage);
            return new MvcHtmlString(result);
        }
    }
}