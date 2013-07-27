﻿using System.Collections.Generic;
using TeenPatti.Interfaces;

namespace TeenPatti.Engine
{
    public static class MessageHandlerManager
    {
        public static Dictionary<string, IMessageHandler> Handlers=new Dictionary<string, IMessageHandler>();

        static MessageHandlerManager()
        {
            Handlers.Add("get_tables", new GetTablesHandler());
        }

        public static IMessageHandler GetHandler(string messageType)
        {
            IMessageHandler handler;
            Handlers.TryGetValue(messageType, out handler);
            return handler;
        }
    }

    

}