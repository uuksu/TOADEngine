namespace TOADEngineEditor
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveSceneButton = new System.Windows.Forms.Button();
            this.sceneDescriptionBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sceneIdBox = new System.Windows.Forms.TextBox();
            this.sceneBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.removeSceneButton = new System.Windows.Forms.Button();
            this.addSceneButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.entityBox = new System.Windows.Forms.ListBox();
            this.removeEntityButton = new System.Windows.Forms.Button();
            this.addEntityButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.saveEntityButton = new System.Windows.Forms.Button();
            this.entityLocationBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.entityIdBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.saveCommandButton = new System.Windows.Forms.Button();
            this.commandScriptBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.commandLocationBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.commandOwnerBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.commandIdBox = new System.Windows.Forms.TextBox();
            this.commandBox = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.removeCommandButton = new System.Windows.Forms.Button();
            this.addCommandButton = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.settingFirstSceneBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.settingCommandNotFoundTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.settingEntityNotFoundTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportGameButton = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runGameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.runGameInDebugModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(723, 336);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.sceneBox);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(715, 310);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Scenes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.saveSceneButton);
            this.groupBox2.Controls.Add(this.sceneDescriptionBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.sceneIdBox);
            this.groupBox2.Location = new System.Drawing.Point(242, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 301);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Values:";
            // 
            // saveSceneButton
            // 
            this.saveSceneButton.Location = new System.Drawing.Point(384, 267);
            this.saveSceneButton.Name = "saveSceneButton";
            this.saveSceneButton.Size = new System.Drawing.Size(75, 23);
            this.saveSceneButton.TabIndex = 6;
            this.saveSceneButton.Text = "Save";
            this.saveSceneButton.UseVisualStyleBackColor = true;
            this.saveSceneButton.Click += new System.EventHandler(this.saveSceneButton_Click);
            // 
            // sceneDescriptionBox
            // 
            this.sceneDescriptionBox.Location = new System.Drawing.Point(70, 58);
            this.sceneDescriptionBox.Multiline = true;
            this.sceneDescriptionBox.Name = "sceneDescriptionBox";
            this.sceneDescriptionBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sceneDescriptionBox.Size = new System.Drawing.Size(389, 203);
            this.sceneDescriptionBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id:";
            // 
            // sceneIdBox
            // 
            this.sceneIdBox.Location = new System.Drawing.Point(70, 19);
            this.sceneIdBox.Name = "sceneIdBox";
            this.sceneIdBox.Size = new System.Drawing.Size(389, 20);
            this.sceneIdBox.TabIndex = 2;
            // 
            // sceneBox
            // 
            this.sceneBox.FormattingEnabled = true;
            this.sceneBox.Location = new System.Drawing.Point(14, 63);
            this.sceneBox.Name = "sceneBox";
            this.sceneBox.ScrollAlwaysVisible = true;
            this.sceneBox.Size = new System.Drawing.Size(213, 238);
            this.sceneBox.TabIndex = 0;
            this.sceneBox.SelectedValueChanged += new System.EventHandler(this.sceneBox_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.removeSceneButton);
            this.groupBox1.Controls.Add(this.addSceneButton);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 301);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scenes:";
            // 
            // removeSceneButton
            // 
            this.removeSceneButton.Location = new System.Drawing.Point(87, 21);
            this.removeSceneButton.Name = "removeSceneButton";
            this.removeSceneButton.Size = new System.Drawing.Size(75, 23);
            this.removeSceneButton.TabIndex = 1;
            this.removeSceneButton.Text = "Remove";
            this.removeSceneButton.UseVisualStyleBackColor = true;
            this.removeSceneButton.Click += new System.EventHandler(this.removeSceneButton_Click);
            // 
            // addSceneButton
            // 
            this.addSceneButton.Location = new System.Drawing.Point(6, 21);
            this.addSceneButton.Name = "addSceneButton";
            this.addSceneButton.Size = new System.Drawing.Size(75, 23);
            this.addSceneButton.TabIndex = 0;
            this.addSceneButton.Text = "Add";
            this.addSceneButton.UseVisualStyleBackColor = true;
            this.addSceneButton.Click += new System.EventHandler(this.addSceneButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(715, 310);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Entities";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.entityBox);
            this.groupBox3.Controls.Add(this.removeEntityButton);
            this.groupBox3.Controls.Add(this.addEntityButton);
            this.groupBox3.Location = new System.Drawing.Point(8, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 301);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Entities:";
            // 
            // entityBox
            // 
            this.entityBox.FormattingEnabled = true;
            this.entityBox.Location = new System.Drawing.Point(6, 52);
            this.entityBox.Name = "entityBox";
            this.entityBox.ScrollAlwaysVisible = true;
            this.entityBox.Size = new System.Drawing.Size(213, 238);
            this.entityBox.TabIndex = 3;
            this.entityBox.SelectedIndexChanged += new System.EventHandler(this.entityBox_SelectedIndexChanged);
            // 
            // removeEntityButton
            // 
            this.removeEntityButton.Location = new System.Drawing.Point(87, 21);
            this.removeEntityButton.Name = "removeEntityButton";
            this.removeEntityButton.Size = new System.Drawing.Size(75, 23);
            this.removeEntityButton.TabIndex = 3;
            this.removeEntityButton.Text = "Remove";
            this.removeEntityButton.UseVisualStyleBackColor = true;
            this.removeEntityButton.Click += new System.EventHandler(this.removeEntityButton_Click);
            // 
            // addEntityButton
            // 
            this.addEntityButton.Location = new System.Drawing.Point(6, 21);
            this.addEntityButton.Name = "addEntityButton";
            this.addEntityButton.Size = new System.Drawing.Size(75, 23);
            this.addEntityButton.TabIndex = 2;
            this.addEntityButton.Text = "Add";
            this.addEntityButton.UseVisualStyleBackColor = true;
            this.addEntityButton.Click += new System.EventHandler(this.addEntityButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.saveEntityButton);
            this.groupBox4.Controls.Add(this.entityLocationBox);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.entityIdBox);
            this.groupBox4.Location = new System.Drawing.Point(242, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(465, 301);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Values:";
            // 
            // saveEntityButton
            // 
            this.saveEntityButton.Location = new System.Drawing.Point(384, 78);
            this.saveEntityButton.Name = "saveEntityButton";
            this.saveEntityButton.Size = new System.Drawing.Size(75, 23);
            this.saveEntityButton.TabIndex = 6;
            this.saveEntityButton.Text = "Save";
            this.saveEntityButton.UseVisualStyleBackColor = true;
            this.saveEntityButton.Click += new System.EventHandler(this.saveEntityButton_Click);
            // 
            // entityLocationBox
            // 
            this.entityLocationBox.Location = new System.Drawing.Point(64, 52);
            this.entityLocationBox.Name = "entityLocationBox";
            this.entityLocationBox.Size = new System.Drawing.Size(395, 20);
            this.entityLocationBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Location:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Id:";
            // 
            // entityIdBox
            // 
            this.entityIdBox.Location = new System.Drawing.Point(64, 19);
            this.entityIdBox.Name = "entityIdBox";
            this.entityIdBox.Size = new System.Drawing.Size(395, 20);
            this.entityIdBox.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.commandBox);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(715, 310);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Commands";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.saveCommandButton);
            this.groupBox6.Controls.Add(this.commandScriptBox);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.commandLocationBox);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.commandOwnerBox);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.commandIdBox);
            this.groupBox6.Location = new System.Drawing.Point(242, 5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(465, 301);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Values:";
            // 
            // saveCommandButton
            // 
            this.saveCommandButton.Location = new System.Drawing.Point(384, 276);
            this.saveCommandButton.Name = "saveCommandButton";
            this.saveCommandButton.Size = new System.Drawing.Size(75, 23);
            this.saveCommandButton.TabIndex = 10;
            this.saveCommandButton.Text = "Save";
            this.saveCommandButton.UseVisualStyleBackColor = true;
            this.saveCommandButton.Click += new System.EventHandler(this.saveCommandButton_Click);
            // 
            // commandScriptBox
            // 
            this.commandScriptBox.Location = new System.Drawing.Point(64, 108);
            this.commandScriptBox.Multiline = true;
            this.commandScriptBox.Name = "commandScriptBox";
            this.commandScriptBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commandScriptBox.Size = new System.Drawing.Size(395, 162);
            this.commandScriptBox.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Script:";
            // 
            // commandLocationBox
            // 
            this.commandLocationBox.Location = new System.Drawing.Point(64, 82);
            this.commandLocationBox.Name = "commandLocationBox";
            this.commandLocationBox.Size = new System.Drawing.Size(395, 20);
            this.commandLocationBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Location:";
            // 
            // commandOwnerBox
            // 
            this.commandOwnerBox.Location = new System.Drawing.Point(64, 52);
            this.commandOwnerBox.Name = "commandOwnerBox";
            this.commandOwnerBox.Size = new System.Drawing.Size(395, 20);
            this.commandOwnerBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Owner:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Id:";
            // 
            // commandIdBox
            // 
            this.commandIdBox.Location = new System.Drawing.Point(64, 19);
            this.commandIdBox.Name = "commandIdBox";
            this.commandIdBox.Size = new System.Drawing.Size(395, 20);
            this.commandIdBox.TabIndex = 2;
            // 
            // commandBox
            // 
            this.commandBox.FormattingEnabled = true;
            this.commandBox.Location = new System.Drawing.Point(14, 63);
            this.commandBox.Name = "commandBox";
            this.commandBox.ScrollAlwaysVisible = true;
            this.commandBox.Size = new System.Drawing.Size(213, 238);
            this.commandBox.TabIndex = 6;
            this.commandBox.SelectedIndexChanged += new System.EventHandler(this.commandBox_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.removeCommandButton);
            this.groupBox5.Controls.Add(this.addCommandButton);
            this.groupBox5.Location = new System.Drawing.Point(8, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(228, 301);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Commands:";
            // 
            // removeCommandButton
            // 
            this.removeCommandButton.Location = new System.Drawing.Point(87, 21);
            this.removeCommandButton.Name = "removeCommandButton";
            this.removeCommandButton.Size = new System.Drawing.Size(75, 23);
            this.removeCommandButton.TabIndex = 3;
            this.removeCommandButton.Text = "Remove";
            this.removeCommandButton.UseVisualStyleBackColor = true;
            this.removeCommandButton.Click += new System.EventHandler(this.removeCommandButton_Click);
            // 
            // addCommandButton
            // 
            this.addCommandButton.Location = new System.Drawing.Point(6, 21);
            this.addCommandButton.Name = "addCommandButton";
            this.addCommandButton.Size = new System.Drawing.Size(75, 23);
            this.addCommandButton.TabIndex = 2;
            this.addCommandButton.Text = "Add";
            this.addCommandButton.UseVisualStyleBackColor = true;
            this.addCommandButton.Click += new System.EventHandler(this.addCommandButton_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox7);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(715, 310);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Settings";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.settingFirstSceneBox);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.settingCommandNotFoundTextBox);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.settingEntityNotFoundTextBox);
            this.groupBox7.Location = new System.Drawing.Point(6, 7);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(701, 300);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Settings";
            // 
            // settingFirstSceneBox
            // 
            this.settingFirstSceneBox.Location = new System.Drawing.Point(83, 20);
            this.settingFirstSceneBox.Name = "settingFirstSceneBox";
            this.settingFirstSceneBox.Size = new System.Drawing.Size(141, 20);
            this.settingFirstSceneBox.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(6, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 42);
            this.label11.TabIndex = 6;
            this.label11.Text = "Command Not Found Texts:";
            // 
            // settingCommandNotFoundTextBox
            // 
            this.settingCommandNotFoundTextBox.Location = new System.Drawing.Point(83, 99);
            this.settingCommandNotFoundTextBox.Name = "settingCommandNotFoundTextBox";
            this.settingCommandNotFoundTextBox.Size = new System.Drawing.Size(141, 20);
            this.settingCommandNotFoundTextBox.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "First Scene:";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(6, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 36);
            this.label10.TabIndex = 4;
            this.label10.Text = "Entity Not Found Texts:";
            // 
            // settingEntityNotFoundTextBox
            // 
            this.settingEntityNotFoundTextBox.Location = new System.Drawing.Point(83, 63);
            this.settingEntityNotFoundTextBox.Name = "settingEntityNotFoundTextBox";
            this.settingEntityNotFoundTextBox.Size = new System.Drawing.Size(141, 20);
            this.settingEntityNotFoundTextBox.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.runGameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(723, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.openGameToolStripMenuItem,
            this.saveGameToolStripMenuItem,
            this.saveGameAsToolStripMenuItem,
            this.exportGameButton,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fileToolStripMenuItem.Text = "File...";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // openGameToolStripMenuItem
            // 
            this.openGameToolStripMenuItem.Name = "openGameToolStripMenuItem";
            this.openGameToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.openGameToolStripMenuItem.Text = "Open Game...";
            this.openGameToolStripMenuItem.Click += new System.EventHandler(this.openGameToolStripMenuItem_Click);
            // 
            // saveGameToolStripMenuItem
            // 
            this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.saveGameToolStripMenuItem.Text = "Save Game";
            this.saveGameToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // saveGameAsToolStripMenuItem
            // 
            this.saveGameAsToolStripMenuItem.Name = "saveGameAsToolStripMenuItem";
            this.saveGameAsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.saveGameAsToolStripMenuItem.Text = "Save Game As...";
            this.saveGameAsToolStripMenuItem.Click += new System.EventHandler(this.saveGameToolStripMenuItem_Click);
            // 
            // exportGameButton
            // 
            this.exportGameButton.Name = "exportGameButton";
            this.exportGameButton.Size = new System.Drawing.Size(157, 22);
            this.exportGameButton.Text = "Export Game...";
            this.exportGameButton.Click += new System.EventHandler(this.exportGameButton_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // runGameToolStripMenuItem
            // 
            this.runGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runGameToolStripMenuItem1,
            this.runGameInDebugModeToolStripMenuItem});
            this.runGameToolStripMenuItem.Name = "runGameToolStripMenuItem";
            this.runGameToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.runGameToolStripMenuItem.Text = "Run Game";
            // 
            // runGameToolStripMenuItem1
            // 
            this.runGameToolStripMenuItem1.Name = "runGameToolStripMenuItem1";
            this.runGameToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.runGameToolStripMenuItem1.Text = "Normal Mode";
            this.runGameToolStripMenuItem1.Click += new System.EventHandler(this.runGameToolStripMenuItem1_Click);
            // 
            // runGameInDebugModeToolStripMenuItem
            // 
            this.runGameInDebugModeToolStripMenuItem.Name = "runGameInDebugModeToolStripMenuItem";
            this.runGameInDebugModeToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.runGameInDebugModeToolStripMenuItem.Text = "Debug Mode";
            this.runGameInDebugModeToolStripMenuItem.Click += new System.EventHandler(this.runGameInDebugModeToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 360);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(739, 398);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "TOAD Engine Editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGameAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runGameInDebugModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runGameToolStripMenuItem1;
        private System.Windows.Forms.ListBox sceneBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sceneIdBox;
        private System.Windows.Forms.TextBox sceneDescriptionBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox entityBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox entityLocationBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox entityIdBox;
        private System.Windows.Forms.ListBox commandBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox commandOwnerBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox commandIdBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox commandScriptBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox commandLocationBox;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button removeSceneButton;
        private System.Windows.Forms.Button addSceneButton;
        private System.Windows.Forms.Button removeEntityButton;
        private System.Windows.Forms.Button addEntityButton;
        private System.Windows.Forms.Button removeCommandButton;
        private System.Windows.Forms.Button addCommandButton;
        private System.Windows.Forms.Button saveSceneButton;
        private System.Windows.Forms.Button saveEntityButton;
        private System.Windows.Forms.Button saveCommandButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportGameButton;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox settingFirstSceneBox;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox settingEntityNotFoundTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox settingCommandNotFoundTextBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}