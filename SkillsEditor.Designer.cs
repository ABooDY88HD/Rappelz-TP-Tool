namespace TP_Tool_11._2
{
    partial class SkillsEditor
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
            this.bt_dataviewer = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gp_cost = new System.Windows.Forms.GroupBox();
            this.grp_needed_weapons = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tp_cost_item = new TP_Tool_11._2.Controls.ArcadiaManagers.AM_TextFromData();
            this.tp_cost_item_count_per_skl = new TP_Tool_11._2.Controls.ArcadiaManagers.AM_TextBox();
            this.tp_cost_item_count = new TP_Tool_11._2.Controls.ArcadiaManagers.AM_TextBox();
            this.tp_vf_is_not_need_weapon = new TP_Tool_11._2.Controls.ArcadiaManagers.AM_CheckBox();
            this.tp_vf_shield_only = new TP_Tool_11._2.Controls.ArcadiaManagers.AM_CheckBox();
            this.tp_vf_heavybow = new TP_Tool_11._2.Controls.ArcadiaManagers.AM_CheckBox();
            this.tp_vf_lightbow = new TP_Tool_11._2.Controls.ArcadiaManagers.AM_CheckBox();
            this.tp_vf_crossbow = new TP_Tool_11._2.Controls.ArcadiaManagers.AM_CheckBox();
            this.tp_vf_spear = new TP_Tool_11._2.Controls.ArcadiaManagers.AM_CheckBox();
            this.tp_vf_double_sword = new TP_Tool_11._2.Controls.ArcadiaManagers.AM_CheckBox();
            this.tp_vf_one_hand_axe = new TP_Tool_11._2.Controls.ArcadiaManagers.AM_CheckBox();
            this.tp_vf_double_axe = new TP_Tool_11._2.Controls.ArcadiaManagers.AM_CheckBox();
            this.tp_vf_axe = new TP_Tool_11._2.Controls.ArcadiaManagers.AM_CheckBox();
            this.tp_vf_double_dagger = new TP_Tool_11._2.Controls.ArcadiaManagers.AM_CheckBox();
            this.tp_vf_dagger = new TP_Tool_11._2.Controls.ArcadiaManagers.AM_CheckBox();
            this.tp_vf_two_hand_staff = new TP_Tool_11._2.Controls.ArcadiaManagers.AM_CheckBox();
            this.tp_vf_one_hand_staff = new TP_Tool_11._2.Controls.ArcadiaManagers.AM_CheckBox();
            this.tp_vf_two_hand_mace = new TP_Tool_11._2.Controls.ArcadiaManagers.AM_CheckBox();
            this.tp_vf_one_hand_mace = new TP_Tool_11._2.Controls.ArcadiaManagers.AM_CheckBox();
            this.tp_vf_two_hand_sword = new TP_Tool_11._2.Controls.ArcadiaManagers.AM_CheckBox();
            this.tp_vf_one_hand_sword = new TP_Tool_11._2.Controls.ArcadiaManagers.AM_CheckBox();
            this.tp_skillResource_id = new TP_Tool_11._2.Controls.ArcadiaManagers.AM_TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gp_cost.SuspendLayout();
            this.grp_needed_weapons.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_dataviewer
            // 
            this.bt_dataviewer.Font = new System.Drawing.Font("Tahoma", 12F);
            this.bt_dataviewer.Location = new System.Drawing.Point(6, 405);
            this.bt_dataviewer.Name = "bt_dataviewer";
            this.bt_dataviewer.Size = new System.Drawing.Size(116, 30);
            this.bt_dataviewer.TabIndex = 0;
            this.bt_dataviewer.Text = "View Data";
            this.bt_dataviewer.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(855, 464);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gp_cost);
            this.tabPage1.Controls.Add(this.grp_needed_weapons);
            this.tabPage1.Controls.Add(this.tp_skillResource_id);
            this.tabPage1.Controls.Add(this.bt_dataviewer);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(847, 438);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gp_cost
            // 
            this.gp_cost.Controls.Add(this.tp_cost_item);
            this.gp_cost.Controls.Add(this.tp_cost_item_count_per_skl);
            this.gp_cost.Controls.Add(this.tp_cost_item_count);
            this.gp_cost.Location = new System.Drawing.Point(301, 6);
            this.gp_cost.Name = "gp_cost";
            this.gp_cost.Size = new System.Drawing.Size(317, 393);
            this.gp_cost.TabIndex = 18;
            this.gp_cost.TabStop = false;
            this.gp_cost.Text = "Cost";
            // 
            // grp_needed_weapons
            // 
            this.grp_needed_weapons.Controls.Add(this.tp_vf_is_not_need_weapon);
            this.grp_needed_weapons.Controls.Add(this.tp_vf_shield_only);
            this.grp_needed_weapons.Controls.Add(this.tp_vf_heavybow);
            this.grp_needed_weapons.Controls.Add(this.tp_vf_lightbow);
            this.grp_needed_weapons.Controls.Add(this.tp_vf_crossbow);
            this.grp_needed_weapons.Controls.Add(this.tp_vf_spear);
            this.grp_needed_weapons.Controls.Add(this.tp_vf_double_sword);
            this.grp_needed_weapons.Controls.Add(this.tp_vf_one_hand_axe);
            this.grp_needed_weapons.Controls.Add(this.tp_vf_double_axe);
            this.grp_needed_weapons.Controls.Add(this.tp_vf_axe);
            this.grp_needed_weapons.Controls.Add(this.tp_vf_double_dagger);
            this.grp_needed_weapons.Controls.Add(this.tp_vf_dagger);
            this.grp_needed_weapons.Controls.Add(this.tp_vf_two_hand_staff);
            this.grp_needed_weapons.Controls.Add(this.tp_vf_one_hand_staff);
            this.grp_needed_weapons.Controls.Add(this.tp_vf_two_hand_mace);
            this.grp_needed_weapons.Controls.Add(this.tp_vf_one_hand_mace);
            this.grp_needed_weapons.Controls.Add(this.tp_vf_two_hand_sword);
            this.grp_needed_weapons.Controls.Add(this.tp_vf_one_hand_sword);
            this.grp_needed_weapons.Location = new System.Drawing.Point(8, 69);
            this.grp_needed_weapons.Name = "grp_needed_weapons";
            this.grp_needed_weapons.Size = new System.Drawing.Size(287, 330);
            this.grp_needed_weapons.TabIndex = 2;
            this.grp_needed_weapons.TabStop = false;
            this.grp_needed_weapons.Text = "Needed Weapons";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(847, 438);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(847, 438);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tp_cost_item
            // 
            this.tp_cost_item.DefaultFilter = null;
            this.tp_cost_item.hasIcon = false;
            this.tp_cost_item.Location = new System.Drawing.Point(6, 19);
            this.tp_cost_item.Name = "tp_cost_item";
            this.tp_cost_item.SelectQuery = null;
            this.tp_cost_item.Size = new System.Drawing.Size(303, 27);
            this.tp_cost_item.TabIndex = 21;
            this.tp_cost_item.TextLabel = "Item";
            this.tp_cost_item.TextTooltip = "";
            // 
            // tp_cost_item_count_per_skl
            // 
            this.tp_cost_item_count_per_skl.Location = new System.Drawing.Point(164, 52);
            this.tp_cost_item_count_per_skl.Name = "tp_cost_item_count_per_skl";
            this.tp_cost_item_count_per_skl.Size = new System.Drawing.Size(145, 27);
            this.tp_cost_item_count_per_skl.TabIndex = 20;
            this.tp_cost_item_count_per_skl.TextLabel = "++ per lvl";
            this.tp_cost_item_count_per_skl.TextTooltip = "";
            // 
            // tp_cost_item_count
            // 
            this.tp_cost_item_count.Location = new System.Drawing.Point(6, 52);
            this.tp_cost_item_count.Name = "tp_cost_item_count";
            this.tp_cost_item_count.Size = new System.Drawing.Size(152, 27);
            this.tp_cost_item_count.TabIndex = 19;
            this.tp_cost_item_count.TextLabel = "item count";
            this.tp_cost_item_count.TextTooltip = "";
            // 
            // tp_vf_is_not_need_weapon
            // 
            this.tp_vf_is_not_need_weapon.Checked = false;
            this.tp_vf_is_not_need_weapon.Location = new System.Drawing.Point(150, 283);
            this.tp_vf_is_not_need_weapon.Name = "tp_vf_is_not_need_weapon";
            this.tp_vf_is_not_need_weapon.Size = new System.Drawing.Size(131, 27);
            this.tp_vf_is_not_need_weapon.TabIndex = 17;
            this.tp_vf_is_not_need_weapon.TextLabel = "any_weapon";
            this.tp_vf_is_not_need_weapon.TextTooltip = "";
            // 
            // tp_vf_shield_only
            // 
            this.tp_vf_shield_only.Checked = false;
            this.tp_vf_shield_only.Location = new System.Drawing.Point(6, 283);
            this.tp_vf_shield_only.Name = "tp_vf_shield_only";
            this.tp_vf_shield_only.Size = new System.Drawing.Size(131, 27);
            this.tp_vf_shield_only.TabIndex = 16;
            this.tp_vf_shield_only.TextLabel = "shield";
            this.tp_vf_shield_only.TextTooltip = "";
            // 
            // tp_vf_heavybow
            // 
            this.tp_vf_heavybow.Checked = false;
            this.tp_vf_heavybow.Location = new System.Drawing.Point(150, 250);
            this.tp_vf_heavybow.Name = "tp_vf_heavybow";
            this.tp_vf_heavybow.Size = new System.Drawing.Size(131, 27);
            this.tp_vf_heavybow.TabIndex = 15;
            this.tp_vf_heavybow.TextLabel = "heavybow";
            this.tp_vf_heavybow.TextTooltip = "";
            // 
            // tp_vf_lightbow
            // 
            this.tp_vf_lightbow.Checked = false;
            this.tp_vf_lightbow.Location = new System.Drawing.Point(6, 250);
            this.tp_vf_lightbow.Name = "tp_vf_lightbow";
            this.tp_vf_lightbow.Size = new System.Drawing.Size(131, 27);
            this.tp_vf_lightbow.TabIndex = 14;
            this.tp_vf_lightbow.TextLabel = "lightbow";
            this.tp_vf_lightbow.TextTooltip = "";
            // 
            // tp_vf_crossbow
            // 
            this.tp_vf_crossbow.Checked = false;
            this.tp_vf_crossbow.Location = new System.Drawing.Point(150, 217);
            this.tp_vf_crossbow.Name = "tp_vf_crossbow";
            this.tp_vf_crossbow.Size = new System.Drawing.Size(131, 27);
            this.tp_vf_crossbow.TabIndex = 13;
            this.tp_vf_crossbow.TextLabel = "crossbow";
            this.tp_vf_crossbow.TextTooltip = "";
            // 
            // tp_vf_spear
            // 
            this.tp_vf_spear.Checked = false;
            this.tp_vf_spear.Location = new System.Drawing.Point(6, 217);
            this.tp_vf_spear.Name = "tp_vf_spear";
            this.tp_vf_spear.Size = new System.Drawing.Size(131, 27);
            this.tp_vf_spear.TabIndex = 12;
            this.tp_vf_spear.TextLabel = "spear";
            this.tp_vf_spear.TextTooltip = "";
            // 
            // tp_vf_double_sword
            // 
            this.tp_vf_double_sword.Checked = false;
            this.tp_vf_double_sword.Location = new System.Drawing.Point(6, 151);
            this.tp_vf_double_sword.Name = "tp_vf_double_sword";
            this.tp_vf_double_sword.Size = new System.Drawing.Size(131, 27);
            this.tp_vf_double_sword.TabIndex = 11;
            this.tp_vf_double_sword.TextLabel = "double sword";
            this.tp_vf_double_sword.TextTooltip = "";
            // 
            // tp_vf_one_hand_axe
            // 
            this.tp_vf_one_hand_axe.Checked = false;
            this.tp_vf_one_hand_axe.Location = new System.Drawing.Point(6, 118);
            this.tp_vf_one_hand_axe.Name = "tp_vf_one_hand_axe";
            this.tp_vf_one_hand_axe.Size = new System.Drawing.Size(131, 27);
            this.tp_vf_one_hand_axe.TabIndex = 10;
            this.tp_vf_one_hand_axe.TextLabel = "1h axe";
            this.tp_vf_one_hand_axe.TextTooltip = "";
            // 
            // tp_vf_double_axe
            // 
            this.tp_vf_double_axe.Checked = false;
            this.tp_vf_double_axe.Location = new System.Drawing.Point(150, 151);
            this.tp_vf_double_axe.Name = "tp_vf_double_axe";
            this.tp_vf_double_axe.Size = new System.Drawing.Size(131, 27);
            this.tp_vf_double_axe.TabIndex = 9;
            this.tp_vf_double_axe.TextLabel = "double axe";
            this.tp_vf_double_axe.TextTooltip = "";
            // 
            // tp_vf_axe
            // 
            this.tp_vf_axe.Checked = false;
            this.tp_vf_axe.Location = new System.Drawing.Point(150, 118);
            this.tp_vf_axe.Name = "tp_vf_axe";
            this.tp_vf_axe.Size = new System.Drawing.Size(131, 27);
            this.tp_vf_axe.TabIndex = 8;
            this.tp_vf_axe.TextLabel = "2h axe";
            this.tp_vf_axe.TextTooltip = "";
            // 
            // tp_vf_double_dagger
            // 
            this.tp_vf_double_dagger.Checked = false;
            this.tp_vf_double_dagger.Location = new System.Drawing.Point(150, 184);
            this.tp_vf_double_dagger.Name = "tp_vf_double_dagger";
            this.tp_vf_double_dagger.Size = new System.Drawing.Size(131, 27);
            this.tp_vf_double_dagger.TabIndex = 7;
            this.tp_vf_double_dagger.TextLabel = "double dagger";
            this.tp_vf_double_dagger.TextTooltip = "";
            // 
            // tp_vf_dagger
            // 
            this.tp_vf_dagger.Checked = false;
            this.tp_vf_dagger.Location = new System.Drawing.Point(6, 184);
            this.tp_vf_dagger.Name = "tp_vf_dagger";
            this.tp_vf_dagger.Size = new System.Drawing.Size(131, 27);
            this.tp_vf_dagger.TabIndex = 6;
            this.tp_vf_dagger.TextLabel = "dagger";
            this.tp_vf_dagger.TextTooltip = "";
            // 
            // tp_vf_two_hand_staff
            // 
            this.tp_vf_two_hand_staff.Checked = false;
            this.tp_vf_two_hand_staff.Location = new System.Drawing.Point(150, 85);
            this.tp_vf_two_hand_staff.Name = "tp_vf_two_hand_staff";
            this.tp_vf_two_hand_staff.Size = new System.Drawing.Size(131, 27);
            this.tp_vf_two_hand_staff.TabIndex = 5;
            this.tp_vf_two_hand_staff.TextLabel = "2h staff";
            this.tp_vf_two_hand_staff.TextTooltip = "";
            // 
            // tp_vf_one_hand_staff
            // 
            this.tp_vf_one_hand_staff.Checked = false;
            this.tp_vf_one_hand_staff.Location = new System.Drawing.Point(6, 85);
            this.tp_vf_one_hand_staff.Name = "tp_vf_one_hand_staff";
            this.tp_vf_one_hand_staff.Size = new System.Drawing.Size(131, 27);
            this.tp_vf_one_hand_staff.TabIndex = 4;
            this.tp_vf_one_hand_staff.TextLabel = "1h staff";
            this.tp_vf_one_hand_staff.TextTooltip = "";
            // 
            // tp_vf_two_hand_mace
            // 
            this.tp_vf_two_hand_mace.Checked = false;
            this.tp_vf_two_hand_mace.Location = new System.Drawing.Point(150, 52);
            this.tp_vf_two_hand_mace.Name = "tp_vf_two_hand_mace";
            this.tp_vf_two_hand_mace.Size = new System.Drawing.Size(131, 27);
            this.tp_vf_two_hand_mace.TabIndex = 3;
            this.tp_vf_two_hand_mace.TextLabel = "2h mace";
            this.tp_vf_two_hand_mace.TextTooltip = "";
            // 
            // tp_vf_one_hand_mace
            // 
            this.tp_vf_one_hand_mace.Checked = false;
            this.tp_vf_one_hand_mace.Location = new System.Drawing.Point(6, 52);
            this.tp_vf_one_hand_mace.Name = "tp_vf_one_hand_mace";
            this.tp_vf_one_hand_mace.Size = new System.Drawing.Size(131, 27);
            this.tp_vf_one_hand_mace.TabIndex = 2;
            this.tp_vf_one_hand_mace.TextLabel = "1h mace";
            this.tp_vf_one_hand_mace.TextTooltip = "";
            // 
            // tp_vf_two_hand_sword
            // 
            this.tp_vf_two_hand_sword.Checked = false;
            this.tp_vf_two_hand_sword.Location = new System.Drawing.Point(150, 19);
            this.tp_vf_two_hand_sword.Name = "tp_vf_two_hand_sword";
            this.tp_vf_two_hand_sword.Size = new System.Drawing.Size(131, 27);
            this.tp_vf_two_hand_sword.TabIndex = 1;
            this.tp_vf_two_hand_sword.TextLabel = "2h sword";
            this.tp_vf_two_hand_sword.TextTooltip = "";
            // 
            // tp_vf_one_hand_sword
            // 
            this.tp_vf_one_hand_sword.Checked = false;
            this.tp_vf_one_hand_sword.Location = new System.Drawing.Point(6, 19);
            this.tp_vf_one_hand_sword.Name = "tp_vf_one_hand_sword";
            this.tp_vf_one_hand_sword.Size = new System.Drawing.Size(131, 27);
            this.tp_vf_one_hand_sword.TabIndex = 0;
            this.tp_vf_one_hand_sword.TextLabel = "1h sword";
            this.tp_vf_one_hand_sword.TextTooltip = "";
            // 
            // tp_skillResource_id
            // 
            this.tp_skillResource_id.Location = new System.Drawing.Point(8, 6);
            this.tp_skillResource_id.Name = "tp_skillResource_id";
            this.tp_skillResource_id.Size = new System.Drawing.Size(221, 27);
            this.tp_skillResource_id.TabIndex = 1;
            this.tp_skillResource_id.TextLabel = "id";
            this.tp_skillResource_id.TextTooltip = "";
            // 
            // SkillsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 460);
            this.Controls.Add(this.tabControl1);
            this.Name = "SkillsEditor";
            this.Text = "SkillsEditor";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gp_cost.ResumeLayout(false);
            this.grp_needed_weapons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_dataviewer;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Controls.ArcadiaManagers.AM_TextBox tp_skillResource_id;
        private System.Windows.Forms.GroupBox grp_needed_weapons;
        private System.Windows.Forms.TabPage tabPage3;
        private Controls.ArcadiaManagers.AM_CheckBox tp_vf_one_hand_sword;
        private Controls.ArcadiaManagers.AM_CheckBox tp_vf_two_hand_mace;
        private Controls.ArcadiaManagers.AM_CheckBox tp_vf_one_hand_mace;
        private Controls.ArcadiaManagers.AM_CheckBox tp_vf_two_hand_sword;
        private Controls.ArcadiaManagers.AM_CheckBox tp_vf_is_not_need_weapon;
        private Controls.ArcadiaManagers.AM_CheckBox tp_vf_shield_only;
        private Controls.ArcadiaManagers.AM_CheckBox tp_vf_heavybow;
        private Controls.ArcadiaManagers.AM_CheckBox tp_vf_lightbow;
        private Controls.ArcadiaManagers.AM_CheckBox tp_vf_crossbow;
        private Controls.ArcadiaManagers.AM_CheckBox tp_vf_spear;
        private Controls.ArcadiaManagers.AM_CheckBox tp_vf_double_sword;
        private Controls.ArcadiaManagers.AM_CheckBox tp_vf_one_hand_axe;
        private Controls.ArcadiaManagers.AM_CheckBox tp_vf_double_axe;
        private Controls.ArcadiaManagers.AM_CheckBox tp_vf_axe;
        private Controls.ArcadiaManagers.AM_CheckBox tp_vf_double_dagger;
        private Controls.ArcadiaManagers.AM_CheckBox tp_vf_dagger;
        private Controls.ArcadiaManagers.AM_CheckBox tp_vf_two_hand_staff;
        private Controls.ArcadiaManagers.AM_CheckBox tp_vf_one_hand_staff;
        private System.Windows.Forms.GroupBox gp_cost;
        private Controls.ArcadiaManagers.AM_TextBox tp_cost_item_count_per_skl;
        private Controls.ArcadiaManagers.AM_TextBox tp_cost_item_count;
        private Controls.ArcadiaManagers.AM_TextFromData tp_cost_item;
    }
}