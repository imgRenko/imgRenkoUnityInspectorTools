using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
namespace imgRenkoPlugins.InspectorEditorCustomer.Attribute
{
    public class MessageInfoBoxAttribute : PropertyAttribute
    {
        
        public string tipText = string.Empty;

        public MessageType boxType = MessageType.Info;

        public float messageBoxHeight = 66.0f;

        public MessageInfoBoxAttribute(string messageInfo, MessageType Type) {
            boxType = Type;
            tipText = messageInfo;
        }
        public MessageInfoBoxAttribute(string messageInfo, MessageType Type,float Height)
        {
            boxType = Type;
            tipText = messageInfo;
            messageBoxHeight = Height;
        }
    }

  
}

