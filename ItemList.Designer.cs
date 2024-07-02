using System.Windows.Forms;

namespace UIF
{
    partial class ItemList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemList));
            this.ResultsLabel = new System.Windows.Forms.Label();
            this.ResultsListBox = new System.Windows.Forms.ListBox();
            this.InfoGroupBox = new System.Windows.Forms.GroupBox();
            this.NameIdToClipboard = new System.Windows.Forms.Button();
            this.AllNameIdToClipboard = new System.Windows.Forms.Button();
            this.IdPrefixTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.IdToClipboard = new System.Windows.Forms.Button();
            this.ItemStatsPanel = new System.Windows.Forms.Panel();
            this.LinkedGunsBtn = new System.Windows.Forms.Button();
            this.LinkedModulesBtn = new System.Windows.Forms.Button();
            this.LinkedAmmoBtn = new System.Windows.Forms.Button();
            this.LinkedGunsLabel = new System.Windows.Forms.Label();
            this.LinkedModulesLabel = new System.Windows.Forms.Label();
            this.firerate = new System.Windows.Forms.TextBox();
            this.movement_speed_multiplier = new System.Windows.Forms.TextBox();
            this.equipable_movement_speed_multiplier = new System.Windows.Forms.TextBox();
            this.recoil_y = new System.Windows.Forms.TextBox();
            this.recoil_x = new System.Windows.Forms.TextBox();
            this.Recoil_XYLabel = new System.Windows.Forms.Label();
            this.pellets = new System.Windows.Forms.TextBox();
            this.PelletsLabel = new System.Windows.Forms.Label();
            this.LinkedAmmoLabel = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.TextBox();
            this.AmmoAmountLabel = new System.Windows.Forms.Label();
            this.damage = new System.Windows.Forms.TextBox();
            this.volume = new System.Windows.Forms.TextBox();
            this.spread = new System.Windows.Forms.TextBox();
            this.health = new System.Windows.Forms.TextBox();
            this.engine = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.TextBox();
            this.useable = new System.Windows.Forms.TextBox();
            this.range = new System.Windows.Forms.TextBox();
            this.structure_damage = new System.Windows.Forms.TextBox();
            this.player_damage = new System.Windows.Forms.TextBox();
            this.player_spine_damage = new System.Windows.Forms.TextBox();
            this.player_skull_damage = new System.Windows.Forms.TextBox();
            this.armor = new System.Windows.Forms.TextBox();
            this.BarrelDamageLabel = new System.Windows.Forms.Label();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.EMSMLabel = new System.Windows.Forms.Label();
            this.SpreadLabel = new System.Windows.Forms.Label();
            this.ItemHealthLabel = new System.Windows.Forms.Label();
            this.EngineLabel = new System.Windows.Forms.Label();
            this.RangeLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.BuildingsDamageLabel = new System.Windows.Forms.Label();
            this.FirerateLabel = new System.Windows.Forms.Label();
            this.UseableLabel = new System.Windows.Forms.Label();
            this.PlayerDamageLabel = new System.Windows.Forms.Label();
            this.BodyDamageLabel = new System.Windows.Forms.Label();
            this.HeadDamageLabel = new System.Windows.Forms.Label();
            this.ProtectionLabel = new System.Windows.Forms.Label();
            this.ItemCapacityLabel = new System.Windows.Forms.Label();
            this.item_capacity = new System.Windows.Forms.TextBox();
            this.SortDamagePlayersBtn = new System.Windows.Forms.Button();
            this.SortCapacityBtn = new System.Windows.Forms.Button();
            this.SortProtectionBtn = new System.Windows.Forms.Button();
            this.SortByRangeBtn = new System.Windows.Forms.Button();
            this.SortByFirerateBtn = new System.Windows.Forms.Button();
            this.SortByRecoilYBtn = new System.Windows.Forms.Button();
            this.SortByRecoilXBtn = new System.Windows.Forms.Button();
            this.SortByMSMBtn = new System.Windows.Forms.Button();
            this.SortByEMSMBtn = new System.Windows.Forms.Button();
            this.SortByPelletsBtn = new System.Windows.Forms.Button();
            this.SortByAmmoAmountBtn = new System.Windows.Forms.Button();
            this.SortByLabel = new System.Windows.Forms.Label();
            this.SortByBarrelDamageBtn = new System.Windows.Forms.Button();
            this.SortByVolumeBtn = new System.Windows.Forms.Button();
            this.SortBySpreadBtn = new System.Windows.Forms.Button();
            this.SortByBuildingHealthBtn = new System.Windows.Forms.Button();
            this.SortBarricadeCapacityBtn = new System.Windows.Forms.Button();
            this.SortVehicleHealthBtn = new System.Windows.Forms.Button();
            this.SortDamageBuildingsBtn = new System.Windows.Forms.Button();
            this.MixBtn = new System.Windows.Forms.Button();
            this.ItemStatsLabel = new System.Windows.Forms.Label();
            this.SortingPanel = new System.Windows.Forms.Panel();
            this.SortByIDBtn = new System.Windows.Forms.Button();
            this.SortByNameBtn = new System.Windows.Forms.Button();
            this.InfoGroupBox.SuspendLayout();
            this.ItemStatsPanel.SuspendLayout();
            this.SortingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultsLabel
            // 
            this.ResultsLabel.AutoSize = true;
            this.ResultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultsLabel.Location = new System.Drawing.Point(9, 9);
            this.ResultsLabel.Name = "ResultsLabel";
            this.ResultsLabel.Size = new System.Drawing.Size(98, 17);
            this.ResultsLabel.TabIndex = 7;
            this.ResultsLabel.Text = "Found results:";
            // 
            // ResultsListBox
            // 
            this.ResultsListBox.FormattingEnabled = true;
            this.ResultsListBox.Location = new System.Drawing.Point(12, 29);
            this.ResultsListBox.Name = "ResultsListBox";
            this.ResultsListBox.Size = new System.Drawing.Size(173, 602);
            this.ResultsListBox.TabIndex = 6;
            this.ResultsListBox.TabStop = false;
            this.ResultsListBox.SelectedIndexChanged += new System.EventHandler(this.ResultsListBox_SelectedIndexChanged);
            // 
            // InfoGroupBox
            // 
            this.InfoGroupBox.Controls.Add(this.NameIdToClipboard);
            this.InfoGroupBox.Controls.Add(this.AllNameIdToClipboard);
            this.InfoGroupBox.Controls.Add(this.IdPrefixTextBox);
            this.InfoGroupBox.Controls.Add(this.IdTextBox);
            this.InfoGroupBox.Controls.Add(this.NameTextBox);
            this.InfoGroupBox.Controls.Add(this.IdLabel);
            this.InfoGroupBox.Controls.Add(this.NameLabel);
            this.InfoGroupBox.Controls.Add(this.IdToClipboard);
            this.InfoGroupBox.Location = new System.Drawing.Point(185, 29);
            this.InfoGroupBox.Name = "InfoGroupBox";
            this.InfoGroupBox.Size = new System.Drawing.Size(344, 137);
            this.InfoGroupBox.TabIndex = 5;
            this.InfoGroupBox.TabStop = false;
            this.InfoGroupBox.Text = "Info";
            // 
            // NameIdToClipboard
            // 
            this.NameIdToClipboard.Location = new System.Drawing.Point(90, 83);
            this.NameIdToClipboard.Name = "NameIdToClipboard";
            this.NameIdToClipboard.Size = new System.Drawing.Size(248, 23);
            this.NameIdToClipboard.TabIndex = 7;
            this.NameIdToClipboard.TabStop = false;
            this.NameIdToClipboard.Text = "Copy Name/ID to clipboard";
            this.NameIdToClipboard.UseVisualStyleBackColor = true;
            this.NameIdToClipboard.Click += new System.EventHandler(this.NameIdToClipboard_Click);
            // 
            // AllNameIdToClipboard
            // 
            this.AllNameIdToClipboard.Location = new System.Drawing.Point(90, 106);
            this.AllNameIdToClipboard.Name = "AllNameIdToClipboard";
            this.AllNameIdToClipboard.Size = new System.Drawing.Size(248, 23);
            this.AllNameIdToClipboard.TabIndex = 6;
            this.AllNameIdToClipboard.TabStop = false;
            this.AllNameIdToClipboard.Text = "Copy all Name/ID to clipboard";
            this.AllNameIdToClipboard.UseVisualStyleBackColor = true;
            this.AllNameIdToClipboard.Click += new System.EventHandler(this.AllNameIdToClipboard_Click);
            // 
            // IdPrefixTextBox
            // 
            this.IdPrefixTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdPrefixTextBox.Location = new System.Drawing.Point(90, 37);
            this.IdPrefixTextBox.Name = "IdPrefixTextBox";
            this.IdPrefixTextBox.Size = new System.Drawing.Size(131, 22);
            this.IdPrefixTextBox.TabIndex = 5;
            this.IdPrefixTextBox.TabStop = false;
            this.IdPrefixTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdTextBox.Location = new System.Drawing.Point(221, 37);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(117, 22);
            this.IdTextBox.TabIndex = 0;
            this.IdTextBox.TabStop = false;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(90, 16);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(248, 22);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TabStop = false;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdLabel.Location = new System.Drawing.Point(6, 37);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(34, 20);
            this.IdLabel.TabIndex = 2;
            this.IdLabel.Text = "ID: ";
            this.IdLabel.Click += new System.EventHandler(this.IdLabel_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(6, 16);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(59, 20);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name: ";
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // IdToClipboard
            // 
            this.IdToClipboard.Location = new System.Drawing.Point(90, 60);
            this.IdToClipboard.Name = "IdToClipboard";
            this.IdToClipboard.Size = new System.Drawing.Size(248, 23);
            this.IdToClipboard.TabIndex = 4;
            this.IdToClipboard.TabStop = false;
            this.IdToClipboard.Text = "Copy ID to clipboard";
            this.IdToClipboard.UseVisualStyleBackColor = true;
            this.IdToClipboard.Click += new System.EventHandler(this.IdToClipboard_Click);
            // 
            // ItemStatsPanel
            // 
            this.ItemStatsPanel.AutoScroll = true;
            this.ItemStatsPanel.Controls.Add(this.LinkedGunsBtn);
            this.ItemStatsPanel.Controls.Add(this.LinkedModulesBtn);
            this.ItemStatsPanel.Controls.Add(this.LinkedAmmoBtn);
            this.ItemStatsPanel.Controls.Add(this.LinkedGunsLabel);
            this.ItemStatsPanel.Controls.Add(this.LinkedModulesLabel);
            this.ItemStatsPanel.Controls.Add(this.firerate);
            this.ItemStatsPanel.Controls.Add(this.movement_speed_multiplier);
            this.ItemStatsPanel.Controls.Add(this.equipable_movement_speed_multiplier);
            this.ItemStatsPanel.Controls.Add(this.recoil_y);
            this.ItemStatsPanel.Controls.Add(this.recoil_x);
            this.ItemStatsPanel.Controls.Add(this.Recoil_XYLabel);
            this.ItemStatsPanel.Controls.Add(this.pellets);
            this.ItemStatsPanel.Controls.Add(this.PelletsLabel);
            this.ItemStatsPanel.Controls.Add(this.LinkedAmmoLabel);
            this.ItemStatsPanel.Controls.Add(this.amount);
            this.ItemStatsPanel.Controls.Add(this.AmmoAmountLabel);
            this.ItemStatsPanel.Controls.Add(this.damage);
            this.ItemStatsPanel.Controls.Add(this.volume);
            this.ItemStatsPanel.Controls.Add(this.spread);
            this.ItemStatsPanel.Controls.Add(this.health);
            this.ItemStatsPanel.Controls.Add(this.engine);
            this.ItemStatsPanel.Controls.Add(this.type);
            this.ItemStatsPanel.Controls.Add(this.useable);
            this.ItemStatsPanel.Controls.Add(this.range);
            this.ItemStatsPanel.Controls.Add(this.structure_damage);
            this.ItemStatsPanel.Controls.Add(this.player_damage);
            this.ItemStatsPanel.Controls.Add(this.player_spine_damage);
            this.ItemStatsPanel.Controls.Add(this.player_skull_damage);
            this.ItemStatsPanel.Controls.Add(this.armor);
            this.ItemStatsPanel.Controls.Add(this.BarrelDamageLabel);
            this.ItemStatsPanel.Controls.Add(this.VolumeLabel);
            this.ItemStatsPanel.Controls.Add(this.EMSMLabel);
            this.ItemStatsPanel.Controls.Add(this.SpreadLabel);
            this.ItemStatsPanel.Controls.Add(this.ItemHealthLabel);
            this.ItemStatsPanel.Controls.Add(this.EngineLabel);
            this.ItemStatsPanel.Controls.Add(this.RangeLabel);
            this.ItemStatsPanel.Controls.Add(this.TypeLabel);
            this.ItemStatsPanel.Controls.Add(this.BuildingsDamageLabel);
            this.ItemStatsPanel.Controls.Add(this.FirerateLabel);
            this.ItemStatsPanel.Controls.Add(this.UseableLabel);
            this.ItemStatsPanel.Controls.Add(this.PlayerDamageLabel);
            this.ItemStatsPanel.Controls.Add(this.BodyDamageLabel);
            this.ItemStatsPanel.Controls.Add(this.HeadDamageLabel);
            this.ItemStatsPanel.Controls.Add(this.ProtectionLabel);
            this.ItemStatsPanel.Controls.Add(this.ItemCapacityLabel);
            this.ItemStatsPanel.Controls.Add(this.item_capacity);
            this.ItemStatsPanel.Location = new System.Drawing.Point(185, 164);
            this.ItemStatsPanel.Name = "ItemStatsPanel";
            this.ItemStatsPanel.Size = new System.Drawing.Size(344, 467);
            this.ItemStatsPanel.TabIndex = 4;
            // 
            // LinkedGunsBtn
            // 
            this.LinkedGunsBtn.Location = new System.Drawing.Point(244, 441);
            this.LinkedGunsBtn.Name = "LinkedGunsBtn";
            this.LinkedGunsBtn.Size = new System.Drawing.Size(81, 22);
            this.LinkedGunsBtn.TabIndex = 34;
            this.LinkedGunsBtn.Text = "Guns";
            this.LinkedGunsBtn.UseVisualStyleBackColor = true;
            this.LinkedGunsBtn.Click += new System.EventHandler(this.LinkedGunsBtn_Click);
            // 
            // LinkedModulesBtn
            // 
            this.LinkedModulesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.LinkedModulesBtn.Location = new System.Drawing.Point(244, 420);
            this.LinkedModulesBtn.Name = "LinkedModulesBtn";
            this.LinkedModulesBtn.Size = new System.Drawing.Size(81, 22);
            this.LinkedModulesBtn.TabIndex = 36;
            this.LinkedModulesBtn.Text = "Modules";
            this.LinkedModulesBtn.UseVisualStyleBackColor = true;
            this.LinkedModulesBtn.Click += new System.EventHandler(this.LinkedModulesBtn_Click);
            // 
            // LinkedAmmoBtn
            // 
            this.LinkedAmmoBtn.Location = new System.Drawing.Point(244, 399);
            this.LinkedAmmoBtn.Name = "LinkedAmmoBtn";
            this.LinkedAmmoBtn.Size = new System.Drawing.Size(81, 22);
            this.LinkedAmmoBtn.TabIndex = 32;
            this.LinkedAmmoBtn.Text = "Ammo";
            this.LinkedAmmoBtn.UseVisualStyleBackColor = true;
            this.LinkedAmmoBtn.Click += new System.EventHandler(this.LinkedAmmoBtn_Click);
            // 
            // LinkedGunsLabel
            // 
            this.LinkedGunsLabel.AutoSize = true;
            this.LinkedGunsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LinkedGunsLabel.Location = new System.Drawing.Point(6, 441);
            this.LinkedGunsLabel.Name = "LinkedGunsLabel";
            this.LinkedGunsLabel.Size = new System.Drawing.Size(99, 20);
            this.LinkedGunsLabel.TabIndex = 45;
            this.LinkedGunsLabel.Text = "Linked guns:";
            // 
            // LinkedModulesLabel
            // 
            this.LinkedModulesLabel.AutoSize = true;
            this.LinkedModulesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LinkedModulesLabel.Location = new System.Drawing.Point(6, 420);
            this.LinkedModulesLabel.Name = "LinkedModulesLabel";
            this.LinkedModulesLabel.Size = new System.Drawing.Size(124, 20);
            this.LinkedModulesLabel.TabIndex = 44;
            this.LinkedModulesLabel.Text = "Linked modules:";
            // 
            // firerate
            // 
            this.firerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firerate.Location = new System.Drawing.Point(245, 377);
            this.firerate.Name = "firerate";
            this.firerate.ReadOnly = true;
            this.firerate.Size = new System.Drawing.Size(79, 22);
            this.firerate.TabIndex = 8;
            this.firerate.TabStop = false;
            this.firerate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // movement_speed_multiplier
            // 
            this.movement_speed_multiplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.movement_speed_multiplier.Location = new System.Drawing.Point(284, 357);
            this.movement_speed_multiplier.Name = "movement_speed_multiplier";
            this.movement_speed_multiplier.ReadOnly = true;
            this.movement_speed_multiplier.Size = new System.Drawing.Size(40, 22);
            this.movement_speed_multiplier.TabIndex = 43;
            this.movement_speed_multiplier.TabStop = false;
            this.movement_speed_multiplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // equipable_movement_speed_multiplier
            // 
            this.equipable_movement_speed_multiplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equipable_movement_speed_multiplier.Location = new System.Drawing.Point(245, 357);
            this.equipable_movement_speed_multiplier.Name = "equipable_movement_speed_multiplier";
            this.equipable_movement_speed_multiplier.ReadOnly = true;
            this.equipable_movement_speed_multiplier.Size = new System.Drawing.Size(40, 22);
            this.equipable_movement_speed_multiplier.TabIndex = 41;
            this.equipable_movement_speed_multiplier.TabStop = false;
            this.equipable_movement_speed_multiplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // recoil_y
            // 
            this.recoil_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recoil_y.Location = new System.Drawing.Point(284, 337);
            this.recoil_y.Name = "recoil_y";
            this.recoil_y.ReadOnly = true;
            this.recoil_y.Size = new System.Drawing.Size(40, 22);
            this.recoil_y.TabIndex = 39;
            this.recoil_y.TabStop = false;
            this.recoil_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // recoil_x
            // 
            this.recoil_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recoil_x.Location = new System.Drawing.Point(245, 337);
            this.recoil_x.Name = "recoil_x";
            this.recoil_x.ReadOnly = true;
            this.recoil_x.Size = new System.Drawing.Size(40, 22);
            this.recoil_x.TabIndex = 40;
            this.recoil_x.TabStop = false;
            this.recoil_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Recoil_XYLabel
            // 
            this.Recoil_XYLabel.AutoSize = true;
            this.Recoil_XYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Recoil_XYLabel.Location = new System.Drawing.Point(6, 336);
            this.Recoil_XYLabel.Name = "Recoil_XYLabel";
            this.Recoil_XYLabel.Size = new System.Drawing.Size(87, 20);
            this.Recoil_XYLabel.TabIndex = 41;
            this.Recoil_XYLabel.Text = "Recoil X/Y:";
            // 
            // pellets
            // 
            this.pellets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pellets.Location = new System.Drawing.Point(245, 317);
            this.pellets.Name = "pellets";
            this.pellets.ReadOnly = true;
            this.pellets.Size = new System.Drawing.Size(79, 22);
            this.pellets.TabIndex = 37;
            this.pellets.TabStop = false;
            this.pellets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PelletsLabel
            // 
            this.PelletsLabel.AutoSize = true;
            this.PelletsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PelletsLabel.Location = new System.Drawing.Point(6, 316);
            this.PelletsLabel.Name = "PelletsLabel";
            this.PelletsLabel.Size = new System.Drawing.Size(60, 20);
            this.PelletsLabel.TabIndex = 38;
            this.PelletsLabel.Text = "Pellets:";
            // 
            // LinkedAmmoLabel
            // 
            this.LinkedAmmoLabel.AutoSize = true;
            this.LinkedAmmoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LinkedAmmoLabel.Location = new System.Drawing.Point(6, 399);
            this.LinkedAmmoLabel.Name = "LinkedAmmoLabel";
            this.LinkedAmmoLabel.Size = new System.Drawing.Size(108, 20);
            this.LinkedAmmoLabel.TabIndex = 31;
            this.LinkedAmmoLabel.Text = "Linked ammo:";
            // 
            // amount
            // 
            this.amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amount.Location = new System.Drawing.Point(245, 297);
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.Size = new System.Drawing.Size(79, 22);
            this.amount.TabIndex = 28;
            this.amount.TabStop = false;
            this.amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AmmoAmountLabel
            // 
            this.AmmoAmountLabel.AutoSize = true;
            this.AmmoAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmmoAmountLabel.Location = new System.Drawing.Point(6, 296);
            this.AmmoAmountLabel.Name = "AmmoAmountLabel";
            this.AmmoAmountLabel.Size = new System.Drawing.Size(117, 20);
            this.AmmoAmountLabel.TabIndex = 29;
            this.AmmoAmountLabel.Text = "Ammo amount:";
            // 
            // damage
            // 
            this.damage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.damage.Location = new System.Drawing.Point(245, 277);
            this.damage.Name = "damage";
            this.damage.ReadOnly = true;
            this.damage.Size = new System.Drawing.Size(79, 22);
            this.damage.TabIndex = 26;
            this.damage.TabStop = false;
            this.damage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // volume
            // 
            this.volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volume.Location = new System.Drawing.Point(245, 257);
            this.volume.Name = "volume";
            this.volume.ReadOnly = true;
            this.volume.Size = new System.Drawing.Size(79, 22);
            this.volume.TabIndex = 24;
            this.volume.TabStop = false;
            this.volume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // spread
            // 
            this.spread.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spread.Location = new System.Drawing.Point(245, 237);
            this.spread.Name = "spread";
            this.spread.ReadOnly = true;
            this.spread.Size = new System.Drawing.Size(79, 22);
            this.spread.TabIndex = 22;
            this.spread.TabStop = false;
            this.spread.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // health
            // 
            this.health.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.health.Location = new System.Drawing.Point(245, 217);
            this.health.Name = "health";
            this.health.ReadOnly = true;
            this.health.Size = new System.Drawing.Size(79, 22);
            this.health.TabIndex = 18;
            this.health.TabStop = false;
            this.health.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // engine
            // 
            this.engine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.engine.Location = new System.Drawing.Point(245, 197);
            this.engine.Name = "engine";
            this.engine.ReadOnly = true;
            this.engine.Size = new System.Drawing.Size(79, 22);
            this.engine.TabIndex = 20;
            this.engine.TabStop = false;
            this.engine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // type
            // 
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type.Location = new System.Drawing.Point(245, 177);
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Size = new System.Drawing.Size(79, 22);
            this.type.TabIndex = 1;
            this.type.TabStop = false;
            this.type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // useable
            // 
            this.useable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.useable.Location = new System.Drawing.Point(245, 157);
            this.useable.Name = "useable";
            this.useable.ReadOnly = true;
            this.useable.Size = new System.Drawing.Size(79, 22);
            this.useable.TabIndex = 5;
            this.useable.TabStop = false;
            this.useable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // range
            // 
            this.range.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.range.Location = new System.Drawing.Point(245, 137);
            this.range.Name = "range";
            this.range.ReadOnly = true;
            this.range.Size = new System.Drawing.Size(79, 22);
            this.range.TabIndex = 0;
            this.range.TabStop = false;
            this.range.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // structure_damage
            // 
            this.structure_damage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.structure_damage.Location = new System.Drawing.Point(245, 117);
            this.structure_damage.Name = "structure_damage";
            this.structure_damage.ReadOnly = true;
            this.structure_damage.Size = new System.Drawing.Size(79, 22);
            this.structure_damage.TabIndex = 4;
            this.structure_damage.TabStop = false;
            this.structure_damage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // player_damage
            // 
            this.player_damage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player_damage.Location = new System.Drawing.Point(245, 97);
            this.player_damage.Name = "player_damage";
            this.player_damage.ReadOnly = true;
            this.player_damage.Size = new System.Drawing.Size(79, 22);
            this.player_damage.TabIndex = 8;
            this.player_damage.TabStop = false;
            this.player_damage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // player_spine_damage
            // 
            this.player_spine_damage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player_spine_damage.Location = new System.Drawing.Point(245, 77);
            this.player_spine_damage.Name = "player_spine_damage";
            this.player_spine_damage.ReadOnly = true;
            this.player_spine_damage.Size = new System.Drawing.Size(79, 22);
            this.player_spine_damage.TabIndex = 11;
            this.player_spine_damage.TabStop = false;
            this.player_spine_damage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // player_skull_damage
            // 
            this.player_skull_damage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player_skull_damage.Location = new System.Drawing.Point(245, 57);
            this.player_skull_damage.Name = "player_skull_damage";
            this.player_skull_damage.ReadOnly = true;
            this.player_skull_damage.Size = new System.Drawing.Size(79, 22);
            this.player_skull_damage.TabIndex = 9;
            this.player_skull_damage.TabStop = false;
            this.player_skull_damage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // armor
            // 
            this.armor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.armor.Location = new System.Drawing.Point(245, 37);
            this.armor.Name = "armor";
            this.armor.ReadOnly = true;
            this.armor.Size = new System.Drawing.Size(79, 22);
            this.armor.TabIndex = 13;
            this.armor.TabStop = false;
            this.armor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BarrelDamageLabel
            // 
            this.BarrelDamageLabel.AutoSize = true;
            this.BarrelDamageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BarrelDamageLabel.Location = new System.Drawing.Point(6, 276);
            this.BarrelDamageLabel.Name = "BarrelDamageLabel";
            this.BarrelDamageLabel.Size = new System.Drawing.Size(183, 20);
            this.BarrelDamageLabel.TabIndex = 27;
            this.BarrelDamageLabel.Text = "Barrel damage multiplier:";
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VolumeLabel.Location = new System.Drawing.Point(6, 256);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(215, 20);
            this.VolumeLabel.TabIndex = 25;
            this.VolumeLabel.Text = "Suppressor volume multiplier:";
            // 
            // EMSMLabel
            // 
            this.EMSMLabel.AutoSize = true;
            this.EMSMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EMSMLabel.Location = new System.Drawing.Point(6, 356);
            this.EMSMLabel.Name = "EMSMLabel";
            this.EMSMLabel.Size = new System.Drawing.Size(225, 20);
            this.EMSMLabel.TabIndex = 42;
            this.EMSMLabel.Text = "Movement speed (items/cloth):";
            // 
            // SpreadLabel
            // 
            this.SpreadLabel.AutoSize = true;
            this.SpreadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpreadLabel.Location = new System.Drawing.Point(6, 236);
            this.SpreadLabel.Name = "SpreadLabel";
            this.SpreadLabel.Size = new System.Drawing.Size(131, 20);
            this.SpreadLabel.TabIndex = 23;
            this.SpreadLabel.Text = "Spread multiplier:";
            // 
            // ItemHealthLabel
            // 
            this.ItemHealthLabel.AutoSize = true;
            this.ItemHealthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemHealthLabel.Location = new System.Drawing.Point(6, 216);
            this.ItemHealthLabel.Name = "ItemHealthLabel";
            this.ItemHealthLabel.Size = new System.Drawing.Size(184, 20);
            this.ItemHealthLabel.TabIndex = 19;
            this.ItemHealthLabel.Text = "Barricade/vehicle Health:";
            // 
            // EngineLabel
            // 
            this.EngineLabel.AutoSize = true;
            this.EngineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EngineLabel.Location = new System.Drawing.Point(6, 196);
            this.EngineLabel.Name = "EngineLabel";
            this.EngineLabel.Size = new System.Drawing.Size(63, 20);
            this.EngineLabel.TabIndex = 21;
            this.EngineLabel.Text = "Engine:";
            // 
            // RangeLabel
            // 
            this.RangeLabel.AutoSize = true;
            this.RangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RangeLabel.Location = new System.Drawing.Point(6, 136);
            this.RangeLabel.Name = "RangeLabel";
            this.RangeLabel.Size = new System.Drawing.Size(61, 20);
            this.RangeLabel.TabIndex = 2;
            this.RangeLabel.Text = "Range:";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeLabel.Location = new System.Drawing.Point(6, 176);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(47, 20);
            this.TypeLabel.TabIndex = 3;
            this.TypeLabel.Text = "Type:";
            // 
            // BuildingsDamageLabel
            // 
            this.BuildingsDamageLabel.AutoSize = true;
            this.BuildingsDamageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuildingsDamageLabel.Location = new System.Drawing.Point(6, 116);
            this.BuildingsDamageLabel.Name = "BuildingsDamageLabel";
            this.BuildingsDamageLabel.Size = new System.Drawing.Size(158, 20);
            this.BuildingsDamageLabel.TabIndex = 6;
            this.BuildingsDamageLabel.Text = "Damage to buildings:";
            // 
            // FirerateLabel
            // 
            this.FirerateLabel.AutoSize = true;
            this.FirerateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirerateLabel.Location = new System.Drawing.Point(6, 376);
            this.FirerateLabel.Name = "FirerateLabel";
            this.FirerateLabel.Size = new System.Drawing.Size(68, 20);
            this.FirerateLabel.TabIndex = 10;
            this.FirerateLabel.Text = "Firerate:";
            // 
            // UseableLabel
            // 
            this.UseableLabel.AutoSize = true;
            this.UseableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UseableLabel.Location = new System.Drawing.Point(6, 156);
            this.UseableLabel.Name = "UseableLabel";
            this.UseableLabel.Size = new System.Drawing.Size(72, 20);
            this.UseableLabel.TabIndex = 7;
            this.UseableLabel.Text = "Useable:";
            // 
            // PlayerDamageLabel
            // 
            this.PlayerDamageLabel.AutoSize = true;
            this.PlayerDamageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerDamageLabel.Location = new System.Drawing.Point(6, 96);
            this.PlayerDamageLabel.Name = "PlayerDamageLabel";
            this.PlayerDamageLabel.Size = new System.Drawing.Size(121, 20);
            this.PlayerDamageLabel.TabIndex = 10;
            this.PlayerDamageLabel.Text = "Player Damage:";
            // 
            // BodyDamageLabel
            // 
            this.BodyDamageLabel.AutoSize = true;
            this.BodyDamageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BodyDamageLabel.Location = new System.Drawing.Point(6, 76);
            this.BodyDamageLabel.Name = "BodyDamageLabel";
            this.BodyDamageLabel.Size = new System.Drawing.Size(124, 20);
            this.BodyDamageLabel.TabIndex = 14;
            this.BodyDamageLabel.Text = "Damage (Body):";
            // 
            // HeadDamageLabel
            // 
            this.HeadDamageLabel.AutoSize = true;
            this.HeadDamageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeadDamageLabel.Location = new System.Drawing.Point(6, 56);
            this.HeadDamageLabel.Name = "HeadDamageLabel";
            this.HeadDamageLabel.Size = new System.Drawing.Size(127, 20);
            this.HeadDamageLabel.TabIndex = 15;
            this.HeadDamageLabel.Text = "Damage (Head):";
            // 
            // ProtectionLabel
            // 
            this.ProtectionLabel.AutoSize = true;
            this.ProtectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProtectionLabel.Location = new System.Drawing.Point(6, 36);
            this.ProtectionLabel.Name = "ProtectionLabel";
            this.ProtectionLabel.Size = new System.Drawing.Size(113, 20);
            this.ProtectionLabel.TabIndex = 16;
            this.ProtectionLabel.Text = "Protection (%):";
            // 
            // ItemCapacityLabel
            // 
            this.ItemCapacityLabel.AutoSize = true;
            this.ItemCapacityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemCapacityLabel.Location = new System.Drawing.Point(6, 16);
            this.ItemCapacityLabel.Name = "ItemCapacityLabel";
            this.ItemCapacityLabel.Size = new System.Drawing.Size(226, 20);
            this.ItemCapacityLabel.TabIndex = 17;
            this.ItemCapacityLabel.Text = "Barricade/cloth capacity (cells):";
            // 
            // item_capacity
            // 
            this.item_capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.item_capacity.Location = new System.Drawing.Point(245, 17);
            this.item_capacity.Name = "item_capacity";
            this.item_capacity.ReadOnly = true;
            this.item_capacity.Size = new System.Drawing.Size(79, 22);
            this.item_capacity.TabIndex = 12;
            this.item_capacity.TabStop = false;
            this.item_capacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SortDamagePlayersBtn
            // 
            this.SortDamagePlayersBtn.Location = new System.Drawing.Point(7, 134);
            this.SortDamagePlayersBtn.Name = "SortDamagePlayersBtn";
            this.SortDamagePlayersBtn.Size = new System.Drawing.Size(160, 23);
            this.SortDamagePlayersBtn.TabIndex = 4;
            this.SortDamagePlayersBtn.TabStop = false;
            this.SortDamagePlayersBtn.Text = "Damage to players";
            this.SortDamagePlayersBtn.UseVisualStyleBackColor = true;
            this.SortDamagePlayersBtn.Click += new System.EventHandler(this.SortDamagePlayersBtn_Click);
            // 
            // SortCapacityBtn
            // 
            this.SortCapacityBtn.Location = new System.Drawing.Point(7, 77);
            this.SortCapacityBtn.Name = "SortCapacityBtn";
            this.SortCapacityBtn.Size = new System.Drawing.Size(160, 23);
            this.SortCapacityBtn.TabIndex = 3;
            this.SortCapacityBtn.TabStop = false;
            this.SortCapacityBtn.Text = "Clothing capacity";
            this.SortCapacityBtn.UseVisualStyleBackColor = true;
            this.SortCapacityBtn.Click += new System.EventHandler(this.SortCapacityBtn_Click);
            // 
            // SortProtectionBtn
            // 
            this.SortProtectionBtn.Location = new System.Drawing.Point(7, 106);
            this.SortProtectionBtn.Name = "SortProtectionBtn";
            this.SortProtectionBtn.Size = new System.Drawing.Size(160, 23);
            this.SortProtectionBtn.TabIndex = 2;
            this.SortProtectionBtn.TabStop = false;
            this.SortProtectionBtn.Text = "Clothing protection";
            this.SortProtectionBtn.UseVisualStyleBackColor = true;
            this.SortProtectionBtn.Click += new System.EventHandler(this.SortProtectionBtn_Click);
            // 
            // SortByRangeBtn
            // 
            this.SortByRangeBtn.Location = new System.Drawing.Point(7, 571);
            this.SortByRangeBtn.Name = "SortByRangeBtn";
            this.SortByRangeBtn.Size = new System.Drawing.Size(160, 23);
            this.SortByRangeBtn.TabIndex = 18;
            this.SortByRangeBtn.TabStop = false;
            this.SortByRangeBtn.Text = "Range";
            this.SortByRangeBtn.UseVisualStyleBackColor = true;
            this.SortByRangeBtn.Click += new System.EventHandler(this.SortByRangeBtn_Click);
            // 
            // SortByFirerateBtn
            // 
            this.SortByFirerateBtn.Location = new System.Drawing.Point(7, 542);
            this.SortByFirerateBtn.Name = "SortByFirerateBtn";
            this.SortByFirerateBtn.Size = new System.Drawing.Size(160, 23);
            this.SortByFirerateBtn.TabIndex = 18;
            this.SortByFirerateBtn.TabStop = false;
            this.SortByFirerateBtn.Text = "Firerate";
            this.SortByFirerateBtn.UseVisualStyleBackColor = true;
            this.SortByFirerateBtn.Click += new System.EventHandler(this.SortByFirerateBtn_Click);
            // 
            // SortByRecoilYBtn
            // 
            this.SortByRecoilYBtn.Location = new System.Drawing.Point(7, 455);
            this.SortByRecoilYBtn.Name = "SortByRecoilYBtn";
            this.SortByRecoilYBtn.Size = new System.Drawing.Size(160, 23);
            this.SortByRecoilYBtn.TabIndex = 17;
            this.SortByRecoilYBtn.TabStop = false;
            this.SortByRecoilYBtn.Text = "Recoil Y";
            this.SortByRecoilYBtn.UseVisualStyleBackColor = true;
            this.SortByRecoilYBtn.Click += new System.EventHandler(this.SortByRecoilYBtn_Click);
            // 
            // SortByRecoilXBtn
            // 
            this.SortByRecoilXBtn.Location = new System.Drawing.Point(7, 426);
            this.SortByRecoilXBtn.Name = "SortByRecoilXBtn";
            this.SortByRecoilXBtn.Size = new System.Drawing.Size(160, 23);
            this.SortByRecoilXBtn.TabIndex = 16;
            this.SortByRecoilXBtn.TabStop = false;
            this.SortByRecoilXBtn.Text = "Recoil X";
            this.SortByRecoilXBtn.UseVisualStyleBackColor = true;
            this.SortByRecoilXBtn.Click += new System.EventHandler(this.SortByRecoilXBtn_Click);
            // 
            // SortByMSMBtn
            // 
            this.SortByMSMBtn.Location = new System.Drawing.Point(7, 513);
            this.SortByMSMBtn.Name = "SortByMSMBtn";
            this.SortByMSMBtn.Size = new System.Drawing.Size(160, 23);
            this.SortByMSMBtn.TabIndex = 15;
            this.SortByMSMBtn.TabStop = false;
            this.SortByMSMBtn.Text = "Movement speed (cloth)";
            this.SortByMSMBtn.UseVisualStyleBackColor = true;
            this.SortByMSMBtn.Click += new System.EventHandler(this.SortByMSMBtn_Click);
            // 
            // SortByEMSMBtn
            // 
            this.SortByEMSMBtn.Location = new System.Drawing.Point(7, 484);
            this.SortByEMSMBtn.Name = "SortByEMSMBtn";
            this.SortByEMSMBtn.Size = new System.Drawing.Size(160, 23);
            this.SortByEMSMBtn.TabIndex = 14;
            this.SortByEMSMBtn.TabStop = false;
            this.SortByEMSMBtn.Text = "Movement speed (items)";
            this.SortByEMSMBtn.UseVisualStyleBackColor = true;
            this.SortByEMSMBtn.Click += new System.EventHandler(this.SortByEMSMBtn_Click);
            // 
            // SortByPelletsBtn
            // 
            this.SortByPelletsBtn.Location = new System.Drawing.Point(7, 397);
            this.SortByPelletsBtn.Name = "SortByPelletsBtn";
            this.SortByPelletsBtn.Size = new System.Drawing.Size(160, 23);
            this.SortByPelletsBtn.TabIndex = 13;
            this.SortByPelletsBtn.TabStop = false;
            this.SortByPelletsBtn.Text = "Pellets";
            this.SortByPelletsBtn.UseVisualStyleBackColor = true;
            this.SortByPelletsBtn.Click += new System.EventHandler(this.SortByPelletsBtn_Click);
            // 
            // SortByAmmoAmountBtn
            // 
            this.SortByAmmoAmountBtn.Location = new System.Drawing.Point(7, 367);
            this.SortByAmmoAmountBtn.Name = "SortByAmmoAmountBtn";
            this.SortByAmmoAmountBtn.Size = new System.Drawing.Size(160, 23);
            this.SortByAmmoAmountBtn.TabIndex = 12;
            this.SortByAmmoAmountBtn.TabStop = false;
            this.SortByAmmoAmountBtn.Text = "Ammo amount";
            this.SortByAmmoAmountBtn.UseVisualStyleBackColor = true;
            this.SortByAmmoAmountBtn.Click += new System.EventHandler(this.SortByAmmoAmountBtn_Click);
            // 
            // SortByLabel
            // 
            this.SortByLabel.AutoSize = true;
            this.SortByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.SortByLabel.Location = new System.Drawing.Point(11, 15);
            this.SortByLabel.Name = "SortByLabel";
            this.SortByLabel.Size = new System.Drawing.Size(122, 30);
            this.SortByLabel.TabIndex = 11;
            this.SortByLabel.Text = "Sort by ...";
            // 
            // SortByBarrelDamageBtn
            // 
            this.SortByBarrelDamageBtn.Location = new System.Drawing.Point(7, 309);
            this.SortByBarrelDamageBtn.Name = "SortByBarrelDamageBtn";
            this.SortByBarrelDamageBtn.Size = new System.Drawing.Size(160, 23);
            this.SortByBarrelDamageBtn.TabIndex = 10;
            this.SortByBarrelDamageBtn.TabStop = false;
            this.SortByBarrelDamageBtn.Text = "Barrel damage";
            this.SortByBarrelDamageBtn.UseVisualStyleBackColor = true;
            this.SortByBarrelDamageBtn.Click += new System.EventHandler(this.SortByBarrelDamageBtn_Click);
            // 
            // SortByVolumeBtn
            // 
            this.SortByVolumeBtn.Location = new System.Drawing.Point(7, 338);
            this.SortByVolumeBtn.Name = "SortByVolumeBtn";
            this.SortByVolumeBtn.Size = new System.Drawing.Size(160, 23);
            this.SortByVolumeBtn.TabIndex = 9;
            this.SortByVolumeBtn.TabStop = false;
            this.SortByVolumeBtn.Text = "Barrel volume";
            this.SortByVolumeBtn.UseVisualStyleBackColor = true;
            this.SortByVolumeBtn.Click += new System.EventHandler(this.SortByVolumeBtn_Click);
            // 
            // SortBySpreadBtn
            // 
            this.SortBySpreadBtn.Location = new System.Drawing.Point(7, 279);
            this.SortBySpreadBtn.Name = "SortBySpreadBtn";
            this.SortBySpreadBtn.Size = new System.Drawing.Size(160, 23);
            this.SortBySpreadBtn.TabIndex = 8;
            this.SortBySpreadBtn.TabStop = false;
            this.SortBySpreadBtn.Text = "Spread";
            this.SortBySpreadBtn.UseVisualStyleBackColor = true;
            this.SortBySpreadBtn.Click += new System.EventHandler(this.SortBySpreadBtn_Click);
            // 
            // SortByBuildingHealthBtn
            // 
            this.SortByBuildingHealthBtn.Location = new System.Drawing.Point(7, 250);
            this.SortByBuildingHealthBtn.Name = "SortByBuildingHealthBtn";
            this.SortByBuildingHealthBtn.Size = new System.Drawing.Size(160, 23);
            this.SortByBuildingHealthBtn.TabIndex = 7;
            this.SortByBuildingHealthBtn.TabStop = false;
            this.SortByBuildingHealthBtn.Text = "Building health";
            this.SortByBuildingHealthBtn.UseVisualStyleBackColor = true;
            this.SortByBuildingHealthBtn.Click += new System.EventHandler(this.SortByBuildingHealthBtn_Click);
            // 
            // SortBarricadeCapacityBtn
            // 
            this.SortBarricadeCapacityBtn.Location = new System.Drawing.Point(7, 221);
            this.SortBarricadeCapacityBtn.Name = "SortBarricadeCapacityBtn";
            this.SortBarricadeCapacityBtn.Size = new System.Drawing.Size(160, 23);
            this.SortBarricadeCapacityBtn.TabIndex = 6;
            this.SortBarricadeCapacityBtn.TabStop = false;
            this.SortBarricadeCapacityBtn.Text = "Barricade capacity";
            this.SortBarricadeCapacityBtn.UseVisualStyleBackColor = true;
            this.SortBarricadeCapacityBtn.Click += new System.EventHandler(this.SortBarricadeCapacityBtn_Click);
            // 
            // SortVehicleHealthBtn
            // 
            this.SortVehicleHealthBtn.Location = new System.Drawing.Point(7, 192);
            this.SortVehicleHealthBtn.Name = "SortVehicleHealthBtn";
            this.SortVehicleHealthBtn.Size = new System.Drawing.Size(160, 23);
            this.SortVehicleHealthBtn.TabIndex = 5;
            this.SortVehicleHealthBtn.TabStop = false;
            this.SortVehicleHealthBtn.Text = "Vehicle health";
            this.SortVehicleHealthBtn.UseVisualStyleBackColor = true;
            this.SortVehicleHealthBtn.Click += new System.EventHandler(this.SortVehicleHealthBtn_Click);
            // 
            // SortDamageBuildingsBtn
            // 
            this.SortDamageBuildingsBtn.Location = new System.Drawing.Point(7, 163);
            this.SortDamageBuildingsBtn.Name = "SortDamageBuildingsBtn";
            this.SortDamageBuildingsBtn.Size = new System.Drawing.Size(160, 23);
            this.SortDamageBuildingsBtn.TabIndex = 0;
            this.SortDamageBuildingsBtn.TabStop = false;
            this.SortDamageBuildingsBtn.Text = "Damage to buildings";
            this.SortDamageBuildingsBtn.UseVisualStyleBackColor = true;
            this.SortDamageBuildingsBtn.Click += new System.EventHandler(this.SortDamageBuildingsBtn_Click);
            // 
            // MixBtn
            // 
            this.MixBtn.Location = new System.Drawing.Point(7, 48);
            this.MixBtn.Name = "MixBtn";
            this.MixBtn.Size = new System.Drawing.Size(160, 23);
            this.MixBtn.TabIndex = 1;
            this.MixBtn.TabStop = false;
            this.MixBtn.Text = "Mix";
            this.MixBtn.UseVisualStyleBackColor = true;
            this.MixBtn.Click += new System.EventHandler(this.MixBtn_Click);
            // 
            // ItemStatsLabel
            // 
            this.ItemStatsLabel.AutoSize = true;
            this.ItemStatsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ItemStatsLabel.Location = new System.Drawing.Point(192, 158);
            this.ItemStatsLabel.Name = "ItemStatsLabel";
            this.ItemStatsLabel.Size = new System.Drawing.Size(54, 13);
            this.ItemStatsLabel.TabIndex = 8;
            this.ItemStatsLabel.Text = "Item Stats";
            // 
            // SortingPanel
            // 
            this.SortingPanel.AutoScroll = true;
            this.SortingPanel.Controls.Add(this.SortByNameBtn);
            this.SortingPanel.Controls.Add(this.SortByIDBtn);
            this.SortingPanel.Controls.Add(this.SortByRangeBtn);
            this.SortingPanel.Controls.Add(this.SortByFirerateBtn);
            this.SortingPanel.Controls.Add(this.SortByRecoilYBtn);
            this.SortingPanel.Controls.Add(this.SortByRecoilXBtn);
            this.SortingPanel.Controls.Add(this.SortByMSMBtn);
            this.SortingPanel.Controls.Add(this.SortByEMSMBtn);
            this.SortingPanel.Controls.Add(this.SortByPelletsBtn);
            this.SortingPanel.Controls.Add(this.SortByAmmoAmountBtn);
            this.SortingPanel.Controls.Add(this.SortByLabel);
            this.SortingPanel.Controls.Add(this.SortByBarrelDamageBtn);
            this.SortingPanel.Controls.Add(this.SortByVolumeBtn);
            this.SortingPanel.Controls.Add(this.SortBySpreadBtn);
            this.SortingPanel.Controls.Add(this.SortByBuildingHealthBtn);
            this.SortingPanel.Controls.Add(this.SortBarricadeCapacityBtn);
            this.SortingPanel.Controls.Add(this.SortVehicleHealthBtn);
            this.SortingPanel.Controls.Add(this.SortDamageBuildingsBtn);
            this.SortingPanel.Controls.Add(this.MixBtn);
            this.SortingPanel.Controls.Add(this.SortProtectionBtn);
            this.SortingPanel.Controls.Add(this.SortCapacityBtn);
            this.SortingPanel.Controls.Add(this.SortDamagePlayersBtn);
            this.SortingPanel.Location = new System.Drawing.Point(536, 29);
            this.SortingPanel.Name = "SortingPanel";
            this.SortingPanel.Size = new System.Drawing.Size(191, 602);
            this.SortingPanel.TabIndex = 9;
            this.SortingPanel.Text = "Sorting";
            // 
            // SortByIDBtn
            // 
            this.SortByIDBtn.Location = new System.Drawing.Point(7, 600);
            this.SortByIDBtn.Name = "SortByIDBtn";
            this.SortByIDBtn.Size = new System.Drawing.Size(160, 23);
            this.SortByIDBtn.TabIndex = 19;
            this.SortByIDBtn.TabStop = false;
            this.SortByIDBtn.Text = "ID";
            this.SortByIDBtn.UseVisualStyleBackColor = true;
            this.SortByIDBtn.Click += new System.EventHandler(this.SortByIDBtn_Click);
            // 
            // SortByNameBtn
            // 
            this.SortByNameBtn.Location = new System.Drawing.Point(7, 629);
            this.SortByNameBtn.Name = "SortByNameBtn";
            this.SortByNameBtn.Size = new System.Drawing.Size(160, 23);
            this.SortByNameBtn.TabIndex = 20;
            this.SortByNameBtn.TabStop = false;
            this.SortByNameBtn.Text = "Name";
            this.SortByNameBtn.UseVisualStyleBackColor = true;
            this.SortByNameBtn.Click += new System.EventHandler(this.SortByNameBtn_Click);
            // 
            // ItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 635);
            this.Controls.Add(this.SortingPanel);
            this.Controls.Add(this.ItemStatsLabel);
            this.Controls.Add(this.InfoGroupBox);
            this.Controls.Add(this.ResultsListBox);
            this.Controls.Add(this.ResultsLabel);
            this.Controls.Add(this.ItemStatsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ItemList";
            this.Text = "Item List";
            this.InfoGroupBox.ResumeLayout(false);
            this.InfoGroupBox.PerformLayout();
            this.ItemStatsPanel.ResumeLayout(false);
            this.ItemStatsPanel.PerformLayout();
            this.SortingPanel.ResumeLayout(false);
            this.SortingPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ResultsLabel;
        private System.Windows.Forms.ListBox ResultsListBox;
        private System.Windows.Forms.GroupBox InfoGroupBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button IdToClipboard;
        private System.Windows.Forms.Button SortDamagePlayersBtn;
        private System.Windows.Forms.Button SortCapacityBtn;
        private System.Windows.Forms.Button SortProtectionBtn;
        private System.Windows.Forms.Button SortDamageBuildingsBtn;
        private System.Windows.Forms.Button SortVehicleHealthBtn;
        private System.Windows.Forms.Button SortBarricadeCapacityBtn;
        private System.Windows.Forms.Button SortByBuildingHealthBtn;
        private System.Windows.Forms.Button SortBySpreadBtn;
        private System.Windows.Forms.Button SortByVolumeBtn;
        private System.Windows.Forms.Button SortByBarrelDamageBtn;
        private System.Windows.Forms.TextBox IdPrefixTextBox;
        private System.Windows.Forms.Button AllNameIdToClipboard;
        private System.Windows.Forms.Button NameIdToClipboard;
        private System.Windows.Forms.Label SortByLabel;
        private System.Windows.Forms.Button SortByAmmoAmountBtn;
        private System.Windows.Forms.Button SortByPelletsBtn;
        private System.Windows.Forms.Button MixBtn;
        private System.Windows.Forms.Button SortByEMSMBtn;
        private System.Windows.Forms.Button SortByMSMBtn;
        private System.Windows.Forms.Button SortByRecoilYBtn;
        private System.Windows.Forms.Button SortByRecoilXBtn;
        private System.Windows.Forms.Button SortByRangeBtn;
        private System.Windows.Forms.Button SortByFirerateBtn;
        private System.Windows.Forms.Panel ItemStatsPanel;
        private System.Windows.Forms.TextBox item_capacity;
        private System.Windows.Forms.Label ItemCapacityLabel;
        private System.Windows.Forms.Label ProtectionLabel;
        private System.Windows.Forms.Label HeadDamageLabel;
        private System.Windows.Forms.Label BodyDamageLabel;
        private System.Windows.Forms.Label PlayerDamageLabel;
        private System.Windows.Forms.Label UseableLabel;
        private System.Windows.Forms.Label FirerateLabel;
        private System.Windows.Forms.Label BuildingsDamageLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label RangeLabel;
        private System.Windows.Forms.Label EngineLabel;
        private System.Windows.Forms.Label ItemHealthLabel;
        private System.Windows.Forms.Label SpreadLabel;
        private System.Windows.Forms.Label EMSMLabel;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.Label BarrelDamageLabel;
        private System.Windows.Forms.TextBox armor;
        private System.Windows.Forms.TextBox player_skull_damage;
        private System.Windows.Forms.TextBox player_spine_damage;
        private System.Windows.Forms.TextBox player_damage;
        private System.Windows.Forms.TextBox structure_damage;
        private System.Windows.Forms.TextBox range;
        private System.Windows.Forms.TextBox useable;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.TextBox engine;
        private System.Windows.Forms.TextBox health;
        private System.Windows.Forms.TextBox spread;
        private System.Windows.Forms.TextBox volume;
        private System.Windows.Forms.TextBox damage;
        private System.Windows.Forms.Label AmmoAmountLabel;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label LinkedAmmoLabel;
        private System.Windows.Forms.Label PelletsLabel;
        private System.Windows.Forms.TextBox pellets;
        private System.Windows.Forms.Button LinkedAmmoBtn;
        private System.Windows.Forms.Button LinkedModulesBtn;
        private System.Windows.Forms.Button LinkedGunsBtn;
        private System.Windows.Forms.Label Recoil_XYLabel;
        private System.Windows.Forms.TextBox recoil_x;
        private System.Windows.Forms.TextBox recoil_y;
        private System.Windows.Forms.TextBox equipable_movement_speed_multiplier;
        private System.Windows.Forms.TextBox movement_speed_multiplier;
        private System.Windows.Forms.TextBox firerate;
        private Label LinkedGunsLabel;
        private Label LinkedModulesLabel;
        private Label ItemStatsLabel;
        private Panel SortingPanel;
        private Button SortByIDBtn;
        private Button SortByNameBtn;
    }
}