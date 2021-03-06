-- Generated By protoc-gen-lua Do not Edit
local protobuf = require "protobuf/protobuf"

local EQUIP_T = protobuf.Descriptor();
local EQUIP_T_GUID_FIELD = protobuf.FieldDescriptor();
local EQUIP_T_PLAYER_GUID_FIELD = protobuf.FieldDescriptor();
local EQUIP_T_TEMPLATE_ID_FIELD = protobuf.FieldDescriptor();
local EQUIP_T_LEVEL_FIELD = protobuf.FieldDescriptor();
local EQUIP_T_ENCHANT_ID_FIELD = protobuf.FieldDescriptor();
local EQUIP_T_ENCHANT_VALUE_FIELD = protobuf.FieldDescriptor();
local EQUIP_T_ENCHANT_COUNT_FIELD = protobuf.FieldDescriptor();
local EQUIP_T_ATTR_FIELD = protobuf.FieldDescriptor();
local EQUIP_T_VALUE_FIELD = protobuf.FieldDescriptor();
local EQUIP_T_COLOR_FIELD = protobuf.FieldDescriptor();
local EQUIP_T_PERCENT_FIELD = protobuf.FieldDescriptor();
local EQUIP_T_ATTR_TYPES_FIELD = protobuf.FieldDescriptor();
local EQUIP_T_ATTR_IDS_FIELD = protobuf.FieldDescriptor();
local EQUIP_T_ATTR_VALUES_FIELD = protobuf.FieldDescriptor();
local EQUIP_T_ATTR_COLORS_FIELD = protobuf.FieldDescriptor();
local EQUIP_T_ATTR_PERS_FIELD = protobuf.FieldDescriptor();
local EQUIP_T_REFORGE_COUNT_FIELD = protobuf.FieldDescriptor();

EQUIP_T_GUID_FIELD.name = "guid"
EQUIP_T_GUID_FIELD.full_name = ".dhc.equip_t.guid"
EQUIP_T_GUID_FIELD.number = 1
EQUIP_T_GUID_FIELD.index = 0
EQUIP_T_GUID_FIELD.label = 1
EQUIP_T_GUID_FIELD.has_default_value = false
EQUIP_T_GUID_FIELD.default_value = 0
EQUIP_T_GUID_FIELD.type = 4
EQUIP_T_GUID_FIELD.cpp_type = 4

EQUIP_T_PLAYER_GUID_FIELD.name = "player_guid"
EQUIP_T_PLAYER_GUID_FIELD.full_name = ".dhc.equip_t.player_guid"
EQUIP_T_PLAYER_GUID_FIELD.number = 2
EQUIP_T_PLAYER_GUID_FIELD.index = 1
EQUIP_T_PLAYER_GUID_FIELD.label = 1
EQUIP_T_PLAYER_GUID_FIELD.has_default_value = false
EQUIP_T_PLAYER_GUID_FIELD.default_value = 0
EQUIP_T_PLAYER_GUID_FIELD.type = 4
EQUIP_T_PLAYER_GUID_FIELD.cpp_type = 4

EQUIP_T_TEMPLATE_ID_FIELD.name = "template_id"
EQUIP_T_TEMPLATE_ID_FIELD.full_name = ".dhc.equip_t.template_id"
EQUIP_T_TEMPLATE_ID_FIELD.number = 3
EQUIP_T_TEMPLATE_ID_FIELD.index = 2
EQUIP_T_TEMPLATE_ID_FIELD.label = 1
EQUIP_T_TEMPLATE_ID_FIELD.has_default_value = false
EQUIP_T_TEMPLATE_ID_FIELD.default_value = 0
EQUIP_T_TEMPLATE_ID_FIELD.type = 5
EQUIP_T_TEMPLATE_ID_FIELD.cpp_type = 1

EQUIP_T_LEVEL_FIELD.name = "level"
EQUIP_T_LEVEL_FIELD.full_name = ".dhc.equip_t.level"
EQUIP_T_LEVEL_FIELD.number = 4
EQUIP_T_LEVEL_FIELD.index = 3
EQUIP_T_LEVEL_FIELD.label = 1
EQUIP_T_LEVEL_FIELD.has_default_value = false
EQUIP_T_LEVEL_FIELD.default_value = 0
EQUIP_T_LEVEL_FIELD.type = 5
EQUIP_T_LEVEL_FIELD.cpp_type = 1

EQUIP_T_ENCHANT_ID_FIELD.name = "enchant_id"
EQUIP_T_ENCHANT_ID_FIELD.full_name = ".dhc.equip_t.enchant_id"
EQUIP_T_ENCHANT_ID_FIELD.number = 10
EQUIP_T_ENCHANT_ID_FIELD.index = 4
EQUIP_T_ENCHANT_ID_FIELD.label = 1
EQUIP_T_ENCHANT_ID_FIELD.has_default_value = false
EQUIP_T_ENCHANT_ID_FIELD.default_value = 0
EQUIP_T_ENCHANT_ID_FIELD.type = 5
EQUIP_T_ENCHANT_ID_FIELD.cpp_type = 1

EQUIP_T_ENCHANT_VALUE_FIELD.name = "enchant_value"
EQUIP_T_ENCHANT_VALUE_FIELD.full_name = ".dhc.equip_t.enchant_value"
EQUIP_T_ENCHANT_VALUE_FIELD.number = 11
EQUIP_T_ENCHANT_VALUE_FIELD.index = 5
EQUIP_T_ENCHANT_VALUE_FIELD.label = 1
EQUIP_T_ENCHANT_VALUE_FIELD.has_default_value = false
EQUIP_T_ENCHANT_VALUE_FIELD.default_value = 0
EQUIP_T_ENCHANT_VALUE_FIELD.type = 5
EQUIP_T_ENCHANT_VALUE_FIELD.cpp_type = 1

EQUIP_T_ENCHANT_COUNT_FIELD.name = "enchant_count"
EQUIP_T_ENCHANT_COUNT_FIELD.full_name = ".dhc.equip_t.enchant_count"
EQUIP_T_ENCHANT_COUNT_FIELD.number = 12
EQUIP_T_ENCHANT_COUNT_FIELD.index = 6
EQUIP_T_ENCHANT_COUNT_FIELD.label = 1
EQUIP_T_ENCHANT_COUNT_FIELD.has_default_value = false
EQUIP_T_ENCHANT_COUNT_FIELD.default_value = 0
EQUIP_T_ENCHANT_COUNT_FIELD.type = 5
EQUIP_T_ENCHANT_COUNT_FIELD.cpp_type = 1

EQUIP_T_ATTR_FIELD.name = "attr"
EQUIP_T_ATTR_FIELD.full_name = ".dhc.equip_t.attr"
EQUIP_T_ATTR_FIELD.number = 14
EQUIP_T_ATTR_FIELD.index = 7
EQUIP_T_ATTR_FIELD.label = 1
EQUIP_T_ATTR_FIELD.has_default_value = false
EQUIP_T_ATTR_FIELD.default_value = 0
EQUIP_T_ATTR_FIELD.type = 5
EQUIP_T_ATTR_FIELD.cpp_type = 1

EQUIP_T_VALUE_FIELD.name = "value"
EQUIP_T_VALUE_FIELD.full_name = ".dhc.equip_t.value"
EQUIP_T_VALUE_FIELD.number = 15
EQUIP_T_VALUE_FIELD.index = 8
EQUIP_T_VALUE_FIELD.label = 1
EQUIP_T_VALUE_FIELD.has_default_value = false
EQUIP_T_VALUE_FIELD.default_value = 0
EQUIP_T_VALUE_FIELD.type = 5
EQUIP_T_VALUE_FIELD.cpp_type = 1

EQUIP_T_COLOR_FIELD.name = "color"
EQUIP_T_COLOR_FIELD.full_name = ".dhc.equip_t.color"
EQUIP_T_COLOR_FIELD.number = 16
EQUIP_T_COLOR_FIELD.index = 9
EQUIP_T_COLOR_FIELD.label = 1
EQUIP_T_COLOR_FIELD.has_default_value = false
EQUIP_T_COLOR_FIELD.default_value = 0
EQUIP_T_COLOR_FIELD.type = 5
EQUIP_T_COLOR_FIELD.cpp_type = 1

EQUIP_T_PERCENT_FIELD.name = "percent"
EQUIP_T_PERCENT_FIELD.full_name = ".dhc.equip_t.percent"
EQUIP_T_PERCENT_FIELD.number = 17
EQUIP_T_PERCENT_FIELD.index = 10
EQUIP_T_PERCENT_FIELD.label = 1
EQUIP_T_PERCENT_FIELD.has_default_value = false
EQUIP_T_PERCENT_FIELD.default_value = 0
EQUIP_T_PERCENT_FIELD.type = 5
EQUIP_T_PERCENT_FIELD.cpp_type = 1

EQUIP_T_ATTR_TYPES_FIELD.name = "attr_types"
EQUIP_T_ATTR_TYPES_FIELD.full_name = ".dhc.equip_t.attr_types"
EQUIP_T_ATTR_TYPES_FIELD.number = 21
EQUIP_T_ATTR_TYPES_FIELD.index = 11
EQUIP_T_ATTR_TYPES_FIELD.label = 3
EQUIP_T_ATTR_TYPES_FIELD.has_default_value = false
EQUIP_T_ATTR_TYPES_FIELD.default_value = {}
EQUIP_T_ATTR_TYPES_FIELD.type = 5
EQUIP_T_ATTR_TYPES_FIELD.cpp_type = 1

EQUIP_T_ATTR_IDS_FIELD.name = "attr_ids"
EQUIP_T_ATTR_IDS_FIELD.full_name = ".dhc.equip_t.attr_ids"
EQUIP_T_ATTR_IDS_FIELD.number = 22
EQUIP_T_ATTR_IDS_FIELD.index = 12
EQUIP_T_ATTR_IDS_FIELD.label = 3
EQUIP_T_ATTR_IDS_FIELD.has_default_value = false
EQUIP_T_ATTR_IDS_FIELD.default_value = {}
EQUIP_T_ATTR_IDS_FIELD.type = 5
EQUIP_T_ATTR_IDS_FIELD.cpp_type = 1

EQUIP_T_ATTR_VALUES_FIELD.name = "attr_values"
EQUIP_T_ATTR_VALUES_FIELD.full_name = ".dhc.equip_t.attr_values"
EQUIP_T_ATTR_VALUES_FIELD.number = 23
EQUIP_T_ATTR_VALUES_FIELD.index = 13
EQUIP_T_ATTR_VALUES_FIELD.label = 3
EQUIP_T_ATTR_VALUES_FIELD.has_default_value = false
EQUIP_T_ATTR_VALUES_FIELD.default_value = {}
EQUIP_T_ATTR_VALUES_FIELD.type = 5
EQUIP_T_ATTR_VALUES_FIELD.cpp_type = 1

EQUIP_T_ATTR_COLORS_FIELD.name = "attr_colors"
EQUIP_T_ATTR_COLORS_FIELD.full_name = ".dhc.equip_t.attr_colors"
EQUIP_T_ATTR_COLORS_FIELD.number = 24
EQUIP_T_ATTR_COLORS_FIELD.index = 14
EQUIP_T_ATTR_COLORS_FIELD.label = 3
EQUIP_T_ATTR_COLORS_FIELD.has_default_value = false
EQUIP_T_ATTR_COLORS_FIELD.default_value = {}
EQUIP_T_ATTR_COLORS_FIELD.type = 5
EQUIP_T_ATTR_COLORS_FIELD.cpp_type = 1

EQUIP_T_ATTR_PERS_FIELD.name = "attr_pers"
EQUIP_T_ATTR_PERS_FIELD.full_name = ".dhc.equip_t.attr_pers"
EQUIP_T_ATTR_PERS_FIELD.number = 25
EQUIP_T_ATTR_PERS_FIELD.index = 15
EQUIP_T_ATTR_PERS_FIELD.label = 3
EQUIP_T_ATTR_PERS_FIELD.has_default_value = false
EQUIP_T_ATTR_PERS_FIELD.default_value = {}
EQUIP_T_ATTR_PERS_FIELD.type = 5
EQUIP_T_ATTR_PERS_FIELD.cpp_type = 1

EQUIP_T_REFORGE_COUNT_FIELD.name = "reforge_count"
EQUIP_T_REFORGE_COUNT_FIELD.full_name = ".dhc.equip_t.reforge_count"
EQUIP_T_REFORGE_COUNT_FIELD.number = 26
EQUIP_T_REFORGE_COUNT_FIELD.index = 16
EQUIP_T_REFORGE_COUNT_FIELD.label = 1
EQUIP_T_REFORGE_COUNT_FIELD.has_default_value = false
EQUIP_T_REFORGE_COUNT_FIELD.default_value = 0
EQUIP_T_REFORGE_COUNT_FIELD.type = 5
EQUIP_T_REFORGE_COUNT_FIELD.cpp_type = 1

EQUIP_T.name = "equip_t"
EQUIP_T.full_name = ".dhc.equip_t"
EQUIP_T.nested_types = {}
EQUIP_T.enum_types = {}
EQUIP_T.fields = {EQUIP_T_GUID_FIELD, EQUIP_T_PLAYER_GUID_FIELD, EQUIP_T_TEMPLATE_ID_FIELD, EQUIP_T_LEVEL_FIELD, EQUIP_T_ENCHANT_ID_FIELD, EQUIP_T_ENCHANT_VALUE_FIELD, EQUIP_T_ENCHANT_COUNT_FIELD, EQUIP_T_ATTR_FIELD, EQUIP_T_VALUE_FIELD, EQUIP_T_COLOR_FIELD, EQUIP_T_PERCENT_FIELD, EQUIP_T_ATTR_TYPES_FIELD, EQUIP_T_ATTR_IDS_FIELD, EQUIP_T_ATTR_VALUES_FIELD, EQUIP_T_ATTR_COLORS_FIELD, EQUIP_T_ATTR_PERS_FIELD, EQUIP_T_REFORGE_COUNT_FIELD}
EQUIP_T.is_extendable = false
EQUIP_T.extensions = {}

module('equip_db_pb')

equip_t = protobuf.Message(EQUIP_T)

