using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TP_Tool_11._2
{
    public partial class SkillsEditor : Form, BaseArcadiaManager
    {
        public ArcadiaManager arcadia_manager { get; set; }
        public DataGridView base_datagrid { get; set; }
        public Button base_button_data_viewer { get; set; }
        public String base_select_query { get; set; }
        public String base_value_filter { get; set; }
        public Int32 base_format_type { get; set; }
        public XML base_xml_file { get; set; }

        public SkillsEditor()
        {
            InitializeComponent();

            base_datagrid = new DataGridView();
            base_button_data_viewer = bt_dataviewer;
            base_select_query = "SELECT dbo.SkillResource.id as skillResource_id,text_id,desc_id,tooltip_id,is_valid,dbo.SkillResource.elemental as skillResource_elemental,is_passive,is_physical_act,is_harmful,is_need_target,is_corpse,dbo.SkillResource.is_toggle as SkillResource_is_toggle,toggle_group,casting_type,casting_level,cast_range,valid_range,cost_hp,cost_hp_per_skl,cost_mp,cost_mp_per_skl,cost_mp_per_enhance,cost_hp_per,cost_hp_per_skl_per,cost_mp_per,cost_mp_per_skl_per,cost_havoc,cost_havoc_per_skl,cost_energy,cost_energy_per_skl,cost_exp,cost_exp_per_enhance,cost_jp,cost_jp_per_enhance,cost_item,cost_item_count,cost_item_count_per_skl,need_level,need_hp,need_mp,need_havoc,need_havoc_burst,need_state_id,need_state_level,need_state_exhaust,vf_one_hand_sword,vf_two_hand_sword,vf_double_sword,vf_dagger,vf_double_dagger,vf_spear,vf_axe,vf_one_hand_axe,vf_double_axe,vf_one_hand_mace,vf_two_hand_mace,vf_lightbow,vf_heavybow,vf_crossbow,vf_one_hand_staff,vf_two_hand_staff,vf_shield_only,vf_is_not_need_weapon,delay_cast,delay_cast_per_skl,delay_cast_mode_per_enhance,delay_common,delay_cooltime,delay_cooltime_per_skl,delay_cooltime_mode_per_enhance,cool_time_group_id,uf_self,uf_party,uf_guild,uf_neutral,uf_purple,uf_enemy,tf_avatar,tf_summon,tf_monster,skill_lvup_limit,target,effect_type,skill_enchant_link_id,state_id,state_level_base,state_level_per_skl,state_level_per_enhance,state_second,state_second_per_level,state_second_per_enhance,probability_on_hit,probability_inc_by_slv,hit_bonus,hit_bonus_per_enhance,percentage,hate_mod,hate_basic,hate_per_skl,hate_per_enhance,critical_bonus,critical_bonus_per_skl,var1,var2,var3,var4,var5,var6,var7,var8,var9,var10,var11,var12,var13,var14,var15,var16,var17,var18,var19,var20,icon_id,icon_file_name,is_projectile,projectile_speed,projectile_acceleration, skill_id,jp_01,jp_02,jp_03,jp_04,jp_05,jp_06,jp_07,jp_08,jp_09,jp_10,jp_11,jp_12,jp_13,jp_14,jp_15,jp_16,jp_17,jp_18,jp_19,jp_20,jp_21,jp_22,jp_23,jp_24,jp_25,jp_26,jp_27,jp_28,jp_29,jp_30,jp_31,jp_32,jp_33,jp_34,jp_35,jp_36,jp_37,jp_38,jp_39,jp_40,jp_41,jp_42,jp_43,jp_44,jp_45,jp_46,jp_47,jp_48,jp_49,jp_50, dbo.SkillStage.id as SkillStage_id,dbo.SkillStage.elemental as SkillStage_elemental,type,deal_damage,has_target,corpse_target,dbo.SkillStage.is_toggle as SkillStage_is_toggle,casting_time,is_creature_skill,stage_type_id,casting_type_id,casting_start_motion_id,casting_middle_motion_id,casting_fx_set_id,fire_motion_id,fire_fx_set_id,stage_data_01,stage_data_02,stage_data_03,stage_data_04,stage_data_05,stage_data_06,stage_data_07,stage_data_08,stage_data_09,stage_data_10,stage_data_11,stage_data_12,stage_data_13,stage_data_14,stage_data_15,stage_data_16,stage_data_17,stage_data_18,stage_data_19,stage_data_20,sub_stage_on_hit_id,sub_stage_on_hit_continuous,hit_fx_output_delay,hit_fx_set_id,hit_fx_set_position_id,fire_fx_output_delay,sub_fire_fx_set_id,sub_fire_fx_position, b1.name as name_1,b1.group_id as group_id_1,b1.code as code_1,b1.value as value_1, b2.name as name_2,b2.group_id as group_id_2,b2.code as code_2,b2.value as value_2 from dbo.SkillResource, dbo.SkillJPResource, dbo.SkillStage , dbo.StringResource b1, dbo.StringResource b2 WHERE dbo.SkillResource.text_id = b1.code and dbo.SkillResource.tooltip_id = b2.code and dbo.SkillResource.id=dbo.SkillJPResource.skill_id and dbo.SkillResource.id = dbo.SkillStage.id  order by dbo.SkillResource.id desc";
            base_format_type = 0;
            base_value_filter = "value LIKE '%{0}%'";
            arcadia_manager = new ArcadiaManager(this);
        }

        
    }
}
