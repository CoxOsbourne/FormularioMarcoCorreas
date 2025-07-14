namespace FormularioMarcoCorreas
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.OkApplyModifyGetOnOffCancel = new Tekla.Structures.Dialog.UIControls.OkApplyModifyGetOnOffCancel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.ParametersTabPage = new System.Windows.Forms.TabPage();
            this.buttonCreateFrame = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFrameWidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFrameLength = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFrameMaterial = new System.Windows.Forms.TextBox();
            this.materialCatalogFrame = new Tekla.Structures.Dialog.UIControls.MaterialCatalog();
            this.textBoxFrameProfile = new System.Windows.Forms.TextBox();
            this.profileCatalogFrame = new Tekla.Structures.Dialog.UIControls.ProfileCatalog();
            this.saveLoad = new Tekla.Structures.Dialog.UIControls.SaveLoad();
            this.label4 = new System.Windows.Forms.Label();
            this.profileCatalogCorrea = new Tekla.Structures.Dialog.UIControls.ProfileCatalog();
            this.textBoxProfileCorrea = new System.Windows.Forms.TextBox();
            this.materialCatalogCorrea = new Tekla.Structures.Dialog.UIControls.MaterialCatalog();
            this.textBoxCorreaMaterial = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.ParametersTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.structuresExtender.SetAttributeName(this.tableLayoutPanel, null);
            this.structuresExtender.SetAttributeTypeName(this.tableLayoutPanel, null);
            this.structuresExtender.SetBindPropertyName(this.tableLayoutPanel, null);
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.OkApplyModifyGetOnOffCancel, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.tabControl, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.saveLoad, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(534, 414);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // OkApplyModifyGetOnOffCancel
            // 
            this.structuresExtender.SetAttributeName(this.OkApplyModifyGetOnOffCancel, null);
            this.structuresExtender.SetAttributeTypeName(this.OkApplyModifyGetOnOffCancel, null);
            this.structuresExtender.SetBindPropertyName(this.OkApplyModifyGetOnOffCancel, null);
            this.OkApplyModifyGetOnOffCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OkApplyModifyGetOnOffCancel.Location = new System.Drawing.Point(3, 382);
            this.OkApplyModifyGetOnOffCancel.Name = "OkApplyModifyGetOnOffCancel";
            this.OkApplyModifyGetOnOffCancel.Size = new System.Drawing.Size(528, 29);
            this.OkApplyModifyGetOnOffCancel.TabIndex = 19;
            this.OkApplyModifyGetOnOffCancel.OkClicked += new System.EventHandler(this.OkApplyModifyGetOnOffCancel_OkClicked);
            this.OkApplyModifyGetOnOffCancel.ApplyClicked += new System.EventHandler(this.OkApplyModifyGetOnOffCancel_ApplyClicked);
            this.OkApplyModifyGetOnOffCancel.ModifyClicked += new System.EventHandler(this.OkApplyModifyGetOnOffCancel_ModifyClicked);
            this.OkApplyModifyGetOnOffCancel.GetClicked += new System.EventHandler(this.OkApplyModifyGetOnOffCancel_GetClicked);
            this.OkApplyModifyGetOnOffCancel.OnOffClicked += new System.EventHandler(this.OkApplyModifyGetOnOffCancel_OnOffClicked);
            this.OkApplyModifyGetOnOffCancel.CancelClicked += new System.EventHandler(this.OkApplyModifyGetOnOffCancel_CancelClicked);
            // 
            // tabControl
            // 
            this.structuresExtender.SetAttributeName(this.tabControl, null);
            this.structuresExtender.SetAttributeTypeName(this.tabControl, null);
            this.structuresExtender.SetBindPropertyName(this.tabControl, null);
            this.tabControl.Controls.Add(this.ParametersTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(3, 52);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(528, 324);
            this.tabControl.TabIndex = 18;
            // 
            // ParametersTabPage
            // 
            this.structuresExtender.SetAttributeName(this.ParametersTabPage, null);
            this.structuresExtender.SetAttributeTypeName(this.ParametersTabPage, null);
            this.structuresExtender.SetBindPropertyName(this.ParametersTabPage, null);
            this.ParametersTabPage.Controls.Add(this.textBoxCorreaMaterial);
            this.ParametersTabPage.Controls.Add(this.materialCatalogCorrea);
            this.ParametersTabPage.Controls.Add(this.textBoxProfileCorrea);
            this.ParametersTabPage.Controls.Add(this.profileCatalogCorrea);
            this.ParametersTabPage.Controls.Add(this.label4);
            this.ParametersTabPage.Controls.Add(this.buttonCreateFrame);
            this.ParametersTabPage.Controls.Add(this.label3);
            this.ParametersTabPage.Controls.Add(this.textBoxFrameWidth);
            this.ParametersTabPage.Controls.Add(this.label2);
            this.ParametersTabPage.Controls.Add(this.textBoxFrameLength);
            this.ParametersTabPage.Controls.Add(this.label1);
            this.ParametersTabPage.Controls.Add(this.textBoxFrameMaterial);
            this.ParametersTabPage.Controls.Add(this.materialCatalogFrame);
            this.ParametersTabPage.Controls.Add(this.textBoxFrameProfile);
            this.ParametersTabPage.Controls.Add(this.profileCatalogFrame);
            this.ParametersTabPage.Location = new System.Drawing.Point(4, 22);
            this.ParametersTabPage.Name = "ParametersTabPage";
            this.ParametersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ParametersTabPage.Size = new System.Drawing.Size(520, 298);
            this.ParametersTabPage.TabIndex = 2;
            this.ParametersTabPage.Text = "albl_Parameters";
            this.ParametersTabPage.UseVisualStyleBackColor = true;
            this.ParametersTabPage.Click += new System.EventHandler(this.ParametersTabPage_Click);
            // 
            // buttonCreateFrame
            // 
            this.structuresExtender.SetAttributeName(this.buttonCreateFrame, null);
            this.structuresExtender.SetAttributeTypeName(this.buttonCreateFrame, null);
            this.structuresExtender.SetBindPropertyName(this.buttonCreateFrame, null);
            this.buttonCreateFrame.Location = new System.Drawing.Point(188, 141);
            this.buttonCreateFrame.Name = "buttonCreateFrame";
            this.buttonCreateFrame.Size = new System.Drawing.Size(131, 23);
            this.buttonCreateFrame.TabIndex = 19;
            this.buttonCreateFrame.Text = "Crear marco y correas";
            this.buttonCreateFrame.UseVisualStyleBackColor = true;
            this.buttonCreateFrame.Click += new System.EventHandler(this.buttonCreateFrame_Click);
            // 
            // label3
            // 
            this.structuresExtender.SetAttributeName(this.label3, null);
            this.structuresExtender.SetAttributeTypeName(this.label3, null);
            this.label3.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label3, null);
            this.label3.Location = new System.Drawing.Point(34, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Marco";
            // 
            // textBoxFrameWidth
            // 
            this.structuresExtender.SetAttributeName(this.textBoxFrameWidth, "FrameWidth");
            this.structuresExtender.SetAttributeTypeName(this.textBoxFrameWidth, "Distance");
            this.structuresExtender.SetBindPropertyName(this.textBoxFrameWidth, null);
            this.textBoxFrameWidth.Location = new System.Drawing.Point(350, 35);
            this.textBoxFrameWidth.Name = "textBoxFrameWidth";
            this.textBoxFrameWidth.Size = new System.Drawing.Size(100, 20);
            this.textBoxFrameWidth.TabIndex = 17;
            this.textBoxFrameWidth.TextChanged += new System.EventHandler(this.textBoxWidth_TextChanged);
            // 
            // label2
            // 
            this.structuresExtender.SetAttributeName(this.label2, null);
            this.structuresExtender.SetAttributeTypeName(this.label2, null);
            this.label2.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label2, null);
            this.label2.Location = new System.Drawing.Point(306, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ancho";
            // 
            // textBoxFrameLength
            // 
            this.structuresExtender.SetAttributeName(this.textBoxFrameLength, "FrameLength");
            this.structuresExtender.SetAttributeTypeName(this.textBoxFrameLength, "Distance");
            this.structuresExtender.SetBindPropertyName(this.textBoxFrameLength, null);
            this.textBoxFrameLength.Location = new System.Drawing.Point(71, 40);
            this.textBoxFrameLength.Name = "textBoxFrameLength";
            this.textBoxFrameLength.Size = new System.Drawing.Size(100, 20);
            this.textBoxFrameLength.TabIndex = 15;
            // 
            // label1
            // 
            this.structuresExtender.SetAttributeName(this.label1, null);
            this.structuresExtender.SetAttributeTypeName(this.label1, null);
            this.label1.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label1, null);
            this.label1.Location = new System.Drawing.Point(31, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Largo";
            // 
            // textBoxFrameMaterial
            // 
            this.structuresExtender.SetAttributeName(this.textBoxFrameMaterial, "FrameMaterial");
            this.structuresExtender.SetAttributeTypeName(this.textBoxFrameMaterial, "String");
            this.structuresExtender.SetBindPropertyName(this.textBoxFrameMaterial, "Text");
            this.textBoxFrameMaterial.Location = new System.Drawing.Point(413, 85);
            this.textBoxFrameMaterial.Name = "textBoxFrameMaterial";
            this.textBoxFrameMaterial.Size = new System.Drawing.Size(56, 20);
            this.textBoxFrameMaterial.TabIndex = 13;
            this.textBoxFrameMaterial.Tag = "Material";
            // 
            // materialCatalogFrame
            // 
            this.structuresExtender.SetAttributeName(this.materialCatalogFrame, null);
            this.structuresExtender.SetAttributeTypeName(this.materialCatalogFrame, null);
            this.materialCatalogFrame.BackColor = System.Drawing.Color.Transparent;
            this.structuresExtender.SetBindPropertyName(this.materialCatalogFrame, null);
            this.materialCatalogFrame.ButtonText = "Material marco";
            this.materialCatalogFrame.Location = new System.Drawing.Point(309, 85);
            this.materialCatalogFrame.Name = "materialCatalogFrame";
            this.materialCatalogFrame.SelectedMaterial = "";
            this.materialCatalogFrame.Size = new System.Drawing.Size(88, 27);
            this.materialCatalogFrame.TabIndex = 12;
            this.materialCatalogFrame.SelectClicked += new System.EventHandler(this.materialCatalogFrameSelectClicked);
            this.materialCatalogFrame.SelectionDone += new System.EventHandler(this.materialCatalogFrameSelectionDone);
            // 
            // textBoxFrameProfile
            // 
            this.structuresExtender.SetAttributeName(this.textBoxFrameProfile, "FrameProfile");
            this.structuresExtender.SetAttributeTypeName(this.textBoxFrameProfile, "String");
            this.structuresExtender.SetBindPropertyName(this.textBoxFrameProfile, "Text");
            this.textBoxFrameProfile.Location = new System.Drawing.Point(108, 85);
            this.textBoxFrameProfile.Name = "textBoxFrameProfile";
            this.textBoxFrameProfile.Size = new System.Drawing.Size(100, 20);
            this.textBoxFrameProfile.TabIndex = 11;
            this.textBoxFrameProfile.Tag = "Profile";
            // 
            // profileCatalogFrame
            // 
            this.structuresExtender.SetAttributeName(this.profileCatalogFrame, null);
            this.structuresExtender.SetAttributeTypeName(this.profileCatalogFrame, null);
            this.profileCatalogFrame.BackColor = System.Drawing.Color.Transparent;
            this.structuresExtender.SetBindPropertyName(this.profileCatalogFrame, null);
            this.profileCatalogFrame.ButtonText = "Perfil marco";
            this.profileCatalogFrame.Location = new System.Drawing.Point(14, 85);
            this.profileCatalogFrame.Name = "profileCatalogFrame";
            this.profileCatalogFrame.SelectedProfile = "";
            this.profileCatalogFrame.Size = new System.Drawing.Size(88, 27);
            this.profileCatalogFrame.TabIndex = 10;
            this.profileCatalogFrame.SelectClicked += new System.EventHandler(this.profileCatalogFrameSelectClicked);
            this.profileCatalogFrame.SelectionDone += new System.EventHandler(this.profileCatalogFrameSelectionDone);
            this.profileCatalogFrame.Load += new System.EventHandler(this.profileCatalogFrame_Load);
            // 
            // saveLoad
            // 
            this.structuresExtender.SetAttributeName(this.saveLoad, null);
            this.structuresExtender.SetAttributeTypeName(this.saveLoad, null);
            this.saveLoad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.structuresExtender.SetBindPropertyName(this.saveLoad, null);
            this.saveLoad.Dock = System.Windows.Forms.DockStyle.Top;
            this.saveLoad.HelpFileType = Tekla.Structures.Dialog.UIControls.SaveLoad.HelpFileTypeEnum.General;
            this.saveLoad.HelpKeyword = "";
            this.saveLoad.HelpUrl = "";
            this.saveLoad.Location = new System.Drawing.Point(3, 3);
            this.saveLoad.Name = "saveLoad";
            this.saveLoad.SaveAsText = "";
            this.saveLoad.Size = new System.Drawing.Size(528, 43);
            this.saveLoad.TabIndex = 0;
            this.saveLoad.UserDefinedHelpFilePath = null;
            // 
            // label4
            // 
            this.structuresExtender.SetAttributeName(this.label4, null);
            this.structuresExtender.SetAttributeTypeName(this.label4, null);
            this.label4.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label4, null);
            this.label4.Location = new System.Drawing.Point(34, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Correas";
            // 
            // profileCatalogCorrea
            // 
            this.structuresExtender.SetAttributeName(this.profileCatalogCorrea, null);
            this.structuresExtender.SetAttributeTypeName(this.profileCatalogCorrea, null);
            this.profileCatalogCorrea.BackColor = System.Drawing.Color.Transparent;
            this.structuresExtender.SetBindPropertyName(this.profileCatalogCorrea, null);
            this.profileCatalogCorrea.ButtonText = "Perfil correas";
            this.profileCatalogCorrea.Location = new System.Drawing.Point(14, 225);
            this.profileCatalogCorrea.Name = "profileCatalogCorrea";
            this.profileCatalogCorrea.SelectedProfile = "";
            this.profileCatalogCorrea.Size = new System.Drawing.Size(88, 27);
            this.profileCatalogCorrea.TabIndex = 21;
            this.profileCatalogCorrea.SelectClicked += new System.EventHandler(this.profileCatalogCorreaSelectClicked);
            this.profileCatalogCorrea.SelectionDone += new System.EventHandler(this.profileCatalogCorreaSelectionDone);
            // 
            // textBoxProfileCorrea
            // 
            this.structuresExtender.SetAttributeName(this.textBoxProfileCorrea, "CorreaProfile");
            this.structuresExtender.SetAttributeTypeName(this.textBoxProfileCorrea, "String");
            this.structuresExtender.SetBindPropertyName(this.textBoxProfileCorrea, "Text");
            this.textBoxProfileCorrea.Location = new System.Drawing.Point(108, 232);
            this.textBoxProfileCorrea.Name = "textBoxProfileCorrea";
            this.textBoxProfileCorrea.Size = new System.Drawing.Size(100, 20);
            this.textBoxProfileCorrea.TabIndex = 22;
            this.textBoxProfileCorrea.Tag = "ProfileCorrea";
            // 
            // materialCatalogCorrea
            // 
            this.structuresExtender.SetAttributeName(this.materialCatalogCorrea, null);
            this.structuresExtender.SetAttributeTypeName(this.materialCatalogCorrea, null);
            this.materialCatalogCorrea.BackColor = System.Drawing.Color.Transparent;
            this.structuresExtender.SetBindPropertyName(this.materialCatalogCorrea, null);
            this.materialCatalogCorrea.ButtonText = "Material correa";
            this.materialCatalogCorrea.Location = new System.Drawing.Point(309, 225);
            this.materialCatalogCorrea.Name = "materialCatalogCorrea";
            this.materialCatalogCorrea.SelectedMaterial = "";
            this.materialCatalogCorrea.Size = new System.Drawing.Size(88, 27);
            this.materialCatalogCorrea.TabIndex = 23;
            this.materialCatalogCorrea.SelectClicked += new System.EventHandler(this.materialCatalogCorreaSelectClicked);
            this.materialCatalogCorrea.SelectionDone += new System.EventHandler(this.materialCatalogCorreaSelectionDone);
            // 
            // textBoxCorreaMaterial
            // 
            this.structuresExtender.SetAttributeName(this.textBoxCorreaMaterial, "PurlinMaterial");
            this.structuresExtender.SetAttributeTypeName(this.textBoxCorreaMaterial, "String");
            this.structuresExtender.SetBindPropertyName(this.textBoxCorreaMaterial, "Text");
            this.textBoxCorreaMaterial.Location = new System.Drawing.Point(413, 232);
            this.textBoxCorreaMaterial.Name = "textBoxCorreaMaterial";
            this.textBoxCorreaMaterial.Size = new System.Drawing.Size(56, 20);
            this.textBoxCorreaMaterial.TabIndex = 24;
            this.textBoxCorreaMaterial.Tag = "Material";
            // 
            // MainForm
            // 
            this.structuresExtender.SetAttributeName(this, null);
            this.structuresExtender.SetAttributeTypeName(this, null);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.structuresExtender.SetBindPropertyName(this, null);
            this.ClientSize = new System.Drawing.Size(534, 414);
            this.Controls.Add(this.tableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Model Plug-in";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.ParametersTabPage.ResumeLayout(false);
            this.ParametersTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private Tekla.Structures.Dialog.UIControls.SaveLoad saveLoad;
        private Tekla.Structures.Dialog.UIControls.OkApplyModifyGetOnOffCancel OkApplyModifyGetOnOffCancel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage ParametersTabPage;
        private System.Windows.Forms.TextBox textBoxFrameLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFrameMaterial;
        private Tekla.Structures.Dialog.UIControls.MaterialCatalog materialCatalogFrame;
        private System.Windows.Forms.TextBox textBoxFrameProfile;
        private Tekla.Structures.Dialog.UIControls.ProfileCatalog profileCatalogFrame;
        private System.Windows.Forms.TextBox textBoxFrameWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCreateFrame;
        private Tekla.Structures.Dialog.UIControls.ProfileCatalog profileCatalogCorrea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCorreaMaterial;
        private Tekla.Structures.Dialog.UIControls.MaterialCatalog materialCatalogCorrea;
        private System.Windows.Forms.TextBox textBoxProfileCorrea;
    }
}