using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;
using Tekla.Structures.Model.UI;
using Tekla.Structures.Plugins;

namespace FormularioMarcoCorreas

{
    public class PluginData
    {
        #region Fields
        //
        // Define the fields specified on the Form.
        //
        [StructuresField("FrameLength")]
        public double FrameLength;

        [StructuresField("FrameWidth")]
        public double FrameWidth;

        [StructuresField("FrameProfile")]
        public string FrameProfile;

        [StructuresField("FrameMaterial")]
        public string FrameMaterial;

        [StructuresField("CorreaProfile")]
        public string CorreaProfile;

        [StructuresField("PurlinMaterial")]
        public string PurlinMaterial;

        //faltan variables aquí
        //missing variables here

        #endregion
    }

    [Plugin("FormularioMarcoCorreas")]
    [PluginUserInterface("FormularioMarcoCorreas.MainForm")]
    public class FormularioMarcoCorreas : PluginBase
    {
        #region Fields
        //private Model _Model;
        //private PluginData _Data;
        private PluginData Data { get; set; }
        //
        // Define variables for the field values.
        //
        
        #endregion

        #region Properties
        /*private Model Model
        {
            get { return this._Model; }
            set { this._Model = value; }
        }

        private PluginData Data
        {
            get { return this._Data; }
            set { this._Data = value; }
        }*/
        #endregion

        #region Constructor
        public FormularioMarcoCorreas(PluginData data)
        {
            //Model = new Model();
            Data = data;
        }
        #endregion

        #region Overrides
        public override List<InputDefinition> DefineInput()
        {
            return new List<InputDefinition>();
        }

        public override bool Run(List<InputDefinition> Input)
        {
            return true;
        }
        #endregion

        #region Private methods
        /// <summary>
        /// Gets the values from the dialog and sets the default values if needed
        /// </summary>
        //private void GetValuesFromDialog()
        //{
            /* Some examples:
            _RebarName = Data.RebarName;
            _RebarSize = Data.RebarSize;
            _RebarGrade = Data.RebarGrade;

            char[] Parameters = { ' ' };
            string[] Radiuses = Data.RebarBendingRadius.Split(Parameters, StringSplitOptions.RemoveEmptyEntries);

            foreach (string Item in Radiuses)
                _RebarBendingRadius.Add(Convert.ToDouble(Item));

            _RebarClass = Data.RebarClass;
            _RebarSpacing = Data.RebarSpacing;

            if (IsDefaultValue(_RebarName))
                _RebarName = "REBAR";
            if (IsDefaultValue(_RebarSize))
                _RebarSize = "12";
            if (IsDefaultValue(_RebarGrade))
                _RebarGrade = "Undefined";
            if (_RebarBendingRadius.Count < 1)
                _RebarBendingRadius.Add(30.00);
            if (IsDefaultValue(_RebarClass) || _RebarClass <= 0)
                _RebarClass = 99;
            if (IsDefaultValue(_RebarSpacing) || _RebarSpacing <= 0)
                _RebarSpacing = 200.0;
            */
        //}

        // Write your private methods here.

        #endregion
    }
}
