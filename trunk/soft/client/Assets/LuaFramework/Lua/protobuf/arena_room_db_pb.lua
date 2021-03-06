-- Generated By protoc-gen-lua Do not Edit
local protobuf = require "protobuf/protobuf"

local ARENA_ROOM_T = protobuf.Descriptor();
local ARENA_ROOM_T_GUID_FIELD = protobuf.FieldDescriptor();
local ARENA_ROOM_T_PLAYER_GUIDS_FIELD = protobuf.FieldDescriptor();
local ARENA_ROOM_T_PLAYER_NAMES_FIELD = protobuf.FieldDescriptor();
local ARENA_ROOM_T_PLAYER_LEVELS_FIELD = protobuf.FieldDescriptor();
local ARENA_ROOM_T_PLAYER_ICONS_FIELD = protobuf.FieldDescriptor();
local ARENA_ROOM_T_PLAYER_INTEGRALS_FIELD = protobuf.FieldDescriptor();
local ARENA_ROOM_T_IS_NPC_FIELD = protobuf.FieldDescriptor();
local ARENA_ROOM_T_PLAYER_POWERS_FIELD = protobuf.FieldDescriptor();
local ARENA_ROOM_T_ARENA_WINS_FIELD = protobuf.FieldDescriptor();
local ARENA_ROOM_T_ARENA_NUMS_FIELD = protobuf.FieldDescriptor();
local ARENA_ROOM_T_ARENA_LIST_INDEXES_FIELD = protobuf.FieldDescriptor();
local ARENA_ROOM_T_SEGMENT_FIELD = protobuf.FieldDescriptor();
local ARENA_ROOM_T_LAST_TIME_FIELD = protobuf.FieldDescriptor();

ARENA_ROOM_T_GUID_FIELD.name = "guid"
ARENA_ROOM_T_GUID_FIELD.full_name = ".dhc.arena_room_t.guid"
ARENA_ROOM_T_GUID_FIELD.number = 1
ARENA_ROOM_T_GUID_FIELD.index = 0
ARENA_ROOM_T_GUID_FIELD.label = 1
ARENA_ROOM_T_GUID_FIELD.has_default_value = false
ARENA_ROOM_T_GUID_FIELD.default_value = 0
ARENA_ROOM_T_GUID_FIELD.type = 4
ARENA_ROOM_T_GUID_FIELD.cpp_type = 4

ARENA_ROOM_T_PLAYER_GUIDS_FIELD.name = "player_guids"
ARENA_ROOM_T_PLAYER_GUIDS_FIELD.full_name = ".dhc.arena_room_t.player_guids"
ARENA_ROOM_T_PLAYER_GUIDS_FIELD.number = 2
ARENA_ROOM_T_PLAYER_GUIDS_FIELD.index = 1
ARENA_ROOM_T_PLAYER_GUIDS_FIELD.label = 3
ARENA_ROOM_T_PLAYER_GUIDS_FIELD.has_default_value = false
ARENA_ROOM_T_PLAYER_GUIDS_FIELD.default_value = {}
ARENA_ROOM_T_PLAYER_GUIDS_FIELD.type = 4
ARENA_ROOM_T_PLAYER_GUIDS_FIELD.cpp_type = 4

ARENA_ROOM_T_PLAYER_NAMES_FIELD.name = "player_names"
ARENA_ROOM_T_PLAYER_NAMES_FIELD.full_name = ".dhc.arena_room_t.player_names"
ARENA_ROOM_T_PLAYER_NAMES_FIELD.number = 3
ARENA_ROOM_T_PLAYER_NAMES_FIELD.index = 2
ARENA_ROOM_T_PLAYER_NAMES_FIELD.label = 3
ARENA_ROOM_T_PLAYER_NAMES_FIELD.has_default_value = false
ARENA_ROOM_T_PLAYER_NAMES_FIELD.default_value = {}
ARENA_ROOM_T_PLAYER_NAMES_FIELD.type = 9
ARENA_ROOM_T_PLAYER_NAMES_FIELD.cpp_type = 9

ARENA_ROOM_T_PLAYER_LEVELS_FIELD.name = "player_levels"
ARENA_ROOM_T_PLAYER_LEVELS_FIELD.full_name = ".dhc.arena_room_t.player_levels"
ARENA_ROOM_T_PLAYER_LEVELS_FIELD.number = 4
ARENA_ROOM_T_PLAYER_LEVELS_FIELD.index = 3
ARENA_ROOM_T_PLAYER_LEVELS_FIELD.label = 3
ARENA_ROOM_T_PLAYER_LEVELS_FIELD.has_default_value = false
ARENA_ROOM_T_PLAYER_LEVELS_FIELD.default_value = {}
ARENA_ROOM_T_PLAYER_LEVELS_FIELD.type = 5
ARENA_ROOM_T_PLAYER_LEVELS_FIELD.cpp_type = 1

ARENA_ROOM_T_PLAYER_ICONS_FIELD.name = "player_icons"
ARENA_ROOM_T_PLAYER_ICONS_FIELD.full_name = ".dhc.arena_room_t.player_icons"
ARENA_ROOM_T_PLAYER_ICONS_FIELD.number = 5
ARENA_ROOM_T_PLAYER_ICONS_FIELD.index = 4
ARENA_ROOM_T_PLAYER_ICONS_FIELD.label = 3
ARENA_ROOM_T_PLAYER_ICONS_FIELD.has_default_value = false
ARENA_ROOM_T_PLAYER_ICONS_FIELD.default_value = {}
ARENA_ROOM_T_PLAYER_ICONS_FIELD.type = 5
ARENA_ROOM_T_PLAYER_ICONS_FIELD.cpp_type = 1

ARENA_ROOM_T_PLAYER_INTEGRALS_FIELD.name = "player_integrals"
ARENA_ROOM_T_PLAYER_INTEGRALS_FIELD.full_name = ".dhc.arena_room_t.player_integrals"
ARENA_ROOM_T_PLAYER_INTEGRALS_FIELD.number = 6
ARENA_ROOM_T_PLAYER_INTEGRALS_FIELD.index = 5
ARENA_ROOM_T_PLAYER_INTEGRALS_FIELD.label = 3
ARENA_ROOM_T_PLAYER_INTEGRALS_FIELD.has_default_value = false
ARENA_ROOM_T_PLAYER_INTEGRALS_FIELD.default_value = {}
ARENA_ROOM_T_PLAYER_INTEGRALS_FIELD.type = 5
ARENA_ROOM_T_PLAYER_INTEGRALS_FIELD.cpp_type = 1

ARENA_ROOM_T_IS_NPC_FIELD.name = "is_npc"
ARENA_ROOM_T_IS_NPC_FIELD.full_name = ".dhc.arena_room_t.is_npc"
ARENA_ROOM_T_IS_NPC_FIELD.number = 7
ARENA_ROOM_T_IS_NPC_FIELD.index = 6
ARENA_ROOM_T_IS_NPC_FIELD.label = 3
ARENA_ROOM_T_IS_NPC_FIELD.has_default_value = false
ARENA_ROOM_T_IS_NPC_FIELD.default_value = {}
ARENA_ROOM_T_IS_NPC_FIELD.type = 5
ARENA_ROOM_T_IS_NPC_FIELD.cpp_type = 1

ARENA_ROOM_T_PLAYER_POWERS_FIELD.name = "player_powers"
ARENA_ROOM_T_PLAYER_POWERS_FIELD.full_name = ".dhc.arena_room_t.player_powers"
ARENA_ROOM_T_PLAYER_POWERS_FIELD.number = 8
ARENA_ROOM_T_PLAYER_POWERS_FIELD.index = 7
ARENA_ROOM_T_PLAYER_POWERS_FIELD.label = 3
ARENA_ROOM_T_PLAYER_POWERS_FIELD.has_default_value = false
ARENA_ROOM_T_PLAYER_POWERS_FIELD.default_value = {}
ARENA_ROOM_T_PLAYER_POWERS_FIELD.type = 5
ARENA_ROOM_T_PLAYER_POWERS_FIELD.cpp_type = 1

ARENA_ROOM_T_ARENA_WINS_FIELD.name = "arena_wins"
ARENA_ROOM_T_ARENA_WINS_FIELD.full_name = ".dhc.arena_room_t.arena_wins"
ARENA_ROOM_T_ARENA_WINS_FIELD.number = 9
ARENA_ROOM_T_ARENA_WINS_FIELD.index = 8
ARENA_ROOM_T_ARENA_WINS_FIELD.label = 3
ARENA_ROOM_T_ARENA_WINS_FIELD.has_default_value = false
ARENA_ROOM_T_ARENA_WINS_FIELD.default_value = {}
ARENA_ROOM_T_ARENA_WINS_FIELD.type = 5
ARENA_ROOM_T_ARENA_WINS_FIELD.cpp_type = 1

ARENA_ROOM_T_ARENA_NUMS_FIELD.name = "arena_nums"
ARENA_ROOM_T_ARENA_NUMS_FIELD.full_name = ".dhc.arena_room_t.arena_nums"
ARENA_ROOM_T_ARENA_NUMS_FIELD.number = 10
ARENA_ROOM_T_ARENA_NUMS_FIELD.index = 9
ARENA_ROOM_T_ARENA_NUMS_FIELD.label = 3
ARENA_ROOM_T_ARENA_NUMS_FIELD.has_default_value = false
ARENA_ROOM_T_ARENA_NUMS_FIELD.default_value = {}
ARENA_ROOM_T_ARENA_NUMS_FIELD.type = 5
ARENA_ROOM_T_ARENA_NUMS_FIELD.cpp_type = 1

ARENA_ROOM_T_ARENA_LIST_INDEXES_FIELD.name = "arena_list_indexes"
ARENA_ROOM_T_ARENA_LIST_INDEXES_FIELD.full_name = ".dhc.arena_room_t.arena_list_indexes"
ARENA_ROOM_T_ARENA_LIST_INDEXES_FIELD.number = 11
ARENA_ROOM_T_ARENA_LIST_INDEXES_FIELD.index = 10
ARENA_ROOM_T_ARENA_LIST_INDEXES_FIELD.label = 3
ARENA_ROOM_T_ARENA_LIST_INDEXES_FIELD.has_default_value = false
ARENA_ROOM_T_ARENA_LIST_INDEXES_FIELD.default_value = {}
ARENA_ROOM_T_ARENA_LIST_INDEXES_FIELD.type = 5
ARENA_ROOM_T_ARENA_LIST_INDEXES_FIELD.cpp_type = 1

ARENA_ROOM_T_SEGMENT_FIELD.name = "segment"
ARENA_ROOM_T_SEGMENT_FIELD.full_name = ".dhc.arena_room_t.segment"
ARENA_ROOM_T_SEGMENT_FIELD.number = 12
ARENA_ROOM_T_SEGMENT_FIELD.index = 11
ARENA_ROOM_T_SEGMENT_FIELD.label = 1
ARENA_ROOM_T_SEGMENT_FIELD.has_default_value = false
ARENA_ROOM_T_SEGMENT_FIELD.default_value = 0
ARENA_ROOM_T_SEGMENT_FIELD.type = 5
ARENA_ROOM_T_SEGMENT_FIELD.cpp_type = 1

ARENA_ROOM_T_LAST_TIME_FIELD.name = "last_time"
ARENA_ROOM_T_LAST_TIME_FIELD.full_name = ".dhc.arena_room_t.last_time"
ARENA_ROOM_T_LAST_TIME_FIELD.number = 13
ARENA_ROOM_T_LAST_TIME_FIELD.index = 12
ARENA_ROOM_T_LAST_TIME_FIELD.label = 1
ARENA_ROOM_T_LAST_TIME_FIELD.has_default_value = false
ARENA_ROOM_T_LAST_TIME_FIELD.default_value = 0
ARENA_ROOM_T_LAST_TIME_FIELD.type = 4
ARENA_ROOM_T_LAST_TIME_FIELD.cpp_type = 4

ARENA_ROOM_T.name = "arena_room_t"
ARENA_ROOM_T.full_name = ".dhc.arena_room_t"
ARENA_ROOM_T.nested_types = {}
ARENA_ROOM_T.enum_types = {}
ARENA_ROOM_T.fields = {ARENA_ROOM_T_GUID_FIELD, ARENA_ROOM_T_PLAYER_GUIDS_FIELD, ARENA_ROOM_T_PLAYER_NAMES_FIELD, ARENA_ROOM_T_PLAYER_LEVELS_FIELD, ARENA_ROOM_T_PLAYER_ICONS_FIELD, ARENA_ROOM_T_PLAYER_INTEGRALS_FIELD, ARENA_ROOM_T_IS_NPC_FIELD, ARENA_ROOM_T_PLAYER_POWERS_FIELD, ARENA_ROOM_T_ARENA_WINS_FIELD, ARENA_ROOM_T_ARENA_NUMS_FIELD, ARENA_ROOM_T_ARENA_LIST_INDEXES_FIELD, ARENA_ROOM_T_SEGMENT_FIELD, ARENA_ROOM_T_LAST_TIME_FIELD}
ARENA_ROOM_T.is_extendable = false
ARENA_ROOM_T.extensions = {}

module('arena_room_db_pb')

arena_room_t = protobuf.Message(ARENA_ROOM_T)

