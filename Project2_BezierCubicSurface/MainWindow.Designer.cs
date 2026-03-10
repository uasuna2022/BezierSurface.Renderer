namespace Project2_BezierCubicSurface
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainMenuStrip = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            loadControlPointsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            mainTableLayoutPanel = new TableLayoutPanel();
            WorkspacePanel = new Panel();
            UITableLayoutPanel = new TableLayoutPanel();
            TriangulationGroupBox = new GroupBox();
            XRotationLabelValue = new Label();
            XRotationLabel = new Label();
            XAxisRotationTrackBar = new TrackBar();
            ZRotationLabel = new Label();
            ZRotationLabelValue = new Label();
            ZAxisRotationTrackBar = new TrackBar();
            ResolutionValueLabel = new Label();
            ResolutionLabel = new Label();
            ResolutionTrackBar = new TrackBar();
            FillTrianglesCheckBox = new CheckBox();
            ShowControlPointsCheckBox = new CheckBox();
            ShowMeshCheckBox = new CheckBox();
            SurfaceReflectanceParametersGroupBox = new GroupBox();
            SpecularCoefficientValueLabel = new Label();
            SpecularCoefficientLabel = new Label();
            SpecularCoefficientTrackBar = new TrackBar();
            DiffuseCoefficientValueLabel = new Label();
            DiffuseCoefficientLabel = new Label();
            DiffuseCoefficientTrackBar = new TrackBar();
            ShininessExponentValueLabel = new Label();
            ShinenessExponentLabel = new Label();
            ShininessExponentTrackBar = new TrackBar();
            ObjectPropertiesGroupBox = new GroupBox();
            NormalMapCheckBox = new CheckBox();
            ImageCheckBox = new CheckBox();
            ColorCheckBox = new CheckBox();
            NormalMapPanel = new Panel();
            ImagePanel = new Panel();
            SurfaceColorPanel = new Panel();
            LightSourcePropertiesGroupBox = new GroupBox();
            AnimationCheckBox = new CheckBox();
            ChooseLightSourceColorLabel = new Label();
            ChooseLightSourceColorPanel = new Panel();
            LightSourceDistanceLabel = new Label();
            LightSourceDistanceLabelValue = new Label();
            LightSourceDistanceTrackbar = new TrackBar();
            mainMenuStrip.SuspendLayout();
            mainTableLayoutPanel.SuspendLayout();
            UITableLayoutPanel.SuspendLayout();
            TriangulationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)XAxisRotationTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ZAxisRotationTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ResolutionTrackBar).BeginInit();
            SurfaceReflectanceParametersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SpecularCoefficientTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DiffuseCoefficientTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ShininessExponentTrackBar).BeginInit();
            ObjectPropertiesGroupBox.SuspendLayout();
            LightSourcePropertiesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LightSourceDistanceTrackbar).BeginInit();
            SuspendLayout();
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.ImageScalingSize = new Size(20, 20);
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, aboutToolStripMenuItem });
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new Size(1382, 28);
            mainMenuStrip.TabIndex = 0;
            mainMenuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { loadControlPointsToolStripMenuItem, exitToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(46, 24);
            toolStripMenuItem1.Text = "File";
            // 
            // loadControlPointsToolStripMenuItem
            // 
            loadControlPointsToolStripMenuItem.Name = "loadControlPointsToolStripMenuItem";
            loadControlPointsToolStripMenuItem.Size = new Size(225, 26);
            loadControlPointsToolStripMenuItem.Text = "Load Control Points ";
            loadControlPointsToolStripMenuItem.Click += loadControlPointsToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(225, 26);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(64, 24);
            aboutToolStripMenuItem.Text = "About";
            // 
            // mainTableLayoutPanel
            // 
            mainTableLayoutPanel.ColumnCount = 2;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            mainTableLayoutPanel.Controls.Add(WorkspacePanel, 0, 0);
            mainTableLayoutPanel.Controls.Add(UITableLayoutPanel, 1, 0);
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Location = new Point(0, 28);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.RowCount = 1;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.Size = new Size(1382, 925);
            mainTableLayoutPanel.TabIndex = 1;
            // 
            // WorkspacePanel
            // 
            WorkspacePanel.BackColor = Color.White;
            WorkspacePanel.Dock = DockStyle.Fill;
            WorkspacePanel.Location = new Point(3, 3);
            WorkspacePanel.Name = "WorkspacePanel";
            WorkspacePanel.Size = new Size(961, 919);
            WorkspacePanel.TabIndex = 0;
            WorkspacePanel.Paint += WorkspacePanel_Paint;
            // 
            // UITableLayoutPanel
            // 
            UITableLayoutPanel.ColumnCount = 1;
            UITableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            UITableLayoutPanel.Controls.Add(TriangulationGroupBox, 0, 0);
            UITableLayoutPanel.Controls.Add(SurfaceReflectanceParametersGroupBox, 0, 1);
            UITableLayoutPanel.Controls.Add(ObjectPropertiesGroupBox, 0, 2);
            UITableLayoutPanel.Controls.Add(LightSourcePropertiesGroupBox, 0, 3);
            UITableLayoutPanel.Dock = DockStyle.Fill;
            UITableLayoutPanel.Location = new Point(970, 3);
            UITableLayoutPanel.Name = "UITableLayoutPanel";
            UITableLayoutPanel.RowCount = 4;
            UITableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 220F));
            UITableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            UITableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            UITableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            UITableLayoutPanel.Size = new Size(409, 919);
            UITableLayoutPanel.TabIndex = 1;
            // 
            // TriangulationGroupBox
            // 
            TriangulationGroupBox.Controls.Add(XRotationLabelValue);
            TriangulationGroupBox.Controls.Add(XRotationLabel);
            TriangulationGroupBox.Controls.Add(XAxisRotationTrackBar);
            TriangulationGroupBox.Controls.Add(ZRotationLabel);
            TriangulationGroupBox.Controls.Add(ZRotationLabelValue);
            TriangulationGroupBox.Controls.Add(ZAxisRotationTrackBar);
            TriangulationGroupBox.Controls.Add(ResolutionValueLabel);
            TriangulationGroupBox.Controls.Add(ResolutionLabel);
            TriangulationGroupBox.Controls.Add(ResolutionTrackBar);
            TriangulationGroupBox.Controls.Add(FillTrianglesCheckBox);
            TriangulationGroupBox.Controls.Add(ShowControlPointsCheckBox);
            TriangulationGroupBox.Controls.Add(ShowMeshCheckBox);
            TriangulationGroupBox.Dock = DockStyle.Fill;
            TriangulationGroupBox.Location = new Point(3, 3);
            TriangulationGroupBox.Name = "TriangulationGroupBox";
            TriangulationGroupBox.Size = new Size(403, 214);
            TriangulationGroupBox.TabIndex = 0;
            TriangulationGroupBox.TabStop = false;
            TriangulationGroupBox.Text = "Triangulation Properties";
            // 
            // XRotationLabelValue
            // 
            XRotationLabelValue.AutoSize = true;
            XRotationLabelValue.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            XRotationLabelValue.Location = new Point(370, 158);
            XRotationLabelValue.Name = "XRotationLabelValue";
            XRotationLabelValue.Size = new Size(15, 17);
            XRotationLabelValue.TabIndex = 11;
            XRotationLabelValue.Text = "0";
            // 
            // XRotationLabel
            // 
            XRotationLabel.AutoSize = true;
            XRotationLabel.Location = new Point(6, 156);
            XRotationLabel.Name = "XRotationLabel";
            XRotationLabel.Size = new Size(61, 20);
            XRotationLabel.TabIndex = 10;
            XRotationLabel.Text = "X-angle";
            // 
            // XAxisRotationTrackBar
            // 
            XAxisRotationTrackBar.Enabled = false;
            XAxisRotationTrackBar.Location = new Point(83, 156);
            XAxisRotationTrackBar.Maximum = 180;
            XAxisRotationTrackBar.Minimum = -180;
            XAxisRotationTrackBar.Name = "XAxisRotationTrackBar";
            XAxisRotationTrackBar.Size = new Size(291, 56);
            XAxisRotationTrackBar.TabIndex = 9;
            XAxisRotationTrackBar.ValueChanged += XAxisRotationTrackBar_ValueChanged;
            // 
            // ZRotationLabel
            // 
            ZRotationLabel.AutoSize = true;
            ZRotationLabel.Location = new Point(6, 106);
            ZRotationLabel.Name = "ZRotationLabel";
            ZRotationLabel.Size = new Size(61, 20);
            ZRotationLabel.TabIndex = 8;
            ZRotationLabel.Text = "Z-angle";
            // 
            // ZRotationLabelValue
            // 
            ZRotationLabelValue.AutoSize = true;
            ZRotationLabelValue.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ZRotationLabelValue.Location = new Point(370, 109);
            ZRotationLabelValue.Name = "ZRotationLabelValue";
            ZRotationLabelValue.Size = new Size(15, 17);
            ZRotationLabelValue.TabIndex = 7;
            ZRotationLabelValue.Text = "0";
            // 
            // ZAxisRotationTrackBar
            // 
            ZAxisRotationTrackBar.Enabled = false;
            ZAxisRotationTrackBar.Location = new Point(83, 106);
            ZAxisRotationTrackBar.Maximum = 180;
            ZAxisRotationTrackBar.Minimum = -180;
            ZAxisRotationTrackBar.Name = "ZAxisRotationTrackBar";
            ZAxisRotationTrackBar.Size = new Size(291, 56);
            ZAxisRotationTrackBar.TabIndex = 6;
            ZAxisRotationTrackBar.ValueChanged += ZAxisRotationTrackBar_ValueChanged;
            // 
            // ResolutionValueLabel
            // 
            ResolutionValueLabel.AutoSize = true;
            ResolutionValueLabel.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResolutionValueLabel.Location = new Point(370, 66);
            ResolutionValueLabel.Name = "ResolutionValueLabel";
            ResolutionValueLabel.Size = new Size(22, 17);
            ResolutionValueLabel.TabIndex = 5;
            ResolutionValueLabel.Text = "30";
            // 
            // ResolutionLabel
            // 
            ResolutionLabel.AutoSize = true;
            ResolutionLabel.Location = new Point(6, 63);
            ResolutionLabel.Name = "ResolutionLabel";
            ResolutionLabel.Size = new Size(79, 20);
            ResolutionLabel.TabIndex = 4;
            ResolutionLabel.Text = "Resolution";
            // 
            // ResolutionTrackBar
            // 
            ResolutionTrackBar.Enabled = false;
            ResolutionTrackBar.Location = new Point(83, 63);
            ResolutionTrackBar.Maximum = 70;
            ResolutionTrackBar.Minimum = 3;
            ResolutionTrackBar.Name = "ResolutionTrackBar";
            ResolutionTrackBar.Size = new Size(291, 56);
            ResolutionTrackBar.TabIndex = 3;
            ResolutionTrackBar.Value = 30;
            ResolutionTrackBar.ValueChanged += trackBar1_ValueChanged;
            // 
            // FillTrianglesCheckBox
            // 
            FillTrianglesCheckBox.AutoSize = true;
            FillTrianglesCheckBox.Enabled = false;
            FillTrianglesCheckBox.Location = new Point(282, 26);
            FillTrianglesCheckBox.Name = "FillTrianglesCheckBox";
            FillTrianglesCheckBox.Size = new Size(113, 24);
            FillTrianglesCheckBox.TabIndex = 2;
            FillTrianglesCheckBox.Text = "Fill Triangles";
            FillTrianglesCheckBox.UseVisualStyleBackColor = true;
            FillTrianglesCheckBox.CheckedChanged += FillTrianglesCheckBox_CheckedChanged;
            // 
            // ShowControlPointsCheckBox
            // 
            ShowControlPointsCheckBox.AutoSize = true;
            ShowControlPointsCheckBox.Checked = true;
            ShowControlPointsCheckBox.CheckState = CheckState.Checked;
            ShowControlPointsCheckBox.Enabled = false;
            ShowControlPointsCheckBox.Location = new Point(113, 26);
            ShowControlPointsCheckBox.Name = "ShowControlPointsCheckBox";
            ShowControlPointsCheckBox.Size = new Size(163, 24);
            ShowControlPointsCheckBox.TabIndex = 1;
            ShowControlPointsCheckBox.Text = "Show Control Points";
            ShowControlPointsCheckBox.UseVisualStyleBackColor = true;
            ShowControlPointsCheckBox.CheckedChanged += ShowControlPointsCheckBox_CheckedChanged;
            // 
            // ShowMeshCheckBox
            // 
            ShowMeshCheckBox.AutoSize = true;
            ShowMeshCheckBox.Enabled = false;
            ShowMeshCheckBox.Location = new Point(6, 26);
            ShowMeshCheckBox.Name = "ShowMeshCheckBox";
            ShowMeshCheckBox.Size = new Size(110, 24);
            ShowMeshCheckBox.TabIndex = 0;
            ShowMeshCheckBox.Text = "Show Mesh ";
            ShowMeshCheckBox.UseVisualStyleBackColor = true;
            ShowMeshCheckBox.CheckedChanged += ShowMeshCheckBox_CheckedChanged;
            // 
            // SurfaceReflectanceParametersGroupBox
            // 
            SurfaceReflectanceParametersGroupBox.Controls.Add(SpecularCoefficientValueLabel);
            SurfaceReflectanceParametersGroupBox.Controls.Add(SpecularCoefficientLabel);
            SurfaceReflectanceParametersGroupBox.Controls.Add(SpecularCoefficientTrackBar);
            SurfaceReflectanceParametersGroupBox.Controls.Add(DiffuseCoefficientValueLabel);
            SurfaceReflectanceParametersGroupBox.Controls.Add(DiffuseCoefficientLabel);
            SurfaceReflectanceParametersGroupBox.Controls.Add(DiffuseCoefficientTrackBar);
            SurfaceReflectanceParametersGroupBox.Controls.Add(ShininessExponentValueLabel);
            SurfaceReflectanceParametersGroupBox.Controls.Add(ShinenessExponentLabel);
            SurfaceReflectanceParametersGroupBox.Controls.Add(ShininessExponentTrackBar);
            SurfaceReflectanceParametersGroupBox.Dock = DockStyle.Fill;
            SurfaceReflectanceParametersGroupBox.Location = new Point(3, 223);
            SurfaceReflectanceParametersGroupBox.Name = "SurfaceReflectanceParametersGroupBox";
            SurfaceReflectanceParametersGroupBox.Size = new Size(403, 194);
            SurfaceReflectanceParametersGroupBox.TabIndex = 1;
            SurfaceReflectanceParametersGroupBox.TabStop = false;
            SurfaceReflectanceParametersGroupBox.Text = "Surface Reflectance Parameters (Material Properties)";
            // 
            // SpecularCoefficientValueLabel
            // 
            SpecularCoefficientValueLabel.AutoSize = true;
            SpecularCoefficientValueLabel.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SpecularCoefficientValueLabel.Location = new Point(370, 130);
            SpecularCoefficientValueLabel.Name = "SpecularCoefficientValueLabel";
            SpecularCoefficientValueLabel.Size = new Size(25, 17);
            SpecularCoefficientValueLabel.TabIndex = 8;
            SpecularCoefficientValueLabel.Text = "0.5";
            // 
            // SpecularCoefficientLabel
            // 
            SpecularCoefficientLabel.AutoSize = true;
            SpecularCoefficientLabel.Location = new Point(6, 130);
            SpecularCoefficientLabel.Name = "SpecularCoefficientLabel";
            SpecularCoefficientLabel.Size = new Size(142, 20);
            SpecularCoefficientLabel.TabIndex = 7;
            SpecularCoefficientLabel.Text = "Specular Coefficient";
            // 
            // SpecularCoefficientTrackBar
            // 
            SpecularCoefficientTrackBar.Enabled = false;
            SpecularCoefficientTrackBar.Location = new Point(146, 130);
            SpecularCoefficientTrackBar.Maximum = 100;
            SpecularCoefficientTrackBar.Name = "SpecularCoefficientTrackBar";
            SpecularCoefficientTrackBar.Size = new Size(228, 56);
            SpecularCoefficientTrackBar.TabIndex = 6;
            SpecularCoefficientTrackBar.Value = 50;
            SpecularCoefficientTrackBar.ValueChanged += SpecularCoefficientTrackBar_ValueChanged;
            // 
            // DiffuseCoefficientValueLabel
            // 
            DiffuseCoefficientValueLabel.AutoSize = true;
            DiffuseCoefficientValueLabel.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DiffuseCoefficientValueLabel.Location = new Point(370, 81);
            DiffuseCoefficientValueLabel.Name = "DiffuseCoefficientValueLabel";
            DiffuseCoefficientValueLabel.Size = new Size(25, 17);
            DiffuseCoefficientValueLabel.TabIndex = 5;
            DiffuseCoefficientValueLabel.Text = "0.5";
            // 
            // DiffuseCoefficientLabel
            // 
            DiffuseCoefficientLabel.AutoSize = true;
            DiffuseCoefficientLabel.Location = new Point(6, 81);
            DiffuseCoefficientLabel.Name = "DiffuseCoefficientLabel";
            DiffuseCoefficientLabel.Size = new Size(132, 20);
            DiffuseCoefficientLabel.TabIndex = 4;
            DiffuseCoefficientLabel.Text = "Diffuse Coefficient";
            // 
            // DiffuseCoefficientTrackBar
            // 
            DiffuseCoefficientTrackBar.Enabled = false;
            DiffuseCoefficientTrackBar.Location = new Point(146, 81);
            DiffuseCoefficientTrackBar.Maximum = 100;
            DiffuseCoefficientTrackBar.Name = "DiffuseCoefficientTrackBar";
            DiffuseCoefficientTrackBar.Size = new Size(228, 56);
            DiffuseCoefficientTrackBar.TabIndex = 3;
            DiffuseCoefficientTrackBar.Value = 50;
            DiffuseCoefficientTrackBar.ValueChanged += DiffuseCoefficientTrackBar_ValueChanged;
            // 
            // ShininessExponentValueLabel
            // 
            ShininessExponentValueLabel.AutoSize = true;
            ShininessExponentValueLabel.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShininessExponentValueLabel.Location = new Point(370, 36);
            ShininessExponentValueLabel.Name = "ShininessExponentValueLabel";
            ShininessExponentValueLabel.Size = new Size(22, 17);
            ShininessExponentValueLabel.TabIndex = 2;
            ShininessExponentValueLabel.Text = "50";
            // 
            // ShinenessExponentLabel
            // 
            ShinenessExponentLabel.AutoSize = true;
            ShinenessExponentLabel.Location = new Point(6, 36);
            ShinenessExponentLabel.Name = "ShinenessExponentLabel";
            ShinenessExponentLabel.Size = new Size(135, 20);
            ShinenessExponentLabel.TabIndex = 1;
            ShinenessExponentLabel.Text = "Shininess Exponent";
            // 
            // ShininessExponentTrackBar
            // 
            ShininessExponentTrackBar.Enabled = false;
            ShininessExponentTrackBar.Location = new Point(145, 36);
            ShininessExponentTrackBar.Maximum = 100;
            ShininessExponentTrackBar.Minimum = 1;
            ShininessExponentTrackBar.Name = "ShininessExponentTrackBar";
            ShininessExponentTrackBar.Size = new Size(229, 56);
            ShininessExponentTrackBar.TabIndex = 0;
            ShininessExponentTrackBar.Value = 51;
            ShininessExponentTrackBar.ValueChanged += ShininessExponentTrackBar_ValueChanged;
            // 
            // ObjectPropertiesGroupBox
            // 
            ObjectPropertiesGroupBox.Controls.Add(NormalMapCheckBox);
            ObjectPropertiesGroupBox.Controls.Add(ImageCheckBox);
            ObjectPropertiesGroupBox.Controls.Add(ColorCheckBox);
            ObjectPropertiesGroupBox.Controls.Add(NormalMapPanel);
            ObjectPropertiesGroupBox.Controls.Add(ImagePanel);
            ObjectPropertiesGroupBox.Controls.Add(SurfaceColorPanel);
            ObjectPropertiesGroupBox.Dock = DockStyle.Fill;
            ObjectPropertiesGroupBox.Location = new Point(3, 423);
            ObjectPropertiesGroupBox.Name = "ObjectPropertiesGroupBox";
            ObjectPropertiesGroupBox.Size = new Size(403, 194);
            ObjectPropertiesGroupBox.TabIndex = 2;
            ObjectPropertiesGroupBox.TabStop = false;
            ObjectPropertiesGroupBox.Text = "Surface Properties ";
            // 
            // NormalMapCheckBox
            // 
            NormalMapCheckBox.AutoSize = true;
            NormalMapCheckBox.Enabled = false;
            NormalMapCheckBox.Location = new Point(278, 159);
            NormalMapCheckBox.Name = "NormalMapCheckBox";
            NormalMapCheckBox.Size = new Size(110, 24);
            NormalMapCheckBox.TabIndex = 8;
            NormalMapCheckBox.Text = "Enable Map";
            NormalMapCheckBox.UseVisualStyleBackColor = true;
            NormalMapCheckBox.CheckedChanged += NormalMapCheckBox_CheckedChanged;
            // 
            // ImageCheckBox
            // 
            ImageCheckBox.AutoSize = true;
            ImageCheckBox.Enabled = false;
            ImageCheckBox.Location = new Point(145, 159);
            ImageCheckBox.Name = "ImageCheckBox";
            ImageCheckBox.Size = new Size(122, 24);
            ImageCheckBox.TabIndex = 7;
            ImageCheckBox.Text = "Enable Image";
            ImageCheckBox.UseVisualStyleBackColor = true;
            ImageCheckBox.CheckedChanged += ImageCheckBox_CheckedChanged;
            // 
            // ColorCheckBox
            // 
            ColorCheckBox.AutoSize = true;
            ColorCheckBox.BackColor = SystemColors.Control;
            ColorCheckBox.Enabled = false;
            ColorCheckBox.Location = new Point(6, 159);
            ColorCheckBox.Name = "ColorCheckBox";
            ColorCheckBox.Size = new Size(116, 24);
            ColorCheckBox.TabIndex = 6;
            ColorCheckBox.Text = "Enable Color";
            ColorCheckBox.UseVisualStyleBackColor = false;
            ColorCheckBox.CheckedChanged += ColorCheckBox_CheckedChanged;
            // 
            // NormalMapPanel
            // 
            NormalMapPanel.BackColor = Color.Gainsboro;
            NormalMapPanel.BorderStyle = BorderStyle.FixedSingle;
            NormalMapPanel.Enabled = false;
            NormalMapPanel.Location = new Point(278, 40);
            NormalMapPanel.Name = "NormalMapPanel";
            NormalMapPanel.Size = new Size(110, 110);
            NormalMapPanel.TabIndex = 3;
            NormalMapPanel.Click += NormalMapPanel_Click;
            // 
            // ImagePanel
            // 
            ImagePanel.BackColor = Color.Gainsboro;
            ImagePanel.BorderStyle = BorderStyle.FixedSingle;
            ImagePanel.Enabled = false;
            ImagePanel.Location = new Point(145, 40);
            ImagePanel.Name = "ImagePanel";
            ImagePanel.Size = new Size(110, 110);
            ImagePanel.TabIndex = 2;
            ImagePanel.Click += ImagePanel_Click;
            // 
            // SurfaceColorPanel
            // 
            SurfaceColorPanel.BackColor = Color.Gainsboro;
            SurfaceColorPanel.BorderStyle = BorderStyle.FixedSingle;
            SurfaceColorPanel.Enabled = false;
            SurfaceColorPanel.Location = new Point(6, 40);
            SurfaceColorPanel.Name = "SurfaceColorPanel";
            SurfaceColorPanel.Size = new Size(110, 110);
            SurfaceColorPanel.TabIndex = 0;
            SurfaceColorPanel.Click += SurfaceColorPanel_Click;
            // 
            // LightSourcePropertiesGroupBox
            // 
            LightSourcePropertiesGroupBox.Controls.Add(AnimationCheckBox);
            LightSourcePropertiesGroupBox.Controls.Add(ChooseLightSourceColorLabel);
            LightSourcePropertiesGroupBox.Controls.Add(ChooseLightSourceColorPanel);
            LightSourcePropertiesGroupBox.Controls.Add(LightSourceDistanceLabel);
            LightSourcePropertiesGroupBox.Controls.Add(LightSourceDistanceLabelValue);
            LightSourcePropertiesGroupBox.Controls.Add(LightSourceDistanceTrackbar);
            LightSourcePropertiesGroupBox.Dock = DockStyle.Fill;
            LightSourcePropertiesGroupBox.Location = new Point(3, 623);
            LightSourcePropertiesGroupBox.Name = "LightSourcePropertiesGroupBox";
            LightSourcePropertiesGroupBox.Size = new Size(403, 293);
            LightSourcePropertiesGroupBox.TabIndex = 3;
            LightSourcePropertiesGroupBox.TabStop = false;
            LightSourcePropertiesGroupBox.Text = "Light Source Properties";
            // 
            // AnimationCheckBox
            // 
            AnimationCheckBox.AutoSize = true;
            AnimationCheckBox.Enabled = false;
            AnimationCheckBox.Location = new Point(248, 83);
            AnimationCheckBox.Name = "AnimationCheckBox";
            AnimationCheckBox.Size = new Size(149, 24);
            AnimationCheckBox.TabIndex = 5;
            AnimationCheckBox.Text = "Enable Animation";
            AnimationCheckBox.UseVisualStyleBackColor = true;
            AnimationCheckBox.CheckedChanged += AnimationCheckBox_CheckedChanged;
            // 
            // ChooseLightSourceColorLabel
            // 
            ChooseLightSourceColorLabel.AutoSize = true;
            ChooseLightSourceColorLabel.Location = new Point(6, 84);
            ChooseLightSourceColorLabel.Name = "ChooseLightSourceColorLabel";
            ChooseLightSourceColorLabel.Size = new Size(184, 20);
            ChooseLightSourceColorLabel.TabIndex = 4;
            ChooseLightSourceColorLabel.Text = "Choose Light Source Color";
            // 
            // ChooseLightSourceColorPanel
            // 
            ChooseLightSourceColorPanel.BackColor = Color.Gainsboro;
            ChooseLightSourceColorPanel.BorderStyle = BorderStyle.FixedSingle;
            ChooseLightSourceColorPanel.Enabled = false;
            ChooseLightSourceColorPanel.Location = new Point(196, 84);
            ChooseLightSourceColorPanel.Name = "ChooseLightSourceColorPanel";
            ChooseLightSourceColorPanel.Size = new Size(20, 20);
            ChooseLightSourceColorPanel.TabIndex = 3;
            ChooseLightSourceColorPanel.Click += ChooseLightSourceColorPanel_Click;
            // 
            // LightSourceDistanceLabel
            // 
            LightSourceDistanceLabel.AutoSize = true;
            LightSourceDistanceLabel.Location = new Point(6, 37);
            LightSourceDistanceLabel.Name = "LightSourceDistanceLabel";
            LightSourceDistanceLabel.Size = new Size(140, 20);
            LightSourceDistanceLabel.TabIndex = 2;
            LightSourceDistanceLabel.Text = "Distance ('Z' Coord)";
            // 
            // LightSourceDistanceLabelValue
            // 
            LightSourceDistanceLabelValue.AutoSize = true;
            LightSourceDistanceLabelValue.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LightSourceDistanceLabelValue.Location = new Point(370, 37);
            LightSourceDistanceLabelValue.Name = "LightSourceDistanceLabelValue";
            LightSourceDistanceLabelValue.Size = new Size(27, 17);
            LightSourceDistanceLabelValue.TabIndex = 1;
            LightSourceDistanceLabelValue.Text = "100";
            // 
            // LightSourceDistanceTrackbar
            // 
            LightSourceDistanceTrackbar.Enabled = false;
            LightSourceDistanceTrackbar.Location = new Point(146, 37);
            LightSourceDistanceTrackbar.Maximum = 500;
            LightSourceDistanceTrackbar.Minimum = 1;
            LightSourceDistanceTrackbar.Name = "LightSourceDistanceTrackbar";
            LightSourceDistanceTrackbar.Size = new Size(228, 56);
            LightSourceDistanceTrackbar.TabIndex = 0;
            LightSourceDistanceTrackbar.Value = 100;
            LightSourceDistanceTrackbar.ValueChanged += LightSourceDistanceTrackbar_ValueChanged;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 953);
            Controls.Add(mainTableLayoutPanel);
            Controls.Add(mainMenuStrip);
            MainMenuStrip = mainMenuStrip;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bicubic Bezier Surface Renderer App";
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            mainTableLayoutPanel.ResumeLayout(false);
            UITableLayoutPanel.ResumeLayout(false);
            TriangulationGroupBox.ResumeLayout(false);
            TriangulationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)XAxisRotationTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ZAxisRotationTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ResolutionTrackBar).EndInit();
            SurfaceReflectanceParametersGroupBox.ResumeLayout(false);
            SurfaceReflectanceParametersGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SpecularCoefficientTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)DiffuseCoefficientTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ShininessExponentTrackBar).EndInit();
            ObjectPropertiesGroupBox.ResumeLayout(false);
            ObjectPropertiesGroupBox.PerformLayout();
            LightSourcePropertiesGroupBox.ResumeLayout(false);
            LightSourcePropertiesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LightSourceDistanceTrackbar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem loadControlPointsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private TableLayoutPanel mainTableLayoutPanel;
        private Panel WorkspacePanel;
        private TableLayoutPanel UITableLayoutPanel;
        private GroupBox TriangulationGroupBox;
        private CheckBox ShowControlPointsCheckBox;
        private CheckBox ShowMeshCheckBox;
        private CheckBox FillTrianglesCheckBox;
        private Label ResolutionLabel;
        private TrackBar ResolutionTrackBar;
        private Label ResolutionValueLabel;
        private TrackBar ZAxisRotationTrackBar;
        private Label ZRotationLabelValue;
        private Label ZRotationLabel;
        private Label XRotationLabel;
        private TrackBar XAxisRotationTrackBar;
        private Label XRotationLabelValue;
        private GroupBox SurfaceReflectanceParametersGroupBox;
        private TrackBar DiffuseCoefficientTrackBar;
        private Label ShininessExponentValueLabel;
        private Label ShinenessExponentLabel;
        private TrackBar ShininessExponentTrackBar;
        private Label DiffuseCoefficientLabel;
        private TrackBar SpecularCoefficientTrackBar;
        private Label DiffuseCoefficientValueLabel;
        private Label SpecularCoefficientValueLabel;
        private Label SpecularCoefficientLabel;
        private GroupBox ObjectPropertiesGroupBox;
        private Panel SurfaceColorPanel;
        private Panel NormalMapPanel;
        private Panel ImagePanel;
        private CheckBox ImageCheckBox;
        private CheckBox ColorCheckBox;
        private CheckBox NormalMapCheckBox;
        private GroupBox LightSourcePropertiesGroupBox;
        private TrackBar LightSourceDistanceTrackbar;
        private Label LightSourceDistanceLabel;
        private Label LightSourceDistanceLabelValue;
        private Label ChooseLightSourceColorLabel;
        private Panel ChooseLightSourceColorPanel;
        private CheckBox AnimationCheckBox;
    }
}
