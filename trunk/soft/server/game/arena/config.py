from pgame.utils.config_base import ConfigBase


class Config(ConfigBase):
    def load_config(self):
        self.load('t_arena_reward')
        self.load('t_artifact')
        self.load('t_attr')
        self.load('t_avatar')
        self.load('t_class')
        self.load('t_color')
        self.load('t_const')
        self.load('t_daily')
        self.load('t_daily_reward')
        self.load('t_drop')
        self.load('t_dungeon')
        self.load('t_dungeon_event')
        self.load('t_dungeon_random')
        self.load('t_equip')
        self.load('t_equip_color')
        self.load('t_equip_discompose')
        self.load('t_equip_draw')
        self.load('t_equip_enchant')
        self.load('t_equip_enhance')
        self.load('t_equip_random')
        self.load('t_equip_random_num')
        self.load('t_equip_random_rate')
        self.load('t_equip_random_value')
        self.load('t_error')
        self.load('t_forge')
        self.load('t_item')
        self.load('t_lang_director')
        self.load('t_level')
        self.load('t_level_punish')
        self.load('t_map')
        self.load('t_map_build')
        self.load('t_map_port')
        self.load('t_mission')
        self.load('t_mission_mine')
        self.load('t_mission_random')
        self.load('t_monster')
        self.load('t_name')
        self.load('t_npc')
        self.load('t_pet')
        self.load('t_pet_draw')
        self.load('t_pet_enhance')
        self.load('t_pet_talent')
        self.load('t_price')
        self.load('t_quest')
        self.load('t_quest_sub')
        self.load('t_recharge')
        self.load('t_resource')
        self.load('t_role')
        self.load('t_role_reputation')
        self.load('t_rune')
        self.load('t_rune_draw')
        self.load('t_rune_num')
        self.load('t_shop')
        self.load('t_sign')
        self.load('t_spell')
        self.load('t_spell_buff')
        self.load('t_spell_level')
        self.load('t_spell_passive')
        self.load('t_tower')
        self.load('t_unlock')
