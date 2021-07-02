using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace imgRenkoPlugins.InspectorEditorCustomer.Config
{
    public class InspectorEditorConfig
    {

        private static InspectorEditorConfig Instance = new InspectorEditorConfig();

   
        private InspectorEditorConfig() { }

        public static InspectorEditorConfig GetInstance()
        {
            return Instance;
        }

       
        public const float defaultPropertyHeight = 18.0f;

    }
}