﻿namespace WslManager
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DistroListView = new System.Windows.Forms.ListView();
            this.DistroNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UniqueIdHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AppxNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BasePathHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.DistroContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWithToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hyperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsTerminalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exploreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.createShortcutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapAsADriveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.configureDistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.unregisterDistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminateDistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripSeparator();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DefaultContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.newDistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importDistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportDistroFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ImportDistroFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ImportLocationFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.distroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDistroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openWithToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hyperToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsTerminalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exploreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.createShortcutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mapAsADriveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.importDistroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDistroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.configureDistroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.unregisterDistroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.terminateDistroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.propertiesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewModeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.largeIconToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.TotalCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SelectedCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ShortcutSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.IconGenerator = new System.ComponentModel.BackgroundWorker();
            this.ShimGenerator = new System.ComponentModel.BackgroundWorker();
            this.ShortcutGenerator = new System.ComponentModel.BackgroundWorker();
            this.shutdownAllDistrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DistroContextMenuStrip.SuspendLayout();
            this.DefaultContextMenuStrip.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // DistroListView
            // 
            this.DistroListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DistroNameHeader,
            this.UniqueIdHeader,
            this.AppxNameHeader,
            this.BasePathHeader});
            this.DistroListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DistroListView.FullRowSelect = true;
            this.DistroListView.HideSelection = false;
            this.DistroListView.LargeImageList = this.ImageList;
            this.DistroListView.Location = new System.Drawing.Point(0, 42);
            this.DistroListView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DistroListView.Name = "DistroListView";
            this.DistroListView.ShowGroups = false;
            this.DistroListView.Size = new System.Drawing.Size(990, 531);
            this.DistroListView.SmallImageList = this.ImageList;
            this.DistroListView.TabIndex = 0;
            this.DistroListView.UseCompatibleStateImageBehavior = false;
            this.DistroListView.ItemActivate += new System.EventHandler(this.DistroListView_ItemActivate);
            this.DistroListView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.DistroListView_ItemDrag);
            this.DistroListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.DistroListView_ItemSelectionChanged);
            this.DistroListView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DistroListView_MouseUp);
            // 
            // DistroNameHeader
            // 
            this.DistroNameHeader.Text = "Distro Name";
            // 
            // UniqueIdHeader
            // 
            this.UniqueIdHeader.Text = "Identifier";
            // 
            // AppxNameHeader
            // 
            this.AppxNameHeader.Text = "Store Package Name";
            // 
            // BasePathHeader
            // 
            this.BasePathHeader.Text = "Base Path";
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "linux");
            this.ImageList.Images.SetKeyName(1, "debian");
            this.ImageList.Images.SetKeyName(2, "suse");
            this.ImageList.Images.SetKeyName(3, "ubuntu");
            this.ImageList.Images.SetKeyName(4, "kali");
            // 
            // DistroContextMenuStrip
            // 
            this.DistroContextMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.DistroContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.openWithToolStripMenuItem,
            this.exploreToolStripMenuItem,
            this.toolStripMenuItem3,
            this.createShortcutToolStripMenuItem,
            this.mapAsADriveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.configureDistroToolStripMenuItem,
            this.exportDistroToolStripMenuItem,
            this.toolStripMenuItem2,
            this.unregisterDistroToolStripMenuItem,
            this.terminateDistroToolStripMenuItem,
            this.toolStripMenuItem12,
            this.propertiesToolStripMenuItem});
            this.DistroContextMenuStrip.Name = "DistroContextMenuStrip";
            this.DistroContextMenuStrip.Size = new System.Drawing.Size(262, 388);
            this.DistroContextMenuStrip.Opened += new System.EventHandler(this.DistroContextMenuStrip_Opening);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(261, 36);
            this.openToolStripMenuItem.Text = "&Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // openWithToolStripMenuItem
            // 
            this.openWithToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hyperToolStripMenuItem,
            this.windowsTerminalToolStripMenuItem});
            this.openWithToolStripMenuItem.Name = "openWithToolStripMenuItem";
            this.openWithToolStripMenuItem.Size = new System.Drawing.Size(261, 36);
            this.openWithToolStripMenuItem.Text = "&Open With...";
            // 
            // hyperToolStripMenuItem
            // 
            this.hyperToolStripMenuItem.Name = "hyperToolStripMenuItem";
            this.hyperToolStripMenuItem.Size = new System.Drawing.Size(320, 40);
            this.hyperToolStripMenuItem.Text = "&Hyper...";
            this.hyperToolStripMenuItem.Click += new System.EventHandler(this.HyperToolStripMenuItem_Click);
            // 
            // windowsTerminalToolStripMenuItem
            // 
            this.windowsTerminalToolStripMenuItem.Name = "windowsTerminalToolStripMenuItem";
            this.windowsTerminalToolStripMenuItem.Size = new System.Drawing.Size(320, 40);
            this.windowsTerminalToolStripMenuItem.Text = "&Windows Terminal...";
            this.windowsTerminalToolStripMenuItem.Click += new System.EventHandler(this.WindowsTerminalToolStripMenuItem_Click);
            // 
            // exploreToolStripMenuItem
            // 
            this.exploreToolStripMenuItem.Name = "exploreToolStripMenuItem";
            this.exploreToolStripMenuItem.Size = new System.Drawing.Size(261, 36);
            this.exploreToolStripMenuItem.Text = "&Explore...";
            this.exploreToolStripMenuItem.Click += new System.EventHandler(this.ExploreToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(258, 6);
            // 
            // createShortcutToolStripMenuItem
            // 
            this.createShortcutToolStripMenuItem.Name = "createShortcutToolStripMenuItem";
            this.createShortcutToolStripMenuItem.Size = new System.Drawing.Size(261, 36);
            this.createShortcutToolStripMenuItem.Text = "&Create Shortcut...";
            this.createShortcutToolStripMenuItem.Click += new System.EventHandler(this.CreateShortcutToolStripMenuItem_Click);
            // 
            // mapAsADriveToolStripMenuItem
            // 
            this.mapAsADriveToolStripMenuItem.Name = "mapAsADriveToolStripMenuItem";
            this.mapAsADriveToolStripMenuItem.Size = new System.Drawing.Size(261, 36);
            this.mapAsADriveToolStripMenuItem.Text = "&Map as a drive...";
            this.mapAsADriveToolStripMenuItem.Click += new System.EventHandler(this.MapAsADriveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(258, 6);
            // 
            // configureDistroToolStripMenuItem
            // 
            this.configureDistroToolStripMenuItem.Name = "configureDistroToolStripMenuItem";
            this.configureDistroToolStripMenuItem.Size = new System.Drawing.Size(261, 36);
            this.configureDistroToolStripMenuItem.Text = "&Configure Distro...";
            this.configureDistroToolStripMenuItem.Click += new System.EventHandler(this.ConfigureDistroToolStripMenuItem_Click);
            // 
            // exportDistroToolStripMenuItem
            // 
            this.exportDistroToolStripMenuItem.Name = "exportDistroToolStripMenuItem";
            this.exportDistroToolStripMenuItem.Size = new System.Drawing.Size(261, 36);
            this.exportDistroToolStripMenuItem.Text = "E&xport Distro...";
            this.exportDistroToolStripMenuItem.Click += new System.EventHandler(this.ExportDistroToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(258, 6);
            // 
            // unregisterDistroToolStripMenuItem
            // 
            this.unregisterDistroToolStripMenuItem.Name = "unregisterDistroToolStripMenuItem";
            this.unregisterDistroToolStripMenuItem.Size = new System.Drawing.Size(261, 36);
            this.unregisterDistroToolStripMenuItem.Text = "&Unregister Distro...";
            this.unregisterDistroToolStripMenuItem.Click += new System.EventHandler(this.UnregisterDistroToolStripMenuItem_Click);
            // 
            // terminateDistroToolStripMenuItem
            // 
            this.terminateDistroToolStripMenuItem.Name = "terminateDistroToolStripMenuItem";
            this.terminateDistroToolStripMenuItem.Size = new System.Drawing.Size(261, 36);
            this.terminateDistroToolStripMenuItem.Text = "&Terminate Distro...";
            this.terminateDistroToolStripMenuItem.Click += new System.EventHandler(this.TerminateDistroToolStripMenuItem_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(258, 6);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(261, 36);
            this.propertiesToolStripMenuItem.Text = "&Properties...";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.PropertiesToolStripMenuItem_Click);
            // 
            // DefaultContextMenuStrip
            // 
            this.DefaultContextMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.DefaultContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewModeToolStripMenuItem,
            this.toolStripMenuItem5,
            this.newDistroToolStripMenuItem,
            this.importDistroToolStripMenuItem,
            this.toolStripMenuItem4,
            this.refreshToolStripMenuItem});
            this.DefaultContextMenuStrip.Name = "DefaultContextMenuStrip";
            this.DefaultContextMenuStrip.Size = new System.Drawing.Size(229, 160);
            // 
            // viewModeToolStripMenuItem
            // 
            this.viewModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.largeIconsToolStripMenuItem,
            this.tileToolStripMenuItem,
            this.smallIconsToolStripMenuItem,
            this.listToolStripMenuItem,
            this.detailsToolStripMenuItem});
            this.viewModeToolStripMenuItem.Name = "viewModeToolStripMenuItem";
            this.viewModeToolStripMenuItem.Size = new System.Drawing.Size(228, 36);
            this.viewModeToolStripMenuItem.Text = "&View Mode";
            this.viewModeToolStripMenuItem.DropDownOpening += new System.EventHandler(this.ViewModeToolStripMenuItem_DropDownOpening);
            // 
            // largeIconsToolStripMenuItem
            // 
            this.largeIconsToolStripMenuItem.Name = "largeIconsToolStripMenuItem";
            this.largeIconsToolStripMenuItem.Size = new System.Drawing.Size(240, 40);
            this.largeIconsToolStripMenuItem.Text = "La&rge Icons";
            this.largeIconsToolStripMenuItem.Click += new System.EventHandler(this.LargeIconToolStripMenuItem_Click);
            // 
            // tileToolStripMenuItem
            // 
            this.tileToolStripMenuItem.Name = "tileToolStripMenuItem";
            this.tileToolStripMenuItem.Size = new System.Drawing.Size(240, 40);
            this.tileToolStripMenuItem.Text = "&Tile";
            this.tileToolStripMenuItem.Click += new System.EventHandler(this.TileToolStripMenuItem_Click);
            // 
            // smallIconsToolStripMenuItem
            // 
            this.smallIconsToolStripMenuItem.Name = "smallIconsToolStripMenuItem";
            this.smallIconsToolStripMenuItem.Size = new System.Drawing.Size(240, 40);
            this.smallIconsToolStripMenuItem.Text = "&Small Icons";
            this.smallIconsToolStripMenuItem.Click += new System.EventHandler(this.SmallIconsToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(240, 40);
            this.listToolStripMenuItem.Text = "&List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.ListToolStripMenuItem_Click);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(240, 40);
            this.detailsToolStripMenuItem.Text = "&Details";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.DetailsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(225, 6);
            // 
            // newDistroToolStripMenuItem
            // 
            this.newDistroToolStripMenuItem.Name = "newDistroToolStripMenuItem";
            this.newDistroToolStripMenuItem.Size = new System.Drawing.Size(228, 36);
            this.newDistroToolStripMenuItem.Text = "&New Distro...";
            this.newDistroToolStripMenuItem.Click += new System.EventHandler(this.NewDistroToolStripMenuItem_Click);
            // 
            // importDistroToolStripMenuItem
            // 
            this.importDistroToolStripMenuItem.Name = "importDistroToolStripMenuItem";
            this.importDistroToolStripMenuItem.Size = new System.Drawing.Size(228, 36);
            this.importDistroToolStripMenuItem.Text = "&Import Distro...";
            this.importDistroToolStripMenuItem.Click += new System.EventHandler(this.ImportDistroToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(225, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(228, 36);
            this.refreshToolStripMenuItem.Text = "&Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // ExportDistroFileDialog
            // 
            this.ExportDistroFileDialog.DefaultExt = "tar.gz";
            this.ExportDistroFileDialog.Filter = "Tarball GZIP file (*.tar.gz)|*.tar.gz";
            this.ExportDistroFileDialog.SupportMultiDottedExtensions = true;
            this.ExportDistroFileDialog.Title = "Export Distro";
            // 
            // ImportDistroFileDialog
            // 
            this.ImportDistroFileDialog.DefaultExt = "tar.gz";
            this.ImportDistroFileDialog.Filter = "Tarball GZIP file (*.tar.gz, *.tgz)|*.tar.gz;*.tgz";
            this.ImportDistroFileDialog.SupportMultiDottedExtensions = true;
            this.ImportDistroFileDialog.Title = "Import Distro";
            // 
            // ImportLocationFolderDialog
            // 
            this.ImportLocationFolderDialog.Description = "Specify the directory path to install distro.";
            // 
            // MainMenu
            // 
            this.MainMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.distroToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(990, 42);
            this.MainMenu.TabIndex = 2;
            this.MainMenu.Text = "menuStrip1";
            // 
            // distroToolStripMenuItem
            // 
            this.distroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDistroToolStripMenuItem1,
            this.openToolStripMenuItem1,
            this.openWithToolStripMenuItem1,
            this.exploreToolStripMenuItem1,
            this.toolStripMenuItem9,
            this.createShortcutToolStripMenuItem1,
            this.mapAsADriveToolStripMenuItem1,
            this.toolStripMenuItem6,
            this.importDistroToolStripMenuItem1,
            this.exportDistroToolStripMenuItem1,
            this.toolStripMenuItem8,
            this.configureDistroToolStripMenuItem1,
            this.unregisterDistroToolStripMenuItem1,
            this.terminateDistroToolStripMenuItem1,
            this.toolStripMenuItem10,
            this.propertiesToolStripMenuItem1,
            this.toolStripMenuItem13,
            this.shutdownAllDistrosToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.distroToolStripMenuItem.Name = "distroToolStripMenuItem";
            this.distroToolStripMenuItem.Size = new System.Drawing.Size(87, 34);
            this.distroToolStripMenuItem.Text = "&Distro";
            this.distroToolStripMenuItem.DropDownOpening += new System.EventHandler(this.DistroToolStripMenuItem_DropDownOpening);
            // 
            // newDistroToolStripMenuItem1
            // 
            this.newDistroToolStripMenuItem1.Name = "newDistroToolStripMenuItem1";
            this.newDistroToolStripMenuItem1.Size = new System.Drawing.Size(315, 40);
            this.newDistroToolStripMenuItem1.Text = "&New Distro...";
            this.newDistroToolStripMenuItem1.Click += new System.EventHandler(this.NewDistroToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(315, 40);
            this.openToolStripMenuItem1.Text = "&Open...";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // openWithToolStripMenuItem1
            // 
            this.openWithToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hyperToolStripMenuItem1,
            this.windowsTerminalToolStripMenuItem1});
            this.openWithToolStripMenuItem1.Name = "openWithToolStripMenuItem1";
            this.openWithToolStripMenuItem1.Size = new System.Drawing.Size(315, 40);
            this.openWithToolStripMenuItem1.Text = "&Open With";
            // 
            // hyperToolStripMenuItem1
            // 
            this.hyperToolStripMenuItem1.Name = "hyperToolStripMenuItem1";
            this.hyperToolStripMenuItem1.Size = new System.Drawing.Size(305, 40);
            this.hyperToolStripMenuItem1.Text = "&Hyper...";
            this.hyperToolStripMenuItem1.Click += new System.EventHandler(this.HyperToolStripMenuItem_Click);
            // 
            // windowsTerminalToolStripMenuItem1
            // 
            this.windowsTerminalToolStripMenuItem1.Name = "windowsTerminalToolStripMenuItem1";
            this.windowsTerminalToolStripMenuItem1.Size = new System.Drawing.Size(305, 40);
            this.windowsTerminalToolStripMenuItem1.Text = "&Windows Terminal";
            this.windowsTerminalToolStripMenuItem1.Click += new System.EventHandler(this.WindowsTerminalToolStripMenuItem_Click);
            // 
            // exploreToolStripMenuItem1
            // 
            this.exploreToolStripMenuItem1.Name = "exploreToolStripMenuItem1";
            this.exploreToolStripMenuItem1.Size = new System.Drawing.Size(315, 40);
            this.exploreToolStripMenuItem1.Text = "&Explore...";
            this.exploreToolStripMenuItem1.DisplayStyleChanged += new System.EventHandler(this.ExploreToolStripMenuItem_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(312, 6);
            // 
            // createShortcutToolStripMenuItem1
            // 
            this.createShortcutToolStripMenuItem1.Name = "createShortcutToolStripMenuItem1";
            this.createShortcutToolStripMenuItem1.Size = new System.Drawing.Size(315, 40);
            this.createShortcutToolStripMenuItem1.Text = "&Create Shortcut...";
            this.createShortcutToolStripMenuItem1.Click += new System.EventHandler(this.CreateShortcutToolStripMenuItem_Click);
            // 
            // mapAsADriveToolStripMenuItem1
            // 
            this.mapAsADriveToolStripMenuItem1.Name = "mapAsADriveToolStripMenuItem1";
            this.mapAsADriveToolStripMenuItem1.Size = new System.Drawing.Size(315, 40);
            this.mapAsADriveToolStripMenuItem1.Text = "&Map as a drive...";
            this.mapAsADriveToolStripMenuItem1.Click += new System.EventHandler(this.MapAsADriveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(312, 6);
            // 
            // importDistroToolStripMenuItem1
            // 
            this.importDistroToolStripMenuItem1.Name = "importDistroToolStripMenuItem1";
            this.importDistroToolStripMenuItem1.Size = new System.Drawing.Size(315, 40);
            this.importDistroToolStripMenuItem1.Text = "&Import Distro...";
            this.importDistroToolStripMenuItem1.Click += new System.EventHandler(this.ImportDistroToolStripMenuItem_Click);
            // 
            // exportDistroToolStripMenuItem1
            // 
            this.exportDistroToolStripMenuItem1.Name = "exportDistroToolStripMenuItem1";
            this.exportDistroToolStripMenuItem1.Size = new System.Drawing.Size(315, 40);
            this.exportDistroToolStripMenuItem1.Text = "E&xport Distro...";
            this.exportDistroToolStripMenuItem1.Click += new System.EventHandler(this.ExportDistroToolStripMenuItem_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(312, 6);
            // 
            // configureDistroToolStripMenuItem1
            // 
            this.configureDistroToolStripMenuItem1.Name = "configureDistroToolStripMenuItem1";
            this.configureDistroToolStripMenuItem1.Size = new System.Drawing.Size(315, 40);
            this.configureDistroToolStripMenuItem1.Text = "&Configure Distro...";
            this.configureDistroToolStripMenuItem1.Click += new System.EventHandler(this.ConfigureDistroToolStripMenuItem_Click);
            // 
            // unregisterDistroToolStripMenuItem1
            // 
            this.unregisterDistroToolStripMenuItem1.Name = "unregisterDistroToolStripMenuItem1";
            this.unregisterDistroToolStripMenuItem1.Size = new System.Drawing.Size(315, 40);
            this.unregisterDistroToolStripMenuItem1.Text = "&Unregister Distro...";
            this.unregisterDistroToolStripMenuItem1.Click += new System.EventHandler(this.UnregisterDistroToolStripMenuItem_Click);
            // 
            // terminateDistroToolStripMenuItem1
            // 
            this.terminateDistroToolStripMenuItem1.Name = "terminateDistroToolStripMenuItem1";
            this.terminateDistroToolStripMenuItem1.Size = new System.Drawing.Size(315, 40);
            this.terminateDistroToolStripMenuItem1.Text = "&Terminate Distro...";
            this.terminateDistroToolStripMenuItem1.Click += new System.EventHandler(this.TerminateDistroToolStripMenuItem_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(312, 6);
            // 
            // propertiesToolStripMenuItem1
            // 
            this.propertiesToolStripMenuItem1.Name = "propertiesToolStripMenuItem1";
            this.propertiesToolStripMenuItem1.Size = new System.Drawing.Size(315, 40);
            this.propertiesToolStripMenuItem1.Text = "&Properties...";
            this.propertiesToolStripMenuItem1.Click += new System.EventHandler(this.PropertiesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(312, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.closeToolStripMenuItem.Text = "E&xit";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewModeToolStripMenuItem1,
            this.toolStripMenuItem11,
            this.refreshToolStripMenuItem1});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(75, 34);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // viewModeToolStripMenuItem1
            // 
            this.viewModeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.largeIconToolStripMenuItem1,
            this.tileToolStripMenuItem1,
            this.smallIconsToolStripMenuItem1,
            this.listToolStripMenuItem1,
            this.detailsToolStripMenuItem1});
            this.viewModeToolStripMenuItem1.Name = "viewModeToolStripMenuItem1";
            this.viewModeToolStripMenuItem1.Size = new System.Drawing.Size(315, 40);
            this.viewModeToolStripMenuItem1.Text = "View &Mode";
            this.viewModeToolStripMenuItem1.DropDownOpening += new System.EventHandler(this.ViewModeToolStripMenuItem1_DropDownOpening);
            // 
            // largeIconToolStripMenuItem1
            // 
            this.largeIconToolStripMenuItem1.Name = "largeIconToolStripMenuItem1";
            this.largeIconToolStripMenuItem1.Size = new System.Drawing.Size(315, 40);
            this.largeIconToolStripMenuItem1.Text = "La&rge Icons";
            this.largeIconToolStripMenuItem1.Click += new System.EventHandler(this.LargeIconToolStripMenuItem_Click);
            // 
            // tileToolStripMenuItem1
            // 
            this.tileToolStripMenuItem1.Name = "tileToolStripMenuItem1";
            this.tileToolStripMenuItem1.Size = new System.Drawing.Size(315, 40);
            this.tileToolStripMenuItem1.Text = "&Tile";
            this.tileToolStripMenuItem1.Click += new System.EventHandler(this.TileToolStripMenuItem_Click);
            // 
            // smallIconsToolStripMenuItem1
            // 
            this.smallIconsToolStripMenuItem1.Name = "smallIconsToolStripMenuItem1";
            this.smallIconsToolStripMenuItem1.Size = new System.Drawing.Size(315, 40);
            this.smallIconsToolStripMenuItem1.Text = "&Small Icons";
            this.smallIconsToolStripMenuItem1.Click += new System.EventHandler(this.SmallIconsToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem1
            // 
            this.listToolStripMenuItem1.Name = "listToolStripMenuItem1";
            this.listToolStripMenuItem1.Size = new System.Drawing.Size(315, 40);
            this.listToolStripMenuItem1.Text = "&List";
            this.listToolStripMenuItem1.Click += new System.EventHandler(this.ListToolStripMenuItem_Click);
            // 
            // detailsToolStripMenuItem1
            // 
            this.detailsToolStripMenuItem1.Name = "detailsToolStripMenuItem1";
            this.detailsToolStripMenuItem1.Size = new System.Drawing.Size(315, 40);
            this.detailsToolStripMenuItem1.Text = "&Details";
            this.detailsToolStripMenuItem1.Click += new System.EventHandler(this.DetailsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(312, 6);
            // 
            // refreshToolStripMenuItem1
            // 
            this.refreshToolStripMenuItem1.Name = "refreshToolStripMenuItem1";
            this.refreshToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshToolStripMenuItem1.Size = new System.Drawing.Size(315, 40);
            this.refreshToolStripMenuItem1.Text = "&Refresh";
            this.refreshToolStripMenuItem1.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(75, 34);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(205, 40);
            this.AboutToolStripMenuItem.Text = "&About...";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TotalCountLabel,
            this.SelectedCountLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 573);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 24, 0);
            this.StatusStrip.Size = new System.Drawing.Size(990, 39);
            this.StatusStrip.TabIndex = 3;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // TotalCountLabel
            // 
            this.TotalCountLabel.Name = "TotalCountLabel";
            this.TotalCountLabel.Size = new System.Drawing.Size(28, 30);
            this.TotalCountLabel.Text = "...";
            this.TotalCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SelectedCountLabel
            // 
            this.SelectedCountLabel.Name = "SelectedCountLabel";
            this.SelectedCountLabel.Size = new System.Drawing.Size(936, 30);
            this.SelectedCountLabel.Spring = true;
            this.SelectedCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ShortcutSaveFileDialog
            // 
            this.ShortcutSaveFileDialog.DefaultExt = "lnk";
            this.ShortcutSaveFileDialog.Filter = "Shortcut File (*.lnk)|*.lnk";
            this.ShortcutSaveFileDialog.SupportMultiDottedExtensions = true;
            this.ShortcutSaveFileDialog.Title = "Create Shortcut As";
            // 
            // IconGenerator
            // 
            this.IconGenerator.DoWork += new System.ComponentModel.DoWorkEventHandler(this.IconGenerator_DoWork);
            this.IconGenerator.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.IconGenerator_RunWorkerCompleted);
            // 
            // ShimGenerator
            // 
            this.ShimGenerator.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ShimGenerator_DoWork);
            this.ShimGenerator.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ShimGenerator_RunWorkerCompleted);
            // 
            // ShortcutGenerator
            // 
            this.ShortcutGenerator.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ShortcutGenerator_DoWork);
            this.ShortcutGenerator.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ShortcutGenerator_RunWorkerCompleted);
            // 
            // shutdownAllDistrosToolStripMenuItem
            // 
            this.shutdownAllDistrosToolStripMenuItem.Name = "shutdownAllDistrosToolStripMenuItem";
            this.shutdownAllDistrosToolStripMenuItem.Size = new System.Drawing.Size(344, 40);
            this.shutdownAllDistrosToolStripMenuItem.Text = "&Shutdown All Distros...";
            this.shutdownAllDistrosToolStripMenuItem.Click += new System.EventHandler(this.ShutdownAllDistrosToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(990, 612);
            this.Controls.Add(this.DistroListView);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.MainMenu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "MainForm";
            this.Text = "WSL Manager [Beta]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DistroContextMenuStrip.ResumeLayout(false);
            this.DefaultContextMenuStrip.ResumeLayout(false);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView DistroListView;
        private System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.ContextMenuStrip DistroContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWithToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hyperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exploreToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportDistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem unregisterDistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminateDistroToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip DefaultContextMenuStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem importDistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog ExportDistroFileDialog;
        private System.Windows.Forms.OpenFileDialog ImportDistroFileDialog;
        private System.Windows.Forms.FolderBrowserDialog ImportLocationFolderDialog;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem distroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openWithToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hyperToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exploreToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem exportDistroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem unregisterDistroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem terminateDistroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem importDistroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewModeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem largeIconToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem smallIconsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader DistroNameHeader;
        private System.Windows.Forms.ColumnHeader UniqueIdHeader;
        private System.Windows.Forms.ColumnHeader AppxNameHeader;
        private System.Windows.Forms.ColumnHeader BasePathHeader;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem13;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel TotalCountLabel;
        private System.Windows.Forms.ToolStripStatusLabel SelectedCountLabel;
        private System.Windows.Forms.ToolStripMenuItem createShortcutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createShortcutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mapAsADriveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem mapAsADriveToolStripMenuItem1;
        private System.Windows.Forms.SaveFileDialog ShortcutSaveFileDialog;
        private System.ComponentModel.BackgroundWorker IconGenerator;
        private System.ComponentModel.BackgroundWorker ShimGenerator;
        private System.ComponentModel.BackgroundWorker ShortcutGenerator;
        private System.Windows.Forms.ToolStripMenuItem newDistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDistroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem configureDistroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem configureDistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsTerminalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsTerminalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem shutdownAllDistrosToolStripMenuItem;
    }
}

