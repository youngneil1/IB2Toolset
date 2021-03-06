﻿namespace IB2Toolset
{
    partial class WorldMapEditor
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
            this.components = new System.ComponentModel.Container();
            this.btnFillWithSelected = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flPanelTab1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtnZoom5x = new System.Windows.Forms.RadioButton();
            this.rbtnZoom2x = new System.Windows.Forms.RadioButton();
            this.rbtnZoom1x = new System.Windows.Forms.RadioButton();
            this.rbtnLoS = new System.Windows.Forms.RadioButton();
            this.rbtnInfo = new System.Windows.Forms.RadioButton();
            this.rbtnWalkable = new System.Windows.Forms.RadioButton();
            this.btnProperties = new System.Windows.Forms.Button();
            this.lblMouseInfo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoveSelectedObject = new System.Windows.Forms.Button();
            this.txtSelectedIconInfo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnPaintTile = new System.Windows.Forms.RadioButton();
            this.rbtnEditTrigger = new System.Windows.Forms.RadioButton();
            this.rbtnPaintTrigger = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.chkGrid = new System.Windows.Forms.CheckBox();
            this.gbMapSize = new System.Windows.Forms.GroupBox();
            this.btnMinusBottumY = new System.Windows.Forms.Button();
            this.btnPlusBottumY = new System.Windows.Forms.Button();
            this.btnMinusTopY = new System.Windows.Forms.Button();
            this.btnPlusTopY = new System.Windows.Forms.Button();
            this.lblMapSizeY = new System.Windows.Forms.Label();
            this.lblMapSizeX = new System.Windows.Forms.Label();
            this.btnPlusLeftX = new System.Windows.Forms.Button();
            this.btnPlusRightX = new System.Windows.Forms.Button();
            this.btnMinusRightX = new System.Windows.Forms.Button();
            this.btnMinusLeftX = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelNoScrollOnFocus1 = new IB2Toolset.PanelNoScrollOnFocus();
            this.panelView = new System.Windows.Forms.Panel();
            this.btnRefreshMap = new System.Windows.Forms.Button();
            this.btnMiniMap = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbMapSize.SuspendLayout();
            this.panelNoScrollOnFocus1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFillWithSelected
            // 
            this.btnFillWithSelected.Location = new System.Drawing.Point(16, 145);
            this.btnFillWithSelected.Name = "btnFillWithSelected";
            this.btnFillWithSelected.Size = new System.Drawing.Size(86, 39);
            this.btnFillWithSelected.TabIndex = 17;
            this.btnFillWithSelected.Text = "Fill Map with Selected Tile";
            this.btnFillWithSelected.UseVisualStyleBackColor = true;
            this.btnFillWithSelected.Click += new System.EventHandler(this.btnFillWithSelected_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.flPanelTab1);
            this.panel3.Location = new System.Drawing.Point(1028, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(140, 598);
            this.panel3.TabIndex = 68;
            // 
            // flPanelTab1
            // 
            this.flPanelTab1.Location = new System.Drawing.Point(3, 3);
            this.flPanelTab1.Name = "flPanelTab1";
            this.flPanelTab1.Size = new System.Drawing.Size(118, 5000);
            this.flPanelTab1.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.panel1);
            this.groupBox6.Location = new System.Drawing.Point(16, 190);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(86, 81);
            this.groupBox6.TabIndex = 69;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Selected Tile";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(18, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 50);
            this.panel1.TabIndex = 7;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.radioButton1);
            this.groupBox7.Controls.Add(this.radioButton2);
            this.groupBox7.Location = new System.Drawing.Point(17, 15);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(86, 60);
            this.groupBox7.TabIndex = 70;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Edit Layer";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(10, 15);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Layer 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(10, 32);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(60, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Layer 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.checkBox1);
            this.groupBox8.Controls.Add(this.checkBox2);
            this.groupBox8.Location = new System.Drawing.Point(17, 81);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(86, 58);
            this.groupBox8.TabIndex = 71;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Show";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(14, 16);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(61, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Layer 1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(14, 33);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(61, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Layer 2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.groupBox3);
            this.groupBox9.Controls.Add(this.groupBox8);
            this.groupBox9.Controls.Add(this.groupBox7);
            this.groupBox9.Controls.Add(this.groupBox6);
            this.groupBox9.Controls.Add(this.btnFillWithSelected);
            this.groupBox9.Location = new System.Drawing.Point(136, 5);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(118, 339);
            this.groupBox9.TabIndex = 72;
            this.groupBox9.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtnZoom5x);
            this.groupBox3.Controls.Add(this.rbtnZoom2x);
            this.groupBox3.Controls.Add(this.rbtnZoom1x);
            this.groupBox3.Location = new System.Drawing.Point(14, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(90, 52);
            this.groupBox3.TabIndex = 72;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "zoom";
            // 
            // rbtnZoom5x
            // 
            this.rbtnZoom5x.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnZoom5x.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnZoom5x.Location = new System.Drawing.Point(59, 19);
            this.rbtnZoom5x.Name = "rbtnZoom5x";
            this.rbtnZoom5x.Size = new System.Drawing.Size(28, 27);
            this.rbtnZoom5x.TabIndex = 2;
            this.rbtnZoom5x.TabStop = true;
            this.rbtnZoom5x.Text = "5X";
            this.rbtnZoom5x.UseVisualStyleBackColor = true;
            this.rbtnZoom5x.CheckedChanged += new System.EventHandler(this.rbtnZoom5x_CheckedChanged);
            // 
            // rbtnZoom2x
            // 
            this.rbtnZoom2x.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnZoom2x.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnZoom2x.Location = new System.Drawing.Point(31, 19);
            this.rbtnZoom2x.Name = "rbtnZoom2x";
            this.rbtnZoom2x.Size = new System.Drawing.Size(28, 27);
            this.rbtnZoom2x.TabIndex = 1;
            this.rbtnZoom2x.TabStop = true;
            this.rbtnZoom2x.Text = "2X";
            this.rbtnZoom2x.UseVisualStyleBackColor = true;
            this.rbtnZoom2x.CheckedChanged += new System.EventHandler(this.rbtnZoom2x_CheckedChanged);
            // 
            // rbtnZoom1x
            // 
            this.rbtnZoom1x.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnZoom1x.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnZoom1x.Location = new System.Drawing.Point(3, 19);
            this.rbtnZoom1x.Name = "rbtnZoom1x";
            this.rbtnZoom1x.Size = new System.Drawing.Size(28, 27);
            this.rbtnZoom1x.TabIndex = 0;
            this.rbtnZoom1x.TabStop = true;
            this.rbtnZoom1x.Text = "1X";
            this.rbtnZoom1x.UseVisualStyleBackColor = true;
            this.rbtnZoom1x.CheckedChanged += new System.EventHandler(this.rbtnZoom1x_CheckedChanged);
            // 
            // rbtnLoS
            // 
            this.rbtnLoS.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnLoS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnLoS.Location = new System.Drawing.Point(9, 303);
            this.rbtnLoS.Name = "rbtnLoS";
            this.rbtnLoS.Size = new System.Drawing.Size(103, 45);
            this.rbtnLoS.TabIndex = 5;
            this.rbtnLoS.TabStop = true;
            this.rbtnLoS.Text = "Toggle\r\nLine-of-Sight";
            this.rbtnLoS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnLoS.UseVisualStyleBackColor = true;
            this.rbtnLoS.CheckedChanged += new System.EventHandler(this.rbtnLoS_CheckedChanged);
            // 
            // rbtnInfo
            // 
            this.rbtnInfo.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnInfo.Location = new System.Drawing.Point(9, 17);
            this.rbtnInfo.Name = "rbtnInfo";
            this.rbtnInfo.Size = new System.Drawing.Size(103, 30);
            this.rbtnInfo.TabIndex = 4;
            this.rbtnInfo.TabStop = true;
            this.rbtnInfo.Text = "INFO";
            this.rbtnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnInfo.UseVisualStyleBackColor = true;
            this.rbtnInfo.CheckedChanged += new System.EventHandler(this.rbtnInfo_CheckedChanged);
            // 
            // rbtnWalkable
            // 
            this.rbtnWalkable.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnWalkable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnWalkable.Location = new System.Drawing.Point(9, 250);
            this.rbtnWalkable.Name = "rbtnWalkable";
            this.rbtnWalkable.Size = new System.Drawing.Size(103, 45);
            this.rbtnWalkable.TabIndex = 3;
            this.rbtnWalkable.TabStop = true;
            this.rbtnWalkable.Text = "Toggle\r\nWalkable";
            this.rbtnWalkable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnWalkable.UseVisualStyleBackColor = true;
            this.rbtnWalkable.CheckedChanged += new System.EventHandler(this.rbtnWalkable_CheckedChanged);
            // 
            // btnProperties
            // 
            this.btnProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProperties.Location = new System.Drawing.Point(142, 517);
            this.btnProperties.Name = "btnProperties";
            this.btnProperties.Size = new System.Drawing.Size(106, 48);
            this.btnProperties.TabIndex = 76;
            this.btnProperties.Text = "Area Properties";
            this.btnProperties.UseVisualStyleBackColor = true;
            this.btnProperties.Click += new System.EventHandler(this.btnProperties_Click);
            // 
            // lblMouseInfo
            // 
            this.lblMouseInfo.Location = new System.Drawing.Point(9, 571);
            this.lblMouseInfo.Name = "lblMouseInfo";
            this.lblMouseInfo.Size = new System.Drawing.Size(121, 30);
            this.lblMouseInfo.TabIndex = 73;
            this.lblMouseInfo.Text = "CURSOR/GRID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoveSelectedObject);
            this.groupBox1.Controls.Add(this.txtSelectedIconInfo);
            this.groupBox1.Location = new System.Drawing.Point(12, 419);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 142);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Object Info";
            // 
            // btnRemoveSelectedObject
            // 
            this.btnRemoveSelectedObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSelectedObject.Location = new System.Drawing.Point(6, 74);
            this.btnRemoveSelectedObject.Name = "btnRemoveSelectedObject";
            this.btnRemoveSelectedObject.Size = new System.Drawing.Size(106, 61);
            this.btnRemoveSelectedObject.TabIndex = 1;
            this.btnRemoveSelectedObject.Text = "Remove Last Selected Object";
            this.btnRemoveSelectedObject.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedObject.Click += new System.EventHandler(this.btnRemoveSelectedObject_Click);
            // 
            // txtSelectedIconInfo
            // 
            this.txtSelectedIconInfo.Location = new System.Drawing.Point(6, 19);
            this.txtSelectedIconInfo.Multiline = true;
            this.txtSelectedIconInfo.Name = "txtSelectedIconInfo";
            this.txtSelectedIconInfo.Size = new System.Drawing.Size(106, 54);
            this.txtSelectedIconInfo.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnPaintTile);
            this.groupBox2.Controls.Add(this.rbtnInfo);
            this.groupBox2.Controls.Add(this.rbtnLoS);
            this.groupBox2.Controls.Add(this.rbtnEditTrigger);
            this.groupBox2.Controls.Add(this.rbtnWalkable);
            this.groupBox2.Controls.Add(this.rbtnPaintTrigger);
            this.groupBox2.Location = new System.Drawing.Point(12, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(118, 364);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            // 
            // rbtnPaintTile
            // 
            this.rbtnPaintTile.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnPaintTile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPaintTile.Location = new System.Drawing.Point(9, 53);
            this.rbtnPaintTile.Name = "rbtnPaintTile";
            this.rbtnPaintTile.Size = new System.Drawing.Size(103, 45);
            this.rbtnPaintTile.TabIndex = 6;
            this.rbtnPaintTile.TabStop = true;
            this.rbtnPaintTile.Text = "Paint\r\nTiles";
            this.rbtnPaintTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnPaintTile.UseVisualStyleBackColor = true;
            // 
            // rbtnEditTrigger
            // 
            this.rbtnEditTrigger.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnEditTrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnEditTrigger.Location = new System.Drawing.Point(9, 175);
            this.rbtnEditTrigger.Name = "rbtnEditTrigger";
            this.rbtnEditTrigger.Size = new System.Drawing.Size(103, 65);
            this.rbtnEditTrigger.TabIndex = 2;
            this.rbtnEditTrigger.TabStop = true;
            this.rbtnEditTrigger.Text = "Edit Last\r\nSelected\r\nTrigger";
            this.rbtnEditTrigger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnEditTrigger.UseVisualStyleBackColor = true;
            this.rbtnEditTrigger.CheckedChanged += new System.EventHandler(this.rbtnEditTrigger_CheckedChanged);
            // 
            // rbtnPaintTrigger
            // 
            this.rbtnPaintTrigger.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnPaintTrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPaintTrigger.Location = new System.Drawing.Point(9, 106);
            this.rbtnPaintTrigger.Name = "rbtnPaintTrigger";
            this.rbtnPaintTrigger.Size = new System.Drawing.Size(103, 61);
            this.rbtnPaintTrigger.TabIndex = 0;
            this.rbtnPaintTrigger.TabStop = true;
            this.rbtnPaintTrigger.Text = "Paint\r\nNew\r\nTrigger";
            this.rbtnPaintTrigger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnPaintTrigger.UseVisualStyleBackColor = true;
            this.rbtnPaintTrigger.CheckedChanged += new System.EventHandler(this.rbtnPaintTrigger_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // chkGrid
            // 
            this.chkGrid.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkGrid.Checked = true;
            this.chkGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGrid.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkGrid.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.chkGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGrid.Location = new System.Drawing.Point(21, 379);
            this.chkGrid.Margin = new System.Windows.Forms.Padding(0);
            this.chkGrid.Name = "chkGrid";
            this.chkGrid.Size = new System.Drawing.Size(103, 28);
            this.chkGrid.TabIndex = 78;
            this.chkGrid.Text = "SHOW GRID";
            this.chkGrid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkGrid.UseVisualStyleBackColor = true;
            this.chkGrid.CheckedChanged += new System.EventHandler(this.chkGrid_CheckedChanged);
            // 
            // gbMapSize
            // 
            this.gbMapSize.Controls.Add(this.btnMinusBottumY);
            this.gbMapSize.Controls.Add(this.btnPlusBottumY);
            this.gbMapSize.Controls.Add(this.btnMinusTopY);
            this.gbMapSize.Controls.Add(this.btnPlusTopY);
            this.gbMapSize.Controls.Add(this.lblMapSizeY);
            this.gbMapSize.Controls.Add(this.lblMapSizeX);
            this.gbMapSize.Controls.Add(this.btnPlusLeftX);
            this.gbMapSize.Controls.Add(this.btnPlusRightX);
            this.gbMapSize.Controls.Add(this.btnMinusRightX);
            this.gbMapSize.Controls.Add(this.btnMinusLeftX);
            this.gbMapSize.Controls.Add(this.label2);
            this.gbMapSize.Controls.Add(this.label1);
            this.gbMapSize.Location = new System.Drawing.Point(136, 350);
            this.gbMapSize.Name = "gbMapSize";
            this.gbMapSize.Size = new System.Drawing.Size(118, 131);
            this.gbMapSize.TabIndex = 79;
            this.gbMapSize.TabStop = false;
            this.gbMapSize.Text = "Map Size (squares)";
            // 
            // btnMinusBottumY
            // 
            this.btnMinusBottumY.Location = new System.Drawing.Point(60, 97);
            this.btnMinusBottumY.Name = "btnMinusBottumY";
            this.btnMinusBottumY.Size = new System.Drawing.Size(25, 25);
            this.btnMinusBottumY.TabIndex = 13;
            this.btnMinusBottumY.Text = "-";
            this.btnMinusBottumY.UseVisualStyleBackColor = true;
            this.btnMinusBottumY.Click += new System.EventHandler(this.btnMinusBottumY_Click);
            // 
            // btnPlusBottumY
            // 
            this.btnPlusBottumY.Location = new System.Drawing.Point(35, 97);
            this.btnPlusBottumY.Name = "btnPlusBottumY";
            this.btnPlusBottumY.Size = new System.Drawing.Size(25, 25);
            this.btnPlusBottumY.TabIndex = 12;
            this.btnPlusBottumY.Text = "+";
            this.btnPlusBottumY.UseVisualStyleBackColor = true;
            this.btnPlusBottumY.Click += new System.EventHandler(this.btnPlusBottumY_Click);
            // 
            // btnMinusTopY
            // 
            this.btnMinusTopY.Location = new System.Drawing.Point(60, 19);
            this.btnMinusTopY.Name = "btnMinusTopY";
            this.btnMinusTopY.Size = new System.Drawing.Size(25, 25);
            this.btnMinusTopY.TabIndex = 11;
            this.btnMinusTopY.Text = "-";
            this.btnMinusTopY.UseVisualStyleBackColor = true;
            this.btnMinusTopY.Click += new System.EventHandler(this.btnMinusTopY_Click);
            // 
            // btnPlusTopY
            // 
            this.btnPlusTopY.Location = new System.Drawing.Point(35, 19);
            this.btnPlusTopY.Name = "btnPlusTopY";
            this.btnPlusTopY.Size = new System.Drawing.Size(25, 25);
            this.btnPlusTopY.TabIndex = 10;
            this.btnPlusTopY.Text = "+";
            this.btnPlusTopY.UseVisualStyleBackColor = true;
            this.btnPlusTopY.Click += new System.EventHandler(this.btnPlusTopY_Click);
            // 
            // lblMapSizeY
            // 
            this.lblMapSizeY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMapSizeY.Location = new System.Drawing.Point(61, 70);
            this.lblMapSizeY.Name = "lblMapSizeY";
            this.lblMapSizeY.Size = new System.Drawing.Size(28, 24);
            this.lblMapSizeY.TabIndex = 9;
            this.lblMapSizeY.Text = "128";
            this.lblMapSizeY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMapSizeX
            // 
            this.lblMapSizeX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMapSizeX.Location = new System.Drawing.Point(30, 70);
            this.lblMapSizeX.Name = "lblMapSizeX";
            this.lblMapSizeX.Size = new System.Drawing.Size(28, 24);
            this.lblMapSizeX.TabIndex = 8;
            this.lblMapSizeX.Text = "128";
            this.lblMapSizeX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlusLeftX
            // 
            this.btnPlusLeftX.Location = new System.Drawing.Point(3, 49);
            this.btnPlusLeftX.Name = "btnPlusLeftX";
            this.btnPlusLeftX.Size = new System.Drawing.Size(25, 25);
            this.btnPlusLeftX.TabIndex = 7;
            this.btnPlusLeftX.Text = "+";
            this.btnPlusLeftX.UseVisualStyleBackColor = true;
            this.btnPlusLeftX.Click += new System.EventHandler(this.btnPlusLeftX_Click);
            // 
            // btnPlusRightX
            // 
            this.btnPlusRightX.Location = new System.Drawing.Point(91, 49);
            this.btnPlusRightX.Name = "btnPlusRightX";
            this.btnPlusRightX.Size = new System.Drawing.Size(25, 25);
            this.btnPlusRightX.TabIndex = 6;
            this.btnPlusRightX.Text = "+";
            this.btnPlusRightX.UseVisualStyleBackColor = true;
            this.btnPlusRightX.Click += new System.EventHandler(this.btnPlusRightX_Click);
            // 
            // btnMinusRightX
            // 
            this.btnMinusRightX.Location = new System.Drawing.Point(91, 74);
            this.btnMinusRightX.Name = "btnMinusRightX";
            this.btnMinusRightX.Size = new System.Drawing.Size(25, 25);
            this.btnMinusRightX.TabIndex = 5;
            this.btnMinusRightX.Text = "-";
            this.btnMinusRightX.UseVisualStyleBackColor = true;
            this.btnMinusRightX.Click += new System.EventHandler(this.btnMinusRightX_Click);
            // 
            // btnMinusLeftX
            // 
            this.btnMinusLeftX.Location = new System.Drawing.Point(3, 74);
            this.btnMinusLeftX.Name = "btnMinusLeftX";
            this.btnMinusLeftX.Size = new System.Drawing.Size(25, 25);
            this.btnMinusLeftX.TabIndex = 4;
            this.btnMinusLeftX.Text = "-";
            this.btnMinusLeftX.UseVisualStyleBackColor = true;
            this.btnMinusLeftX.Click += new System.EventHandler(this.btnMinusLeftX_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            // 
            // panelNoScrollOnFocus1
            // 
            this.panelNoScrollOnFocus1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNoScrollOnFocus1.AutoScroll = true;
            this.panelNoScrollOnFocus1.BackColor = System.Drawing.Color.Black;
            this.panelNoScrollOnFocus1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelNoScrollOnFocus1.Controls.Add(this.panelView);
            this.panelNoScrollOnFocus1.Location = new System.Drawing.Point(260, 12);
            this.panelNoScrollOnFocus1.Name = "panelNoScrollOnFocus1";
            this.panelNoScrollOnFocus1.Size = new System.Drawing.Size(765, 598);
            this.panelNoScrollOnFocus1.TabIndex = 77;
            // 
            // panelView
            // 
            this.panelView.BackColor = System.Drawing.Color.Gainsboro;
            this.panelView.ContextMenuStrip = this.contextMenuStrip1;
            this.panelView.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panelView.Location = new System.Drawing.Point(-2, -2);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(800, 800);
            this.panelView.TabIndex = 16;
            this.panelView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelView_MouseClick);
            this.panelView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelView_MouseDown);
            this.panelView.MouseEnter += new System.EventHandler(this.panelView_MouseEnter);
            this.panelView.MouseLeave += new System.EventHandler(this.panelView_MouseLeave);
            this.panelView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelView_MouseMove);
            this.panelView.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.panelView_PreviewKeyDown);
            // 
            // btnRefreshMap
            // 
            this.btnRefreshMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshMap.Location = new System.Drawing.Point(142, 485);
            this.btnRefreshMap.Name = "btnRefreshMap";
            this.btnRefreshMap.Size = new System.Drawing.Size(106, 30);
            this.btnRefreshMap.TabIndex = 80;
            this.btnRefreshMap.Text = "Refresh Map";
            this.btnRefreshMap.UseVisualStyleBackColor = true;
            this.btnRefreshMap.Click += new System.EventHandler(this.btnRefreshMap_Click);
            // 
            // btnMiniMap
            // 
            this.btnMiniMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiniMap.Location = new System.Drawing.Point(142, 567);
            this.btnMiniMap.Name = "btnMiniMap";
            this.btnMiniMap.Size = new System.Drawing.Size(106, 48);
            this.btnMiniMap.TabIndex = 81;
            this.btnMiniMap.Text = "Create MiniMap";
            this.btnMiniMap.UseVisualStyleBackColor = true;
            this.btnMiniMap.Click += new System.EventHandler(this.btnMiniMap_Click);
            // 
            // WorldMapEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 622);
            this.Controls.Add(this.btnMiniMap);
            this.Controls.Add(this.btnRefreshMap);
            this.Controls.Add(this.gbMapSize);
            this.Controls.Add(this.chkGrid);
            this.Controls.Add(this.panelNoScrollOnFocus1);
            this.Controls.Add(this.btnProperties);
            this.Controls.Add(this.lblMouseInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "WorldMapEditor";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.WorldMapEditor_Load);
            this.panel3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gbMapSize.ResumeLayout(false);
            this.gbMapSize.PerformLayout();
            this.panelNoScrollOnFocus1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFillWithSelected;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flPanelTab1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.RadioButton rbtnLoS;
        private System.Windows.Forms.RadioButton rbtnInfo;
        private System.Windows.Forms.RadioButton rbtnWalkable;
        private System.Windows.Forms.Button btnProperties;
        private System.Windows.Forms.Label lblMouseInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemoveSelectedObject;
        private System.Windows.Forms.TextBox txtSelectedIconInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnEditTrigger;
        private System.Windows.Forms.RadioButton rbtnPaintTrigger;
        private PanelNoScrollOnFocus panelNoScrollOnFocus1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox chkGrid;
        private System.Windows.Forms.RadioButton rbtnPaintTile;
        private System.Windows.Forms.GroupBox gbMapSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMinusBottumY;
        private System.Windows.Forms.Button btnPlusBottumY;
        private System.Windows.Forms.Button btnMinusTopY;
        private System.Windows.Forms.Button btnPlusTopY;
        private System.Windows.Forms.Label lblMapSizeY;
        private System.Windows.Forms.Label lblMapSizeX;
        private System.Windows.Forms.Button btnPlusLeftX;
        private System.Windows.Forms.Button btnPlusRightX;
        private System.Windows.Forms.Button btnMinusRightX;
        private System.Windows.Forms.Button btnMinusLeftX;
        private System.Windows.Forms.Button btnRefreshMap;
        private System.Windows.Forms.Button btnMiniMap;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtnZoom5x;
        private System.Windows.Forms.RadioButton rbtnZoom2x;
        private System.Windows.Forms.RadioButton rbtnZoom1x;
    }
}

