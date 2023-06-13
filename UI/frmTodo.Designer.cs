namespace C__Todo_App_with_SQL_Server
{
    partial class frmTodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTodo));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtTitle = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtDescription = new Bunifu.UI.WinForms.BunifuTextBox();
            this.dtpDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 178);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.AllowAnimations = true;
            this.btnExit.AllowMouseEffects = true;
            this.btnExit.AllowToggling = false;
            this.btnExit.AnimationSpeed = 200;
            this.btnExit.AutoGenerateColors = false;
            this.btnExit.AutoRoundBorders = false;
            this.btnExit.AutoSizeLeftIcon = true;
            this.btnExit.AutoSizeRightIcon = true;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackColor1 = System.Drawing.Color.Crimson;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExit.ButtonText = "Exit";
            this.btnExit.ButtonTextMarginLeft = 0;
            this.btnExit.ColorContrastOnClick = 45;
            this.btnExit.ColorContrastOnHover = 45;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnExit.CustomizableEdges = borderEdges1;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExit.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExit.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnExit.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnExit.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnExit.IconMarginLeft = 11;
            this.btnExit.IconPadding = 10;
            this.btnExit.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnExit.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnExit.IconSize = 25;
            this.btnExit.IdleBorderColor = System.Drawing.Color.Crimson;
            this.btnExit.IdleBorderRadius = 10;
            this.btnExit.IdleBorderThickness = 1;
            this.btnExit.IdleFillColor = System.Drawing.Color.Crimson;
            this.btnExit.IdleIconLeftImage = global::C__Todo_App_with_SQL_Server.Properties.Resources.arrow_left_on_rectangle;
            this.btnExit.IdleIconRightImage = null;
            this.btnExit.IndicateFocus = false;
            this.btnExit.Location = new System.Drawing.Point(638, 37);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExit.OnDisabledState.BorderRadius = 10;
            this.btnExit.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExit.OnDisabledState.BorderThickness = 1;
            this.btnExit.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExit.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExit.OnDisabledState.IconLeftImage = null;
            this.btnExit.OnDisabledState.IconRightImage = null;
            this.btnExit.onHoverState.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExit.onHoverState.BorderRadius = 10;
            this.btnExit.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExit.onHoverState.BorderThickness = 1;
            this.btnExit.onHoverState.FillColor = System.Drawing.Color.PaleVioletRed;
            this.btnExit.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnExit.onHoverState.IconLeftImage = null;
            this.btnExit.onHoverState.IconRightImage = null;
            this.btnExit.OnIdleState.BorderColor = System.Drawing.Color.Crimson;
            this.btnExit.OnIdleState.BorderRadius = 10;
            this.btnExit.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExit.OnIdleState.BorderThickness = 1;
            this.btnExit.OnIdleState.FillColor = System.Drawing.Color.Crimson;
            this.btnExit.OnIdleState.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnExit.OnIdleState.IconLeftImage = global::C__Todo_App_with_SQL_Server.Properties.Resources.arrow_left_on_rectangle;
            this.btnExit.OnIdleState.IconRightImage = null;
            this.btnExit.OnPressedState.BorderColor = System.Drawing.Color.Crimson;
            this.btnExit.OnPressedState.BorderRadius = 10;
            this.btnExit.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExit.OnPressedState.BorderThickness = 1;
            this.btnExit.OnPressedState.FillColor = System.Drawing.Color.Crimson;
            this.btnExit.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnExit.OnPressedState.IconLeftImage = null;
            this.btnExit.OnPressedState.IconRightImage = null;
            this.btnExit.Size = new System.Drawing.Size(150, 39);
            this.btnExit.TabIndex = 5;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.TextMarginLeft = 0;
            this.btnExit.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnExit.UseDefaultRadiusAndThickness = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Title";
            // 
            // btnAdd
            // 
            this.btnAdd.AllowAnimations = true;
            this.btnAdd.AllowMouseEffects = true;
            this.btnAdd.AllowToggling = false;
            this.btnAdd.AnimationSpeed = 200;
            this.btnAdd.AutoGenerateColors = false;
            this.btnAdd.AutoRoundBorders = false;
            this.btnAdd.AutoSizeLeftIcon = true;
            this.btnAdd.AutoSizeRightIcon = true;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(179)))), ((int)(((byte)(113)))));
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.ButtonText = "Add";
            this.btnAdd.ButtonTextMarginLeft = 0;
            this.btnAdd.ColorContrastOnClick = 45;
            this.btnAdd.ColorContrastOnHover = 45;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnAdd.CustomizableEdges = borderEdges2;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAdd.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAdd.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAdd.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdd.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAdd.IconMarginLeft = 11;
            this.btnAdd.IconPadding = 10;
            this.btnAdd.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAdd.IconSize = 25;
            this.btnAdd.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(179)))), ((int)(((byte)(113)))));
            this.btnAdd.IdleBorderRadius = 10;
            this.btnAdd.IdleBorderThickness = 1;
            this.btnAdd.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(179)))), ((int)(((byte)(113)))));
            this.btnAdd.IdleIconLeftImage = global::C__Todo_App_with_SQL_Server.Properties.Resources.plus;
            this.btnAdd.IdleIconRightImage = null;
            this.btnAdd.IndicateFocus = false;
            this.btnAdd.Location = new System.Drawing.Point(638, 97);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAdd.OnDisabledState.BorderRadius = 10;
            this.btnAdd.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.OnDisabledState.BorderThickness = 1;
            this.btnAdd.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAdd.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAdd.OnDisabledState.IconLeftImage = null;
            this.btnAdd.OnDisabledState.IconRightImage = null;
            this.btnAdd.onHoverState.BorderColor = System.Drawing.Color.MediumAquamarine;
            this.btnAdd.onHoverState.BorderRadius = 10;
            this.btnAdd.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.onHoverState.BorderThickness = 1;
            this.btnAdd.onHoverState.FillColor = System.Drawing.Color.MediumAquamarine;
            this.btnAdd.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.onHoverState.IconLeftImage = null;
            this.btnAdd.onHoverState.IconRightImage = null;
            this.btnAdd.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(179)))), ((int)(((byte)(113)))));
            this.btnAdd.OnIdleState.BorderRadius = 10;
            this.btnAdd.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.OnIdleState.BorderThickness = 1;
            this.btnAdd.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(179)))), ((int)(((byte)(113)))));
            this.btnAdd.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdd.OnIdleState.IconLeftImage = global::C__Todo_App_with_SQL_Server.Properties.Resources.plus;
            this.btnAdd.OnIdleState.IconRightImage = null;
            this.btnAdd.OnPressedState.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.OnPressedState.BorderRadius = 10;
            this.btnAdd.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.OnPressedState.BorderThickness = 1;
            this.btnAdd.OnPressedState.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.OnPressedState.IconLeftImage = null;
            this.btnAdd.OnPressedState.IconRightImage = null;
            this.btnAdd.Size = new System.Drawing.Size(150, 39);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.TextMarginLeft = 0;
            this.btnAdd.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAdd.UseDefaultRadiusAndThickness = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.AcceptsReturn = false;
            this.txtTitle.AcceptsTab = false;
            this.txtTitle.AnimationSpeed = 200;
            this.txtTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTitle.BackColor = System.Drawing.Color.Transparent;
            this.txtTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTitle.BackgroundImage")));
            this.txtTitle.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtTitle.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTitle.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtTitle.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtTitle.BorderRadius = 10;
            this.txtTitle.BorderThickness = 1;
            this.txtTitle.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtTitle.DefaultText = "";
            this.txtTitle.FillColor = System.Drawing.Color.White;
            this.txtTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTitle.HideSelection = true;
            this.txtTitle.IconLeft = null;
            this.txtTitle.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.IconPadding = 10;
            this.txtTitle.IconRight = null;
            this.txtTitle.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.Lines = new string[0];
            this.txtTitle.Location = new System.Drawing.Point(124, 37);
            this.txtTitle.MaxLength = 32767;
            this.txtTitle.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtTitle.Modified = false;
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTitle.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTitle.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTitle.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.SystemColors.ControlText;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTitle.OnIdleState = stateProperties4;
            this.txtTitle.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.txtTitle.PasswordChar = '\0';
            this.txtTitle.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTitle.PlaceholderText = "Input Text";
            this.txtTitle.ReadOnly = false;
            this.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTitle.SelectedText = "";
            this.txtTitle.SelectionLength = 0;
            this.txtTitle.SelectionStart = 0;
            this.txtTitle.ShortcutsEnabled = true;
            this.txtTitle.Size = new System.Drawing.Size(191, 30);
            this.txtTitle.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtTitle.TabIndex = 1;
            this.txtTitle.Tag = "Title";
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTitle.TextMarginBottom = 0;
            this.txtTitle.TextMarginLeft = 0;
            this.txtTitle.TextMarginTop = 0;
            this.txtTitle.TextPlaceholder = "Input Text";
            this.txtTitle.UseSystemPasswordChar = false;
            this.txtTitle.WordWrap = true;
            // 
            // txtDescription
            // 
            this.txtDescription.AcceptsReturn = false;
            this.txtDescription.AcceptsTab = false;
            this.txtDescription.AnimationSpeed = 200;
            this.txtDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDescription.BackColor = System.Drawing.Color.Transparent;
            this.txtDescription.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtDescription.BackgroundImage")));
            this.txtDescription.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtDescription.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtDescription.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtDescription.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtDescription.BorderRadius = 10;
            this.txtDescription.BorderThickness = 1;
            this.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtDescription.DefaultText = "";
            this.txtDescription.FillColor = System.Drawing.Color.White;
            this.txtDescription.HideSelection = true;
            this.txtDescription.IconLeft = null;
            this.txtDescription.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.IconPadding = 10;
            this.txtDescription.IconRight = null;
            this.txtDescription.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(124, 87);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtDescription.Modified = false;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDescription.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtDescription.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDescription.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDescription.OnIdleState = stateProperties8;
            this.txtDescription.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtDescription.PlaceholderText = "Input Description";
            this.txtDescription.ReadOnly = false;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(496, 56);
            this.txtDescription.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Tag = "Description";
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescription.TextMarginBottom = 0;
            this.txtDescription.TextMarginLeft = 0;
            this.txtDescription.TextMarginTop = 0;
            this.txtDescription.TextPlaceholder = "Input Description";
            this.txtDescription.UseSystemPasswordChar = false;
            this.txtDescription.WordWrap = true;
            // 
            // dtpDate
            // 
            this.dtpDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpDate.BorderRadius = 5;
            this.dtpDate.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.dtpDate.Color = System.Drawing.Color.Silver;
            this.dtpDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dtpDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dtpDate.DisabledColor = System.Drawing.Color.Gray;
            this.dtpDate.DisplayWeekNumbers = false;
            this.dtpDate.DPHeight = 0;
            this.dtpDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDate.FillDatePicker = false;
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDate.ForeColor = System.Drawing.Color.Black;
            this.dtpDate.Icon = ((System.Drawing.Image)(resources.GetObject("dtpDate.Icon")));
            this.dtpDate.IconColor = System.Drawing.Color.Gray;
            this.dtpDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dtpDate.LeftTextMargin = 5;
            this.dtpDate.Location = new System.Drawing.Point(377, 37);
            this.dtpDate.MinimumSize = new System.Drawing.Size(4, 32);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(243, 32);
            this.dtpDate.TabIndex = 3;
            this.dtpDate.Value = new System.DateTime(2023, 6, 2, 13, 58, 0, 0);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(0, 175);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(819, 275);
            this.dgv.TabIndex = 1;
            this.dgv.TabStop = false;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // frmTodo
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(819, 450);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panel1);
            this.Name = "frmTodo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todo";
            this.Load += new System.EventHandler(this.frmTodo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv;
        private Bunifu.UI.WinForms.BunifuDatePicker dtpDate;
        private Bunifu.UI.WinForms.BunifuTextBox txtTitle;
        private Bunifu.UI.WinForms.BunifuTextBox txtDescription;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExit;
    }
}

