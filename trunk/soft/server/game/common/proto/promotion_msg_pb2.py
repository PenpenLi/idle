# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: promotion_msg.proto

import sys
_b=sys.version_info[0]<3 and (lambda x:x) or (lambda x:x.encode('latin1'))
from google.protobuf import descriptor as _descriptor
from google.protobuf import message as _message
from google.protobuf import reflection as _reflection
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import common.proto.common_msg_pb2 as common__msg__pb2


DESCRIPTOR = _descriptor.FileDescriptor(
  name='promotion_msg.proto',
  package='protocol.promotion',
  syntax='proto2',
  serialized_options=None,
  serialized_pb=_b('\n\x13promotion_msg.proto\x12\x12protocol.promotion\x1a\x10\x63ommon_msg.proto\"$\n\x11\x63msg_task_receive\x12\x0f\n\x07task_id\x18\x01 \x02(\x05\" \n\rcmsg_task_end\x12\x0f\n\x07task_id\x18\x01 \x02(\x05\"L\n\rsmsg_task_end\x12\x0e\n\x06map_id\x18\x01 \x02(\x05\x12+\n\x06\x61ssets\x18\x02 \x02(\x0b\x32\x1b.protocol.common.msg_assets\"#\n\x0f\x63msg_daily_draw\x12\x10\n\x08\x64\x61ily_id\x18\x01 \x02(\x05\">\n\x0fsmsg_daily_draw\x12+\n\x06\x61ssets\x18\x01 \x02(\x0b\x32\x1b.protocol.common.msg_assets\"1\n\x16\x63msg_daily_reward_draw\x12\x17\n\x0f\x64\x61ily_reward_id\x18\x01 \x02(\x05\"E\n\x16smsg_daily_reward_draw\x12+\n\x06\x61ssets\x18\x01 \x02(\x0b\x32\x1b.protocol.common.msg_assets\"\x1e\n\ncmsg_aside\x12\x10\n\x08\x61side_id\x18\x01 \x02(\x05\"(\n\rcmsg_shop_buy\x12\n\n\x02id\x18\x01 \x02(\x05\x12\x0b\n\x03num\x18\x02 \x02(\x05\"<\n\rsmsg_shop_buy\x12+\n\x06\x61ssets\x18\x01 \x02(\x0b\x32\x1b.protocol.common.msg_assets\" \n\x0b\x63msg_portal\x12\x11\n\tportal_id\x18\x01 \x02(\x05')
  ,
  dependencies=[common__msg__pb2.DESCRIPTOR,])




_CMSG_TASK_RECEIVE = _descriptor.Descriptor(
  name='cmsg_task_receive',
  full_name='protocol.promotion.cmsg_task_receive',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='task_id', full_name='protocol.promotion.cmsg_task_receive.task_id', index=0,
      number=1, type=5, cpp_type=1, label=2,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  serialized_options=None,
  is_extendable=False,
  syntax='proto2',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=61,
  serialized_end=97,
)


_CMSG_TASK_END = _descriptor.Descriptor(
  name='cmsg_task_end',
  full_name='protocol.promotion.cmsg_task_end',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='task_id', full_name='protocol.promotion.cmsg_task_end.task_id', index=0,
      number=1, type=5, cpp_type=1, label=2,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  serialized_options=None,
  is_extendable=False,
  syntax='proto2',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=99,
  serialized_end=131,
)


_SMSG_TASK_END = _descriptor.Descriptor(
  name='smsg_task_end',
  full_name='protocol.promotion.smsg_task_end',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='map_id', full_name='protocol.promotion.smsg_task_end.map_id', index=0,
      number=1, type=5, cpp_type=1, label=2,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='assets', full_name='protocol.promotion.smsg_task_end.assets', index=1,
      number=2, type=11, cpp_type=10, label=2,
      has_default_value=False, default_value=None,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  serialized_options=None,
  is_extendable=False,
  syntax='proto2',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=133,
  serialized_end=209,
)


_CMSG_DAILY_DRAW = _descriptor.Descriptor(
  name='cmsg_daily_draw',
  full_name='protocol.promotion.cmsg_daily_draw',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='daily_id', full_name='protocol.promotion.cmsg_daily_draw.daily_id', index=0,
      number=1, type=5, cpp_type=1, label=2,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  serialized_options=None,
  is_extendable=False,
  syntax='proto2',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=211,
  serialized_end=246,
)


_SMSG_DAILY_DRAW = _descriptor.Descriptor(
  name='smsg_daily_draw',
  full_name='protocol.promotion.smsg_daily_draw',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='assets', full_name='protocol.promotion.smsg_daily_draw.assets', index=0,
      number=1, type=11, cpp_type=10, label=2,
      has_default_value=False, default_value=None,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  serialized_options=None,
  is_extendable=False,
  syntax='proto2',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=248,
  serialized_end=310,
)


_CMSG_DAILY_REWARD_DRAW = _descriptor.Descriptor(
  name='cmsg_daily_reward_draw',
  full_name='protocol.promotion.cmsg_daily_reward_draw',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='daily_reward_id', full_name='protocol.promotion.cmsg_daily_reward_draw.daily_reward_id', index=0,
      number=1, type=5, cpp_type=1, label=2,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  serialized_options=None,
  is_extendable=False,
  syntax='proto2',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=312,
  serialized_end=361,
)


_SMSG_DAILY_REWARD_DRAW = _descriptor.Descriptor(
  name='smsg_daily_reward_draw',
  full_name='protocol.promotion.smsg_daily_reward_draw',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='assets', full_name='protocol.promotion.smsg_daily_reward_draw.assets', index=0,
      number=1, type=11, cpp_type=10, label=2,
      has_default_value=False, default_value=None,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  serialized_options=None,
  is_extendable=False,
  syntax='proto2',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=363,
  serialized_end=432,
)


_CMSG_ASIDE = _descriptor.Descriptor(
  name='cmsg_aside',
  full_name='protocol.promotion.cmsg_aside',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='aside_id', full_name='protocol.promotion.cmsg_aside.aside_id', index=0,
      number=1, type=5, cpp_type=1, label=2,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  serialized_options=None,
  is_extendable=False,
  syntax='proto2',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=434,
  serialized_end=464,
)


_CMSG_SHOP_BUY = _descriptor.Descriptor(
  name='cmsg_shop_buy',
  full_name='protocol.promotion.cmsg_shop_buy',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='id', full_name='protocol.promotion.cmsg_shop_buy.id', index=0,
      number=1, type=5, cpp_type=1, label=2,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='num', full_name='protocol.promotion.cmsg_shop_buy.num', index=1,
      number=2, type=5, cpp_type=1, label=2,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  serialized_options=None,
  is_extendable=False,
  syntax='proto2',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=466,
  serialized_end=506,
)


_SMSG_SHOP_BUY = _descriptor.Descriptor(
  name='smsg_shop_buy',
  full_name='protocol.promotion.smsg_shop_buy',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='assets', full_name='protocol.promotion.smsg_shop_buy.assets', index=0,
      number=1, type=11, cpp_type=10, label=2,
      has_default_value=False, default_value=None,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  serialized_options=None,
  is_extendable=False,
  syntax='proto2',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=508,
  serialized_end=568,
)


_CMSG_PORTAL = _descriptor.Descriptor(
  name='cmsg_portal',
  full_name='protocol.promotion.cmsg_portal',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='portal_id', full_name='protocol.promotion.cmsg_portal.portal_id', index=0,
      number=1, type=5, cpp_type=1, label=2,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  serialized_options=None,
  is_extendable=False,
  syntax='proto2',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=570,
  serialized_end=602,
)

_SMSG_TASK_END.fields_by_name['assets'].message_type = common__msg__pb2._MSG_ASSETS
_SMSG_DAILY_DRAW.fields_by_name['assets'].message_type = common__msg__pb2._MSG_ASSETS
_SMSG_DAILY_REWARD_DRAW.fields_by_name['assets'].message_type = common__msg__pb2._MSG_ASSETS
_SMSG_SHOP_BUY.fields_by_name['assets'].message_type = common__msg__pb2._MSG_ASSETS
DESCRIPTOR.message_types_by_name['cmsg_task_receive'] = _CMSG_TASK_RECEIVE
DESCRIPTOR.message_types_by_name['cmsg_task_end'] = _CMSG_TASK_END
DESCRIPTOR.message_types_by_name['smsg_task_end'] = _SMSG_TASK_END
DESCRIPTOR.message_types_by_name['cmsg_daily_draw'] = _CMSG_DAILY_DRAW
DESCRIPTOR.message_types_by_name['smsg_daily_draw'] = _SMSG_DAILY_DRAW
DESCRIPTOR.message_types_by_name['cmsg_daily_reward_draw'] = _CMSG_DAILY_REWARD_DRAW
DESCRIPTOR.message_types_by_name['smsg_daily_reward_draw'] = _SMSG_DAILY_REWARD_DRAW
DESCRIPTOR.message_types_by_name['cmsg_aside'] = _CMSG_ASIDE
DESCRIPTOR.message_types_by_name['cmsg_shop_buy'] = _CMSG_SHOP_BUY
DESCRIPTOR.message_types_by_name['smsg_shop_buy'] = _SMSG_SHOP_BUY
DESCRIPTOR.message_types_by_name['cmsg_portal'] = _CMSG_PORTAL
_sym_db.RegisterFileDescriptor(DESCRIPTOR)

cmsg_task_receive = _reflection.GeneratedProtocolMessageType('cmsg_task_receive', (_message.Message,), dict(
  DESCRIPTOR = _CMSG_TASK_RECEIVE,
  __module__ = 'promotion_msg_pb2'
  # @@protoc_insertion_point(class_scope:protocol.promotion.cmsg_task_receive)
  ))
_sym_db.RegisterMessage(cmsg_task_receive)

cmsg_task_end = _reflection.GeneratedProtocolMessageType('cmsg_task_end', (_message.Message,), dict(
  DESCRIPTOR = _CMSG_TASK_END,
  __module__ = 'promotion_msg_pb2'
  # @@protoc_insertion_point(class_scope:protocol.promotion.cmsg_task_end)
  ))
_sym_db.RegisterMessage(cmsg_task_end)

smsg_task_end = _reflection.GeneratedProtocolMessageType('smsg_task_end', (_message.Message,), dict(
  DESCRIPTOR = _SMSG_TASK_END,
  __module__ = 'promotion_msg_pb2'
  # @@protoc_insertion_point(class_scope:protocol.promotion.smsg_task_end)
  ))
_sym_db.RegisterMessage(smsg_task_end)

cmsg_daily_draw = _reflection.GeneratedProtocolMessageType('cmsg_daily_draw', (_message.Message,), dict(
  DESCRIPTOR = _CMSG_DAILY_DRAW,
  __module__ = 'promotion_msg_pb2'
  # @@protoc_insertion_point(class_scope:protocol.promotion.cmsg_daily_draw)
  ))
_sym_db.RegisterMessage(cmsg_daily_draw)

smsg_daily_draw = _reflection.GeneratedProtocolMessageType('smsg_daily_draw', (_message.Message,), dict(
  DESCRIPTOR = _SMSG_DAILY_DRAW,
  __module__ = 'promotion_msg_pb2'
  # @@protoc_insertion_point(class_scope:protocol.promotion.smsg_daily_draw)
  ))
_sym_db.RegisterMessage(smsg_daily_draw)

cmsg_daily_reward_draw = _reflection.GeneratedProtocolMessageType('cmsg_daily_reward_draw', (_message.Message,), dict(
  DESCRIPTOR = _CMSG_DAILY_REWARD_DRAW,
  __module__ = 'promotion_msg_pb2'
  # @@protoc_insertion_point(class_scope:protocol.promotion.cmsg_daily_reward_draw)
  ))
_sym_db.RegisterMessage(cmsg_daily_reward_draw)

smsg_daily_reward_draw = _reflection.GeneratedProtocolMessageType('smsg_daily_reward_draw', (_message.Message,), dict(
  DESCRIPTOR = _SMSG_DAILY_REWARD_DRAW,
  __module__ = 'promotion_msg_pb2'
  # @@protoc_insertion_point(class_scope:protocol.promotion.smsg_daily_reward_draw)
  ))
_sym_db.RegisterMessage(smsg_daily_reward_draw)

cmsg_aside = _reflection.GeneratedProtocolMessageType('cmsg_aside', (_message.Message,), dict(
  DESCRIPTOR = _CMSG_ASIDE,
  __module__ = 'promotion_msg_pb2'
  # @@protoc_insertion_point(class_scope:protocol.promotion.cmsg_aside)
  ))
_sym_db.RegisterMessage(cmsg_aside)

cmsg_shop_buy = _reflection.GeneratedProtocolMessageType('cmsg_shop_buy', (_message.Message,), dict(
  DESCRIPTOR = _CMSG_SHOP_BUY,
  __module__ = 'promotion_msg_pb2'
  # @@protoc_insertion_point(class_scope:protocol.promotion.cmsg_shop_buy)
  ))
_sym_db.RegisterMessage(cmsg_shop_buy)

smsg_shop_buy = _reflection.GeneratedProtocolMessageType('smsg_shop_buy', (_message.Message,), dict(
  DESCRIPTOR = _SMSG_SHOP_BUY,
  __module__ = 'promotion_msg_pb2'
  # @@protoc_insertion_point(class_scope:protocol.promotion.smsg_shop_buy)
  ))
_sym_db.RegisterMessage(smsg_shop_buy)

cmsg_portal = _reflection.GeneratedProtocolMessageType('cmsg_portal', (_message.Message,), dict(
  DESCRIPTOR = _CMSG_PORTAL,
  __module__ = 'promotion_msg_pb2'
  # @@protoc_insertion_point(class_scope:protocol.promotion.cmsg_portal)
  ))
_sym_db.RegisterMessage(cmsg_portal)


# @@protoc_insertion_point(module_scope)
