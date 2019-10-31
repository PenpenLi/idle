-- Generated By protoc-gen-lua Do not Edit
local protobuf = require "protobuf/protobuf"
require("protobuf/equip_db_pb")
require("protobuf/pet_db_pb")
require("protobuf/mail_db_pb")

local MSG_ASSET = protobuf.Descriptor();
local MSG_ASSET_TYPE_FIELD = protobuf.FieldDescriptor();
local MSG_ASSET_VALUE1_FIELD = protobuf.FieldDescriptor();
local MSG_ASSET_VALUE2_FIELD = protobuf.FieldDescriptor();
local MSG_ASSET_VALUE3_FIELD = protobuf.FieldDescriptor();
local MSG_ASSETS = protobuf.Descriptor();
local MSG_ASSETS_ASSETS_FIELD = protobuf.FieldDescriptor();
local MSG_ASSETS_EQUIPS_FIELD = protobuf.FieldDescriptor();
local MSG_ASSETS_PETS_FIELD = protobuf.FieldDescriptor();
local MSG_ASSETS_MAILS_FIELD = protobuf.FieldDescriptor();
local CMSG_HEART_BEAT = protobuf.Descriptor();
local CMSG_HEART_BEAT_TIME_FIELD = protobuf.FieldDescriptor();

MSG_ASSET_TYPE_FIELD.name = "type"
MSG_ASSET_TYPE_FIELD.full_name = ".protocol.common.msg_asset.type"
MSG_ASSET_TYPE_FIELD.number = 1
MSG_ASSET_TYPE_FIELD.index = 0
MSG_ASSET_TYPE_FIELD.label = 1
MSG_ASSET_TYPE_FIELD.has_default_value = false
MSG_ASSET_TYPE_FIELD.default_value = 0
MSG_ASSET_TYPE_FIELD.type = 5
MSG_ASSET_TYPE_FIELD.cpp_type = 1

MSG_ASSET_VALUE1_FIELD.name = "value1"
MSG_ASSET_VALUE1_FIELD.full_name = ".protocol.common.msg_asset.value1"
MSG_ASSET_VALUE1_FIELD.number = 2
MSG_ASSET_VALUE1_FIELD.index = 1
MSG_ASSET_VALUE1_FIELD.label = 1
MSG_ASSET_VALUE1_FIELD.has_default_value = false
MSG_ASSET_VALUE1_FIELD.default_value = 0
MSG_ASSET_VALUE1_FIELD.type = 5
MSG_ASSET_VALUE1_FIELD.cpp_type = 1

MSG_ASSET_VALUE2_FIELD.name = "value2"
MSG_ASSET_VALUE2_FIELD.full_name = ".protocol.common.msg_asset.value2"
MSG_ASSET_VALUE2_FIELD.number = 3
MSG_ASSET_VALUE2_FIELD.index = 2
MSG_ASSET_VALUE2_FIELD.label = 1
MSG_ASSET_VALUE2_FIELD.has_default_value = false
MSG_ASSET_VALUE2_FIELD.default_value = 0
MSG_ASSET_VALUE2_FIELD.type = 5
MSG_ASSET_VALUE2_FIELD.cpp_type = 1

MSG_ASSET_VALUE3_FIELD.name = "value3"
MSG_ASSET_VALUE3_FIELD.full_name = ".protocol.common.msg_asset.value3"
MSG_ASSET_VALUE3_FIELD.number = 4
MSG_ASSET_VALUE3_FIELD.index = 3
MSG_ASSET_VALUE3_FIELD.label = 1
MSG_ASSET_VALUE3_FIELD.has_default_value = false
MSG_ASSET_VALUE3_FIELD.default_value = 0
MSG_ASSET_VALUE3_FIELD.type = 5
MSG_ASSET_VALUE3_FIELD.cpp_type = 1

MSG_ASSET.name = "msg_asset"
MSG_ASSET.full_name = ".protocol.common.msg_asset"
MSG_ASSET.nested_types = {}
MSG_ASSET.enum_types = {}
MSG_ASSET.fields = {MSG_ASSET_TYPE_FIELD, MSG_ASSET_VALUE1_FIELD, MSG_ASSET_VALUE2_FIELD, MSG_ASSET_VALUE3_FIELD}
MSG_ASSET.is_extendable = false
MSG_ASSET.extensions = {}
MSG_ASSETS_ASSETS_FIELD.name = "assets"
MSG_ASSETS_ASSETS_FIELD.full_name = ".protocol.common.msg_assets.assets"
MSG_ASSETS_ASSETS_FIELD.number = 1
MSG_ASSETS_ASSETS_FIELD.index = 0
MSG_ASSETS_ASSETS_FIELD.label = 3
MSG_ASSETS_ASSETS_FIELD.has_default_value = false
MSG_ASSETS_ASSETS_FIELD.default_value = {}
MSG_ASSETS_ASSETS_FIELD.message_type = MSG_ASSET
MSG_ASSETS_ASSETS_FIELD.type = 11
MSG_ASSETS_ASSETS_FIELD.cpp_type = 10

MSG_ASSETS_EQUIPS_FIELD.name = "equips"
MSG_ASSETS_EQUIPS_FIELD.full_name = ".protocol.common.msg_assets.equips"
MSG_ASSETS_EQUIPS_FIELD.number = 2
MSG_ASSETS_EQUIPS_FIELD.index = 1
MSG_ASSETS_EQUIPS_FIELD.label = 3
MSG_ASSETS_EQUIPS_FIELD.has_default_value = false
MSG_ASSETS_EQUIPS_FIELD.default_value = {}
MSG_ASSETS_EQUIPS_FIELD.message_type = equip_db_pb.equip_t
MSG_ASSETS_EQUIPS_FIELD.type = 11
MSG_ASSETS_EQUIPS_FIELD.cpp_type = 10

MSG_ASSETS_PETS_FIELD.name = "pets"
MSG_ASSETS_PETS_FIELD.full_name = ".protocol.common.msg_assets.pets"
MSG_ASSETS_PETS_FIELD.number = 3
MSG_ASSETS_PETS_FIELD.index = 2
MSG_ASSETS_PETS_FIELD.label = 3
MSG_ASSETS_PETS_FIELD.has_default_value = false
MSG_ASSETS_PETS_FIELD.default_value = {}
MSG_ASSETS_PETS_FIELD.message_type = pet_db_pb.pet_t
MSG_ASSETS_PETS_FIELD.type = 11
MSG_ASSETS_PETS_FIELD.cpp_type = 10

MSG_ASSETS_MAILS_FIELD.name = "mails"
MSG_ASSETS_MAILS_FIELD.full_name = ".protocol.common.msg_assets.mails"
MSG_ASSETS_MAILS_FIELD.number = 4
MSG_ASSETS_MAILS_FIELD.index = 3
MSG_ASSETS_MAILS_FIELD.label = 3
MSG_ASSETS_MAILS_FIELD.has_default_value = false
MSG_ASSETS_MAILS_FIELD.default_value = {}
MSG_ASSETS_MAILS_FIELD.message_type = mail_db_pb.mail_t
MSG_ASSETS_MAILS_FIELD.type = 11
MSG_ASSETS_MAILS_FIELD.cpp_type = 10

MSG_ASSETS.name = "msg_assets"
MSG_ASSETS.full_name = ".protocol.common.msg_assets"
MSG_ASSETS.nested_types = {}
MSG_ASSETS.enum_types = {}
MSG_ASSETS.fields = {MSG_ASSETS_ASSETS_FIELD, MSG_ASSETS_EQUIPS_FIELD, MSG_ASSETS_PETS_FIELD, MSG_ASSETS_MAILS_FIELD}
MSG_ASSETS.is_extendable = false
MSG_ASSETS.extensions = {}
CMSG_HEART_BEAT_TIME_FIELD.name = "time"
CMSG_HEART_BEAT_TIME_FIELD.full_name = ".protocol.common.cmsg_heart_beat.time"
CMSG_HEART_BEAT_TIME_FIELD.number = 1
CMSG_HEART_BEAT_TIME_FIELD.index = 0
CMSG_HEART_BEAT_TIME_FIELD.label = 2
CMSG_HEART_BEAT_TIME_FIELD.has_default_value = false
CMSG_HEART_BEAT_TIME_FIELD.default_value = 0
CMSG_HEART_BEAT_TIME_FIELD.type = 4
CMSG_HEART_BEAT_TIME_FIELD.cpp_type = 4

CMSG_HEART_BEAT.name = "cmsg_heart_beat"
CMSG_HEART_BEAT.full_name = ".protocol.common.cmsg_heart_beat"
CMSG_HEART_BEAT.nested_types = {}
CMSG_HEART_BEAT.enum_types = {}
CMSG_HEART_BEAT.fields = {CMSG_HEART_BEAT_TIME_FIELD}
CMSG_HEART_BEAT.is_extendable = false
CMSG_HEART_BEAT.extensions = {}

module('common_msg_pb')

cmsg_heart_beat = protobuf.Message(CMSG_HEART_BEAT)
msg_asset = protobuf.Message(MSG_ASSET)
msg_assets = protobuf.Message(MSG_ASSETS)

