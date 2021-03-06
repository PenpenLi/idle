# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: pet_db.proto

import sys
_b=sys.version_info[0]<3 and (lambda x:x) or (lambda x:x.encode('latin1'))
from google.protobuf import descriptor as _descriptor
from google.protobuf import message as _message
from google.protobuf import reflection as _reflection
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()




DESCRIPTOR = _descriptor.FileDescriptor(
  name='pet_db.proto',
  package='dhc',
  syntax='proto2',
  serialized_options=None,
  serialized_pb=_b('\n\x0cpet_db.proto\x12\x03\x64hc\"l\n\x05pet_t\x12\x0c\n\x04guid\x18\x01 \x01(\x04\x12\x13\n\x0bplayer_guid\x18\x02 \x01(\x04\x12\r\n\x05level\x18\x03 \x01(\x05\x12\x0b\n\x03\x65xp\x18\x04 \x01(\x05\x12\x13\n\x0btemplate_id\x18\x05 \x01(\x05\x12\x0f\n\x07\x65nhance\x18\x06 \x01(\x05')
)




_PET_T = _descriptor.Descriptor(
  name='pet_t',
  full_name='dhc.pet_t',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='guid', full_name='dhc.pet_t.guid', index=0,
      number=1, type=4, cpp_type=4, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='player_guid', full_name='dhc.pet_t.player_guid', index=1,
      number=2, type=4, cpp_type=4, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='level', full_name='dhc.pet_t.level', index=2,
      number=3, type=5, cpp_type=1, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='exp', full_name='dhc.pet_t.exp', index=3,
      number=4, type=5, cpp_type=1, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='template_id', full_name='dhc.pet_t.template_id', index=4,
      number=5, type=5, cpp_type=1, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='enhance', full_name='dhc.pet_t.enhance', index=5,
      number=6, type=5, cpp_type=1, label=1,
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
  serialized_start=21,
  serialized_end=129,
)

DESCRIPTOR.message_types_by_name['pet_t'] = _PET_T
_sym_db.RegisterFileDescriptor(DESCRIPTOR)

pet_t = _reflection.GeneratedProtocolMessageType('pet_t', (_message.Message,), dict(
  DESCRIPTOR = _PET_T,
  __module__ = 'pet_db_pb2'
  # @@protoc_insertion_point(class_scope:dhc.pet_t)
  ))
_sym_db.RegisterMessage(pet_t)


# @@protoc_insertion_point(module_scope)

pet_t_tmp = pet_t

from pgame.utils import proto_utils
class pet_t_db(proto_utils.object_t_db):
   def __init__(self):
      proto_utils.object_t_db.__init__(self, pet_t_tmp)
      self.children = [
         ]

proto_utils.make_db_proto(pet_t_db, pet_t_tmp)

pet_t = pet_t_db
