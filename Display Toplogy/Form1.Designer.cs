namespace Display_Toplogy {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayPathInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectedDisplaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displaySourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayTargetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayActivePathsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayAllPathsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayCurrentTopologyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alignedGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.layoutManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debugToolStripMenuItem,
            this.createToolStripMenuItem,
            this.layoutManagerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(473, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayPathInfoToolStripMenuItem,
            this.connectedDisplaysToolStripMenuItem,
            this.displaySourcesToolStripMenuItem,
            this.displayTargetsToolStripMenuItem,
            this.displayActivePathsToolStripMenuItem,
            this.displayAllPathsToolStripMenuItem,
            this.displayCurrentTopologyToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "&Debug";
            // 
            // displayPathInfoToolStripMenuItem
            // 
            this.displayPathInfoToolStripMenuItem.Name = "displayPathInfoToolStripMenuItem";
            this.displayPathInfoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.displayPathInfoToolStripMenuItem.Text = "Display &Adapters";
            this.displayPathInfoToolStripMenuItem.Click += new System.EventHandler(this.displayPathInfoToolStripMenuItem_Click);
            // 
            // connectedDisplaysToolStripMenuItem
            // 
            this.connectedDisplaysToolStripMenuItem.Name = "connectedDisplaysToolStripMenuItem";
            this.connectedDisplaysToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.connectedDisplaysToolStripMenuItem.Text = "&Connected Displays";
            this.connectedDisplaysToolStripMenuItem.Click += new System.EventHandler(this.connectedDisplaysToolStripMenuItem_Click);
            // 
            // displaySourcesToolStripMenuItem
            // 
            this.displaySourcesToolStripMenuItem.Name = "displaySourcesToolStripMenuItem";
            this.displaySourcesToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.displaySourcesToolStripMenuItem.Text = "Display &Sources";
            this.displaySourcesToolStripMenuItem.Click += new System.EventHandler(this.displaySourcesToolStripMenuItem_Click_1);
            // 
            // displayTargetsToolStripMenuItem
            // 
            this.displayTargetsToolStripMenuItem.Name = "displayTargetsToolStripMenuItem";
            this.displayTargetsToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.displayTargetsToolStripMenuItem.Text = "Display &Targets";
            this.displayTargetsToolStripMenuItem.Click += new System.EventHandler(this.displayTargetsToolStripMenuItem_Click);
            // 
            // displayActivePathsToolStripMenuItem
            // 
            this.displayActivePathsToolStripMenuItem.Name = "displayActivePathsToolStripMenuItem";
            this.displayActivePathsToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.displayActivePathsToolStripMenuItem.Text = "Display Active &Paths";
            this.displayActivePathsToolStripMenuItem.Click += new System.EventHandler(this.displayActivePathsToolStripMenuItem_Click);
            // 
            // displayAllPathsToolStripMenuItem
            // 
            this.displayAllPathsToolStripMenuItem.Name = "displayAllPathsToolStripMenuItem";
            this.displayAllPathsToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.displayAllPathsToolStripMenuItem.Text = "Display A&ll Paths";
            this.displayAllPathsToolStripMenuItem.Click += new System.EventHandler(this.displayAllPathsToolStripMenuItem_Click);
            // 
            // displayCurrentTopologyToolStripMenuItem
            // 
            this.displayCurrentTopologyToolStripMenuItem.Name = "displayCurrentTopologyToolStripMenuItem";
            this.displayCurrentTopologyToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.displayCurrentTopologyToolStripMenuItem.Text = "Display C&urrent Topology";
            this.displayCurrentTopologyToolStripMenuItem.Click += new System.EventHandler(this.displayCurrentTopologyToolStripMenuItem_Click);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alignedGridToolStripMenuItem});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // alignedGridToolStripMenuItem
            // 
            this.alignedGridToolStripMenuItem.Name = "alignedGridToolStripMenuItem";
            this.alignedGridToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.alignedGridToolStripMenuItem.Text = "Aligned &Grid";
            this.alignedGridToolStripMenuItem.Click += new System.EventHandler(this.alignedGridToolStripMenuItem_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 45);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(473, 509);
            this.propertyGrid1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(473, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // layoutManagerToolStripMenuItem
            // 
            this.layoutManagerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managerToolStripMenuItem});
            this.layoutManagerToolStripMenuItem.Name = "layoutManagerToolStripMenuItem";
            this.layoutManagerToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.layoutManagerToolStripMenuItem.Text = "&Layout";
            // 
            // managerToolStripMenuItem
            // 
            this.managerToolStripMenuItem.Name = "managerToolStripMenuItem";
            this.managerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.managerToolStripMenuItem.Text = "&Manager";
            this.managerToolStripMenuItem.Click += new System.EventHandler(this.managerToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 554);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Display Topology";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayPathInfoToolStripMenuItem;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem connectedDisplaysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displaySourcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayTargetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayActivePathsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayAllPathsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayCurrentTopologyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alignedGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem layoutManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerToolStripMenuItem;
    }
}

